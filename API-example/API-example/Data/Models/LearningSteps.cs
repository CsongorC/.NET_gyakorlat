using API_example.Data.Enums;

namespace API_example.Data.Models
{
    public class LearningSteps
    {
        public int id { get; set; }
        public String Name { get; set; }
        public LearningStepType Type { get; set; }
        public int CourseId { get; set; }
        public Courses Course { get; set; }
    }
}
