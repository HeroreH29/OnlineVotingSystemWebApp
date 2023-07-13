using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;



namespace OnlineVotingSystem.Controllers
{
    public class AdminLandingController : Controller
    {
        private string Directory = "keyfile2.json";
        private string projectId;
        private FirestoreDb db;
        List<AdminLandingModel> listCandi = new List<AdminLandingModel>();
        List<HasVotedModel> hasVotedList = new List<HasVotedModel>();
        List<HasNotVotedModel> hasNotVotedList = new List<HasNotVotedModel>();
        HasVotedViewModel vm = new HasVotedViewModel();
        HasNotVotedViewModel vm2 = new HasNotVotedViewModel();
        
        
        public AdminLandingController()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", Directory);
            projectId = "online-voting-system-dd4f9";
            db = FirestoreDb.Create(projectId);
        }
        public async Task<IActionResult> Index()
        {
            Query candiQuery = db.Collection("Candidates").WhereEqualTo("registrationStatus", "Pending");
            QuerySnapshot candiQuerySnapshot = await candiQuery.GetSnapshotAsync();
            
            foreach (DocumentSnapshot document in candiQuerySnapshot.Documents)
            {
                if (document.Exists)
                {
                    Dictionary<string, object> candidate = document.ToDictionary();
                    string json = JsonConvert.SerializeObject(candidate);
                    AdminLandingModel candiModel = JsonConvert.DeserializeObject<AdminLandingModel>(json);
                    listCandi.Add(candiModel);
                    
                    ViewBag.AdminLandingImage = candiModel.imageURL;
                }
            }
            
            return View(listCandi);
        }

        [HttpGet]
        public async Task<IActionResult> acceptCandi(string personId)
        {
            string pos = "";
            
            CollectionReference candidates = db.Collection("Candidates");
            Query query = candidates.WhereEqualTo("candidateFullName", personId);
            QuerySnapshot documentSnapshots = await query.GetSnapshotAsync();
            foreach (DocumentSnapshot document in documentSnapshots.Documents)
            {
                /*Dictionary<string, object> updates = new Dictionary<string, object>();
                updates.Add();*/
                string email = document.Id;
                pos = document.GetValue<string>("candidatePosition");
                

                DocumentReference candi = candidates.Document(email);
                Dictionary<string, object> updates = new Dictionary<string, object>();
                updates.Add("voteCount", 0);
                updates.Add("registrationStatus", "Accepted");

                if (pos.Equals("Chairperson"))
                {
                    updates.Add("posOrder", 1);
                }
                else if (pos.Equals("Vice Chairperson"))
                {
                    updates.Add("posOrder", 2);
                }
                else if (pos.Equals("Secretary"))
                {
                    updates.Add("posOrder", 3);
                }
                else if (pos.Equals("Treasurer"))
                {
                    updates.Add("posOrder", 4);
                }
                else if (pos.Equals("Auditor"))
                {
                    updates.Add("posOrder", 5);
                }
                else if (pos.Equals("4th Year Representative"))
                {
                    updates.Add("posOrder", 6);
                }
                else if (pos.Equals("3rd Year Representative"))
                {
                    updates.Add("posOrder", 7);
                }
                else if (pos.Equals("2nd Year Representative"))
                {
                    updates.Add("posOrder", 8);
                }
                else if (pos.Equals("1st Year Representative"))
                {
                    updates.Add("posOrder", 9);
                }

                await candi.UpdateAsync(updates);
                
            }
            return RedirectToAction("Index", "AdminLanding");
        }
        [HttpGet]
        public async Task<IActionResult> rejectCandi(string personId)
        {
            string pos = "";

            CollectionReference candidates = db.Collection("Candidates");
            Query query = candidates.WhereEqualTo("candidateFullName", personId);
            QuerySnapshot documentSnapshots = await query.GetSnapshotAsync();
            foreach (DocumentSnapshot document in documentSnapshots.Documents)
            {
                string email = document.Id;
                
                DocumentReference candi = candidates.Document(email);
                Dictionary<string, object> updates = new Dictionary<string, object>();
                
                updates.Add("registrationStatus", "Rejected");
                await candi.UpdateAsync(updates);

            }
            return RedirectToAction("Index", "AdminLanding");
        }
#nullable enable
        public async Task<IActionResult> hasVoted (HasVotedModel? model)
        {
            string? voterFirstName = "";
            string? voterLastName = "";
            string? voterCollege = "";
            string? voterUID = "";
            string? voterYearSection = "";
            string? chairperson = "";
            string? viceChairperson = "";
            string? secretary = "";
            string? treasurer = "";
            string? auditor = "";
            string? fourthYear = "";
            string? thirdYear = "";
            string? secondYear = "";
            string? firstYear = "";

            Query voterQuery = db.Collection("Voters").WhereEqualTo("hasVoted", true);
            QuerySnapshot voterQuerySnapshot = await voterQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot document in voterQuerySnapshot.Documents)
            {
                if (document.Exists)
                {
                    Dictionary<string, object> hasvoted = document.ToDictionary();
                    string json = JsonConvert.SerializeObject(hasvoted);
                    model = JsonConvert.DeserializeObject<HasVotedModel>(json);
                    voterFirstName = model.voterFirstName;
                    voterLastName = model.voterLastName;
                    voterCollege = model.voterCollege;
                    voterYearSection = model.voterYearSection;
                    voterUID = model.voterUID;
                    /*model.voterFirstName = document.GetValue<string>("voterFirstName");
                        model.voterLastName = document.GetValue<string>("voterLastName");
                        model.voterCollege = document.GetValue<string>("voterCollege");
                        model.voterYearSection = document.GetValue<string>("voterYearSection");*/
                }
            }

