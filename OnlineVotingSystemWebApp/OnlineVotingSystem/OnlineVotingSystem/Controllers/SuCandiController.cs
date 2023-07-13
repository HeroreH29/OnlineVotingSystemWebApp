using Firebase.Auth;
using Firebase.Storage;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using Google.Cloud.Storage.V1;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Controllers
{
    public class SuCandiController : Controller
    {
        private IWebHostEnvironment _env;
        private string imgURL;

        public IActionResult Index()
        {
            //ViewBag.ListSelectList = new SelectList(GetOptions(), "Name", "Value");

            var model = new ListModel();

            return View(model);
        }

        public SuCandiController(IWebHostEnvironment env)
        {
            _env = env;
        }
        private List<ListItem> GetOptions()
        {
            var listlist = new List<ListItem>();
            listlist.Add(new ListItem() { Value = "Chairperson", Name = "Chairperson" }) ;
            listlist.Add(new ListItem() { Value = "Vice Chairperson", Name = "Vice Chairperson" }) ;
            listlist.Add(new ListItem() { Value = "Secretary", Name = "Secretary" }) ;
            listlist.Add(new ListItem() { Value = "Treasurer", Name = "Treasurer" });
            listlist.Add(new ListItem() { Value = "Auditor", Name = "Auditor" });
            listlist.Add(new ListItem() { Value = "4th Year Representative", Name = "4th Year Representative" });
            listlist.Add(new ListItem() { Value = "3rd Year Representative", Name = "3rd Year Representative" });
            listlist.Add(new ListItem() { Value = "2nd Year Representative", Name = "2nd Year Representative" });
            listlist.Add(new ListItem() { Value = "1st Year Representative", Name = "1st Year Representative" });

            return listlist;
        }
        [HttpPost]
        public async Task<IActionResult> IndexAsync(ListModel candi)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    string candiFullName = candi.candidateFullName;
                    string candiEmail = candi.candiEmail;
                    string candiPass = candi.candiPassword;
                    string candiYrAndSec = candi.candidateYearSection;
                    string candiPos = candi.candidatePosition;
                    string candiAchieve = candi.candidateAchievements;
                    string candiQuali = candi.candidatePersonalQualities;
                    string candiBack = candi.candidateBackground;
                    imgURL = candi.imageURL;


                    //Creating instance app
                    UserRecord userRecord;

                    if (FirebaseApp.DefaultInstance == null)
                    {
                        FirebaseApp.Create(new AppOptions()
                        {
                            Credential = GoogleCredential.FromFile("keyfile2.json"),
                        });
                    }
                    //Initializing auth account
                    UserRecordArgs args = new UserRecordArgs()
                    {
                        Email = candiEmail,
                        Password = candiPass
                    };

                    userRecord = await FirebaseAdmin.Auth.FirebaseAuth.DefaultInstance.CreateUserAsync(args);
                    userRecord = await FirebaseAdmin.Auth.FirebaseAuth.DefaultInstance.GetUserByEmailAsync(candiEmail);

                    //Upload Candidate Image (test)
                    var dir = _env.WebRootPath;
                    string fileName = TempData["fileName"].ToString();
                    string contentType = TempData["contentType"].ToString();
                    string fileExtension = TempData["fileExtension"].ToString();
                    FileStream stream;
                    stream = new FileStream(Path.Combine(dir, $"images/{fileName}"), FileMode.Open);
                    await Upload(fileExtension, fileName, dir, candiFullName, candiEmail, candiYrAndSec, candiAchieve, candiPos, candiBack, candiQuali, imgURL, stream, candiEmail, candiPass);
                    //Insert Candidate Details to Firestore
                    /* Register(fileName, dir, candiFullName, candiEmail, candiAchieve, candiPos, candiBack, candiQuali, imgURL);*/
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                   return View();
                }
            }
            catch
            {
                return View();
            }

        }

        public async Task<IActionResult> Upload (string fileExtension, string fileName, string dir, string candiFullName, string candiEmail, string candiYearSection, string candiAchievement, string candiPosition, string candiBackground, string candiPersonalQualities, string imgURL, FileStream stream, string email, string password)
        {
            var auth = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyBMwBv3zjpOMXWODh_hsHBXcQQwyEVRbhk"));
            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            var a = await auth.SignInWithEmailAndPasswordAsync(email, password);
            string fileInMili = milliseconds.ToString() + fileExtension;
            var cancellation = new CancellationTokenSource();

            var task = new FirebaseStorage(
                "online-voting-system-dd4f9.appspot.com",
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                    ThrowOnCancel = true
                }
                ).Child(fileInMili).PutAsync(stream, cancellation.Token);

            try
            {
                imgURL = await task;
                Debug.WriteLine(imgURL);
                string Directory = "keyfile2.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", Directory);
                //end of setup

                //Creating firestore and adding data to firestore
                string projectId = "online-voting-system-dd4f9";
                FirestoreDb db = FirestoreDb.Create(projectId);

                //Voter Details and Login Credentials
                DocumentReference docRef = db.Collection("Candidates").Document(candiEmail);
                Dictionary<string, object> candiDetails = new Dictionary<string, object>
                    {
                        { "candidateAchievements", candiAchievement },
                        {"candidateYearSection", candiYearSection },
                        { "candidateBackground", candiBackground },
                        { "candidateFullName", candiFullName },
                        { "candidatePersonalQualities", candiPersonalQualities },
                        { "candidatePosition", candiPosition },
                        { "userType", "Candidate" },
                        { "registrationStatus", "Pending" },
                        { "imageURL", imgURL }
                    };
                await docRef.SetAsync(candiDetails);

                //Delete locally uploaded image to save storage space
                FileDelete(dir, fileName);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in uploading...");
                return View();
            }

        }

        private RedirectToActionResult FileDelete(string dir, string fileName)
        {
            FileInfo fileInfo = new FileInfo(Path.Combine(dir, $"images/{fileName}"));
            fileInfo.Delete();

            return RedirectToAction("Index", "Home");
        }
    }
}
