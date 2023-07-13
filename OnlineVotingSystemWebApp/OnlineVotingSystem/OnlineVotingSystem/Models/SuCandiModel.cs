using Google.Cloud.Firestore;
using System.Collections.Generic;
using OnlineVotingSystem.Models;

namespace OnlineVotingSystem.Models
{
    [FirestoreData]
    public class SuCandiModel
    {
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
