using Google.Cloud.Firestore;
using System.Collections.Generic;

namespace OnlineVotingSystem.Models
{
    [FirestoreData]
    public class HasVotedModel
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

        [FirestoreProperty]
        public string candidateFullName { get; set; }

        public string chairpersonFullName { get; set; }

        public string viceChairpersonFullName { get; set; }

        public string secretaryFullName { get; set; }

        public string treasurerFullName { get; set; }

        public string auditorFullName { get; set; }

        public string fourthYearRepFullName { get; set; }

        public string thirdYearRepFullName { get; set; }

        public string secondYearRepFullName { get; set; }

        public string firstYearRepFullName { get; set; }
    }

    public class HasVotedViewModel
    {
        public IEnumerable<HasVotedModel> hasVoted { get; set; }
    }
}
