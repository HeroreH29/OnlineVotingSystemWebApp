using Google.Cloud.Firestore;
using System.Collections.Generic;

namespace OnlineVotingSystem.Models
{
    [FirestoreData]
    public class HasNotVotedModel
    {
        [FirestoreProperty]
        public string voterCollege { get; set; }

        [FirestoreProperty]
        public string voterFirstName { get; set; }

        [FirestoreProperty]
        public string voterLastName { get; set; }

        [FirestoreProperty]
        public string voterUID { get; set; }

        [FirestoreProperty]
        public string voterYearSection { get; set; }
    }

    public class HasNotVotedViewModel
    {
        public IEnumerable<HasNotVotedModel> hasNotVoted { get; set; }
    }
}