            //Check for Chairperson
            Query chairpersonQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 1).WhereEqualTo(voterUID, 2);
            QuerySnapshot chairpersonQuerySnapshot = await chairpersonQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot document in chairpersonQuerySnapshot.Documents)
            {
                if (document.Exists)
                {
                    Dictionary<string, object> hasvoted = document.ToDictionary();
                    string json = JsonConvert.SerializeObject(hasvoted);
                    model = JsonConvert.DeserializeObject<HasVotedModel>(json);
                    
                    chairperson = model.candidateFullName;
                    /*model.candidateFullName = document.GetValue<string>("candidateFullName");
                    model.chairpersonFullName = model.candidateFullName;*/

                }
            }
            

            //Check for Vice Chairperson
            Query viceChairpersonQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 2).WhereEqualTo(voterUID, 2);
            QuerySnapshot viceChairpersonQuerySnapshot = await viceChairpersonQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot document in viceChairpersonQuerySnapshot.Documents)
            {
                if (document.Exists)
                {
                    Dictionary<string, object> hasvoted = document.ToDictionary();
                    string json = JsonConvert.SerializeObject(hasvoted);
                    model = JsonConvert.DeserializeObject<HasVotedModel>(json);
                    viceChairperson = model.candidateFullName;

                    /*model.candidateFullName = document.GetValue<string>("candidateFullName");
                    model.viceChairpersonFullName = model.candidateFullName;*/

                }
            }
            
            //Check for Secretary
            Query SecretaryQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 3).WhereEqualTo(voterUID, 2);
            QuerySnapshot secretaryQuerySnapshot = await SecretaryQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot document in secretaryQuerySnapshot.Documents)
            {
                if (document.Exists)
                {
                    Dictionary<string, object> hasvoted = document.ToDictionary();
                    string json = JsonConvert.SerializeObject(hasvoted);
                    model = JsonConvert.DeserializeObject<HasVotedModel>(json);
                    secretary = model.candidateFullName;

                    /*model.candidateFullName = document.GetValue<string>("candidateFullName");
                    model.secretaryFullName = model.candidateFullName;*/

                }
            }
           

            //Check for Treasurer
            Query treasurerQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 4).WhereEqualTo(voterUID, 2);
            QuerySnapshot treasurerQuerySnapshot = await treasurerQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot document in treasurerQuerySnapshot.Documents)
            {
                if (document.Exists)
                {
                    Dictionary<string, object> hasvoted = document.ToDictionary();
                    string json = JsonConvert.SerializeObject(hasvoted);
                    model = JsonConvert.DeserializeObject<HasVotedModel>(json);
                    treasurer = model.candidateFullName;

                    /*model.candidateFullName = document.GetValue<string>("candidateFullName");
                    model.treasurerFullName = model.candidateFullName;*/

                }
            }
            

            //Check for auditor
            Query auditorQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 5).WhereEqualTo(voterUID, 2);
            QuerySnapshot auditorQuerySnapshot = await auditorQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot document in auditorQuerySnapshot.Documents)
            {
                if (document.Exists)
                {
                    Dictionary<string, object> hasvoted = document.ToDictionary();
                    string json = JsonConvert.SerializeObject(hasvoted);
                    model = JsonConvert.DeserializeObject<HasVotedModel>(json);
                    
                    auditor = model.candidateFullName;
                    /*model.candidateFullName = document.GetValue<string>("candidateFullName");
                    model.auditorFullName = model.candidateFullName;*/

                }
            }
            

            //Check for 4th Year Representative
            Query fourthYearQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 6).WhereEqualTo(voterUID, 2) ;
            QuerySnapshot fourthYearQuerySnapshot = await fourthYearQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot document in fourthYearQuerySnapshot.Documents)
            {
                if (document.Exists)
                {
                    Dictionary<string, object> hasvoted = document.ToDictionary();
                    string json = JsonConvert.SerializeObject(hasvoted);
                    model = JsonConvert.DeserializeObject<HasVotedModel>(json);
                    fourthYear = model.candidateFullName;
                    /*model.candidateFullName = document.GetValue<string>("candidateFullName");
                    model.fourthYearRepFullName = model.candidateFullName;*/

                }
            }
            

            //Check for 3rd Year Representative
            Query thirdYearQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 7).WhereEqualTo(voterUID, 2);
            QuerySnapshot thirdYearQuerySnapshot = await thirdYearQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot document in thirdYearQuerySnapshot.Documents)
            {
                if (document.Exists)
                {
                    Dictionary<string, object> hasvoted = document.ToDictionary();
                    string json = JsonConvert.SerializeObject(hasvoted);
                    model = JsonConvert.DeserializeObject<HasVotedModel>(json);
                    thirdYear = model.candidateFullName;
                    /*model.candidateFullName = document.GetValue<string>("candidateFullName");
                    model.thirdYearRepFullName = model.candidateFullName;*/
                }
            }
           

            //Check for 2nd Year Representative
            Query secondYearQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 8).WhereEqualTo(voterUID, 2);
            QuerySnapshot secondYearQuerySnapshot = await secondYearQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot document in secondYearQuerySnapshot.Documents)
            {
                if (document.Exists)
                {
                    Dictionary<string, object> hasvoted = document.ToDictionary();
                    string json = JsonConvert.SerializeObject(hasvoted);
                    model = JsonConvert.DeserializeObject<HasVotedModel>(json);

                    secondYear = model.candidateFullName;

                    /*model.candidateFullName = document.GetValue<string>("candidateFullName");
                    model.secondYearRepFullName = model.candidateFullName;*/

                }
            }
            
            //Check for 1st Year Representative
            Query firstYearQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 9).WhereEqualTo(voterUID, 2);
            QuerySnapshot firstYearQuerySnapshot = await firstYearQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot document in firstYearQuerySnapshot.Documents)
            {
                if (document.Exists)
                {
                    Dictionary<string, object> hasvoted = document.ToDictionary();
                    string json = JsonConvert.SerializeObject(hasvoted);
                    model = JsonConvert.DeserializeObject<HasVotedModel>(json);
                    
                    firstYear = model.candidateFullName;
                    
                    /*model.candidateFullName = document.GetValue<string>("candidateFullName");
                    model.firstYearRepFullName = model.candidateFullName;*/
                    
                }
            }
            


            model.voterFirstName = voterFirstName;
            model.voterLastName = voterLastName;
            model.voterCollege = voterCollege;
            model.voterYearSection = voterYearSection;
            model.voterUID = voterUID;

            model.chairpersonFullName = chairperson;
            model.viceChairpersonFullName = viceChairperson;
            model.secretaryFullName = secretary;
            model.treasurerFullName = treasurer;
            model.auditorFullName = auditor;
            model.fourthYearRepFullName = fourthYear;
            model.thirdYearRepFullName = thirdYear;
            model.secondYearRepFullName = secondYear;
            model.firstYearRepFullName = firstYear;


            hasVotedList.Add(model);
            vm.hasVoted = hasVotedList;

            return View(vm);
        }

        public async Task<IActionResult> hasNotVoted (HasNotVotedModel? model)
        {
            Query voterQuery = db.Collection("Voters").WhereEqualTo("hasVoted", false);
            QuerySnapshot voterQuerySnapshot = await voterQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot document in voterQuerySnapshot.Documents)
            {
                if (document.Exists)
                {
                    Dictionary<string, object>? hasnotvoted = document.ToDictionary();
                    string? json = JsonConvert.SerializeObject(hasnotvoted);
                    model = JsonConvert.DeserializeObject<HasNotVotedModel>(json);
                    hasNotVotedList.Add(model);
                    vm2.hasNotVoted = hasNotVotedList;


                }
            }
            return View(vm2);
        }

        public IActionResult dateTimePicker()
        {
            return View();
        }

        public async Task<IActionResult> getDateTime(DateTimePickerModel model)
        {
            DateTime dT = new DateTime();
            dT = model.ToDatePicker.ToUniversalTime();
            //string current = TimeZone.CurrentTimeZone.StandardName;
            TimeZoneInfo taipei = TimeZoneInfo.FindSystemTimeZoneById("Taipei Standard Time");
            DateTime serverTime = DateTime.Now;
            DateTime test = TimeZoneInfo.ConvertTimeFromUtc(dT, taipei);
            DateTime _localTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(serverTime, TimeZoneInfo.Local.Id, "Taipei Standard Time");
            //DateTime _setLocalTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dT, TimeZoneInfo.Local.Id, "Taipei Standard Time");
            model.ToDatePicker = test;
            

            int check = test.CompareTo(_localTime);

            if (check > 0)
            {
                DateTime setTime = model.ToDatePicker.ToUniversalTime();

                DocumentReference admin = db.Collection("Admin").Document("hezekiahruizlegaspi@gmail.com");
                DocumentSnapshot documentSnapshot = await admin.GetSnapshotAsync();

                if (documentSnapshot.Exists)
                {
                    await admin.UpdateAsync("hasEnded", false);
                    await admin.UpdateAsync("hasSet", true);
                    await admin.UpdateAsync("electionEnd", setTime);
                }
            }
            else
            {
                Debug.WriteLine("Ano ka hilo?");
            }
            return RedirectToAction("Index", "AdminLanding");
        }

        public async Task<IActionResult> endNow(DateTimePickerModel model)
        {
            DocumentReference admin = db.Collection("Admin").Document("hezekiahruizlegaspi@gmail.com");
            DocumentSnapshot documentSnapshot = await admin.GetSnapshotAsync();

            if (documentSnapshot.Exists)
            {
                await admin.UpdateAsync("hasEnded", true);
                await admin.UpdateAsync("hasSet", true);
                await admin.UpdateAsync("electionEnd", DateTime.UtcNow);
            }
            return RedirectToAction("Index", "AdminLanding");
        }

        public ActionResult goBacktoIndex()
        {
            return RedirectToAction("Index",  "Home");
        }
    }
}
