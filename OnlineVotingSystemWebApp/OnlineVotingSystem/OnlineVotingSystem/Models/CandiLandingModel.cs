using Google.Cloud.Firestore;

namespace OnlineVotingSystem.Models
{
    [FirestoreData]
    public class CandiLandingModel
    {
        [FirestoreProperty]
        public string candidateFullName { get; set; }
        [FirestoreProperty]
        public string candidateYearSection { get; set; }
        [FirestoreProperty]
        public string candidateAchievements { get; set; }
        [FirestoreProperty]
        public string candidateBackground { get; set; }
        [FirestoreProperty]
        public string candidatePersonalQualities { get; set; }
        [FirestoreProperty]
        public string candidatePosition { get; set; }
        [FirestoreProperty]
        public string registrationStatus { get; set; }

        [FirestoreProperty]
        public string imageURL { get; set; }
    }
}
