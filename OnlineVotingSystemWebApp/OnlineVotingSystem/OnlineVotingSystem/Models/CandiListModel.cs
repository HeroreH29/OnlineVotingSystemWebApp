using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace OnlineVotingSystem.Models
{
    [FirestoreData]
    public class CandiListModel
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

        //auth
        public string candiEmail { get; set; }
        public string candiPassword { get; set; }
        public string candiReTypePass { get; set; }
        public bool candiError { get; set; } = false;

        public string getValueSelector { get; set; }

        public string tempImagePath { get; set; } = "";
        public int? id { get; set; }

    }

    [FirestoreData]
    public class VoterListModel
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

        [FirestoreProperty]
        public Dictionary<string, object> Votes { get; set; }
    }

    public class ViewModel
    {
        public IEnumerable<VoterListModel> Voters { get; set; }
        public IEnumerable<CandiListModel> Candidates { get; set; }

        

        public bool checkVote { get; set; }

        public string getEmail { get; set; }

        public string getPassword { get; set; }

        public string getUID { get; set; }
    }

    public class CheckVoteModel
    {

        public bool checkVote { get; set; } = new bool();    
    }
}
