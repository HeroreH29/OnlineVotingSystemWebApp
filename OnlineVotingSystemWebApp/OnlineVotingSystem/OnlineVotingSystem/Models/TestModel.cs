using System.Collections.Generic;

namespace OnlineVotingSystem.Models
{
    public class TestModel
    {

        public List<indexCandi> testList { get; set; }
    }

    public class indexCandi
    {
        public int indexNumber { get; set; }
    }

    public class FileModel
    {
        public List<PmModel> PmModel { get; set; } 
    }
    public class PmModel
    {
        public int pmNumber { get; set; } 
    }
}
