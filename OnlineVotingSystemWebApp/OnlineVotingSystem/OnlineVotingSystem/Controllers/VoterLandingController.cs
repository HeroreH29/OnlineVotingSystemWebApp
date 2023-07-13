using OnlineVotingSystem.Models;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;
using Firebase.Auth;

namespace OnlineVotingSystem.Controllers
{
    public class VoterLandingController : Controller
    {
        private string Directory = "keyfile2.json";
        private string projectId;
        private FirestoreDb db;
        List<CandiListModel> listCandi = new List<CandiListModel>();
        ViewModel vm = new ViewModel();
        
        public VoterLandingController()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", Directory);
            projectId = "online-voting-system-dd4f9";
            db = FirestoreDb.Create(projectId);
            
        }
        public async Task<IActionResult> Index(ViewModel check)
        {
            try
            {
                bool chairperson = false;
                
                string email = TempData["emailemail"].ToString();
                TempData["emailemail"] = email;

                
                string uid = TempData["uiduid"].ToString();
                TempData["uiduid"] = uid;
            
                DocumentReference voters = db.Collection("Voters").Document(email);
                DocumentSnapshot documentSnapshot = await voters.GetSnapshotAsync();
                if (documentSnapshot.Exists)
                {
                    Dictionary<string, bool> map = documentSnapshot.GetValue<Dictionary<string, bool>>("Votes");

                    chairperson = map["Chairperson"];
                }
                    if (chairperson == false){
                        Query candiQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 1);
                        QuerySnapshot candiQuerySnapshot = await candiQuery.GetSnapshotAsync();


                        foreach (DocumentSnapshot document in candiQuerySnapshot.Documents)
                        {
                            if (document.Exists)
                            {
                            Dictionary<string, object> candidate = document.ToDictionary();
                            string json = JsonConvert.SerializeObject(candidate);
                            CandiListModel candiModel = JsonConvert.DeserializeObject<CandiListModel>(json);
                            ViewBag.Chairperson = candiModel.imageURL;
                            listCandi.Add(candiModel);
                            vm.Candidates = listCandi;
                            }
                        }
                            return View(vm);
                        }
                    else
                    {
                    
                        check.checkVote = chairperson;
                        check.getEmail = email;
                    
                        return View(check);
                    }
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> ViceChairperson(ViewModel check)
        {
            string email = TempData["emailemail"].ToString();
            TempData["emailemail"] = email;
            string uid = TempData["uiduid"].ToString();
            TempData["uiduid"] = uid;

            bool viceChairperson = false;
            
            DocumentReference voters = db.Collection("Voters").Document(email);
            DocumentSnapshot documentSnapshot = await voters.GetSnapshotAsync();
            if (documentSnapshot.Exists)
            {
                Dictionary<string, bool> map = documentSnapshot.GetValue<Dictionary<string, bool>>("Votes");

                viceChairperson = map["Vice Chairperson"];
            }
            if (viceChairperson == false)
            {
                Query candiQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 2);
                QuerySnapshot candiQuerySnapshot = await candiQuery.GetSnapshotAsync();


                foreach (DocumentSnapshot document in candiQuerySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        Dictionary<string, object> candidate = document.ToDictionary();
                        string json = JsonConvert.SerializeObject(candidate);
                        CandiListModel candiModel = JsonConvert.DeserializeObject<CandiListModel>(json);
                        ViewBag.ViceChairperson = candiModel.imageURL;
                        listCandi.Add(candiModel);
                        vm.Candidates = listCandi;
                    }
                }
                    return View(vm);
                }
            else
            {

                check.checkVote = viceChairperson;

                return View(check);
            }
        }
        public async Task<IActionResult> Secretary(ViewModel check)
        {
            string email = TempData["emailemail"].ToString();
            TempData["emailemail"] = email;
            string uid = TempData["uiduid"].ToString();
            TempData["uiduid"] = uid;
            bool secretary = false;
            
            DocumentReference voters = db.Collection("Voters").Document(email);
            DocumentSnapshot documentSnapshot = await voters.GetSnapshotAsync();
            if (documentSnapshot.Exists)
            {
                Dictionary<string, bool> map = documentSnapshot.GetValue<Dictionary<string, bool>>("Votes");

                secretary = map["Secretary"];
            }
            if (secretary == false)
            {
                Query candiQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 3);
                QuerySnapshot candiQuerySnapshot = await candiQuery.GetSnapshotAsync();


                foreach (DocumentSnapshot document in candiQuerySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        Dictionary<string, object> candidate = document.ToDictionary();
                        string json = JsonConvert.SerializeObject(candidate);
                        CandiListModel candiModel = JsonConvert.DeserializeObject<CandiListModel>(json);
                        ViewBag.Secretary = candiModel.imageURL;
                        listCandi.Add(candiModel);
                        vm.Candidates = listCandi;
                    }
                }
                return View(vm);
            }
            else
            {

                check.checkVote = secretary;

                return View(check);
            }
        }
        public async Task<IActionResult> Treasurer(ViewModel check)
        {
            string email = TempData["emailemail"].ToString();
            TempData["emailemail"] = email;
            string uid = TempData["uiduid"].ToString();
            TempData["uiduid"] = uid;
            bool treasurer = false;
            
            DocumentReference voters = db.Collection("Voters").Document(email);
            DocumentSnapshot documentSnapshot = await voters.GetSnapshotAsync();
            if (documentSnapshot.Exists)
            {
                Dictionary<string, bool> map = documentSnapshot.GetValue<Dictionary<string, bool>>("Votes");

                treasurer = map["Treasurer"];
            }
            if (treasurer == false)
            {
                Query candiQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 4);
                QuerySnapshot candiQuerySnapshot = await candiQuery.GetSnapshotAsync();


                foreach (DocumentSnapshot document in candiQuerySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        Dictionary<string, object> candidate = document.ToDictionary();
                        string json = JsonConvert.SerializeObject(candidate);
                        CandiListModel candiModel = JsonConvert.DeserializeObject<CandiListModel>(json);
                        ViewBag.Treasurer = candiModel.imageURL;
                        listCandi.Add(candiModel);
                        vm.Candidates = listCandi;
                    }
                }
                return View(vm);
            }
            else
            {

                check.checkVote = treasurer;

                return View(check);
            }
        }
        public async Task<IActionResult> Auditor(ViewModel check)
        {
            bool auditor = false;
            string email = TempData["emailemail"].ToString();
            TempData["emailemail"] = email;
            string uid = TempData["uiduid"].ToString();
            TempData["uiduid"] = uid;
            DocumentReference voters = db.Collection("Voters").Document(email);
            DocumentSnapshot documentSnapshot = await voters.GetSnapshotAsync();
            if (documentSnapshot.Exists)
            {
                Dictionary<string, bool> map = documentSnapshot.GetValue<Dictionary<string, bool>>("Votes");

                auditor = map["Auditor"];
            }
            if (auditor == false)
            {
                Query candiQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 5);
                QuerySnapshot candiQuerySnapshot = await candiQuery.GetSnapshotAsync();


                foreach (DocumentSnapshot document in candiQuerySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        Dictionary<string, object> candidate = document.ToDictionary();
                        string json = JsonConvert.SerializeObject(candidate);
                        CandiListModel candiModel = JsonConvert.DeserializeObject<CandiListModel>(json);
                        ViewBag.Auditor = candiModel.imageURL;
                        listCandi.Add(candiModel);
                        vm.Candidates = listCandi;
                    }
                }
                return View(vm);
            }
            else
            {

                check.checkVote = auditor;

                return View(check);
            }
        }

        public async Task<IActionResult> FourthYearRep(ViewModel check)
        {
            bool FourthYearRep = false;
            string email = TempData["emailemail"].ToString();
            TempData["emailemail"] = email;
            string uid = TempData["uiduid"].ToString();
            TempData["uiduid"] = uid;
            DocumentReference voters = db.Collection("Voters").Document(email);
            DocumentSnapshot documentSnapshot = await voters.GetSnapshotAsync();
            if (documentSnapshot.Exists)
            {
                Dictionary<string, bool> map = documentSnapshot.GetValue<Dictionary<string, bool>>("Votes");

                FourthYearRep = map["4th Year Representative"];
            }
            if (FourthYearRep == false)
            {
                Query candiQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 6);
                QuerySnapshot candiQuerySnapshot = await candiQuery.GetSnapshotAsync();


                foreach (DocumentSnapshot document in candiQuerySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        Dictionary<string, object> candidate = document.ToDictionary();
                        string json = JsonConvert.SerializeObject(candidate);
                        CandiListModel candiModel = JsonConvert.DeserializeObject<CandiListModel>(json);
                        ViewBag.Fourth = candiModel.imageURL;
                        listCandi.Add(candiModel);
                        vm.Candidates = listCandi;
                    }
                }
                return View(vm);
            }
            else
            {

                check.checkVote = FourthYearRep;

                return View(check);
            }
        }

        public async Task<IActionResult> ThirdYearRep(ViewModel check)
        {
            bool thirdYearRep = false;
            string email = TempData["emailemail"].ToString();
            TempData["emailemail"] = email;
            string uid = TempData["uiduid"].ToString();
            TempData["uiduid"] = uid;

            DocumentReference voters = db.Collection("Voters").Document(email);
            DocumentSnapshot documentSnapshot = await voters.GetSnapshotAsync();
            if (documentSnapshot.Exists)
            {
                Dictionary<string, bool> map = documentSnapshot.GetValue<Dictionary<string, bool>>("Votes");

                thirdYearRep = map["3rd Year Representative"];
            }
            if (thirdYearRep == false)
            {
                Query candiQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 9);
                QuerySnapshot candiQuerySnapshot = await candiQuery.GetSnapshotAsync();


                foreach (DocumentSnapshot document in candiQuerySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        Dictionary<string, object> candidate = document.ToDictionary();
                        string json = JsonConvert.SerializeObject(candidate);
                        CandiListModel candiModel = JsonConvert.DeserializeObject<CandiListModel>(json);
                        ViewBag.Third = candiModel.imageURL;
                        listCandi.Add(candiModel);
                        vm.Candidates = listCandi;
                    }
                }
                return View(vm);
            }
            else
            {
                check.checkVote = thirdYearRep;
                return View(check);
            }
        }

        public async Task<IActionResult> SecondYearRep(ViewModel check)
        {
            bool secondYearRep = false;
            string email = TempData["emailemail"].ToString();
            TempData["emailemail"] = email;
            string uid = TempData["uiduid"].ToString();
            TempData["uiduid"] = uid;
            DocumentReference voters = db.Collection("Voters").Document(email);
            DocumentSnapshot documentSnapshot = await voters.GetSnapshotAsync();
            if (documentSnapshot.Exists)
            {
                Dictionary<string, bool> map = documentSnapshot.GetValue<Dictionary<string, bool>>("Votes");

                secondYearRep = map["2nd Year Representative"];
            }
            if (secondYearRep == false)
            {
                Query candiQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 8);
                QuerySnapshot candiQuerySnapshot = await candiQuery.GetSnapshotAsync();


                foreach (DocumentSnapshot document in candiQuerySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        Dictionary<string, object> candidate = document.ToDictionary();
                        string json = JsonConvert.SerializeObject(candidate);
                        CandiListModel candiModel = JsonConvert.DeserializeObject<CandiListModel>(json);
                        ViewBag.Second = candiModel.imageURL;
                        listCandi.Add(candiModel);
                        vm.Candidates = listCandi;
                    }
                }
                return View(vm);
            }
            else
            {
                check.checkVote = secondYearRep;
                return View(check);
            }
        }

        public async Task<IActionResult> FirstYearRep(ViewModel check)
        {
            bool firstYearRep = false;
            string email = TempData["emailemail"].ToString();
            TempData["emailemail"] = email;
            string uid = TempData["uiduid"].ToString();
            TempData["uiduid"] = uid;
            DocumentReference voters = db.Collection("Voters").Document(email);
            DocumentSnapshot documentSnapshot = await voters.GetSnapshotAsync();
            if (documentSnapshot.Exists)
            {
                Dictionary<string, bool> map = documentSnapshot.GetValue<Dictionary<string, bool>>("Votes");

                firstYearRep = map["1st Year Representative"];
            }
            if (firstYearRep == false)
            {
                Query candiQuery = db.Collection("Candidates").WhereEqualTo("posOrder", 9);
                QuerySnapshot candiQuerySnapshot = await candiQuery.GetSnapshotAsync();


                foreach (DocumentSnapshot document in candiQuerySnapshot.Documents)
                {
                    if (document.Exists)
                    {
                        Dictionary<string, object> candidate = document.ToDictionary();
                        string json = JsonConvert.SerializeObject(candidate);
                        CandiListModel candiModel = JsonConvert.DeserializeObject<CandiListModel>(json);
                        ViewBag.First = candiModel.imageURL;
                        listCandi.Add(candiModel);
                        vm.Candidates = listCandi;
                    }
                }
                return View(vm);
            }
            else
            {
                check.checkVote = firstYearRep;
                return View(check);
            }
            
        }
        [HttpGet]
        public IActionResult voteChoice(VoteChoiceModel choice, string personId)
        {
            string uid = TempData["uiduid"].ToString();
            TempData["uiduid"] = uid;
            string email = TempData["emailemail"].ToString();
            TempData["emailemail"] = email;
            choice.personId = personId;
            return View(choice);
        }

        [HttpGet]
        public async Task<IActionResult> voteCandi(ViewModel check, string personId)
        {
            string fullName = personId;
            string email = TempData["emailemail"].ToString();
            TempData["emailemail"] = email;
            string uid = TempData["uiduid"].ToString();
            TempData["uiduid"] = uid;
            string pos = "";
            string id = "";
            int voteCount = 0;
            CollectionReference candidates = db.Collection("Candidates");
            Query query = candidates.WhereEqualTo("candidateFullName", fullName);
            QuerySnapshot documentSnapshots = await query.GetSnapshotAsync();
            foreach(DocumentSnapshot document in documentSnapshots.Documents)
            {
                pos = document.GetValue<string>("candidatePosition");
                id = document.Id;
                voteCount = ((int)document.GetValue<double>("voteCount"));

            }
            DocumentReference voters = db.Collection("Voters").Document(email);
            DocumentSnapshot documentSnapshot = await voters.GetSnapshotAsync();
            if (documentSnapshot.Exists)
            {
                Dictionary<string, bool> map = documentSnapshot.GetValue<Dictionary<string, bool>>("Votes");

                bool chairperson = map[pos];
                bool viceChaiperson = map[pos];
                bool treasurer = map[pos];
                bool secretary = map[pos];
                bool auditor = map[pos];
                bool fourthYearRep = map[pos];
                bool thirdYearRep = map[pos];
                bool secondYearRep = map[pos];
                bool firstYearRep = map[pos];

                if (chairperson == false && pos.Equals("Chairperson"))
                {
                    recordVote(check, id, pos, voteCount);
                }
                else if (viceChaiperson == false && pos.Equals("Vice Chairperson"))
                {
                    recordVote(check,id, pos, voteCount);
                }
                else if (treasurer == false && pos.Equals("Treasurer"))
                {
                    recordVote(check, id, pos, voteCount);
                }
                else if (secretary == false && pos.Equals("Secretary"))
                {
                    recordVote(check, id, pos, voteCount);
                }
                else if (auditor == false && pos.Equals("Auditor"))
                {
                    recordVote(check, id, pos, voteCount);
                }
                else if (fourthYearRep == false && pos.Equals("4th Year Representative"))
                {
                    recordVote(check, id, pos, voteCount);
                }
                else if (thirdYearRep == false && pos.Equals("3rd Year Representative"))
                {
                    recordVote(check, id, pos, voteCount);
                }
                else if (secondYearRep == false && pos.Equals("2nd Year Representative"))
                {
                    recordVote(check, id, pos, voteCount);
                }
                else if (firstYearRep == false && pos.Equals("1st Year Representative"))
                {
                    recordVote(check, id, pos, voteCount);
                }
                else
                {
                    //Voter already voted for this position
                    Debug.WriteLine("You have already voted for this position");
                }
            }

            return RedirectToAction("Index", "VoterLanding");
        }

        private async void recordVote(ViewModel check, string id, string pos, int voteCount)
        {
            DocumentReference candi = db.Collection("Candidates").Document(id);

            Dictionary<string, object> update = new Dictionary<string, object>();
            
            string uid = TempData["uiduid"].ToString();
            TempData["uiduid"] = uid;
            
            update.Add(uid, 2);

            voteCount = voteCount + 1;
            update.Add("voteCount", voteCount);

            try
            {
                await candi.UpdateAsync(update);

                //Update Vote value in Voter Document
                string email1 = TempData["emailemail"].ToString();
                TempData["emailemail"] = email1;
                DocumentReference voter = db.Collection("Voters").Document(email1);

                Dictionary<string, object> updateVoter = new Dictionary<string, object>();
                updateVoter.Add("Votes." + pos, true);
                updateVoter.Add("hasVoted", true);

                await voter.UpdateAsync(updateVoter);
                Debug.WriteLine("Candidate Voted Successfully!");
            }
            catch (Exception e)
            {
                Debug.WriteLine("Something went wrong! " + e);
            }
            
        }

        public async Task<IActionResult> VoterProfile (VoterProfileModel model)
        {
            string token = TempData["token"].ToString();
            TempData["token"] = token;
            string email = TempData["emailemail"].ToString();
            TempData["emailemail"] = email;

            model.token = token;
            model.voterEmail = email;

            DocumentReference voter = db.Collection("Voters").Document(email);
            DocumentSnapshot documentSnapshot = await voter.GetSnapshotAsync();

            model.voterFirstName = documentSnapshot.GetValue<string>("voterFirstName");
            model.voterLastName = documentSnapshot.GetValue<string>("voterLastName");
            model.voterCollege = documentSnapshot.GetValue<string>("voterCollege");
            model.voterYearSection = documentSnapshot.GetValue<string>("voterYearSection");

            return View(model);
        }

        public async Task<IActionResult> VoterUpdate(VoterUpdateModel model)
        {
            string token = TempData["token"].ToString();
            TempData["token"] = token;
            string email = TempData["emailemail"].ToString();
            TempData["emailemail"] = email;

            model.token = token;
            model.voterEmail = email;

            DocumentReference voter = db.Collection("Voters").Document(email);
            DocumentSnapshot documentSnapshot = await voter.GetSnapshotAsync();

            model.voterFirstName = documentSnapshot.GetValue<string>("voterFirstName");
            model.voterLastName = documentSnapshot.GetValue<string>("voterLastName");
            model.voterCollege = documentSnapshot.GetValue<string>("voterCollege");
            model.voterYearSection = documentSnapshot.GetValue<string>("voterYearSection");
            return View(model);
        }
        public async Task<IActionResult> VoterStudentUpdate(VoterUpdateModel model)
        {
            string token = TempData["token"].ToString();
            TempData["token"] = token;
            string email = TempData["emailemail"].ToString();
            TempData["emailemail"] = email;
            model.token = token;
            model.voterEmail = email;

            DocumentReference voter = db.Collection("Voters").Document(email);
            Dictionary<string, object> updates = new Dictionary<string, object>
            {
                { "voterFirstName", model.voterFirstName },
                { "voterLastName", model.voterLastName },
                { "voterCollege", model.voterCollege },
                { "voterYearSection", model.voterCollege }
            };
            await voter.UpdateAsync(updates);

            return RedirectToAction("VoterProfile", "VoterLanding", model);
        }

        public async Task<IActionResult> ChangePassword (VoterUpdateModel model)
        {
            string token = TempData["token"].ToString();
            TempData["token"] = token;
            string email = TempData["emailemail"].ToString();
            TempData["emailemail"] = email;

            model.token = token;
            model.voterEmail = email;

            DocumentReference voter = db.Collection("Voters").Document(email);
            DocumentSnapshot documentSnapshot = await voter.GetSnapshotAsync();

            model.voterFirstName = documentSnapshot.GetValue<string>("voterFirstName");
            model.voterLastName = documentSnapshot.GetValue<string>("voterLastName");
            model.voterCollege = documentSnapshot.GetValue<string>("voterCollege");
            model.voterYearSection = documentSnapshot.GetValue<string>("voterYearSection");

            //Password Change
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyBMwBv3zjpOMXWODh_hsHBXcQQwyEVRbhk"));
            string password = model.voterPassword;

            try
            {
                await authProvider.ChangeUserPassword(token, password);
                Debug.WriteLine("Password Changed Successfully");

                return RedirectToAction("VoterProfile", "VoterLanding", model);
            }
            catch (Exception ex)
            { 
            
                Debug.WriteLine("Change password failed " + ex);
                return RedirectToAction("VoterUpdate", "VoterLanding", model);
            }
        }
        public ActionResult goBacktoIndex()
        {

            return RedirectToAction("Index",  "Home");
        }
    }
}
