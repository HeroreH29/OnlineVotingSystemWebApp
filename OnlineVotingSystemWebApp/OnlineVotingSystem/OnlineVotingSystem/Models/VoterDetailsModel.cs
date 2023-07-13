using Google.Cloud.Firestore;

namespace OnlineVotingSystem.Models
{
    [FirestoreData]
    public class VoterDetailsModel
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
        public bool hasVoted { get; set; }
    }
}
