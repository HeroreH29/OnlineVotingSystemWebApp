using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace OnlineVotingSystem.Models
{
    [FirestoreData]
    public class ListModel
    {
        //private SelectList _PositionSelectList { get; set; }

        //public SelectList PositionSelectList
        //{
        //    get
        //    {
        //        if (_PositionSelectList != null)
        //            return _PositionSelectList;


        //            return new SelectList(GetOptions(), "Value", "Name");
                
        //    }

        //    set { _PositionSelectList = value; }
        //}

        //private List<ListItem> GetOptions()
        //{
        //    var listlist = new List<ListItem>();
        //    listlist.Add(new ListItem() { Value = "Chairperson", Name = "Chairperson" });
        //    listlist.Add(new ListItem() { Value = "Vice Chairperson", Name = "Vice Chairperson" });
        //    listlist.Add(new ListItem() { Value = "Secretary", Name = "Secretary" });
        //    listlist.Add(new ListItem() { Value = "Treasurer", Name = "Treasurer" });
        //    listlist.Add(new ListItem() { Value = "Auditor", Name = "Auditor" });
        //    listlist.Add(new ListItem() { Value = "4th Year Representative", Name = "4th Year Representative" });
        //    listlist.Add(new ListItem() { Value = "3rd Year Representative", Name = "3rd Year Representative" });
        //    listlist.Add(new ListItem() { Value = "2nd Year Representative", Name = "2nd Year Representative" });
        //    listlist.Add(new ListItem() { Value = "1st Year Representative", Name = "1st Year Representative" });

        //    return listlist;
        //}
        
        [FirestoreProperty]
        public string candidateFullName { get; set; }
        [FirestoreProperty]
        public string candidateAchievements { get; set; }
        [FirestoreProperty]
        public string candidateCollege { get; set; }
        [FirestoreProperty]
        public string candidateYearSection { get; set; }

        [FirestoreProperty]
        public string candidateBackground { get; set; }

        [FirestoreProperty]
        public string candidatePersonalQualities { get; set; }

        [FirestoreProperty]
        public string candidatePosition { get; set; }

        [FirestoreProperty]
        public string imageURL { get; set; }

        [FirestoreProperty]
        public string registrationStatus { get; set; }

        [FirestoreProperty]
        public string userType { get; set; }



        //auth
        public string candiEmail { get; set; }
        public string candiPassword { get; set; }
        public string candiReTypePass { get; set; }
        public bool candiError { get; set; } = false;

        public string getValueSelector { get; set; }

        public string tempImagePath { get; set; } = "";


    }
    
    
}
