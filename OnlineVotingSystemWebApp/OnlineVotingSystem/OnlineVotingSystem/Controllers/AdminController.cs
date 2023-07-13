using Firebase.Auth;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Cloud.Firestore;
using Google.Cloud.Storage.V1;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AdminModel admin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    string adminEmail = admin.AdminEmail;
                    string adminPassword = admin.AdminPassword;

                    //User sign in :) <3 UwU Nya~ Ichi..Ni..San.. Nya~ Arigatou~!
                    var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyBMwBv3zjpOMXWODh_hsHBXcQQwyEVRbhk"));
                    var auth = await authProvider.SignInWithEmailAndPasswordAsync(adminEmail, adminPassword);

                    string projectId = "online-voting-system-dd4f9";
                    FirestoreDb db = FirestoreDb.Create(projectId);
                    DocumentReference voters = db.Collection("Admin").Document(adminEmail);
                    DocumentSnapshot docu = await voters.GetSnapshotAsync();

                    if (docu.Exists)
                    {
                        return RedirectToAction("Index", "AdminLanding");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}
