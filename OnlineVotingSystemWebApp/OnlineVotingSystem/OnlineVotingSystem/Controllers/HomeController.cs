using Firebase.Auth;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Cloud.Firestore;
using Google.Cloud.Storage.V1;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OnlineVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private string userType;

        private string Directory = "keyfile2.json";
        private string projectId;
        private FirestoreDb db;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", Directory);
            projectId = "online-voting-system-dd4f9";
            db = FirestoreDb.Create(projectId);
        }

        public async Task<IActionResult> Index (LoginModel model)
        {
            model.hasEnded = false;
            DocumentReference admin = db.Collection("Admin").Document("hezekiahruizlegaspi@gmail.com");
            DocumentSnapshot documentSnapshot = await admin.GetSnapshotAsync();
            DateTime dateTime = new DateTime();

            if (documentSnapshot.Exists)
            {
                Dictionary<string, object> dictionary = documentSnapshot.ToDictionary();

                dateTime = documentSnapshot.GetValue<DateTime>("electionEnd");
                string convert = dateTime.ToString("MMM dd, yyyy @hh:mm tt");

                model.electionEnd = convert;

                model.hasEnded = documentSnapshot.GetValue<bool>("hasEnded");

            }

            //Check if date and time set is same or more than the current date
            int check = dateTime.CompareTo(DateTime.UtcNow);

            if (check <= 0)
            {
                model.hasEnded = true;

                await admin.UpdateAsync("hasEnded", true);
            }

            return View(model);
        }

        
        public async Task<IActionResult> landingding(ViewModel lmodel)
        {
            try
            {  
                if (ModelState.IsValid)
                {
                    string email = lmodel.getEmail;
                    string password = lmodel.getPassword;

                    TempData["emailemail"] = email;
                    //User sign in :) <3 UwU Nya~ Ichi..Ni..San.. Nya~ Arigatou~!
                    var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyBMwBv3zjpOMXWODh_hsHBXcQQwyEVRbhk"));
                    var auth = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
                    var test = auth.User;
                    string token = auth.FirebaseToken;
                    TempData["token"] = token;

                    //Change Password Test
                    //var result = await authProvider.ChangeUserPassword(token, "inaantoknakosobra");
                    //Debug.WriteLine(result);

                    lmodel.getUID = test.LocalId;
                    TempData["uiduid"] = test.LocalId;
                    

                    string projectId = "online-voting-system-dd4f9";
                    FirestoreDb db = FirestoreDb.Create(projectId);
                    DocumentReference voters = db.Collection("Voters").Document(email);
                    DocumentSnapshot docu = await voters.GetSnapshotAsync();

                    if (docu.Exists)
                    {
                       return RedirectToAction("Index", "VoterLanding", lmodel);
                    }
                    else
                    {
                       return RedirectToAction("Index", "CandiLanding", lmodel);
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch(Exception e)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
