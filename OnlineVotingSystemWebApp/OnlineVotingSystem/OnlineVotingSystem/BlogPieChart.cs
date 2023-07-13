using Google.Cloud.Firestore;

namespace OnlineVotingSystem
{
    [FirestoreData]
    public class BlogPieChart
    {
        [FirestoreProperty]
        public string candidateFullName { get; set; }

        [FirestoreProperty]
        public int? voteCount { get; set; }

        [FirestoreProperty]
        public string imageURL { get; set; }

        public string chairpersonFullName { get; set; }
        public string viceChairpersonFullName { get; set; }
        public string secretaryFullName { get; set; }
        public string treasurerFullName { get; set; }
        public string auditorFullName { get; set; }
        public string fourthYearFullName { get; set; }
        public string thirdYearFullName { get; set; }
        public string secondYearFullName { get; set; }
        public string firstYearFullName { get; set; }

    }
}
