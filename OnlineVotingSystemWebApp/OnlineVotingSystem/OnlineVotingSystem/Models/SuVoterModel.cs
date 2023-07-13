using Google.Cloud.Firestore;

namespace OnlineVotingSystem.Models
    
{
    [FirestoreData]
    public class SuVoterModel
    {
        [FirestoreProperty]
        public string voterFirstName { get; set; }
        [FirestoreProperty]
        public string voterLastName { get; set; }
        [FirestoreProperty]
        public string voterCollege { get; set; }
        [FirestoreProperty]
        public string voterYearSection { get; set; }

        [FirestoreProperty]
        public string voterUID { get; set; }

        [FirestoreProperty]
        public string hasVoted { get; set; }

        [FirestoreProperty]
        public string userType { get; set; }


        public string voterEmail { get; set; }
        public string voterPassword { get; set; }
        public string voterReTypePass { get; set; }
    }
}
