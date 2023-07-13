using Google.Cloud.Firestore;

namespace OnlineVotingSystem.Models
{
    [FirestoreData]
    public class VoterProfileModel
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
        public string docuID { get; set; }

        //Firebase Auth
        public string voterEmail { get; set; }
        public string token { get; set; }
        public string voterPassword { get; set; }
        public string voterReTypePass { get; set; }
    }

    [FirestoreData]
    public class VoterUpdateModel
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
        public string docuID { get; set; }

        //Firebase Auth
        public string voterEmail { get; set; }
        public string token { get; set; }
        public string voterPassword { get; set; }
        public string voterReTypePass { get; set; }
    }
}
