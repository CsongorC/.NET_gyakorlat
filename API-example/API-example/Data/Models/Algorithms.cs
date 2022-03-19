using API_example.Data.Enums;

namespace API_example.Data.Models
{
    public class Algorithms
    {
        public int id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public AlgorithmType Type { get; set; }

        public string Icon { get; set; }

        public string Url { get; set; }

        public List<Courses> Courses { get; set; }

        public string AlgorithmNickname { get; set; }

        public bool IsPublished { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
