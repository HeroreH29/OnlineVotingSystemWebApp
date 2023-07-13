using Firebase.Auth;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;
using OnlineVotingSystem.Models;
using System;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Controllers
{
    public class CandiLandingController : Controller
    {
        private string Directory = "keyfile2.json";
        private string projectId;
        private FirestoreDb db;
        private string fullName, yearSection, achievements, personalQualities, background, position, registrationStatus, imageURL;
        public CandiLandingController()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", Directory);
            projectId = "online-voting-system-dd4f9";
            db = FirestoreDb.Create(projectId);
        } 
        public async Task<IActionResult> Index()
        {
            string email = TempData["emailemail"].ToString();
            DocumentReference docRef = db.Collection("Candidates").Document(email);
            DocumentSnapshot snap = await docRef.GetSnapshotAsync();
            CandiLandingModel details = new CandiLandingModel();
            

            if (snap.Exists)
            {
                
                    details.candidateFullName = snap.GetValue<string>("candidateFullName");
                    details.candidateYearSection = snap.GetValue<string>("candidateYearSection");
                    details.candidatePosition = snap.GetValue<string>("candidatePosition");
                    details.candidateAchievements = snap.GetValue<string>("candidateAchievements");
                    details.candidatePersonalQualities = snap.GetValue<string>("candidatePersonalQualities");
                    details.candidateBackground = snap.GetValue<string>("candidateBackground");
                    details.registrationStatus = snap.GetValue<string>("registrationStatus");
                    details.imageURL = snap.GetValue<string>("imageURL");
                    ViewBag.CandiImage = details.imageURL;
                


            }
            return View(details);
        }

        public ActionResult goBacktoIndex()
        {

            return RedirectToAction("Index", "Home");
        }
    }
}
