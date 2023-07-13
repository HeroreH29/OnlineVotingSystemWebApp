using Firebase.Auth;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
namespace OnlineVotingSystem.Controllers
{
    public class SuVoterController : Controller
    {
        public string[] positions = {"Chairperson", "Vice Chairperson", "Secretary", "Treasurer", "Auditor", "4th Year Representative"
            , "3rd Year Representative", "2nd Year Representative", "1st Year Representative"};

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IndexAsync(SuVoterModel smodel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string votEmail = smodel.voterEmail;
                    string votPass = smodel.voterPassword;
                    string votFname = smodel.voterFirstName;
                    string votLname = smodel.voterLastName;
                    string votCollege = smodel.voterCollege;
                    string votYrAndSec = smodel.voterYearSection;

                    UserRecord userRecord;
                    string votUid;

                    if (FirebaseApp.DefaultInstance == null)
                    {
                        FirebaseApp.Create(new AppOptions()
                        {
                            Credential = GoogleCredential.FromFile("keyfile2.json"),
                        });
                    }

                    UserRecordArgs args = new UserRecordArgs()
                    {
                        Email = votEmail,
                        Password = votPass
                    };

                    var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyBMwBv3zjpOMXWODh_hsHBXcQQwyEVRbhk"));
                    await authProvider.CreateUserWithEmailAndPasswordAsync(votEmail, votPass);

                    //Uid authentication
                    userRecord = await FirebaseAdmin.Auth.FirebaseAuth.DefaultInstance.GetUserByEmailAsync(votEmail);
                    System.Diagnostics.Debug.WriteLine($"Successfully fetched user data: {userRecord.Uid}");
                    votUid = userRecord.Uid;
                    

                    //Firestore

                    //Setting up for the environment variable
                    string Directory = "keyfile2.json";
                    Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", Directory);
                    //end of setup


                    //Creating firestore and adding data to firestore
                    string projectId = "online-voting-system-dd4f9";
                    FirestoreDb db = FirestoreDb.Create(projectId);

                    //Voter Details and Login Credentials
                    DocumentReference docRef = db.Collection("Voters").Document(votEmail);
                    Dictionary<string, object> voterDetails = new Dictionary<string, object>
                    {
                        { "voterFirstName", votFname },
                        { "voterLastName", votLname },
                        { "voterCollege", votCollege },
                        { "voterYearSection", votYrAndSec },
                        { "voterUID", votUid },
                        { "userType", "Voter" }
                    };
                    await docRef.SetAsync(voterDetails);

                    //'hasVoted' field for Voters
                    Dictionary<string, bool> hasVoted = new Dictionary<string, bool>
                    {
                        { "hasVoted", false }
                    };

                    await docRef.SetAsync(hasVoted, SetOptions.MergeAll);

                    //Insert All Candidate Positions
                    Dictionary<string, bool> pos = new Dictionary<string, bool>();

                    for (int a = 0; a < positions.Length; a++)
                    {
                        pos.Add(positions[a], false);
                    }

                    Dictionary<string, object> votes = new Dictionary<string, object>();
                    votes.Add("Votes", pos);

                    await docRef.SetAsync(votes, SetOptions.MergeAll);
                    insertUIDToCandidates(votUid);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                /*smodel.voterError = true;*/
                /*SuVoterModel objMod = new SuVoterModel();
                objMod.voterError = true;*/
                return View(smodel);
            }
        }

        private async void insertUIDToCandidates(string uid)
        {
            string projectId = "online-voting-system-dd4f9";
            FirestoreDb db = FirestoreDb.Create(projectId);

            CollectionReference colRef = db.Collection("Candidates");
            Query query = colRef.WhereEqualTo("registrationStatus", "Accepted");
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

            Dictionary<string, int> voter = new Dictionary<string, int>();
            voter.Add(uid, 0);
            
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                string docuID = documentSnapshot.Id;
                await colRef.Document(docuID).SetAsync(voter, SetOptions.MergeAll);
            }
            
        }
    }
}
