using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineVotingSystem.Controllers
{
    public class ElectionResultController : Controller
    {
        private string Directory = "keyfile2.json";
        private string projectId;
        private FirestoreDb db;

        public ElectionResultController()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", Directory);
            projectId = "online-voting-system-dd4f9";
            db = FirestoreDb.Create(projectId);

        }
        public async Task<IActionResult> Index(BlogPieChart model)
        {
            //Chairperson
            Query chairperson = db.Collection("Candidates").OrderBy("voteCount").WhereEqualTo("posOrder", 1);
            QuerySnapshot chairpersonSnapshots = await chairperson.GetSnapshotAsync();
            
            foreach (DocumentSnapshot documentSnapshot in chairpersonSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.chairpersonFullName = model.candidateFullName;
                model.imageURL = documentSnapshot.GetValue<string>("imageURL");
                ViewBag.Chairperson = model.imageURL;
            }

            //Vice Chairperson
            Query vicechairperson = db.Collection("Candidates").OrderBy("voteCount").WhereEqualTo("posOrder", 2);
            QuerySnapshot vicechairpersonSnapshots = await vicechairperson.GetSnapshotAsync();

            foreach (DocumentSnapshot documentSnapshot in vicechairpersonSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.viceChairpersonFullName = model.candidateFullName;
                model.imageURL = documentSnapshot.GetValue<string>("imageURL");
                ViewBag.ViceChairperson = model.imageURL;
            }

            //Secretary
            Query secretary = db.Collection("Candidates").OrderBy("voteCount").WhereEqualTo("posOrder", 3);
            QuerySnapshot secretarySnapshots = await secretary.GetSnapshotAsync();

            foreach (DocumentSnapshot documentSnapshot in secretarySnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.secretaryFullName = model.candidateFullName;
                model.imageURL = documentSnapshot.GetValue<string>("imageURL");
                ViewBag.Secretary = model.imageURL;
            }

            //Treasurer
            Query treasurer = db.Collection("Candidates").OrderBy("voteCount").WhereEqualTo("posOrder", 4);
            QuerySnapshot treasurerSnapshots = await treasurer.GetSnapshotAsync();

            foreach (DocumentSnapshot documentSnapshot in treasurerSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.treasurerFullName = model.candidateFullName;
                model.imageURL = documentSnapshot.GetValue<string>("imageURL");
                ViewBag.Treasurer = model.imageURL;
            }

            //Auditor
            Query auditor = db.Collection("Candidates").OrderBy("voteCount").WhereEqualTo("posOrder", 5);
            QuerySnapshot auditorSnapshots = await auditor.GetSnapshotAsync();

            foreach (DocumentSnapshot documentSnapshot in auditorSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.auditorFullName = model.candidateFullName;
                model.imageURL = documentSnapshot.GetValue<string>("imageURL");
                ViewBag.Auditor = model.imageURL;
            }

            //Fourth Year
            Query fourthyear = db.Collection("Candidates").OrderBy("voteCount").WhereEqualTo("posOrder", 6);
            QuerySnapshot fourthyearSnapshots = await fourthyear.GetSnapshotAsync();

            foreach (DocumentSnapshot documentSnapshot in fourthyearSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.fourthYearFullName = model.candidateFullName;
                model.imageURL = documentSnapshot.GetValue<string>("imageURL");
                ViewBag.Fourth = model.imageURL;
            }

            //Third Year
            Query thirdyear = db.Collection("Candidates").OrderBy("voteCount").WhereEqualTo("posOrder", 7);
            QuerySnapshot thirdyearSnapshots = await thirdyear.GetSnapshotAsync();
            
            foreach (DocumentSnapshot documentSnapshot in thirdyearSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.thirdYearFullName = model.candidateFullName;
                model.imageURL = documentSnapshot.GetValue<string>("imageURL");
                ViewBag.Third = model.imageURL;
            }

            //Second Year
            Query secondyear = db.Collection("Candidates").OrderBy("voteCount").WhereEqualTo("posOrder", 8);
            QuerySnapshot secondyearSnapshots = await secondyear.GetSnapshotAsync();
            
            foreach (DocumentSnapshot documentSnapshot in secondyearSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.secondYearFullName = model.candidateFullName;
                model.imageURL = documentSnapshot.GetValue<string>("imageURL");
                ViewBag.Second = model.imageURL;
            }

            //First Year
            Query firstyear = db.Collection("Candidates").OrderBy("voteCount").WhereEqualTo("posOrder", 9);
            QuerySnapshot firstyearSnapshots = await firstyear.GetSnapshotAsync();

            foreach (DocumentSnapshot documentSnapshot in firstyearSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.firstYearFullName = model.candidateFullName;
                model.imageURL = documentSnapshot.GetValue<string>("imageURL");
                ViewBag.First = model.imageURL;
            }

            return View(model);
        }

        public async Task<JsonResult> GetChairperson(BlogPieChart model)
        {
            Query candidates = db.Collection("Candidates").OrderBy("candidateFullName").WhereEqualTo("posOrder", 1);
            QuerySnapshot documentSnapshots = await candidates.GetSnapshotAsync();
            int count = documentSnapshots.Count;
            List<BlogPieChart> list = new List<BlogPieChart>();

            foreach (DocumentSnapshot documentSnapshot in documentSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.voteCount = ((int)documentSnapshot.GetValue<double>("voteCount"));
                model.chairpersonFullName = model.candidateFullName;
                list.Add(new BlogPieChart { chairpersonFullName = model.chairpersonFullName, voteCount = model.voteCount });
            }
            return Json(new {JSONList = list});

        }

        public async Task<JsonResult> GetViceChairperson(BlogPieChart model)
        {
            Query candidates = db.Collection("Candidates").OrderBy("candidateFullName").WhereEqualTo("posOrder", 2);
            QuerySnapshot documentSnapshots = await candidates.GetSnapshotAsync();
            int count = documentSnapshots.Count;
            List<BlogPieChart> list = new List<BlogPieChart>();

            foreach (DocumentSnapshot documentSnapshot in documentSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.voteCount = ((int)documentSnapshot.GetValue<double>("voteCount"));
                model.viceChairpersonFullName = model.candidateFullName;
                list.Add(new BlogPieChart { viceChairpersonFullName = model.viceChairpersonFullName, voteCount = model.voteCount });
            }
            return Json(new { JSONList = list });

        }

        public async Task<JsonResult> GetSecretary(BlogPieChart model)
        {
            Query candidates = db.Collection("Candidates").OrderBy("candidateFullName").WhereEqualTo("posOrder", 3);
            QuerySnapshot documentSnapshots = await candidates.GetSnapshotAsync();
            int count = documentSnapshots.Count;
            List<BlogPieChart> list = new List<BlogPieChart>();

            foreach (DocumentSnapshot documentSnapshot in documentSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.voteCount = ((int)documentSnapshot.GetValue<double>("voteCount"));
                model.secretaryFullName = model.candidateFullName;
                list.Add(new BlogPieChart { secretaryFullName = model.secretaryFullName, voteCount = model.voteCount });
            }
            return Json(new { JSONList = list });

        }

        public async Task<JsonResult> GetTreasurer(BlogPieChart model)
        {
            Query candidates = db.Collection("Candidates").OrderBy("candidateFullName").WhereEqualTo("posOrder", 4);
            QuerySnapshot documentSnapshots = await candidates.GetSnapshotAsync();
            int count = documentSnapshots.Count;
            List<BlogPieChart> list = new List<BlogPieChart>();

            foreach (DocumentSnapshot documentSnapshot in documentSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.voteCount = ((int)documentSnapshot.GetValue<double>("voteCount"));
                model.treasurerFullName = model.candidateFullName;
                list.Add(new BlogPieChart { treasurerFullName = model.treasurerFullName, voteCount = model.voteCount });
            }
            return Json(new { JSONList = list });

        }

        public async Task<JsonResult> GetAuditor(BlogPieChart model)
        {
            Query candidates = db.Collection("Candidates").OrderBy("candidateFullName").WhereEqualTo("posOrder", 5);
            QuerySnapshot documentSnapshots = await candidates.GetSnapshotAsync();
            int count = documentSnapshots.Count;
            List<BlogPieChart> list = new List<BlogPieChart>();

            foreach (DocumentSnapshot documentSnapshot in documentSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.voteCount = ((int)documentSnapshot.GetValue<double>("voteCount"));
                model.auditorFullName = model.candidateFullName;
                list.Add(new BlogPieChart { auditorFullName = model.auditorFullName, voteCount = model.voteCount });
            }
            return Json(new { JSONList = list });

        }

        public async Task<JsonResult> GetFourthYear(BlogPieChart model)
        {
            Query candidates = db.Collection("Candidates").OrderBy("candidateFullName").WhereEqualTo("posOrder", 6);
            QuerySnapshot documentSnapshots = await candidates.GetSnapshotAsync();
            int count = documentSnapshots.Count;
            List<BlogPieChart> list = new List<BlogPieChart>();

            foreach (DocumentSnapshot documentSnapshot in documentSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.voteCount = ((int)documentSnapshot.GetValue<double>("voteCount"));
                model.fourthYearFullName = model.candidateFullName;
                list.Add(new BlogPieChart { fourthYearFullName = model.fourthYearFullName, voteCount = model.voteCount });
            }
            return Json(new { JSONList = list });

        }

        public async Task<JsonResult> GetThirdYear(BlogPieChart model)
        {
            Query candidates = db.Collection("Candidates").OrderBy("candidateFullName").WhereEqualTo("posOrder", 7);
            QuerySnapshot documentSnapshots = await candidates.GetSnapshotAsync();
            int count = documentSnapshots.Count;
            List<BlogPieChart> list = new List<BlogPieChart>();

            foreach (DocumentSnapshot documentSnapshot in documentSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.voteCount = ((int)documentSnapshot.GetValue<double>("voteCount"));
                model.thirdYearFullName = model.candidateFullName;
                list.Add(new BlogPieChart { thirdYearFullName = model.thirdYearFullName, voteCount = model.voteCount });
            }
            return Json(new { JSONList = list });

        }

        public async Task<JsonResult> GetSecondYear(BlogPieChart model)
        {
            Query candidates = db.Collection("Candidates").OrderBy("candidateFullName").WhereEqualTo("posOrder", 8);
            QuerySnapshot documentSnapshots = await candidates.GetSnapshotAsync();
            int count = documentSnapshots.Count;
            List<BlogPieChart> list = new List<BlogPieChart>();

            foreach (DocumentSnapshot documentSnapshot in documentSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.voteCount = ((int)documentSnapshot.GetValue<double>("voteCount"));
                model.secondYearFullName = model.candidateFullName;
                list.Add(new BlogPieChart { secondYearFullName = model.secondYearFullName, voteCount = model.voteCount });
            }
            return Json(new { JSONList = list });

        }

        public async Task<JsonResult> GetFirstYear(BlogPieChart model)
        {
            Query candidates = db.Collection("Candidates").OrderBy("candidateFullName").WhereEqualTo("posOrder", 9);
            QuerySnapshot documentSnapshots = await candidates.GetSnapshotAsync();
            int count = documentSnapshots.Count;
            List<BlogPieChart> list = new List<BlogPieChart>();

            foreach (DocumentSnapshot documentSnapshot in documentSnapshots.Documents)
            {
                model.candidateFullName = documentSnapshot.GetValue<string>("candidateFullName");
                model.voteCount = ((int)documentSnapshot.GetValue<double>("voteCount"));
                model.firstYearFullName = model.candidateFullName;
                list.Add(new BlogPieChart { firstYearFullName = model.firstYearFullName, voteCount = model.voteCount });
            }
            return Json(new { JSONList = list });

        }
    }
}
