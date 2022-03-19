namespace API_example.Data.Models
{
    public class Courses
    {
        public int id { get; set; }
        public String Name { get; set; }
        public int AlgorithmId { get; set; }
        public Algorithms Algorithm { get; set; }
        public List<Courses_Authors> Course_Authors { get; set; }
        public List<LearningSteps> LearningSteps { get; set; }
    }
}
