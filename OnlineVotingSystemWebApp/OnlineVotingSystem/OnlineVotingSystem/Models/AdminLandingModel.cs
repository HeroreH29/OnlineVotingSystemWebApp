using Google.Cloud.Firestore;

namespace OnlineVotingSystem.Models
{
    [FirestoreData]
    public class AdminLandingModel
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

        [FirestoreProperty]
        public int posOrder { get; set; }

        [FirestoreProperty]
        public int voteCount { get; set; }
    }

    
}
