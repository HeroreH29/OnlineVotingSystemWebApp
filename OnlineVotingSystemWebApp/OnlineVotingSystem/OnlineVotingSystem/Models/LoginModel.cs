using Google.Cloud.Firestore;
using System;
#nullable enable

namespace OnlineVotingSystem.Models
{
    [FirestoreData]
    public class LoginModel
    {
        public string getEmail { get; set; }

        public string getPassword { get; set; }

        [FirestoreProperty]
        public bool hasEnded { get; set; } = false;
        public string? electionEnd { get; set; } = "";

        public string getUID { get; set; }
    }
}
