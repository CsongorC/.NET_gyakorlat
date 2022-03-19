namespace API_example.Data.Models
{
    public class Courses_Authors
    {
        public int id { get; set; }

        public int AuthorId { get; set; }
        public Authors? Author { get; set; }

        public int CourseId { get; set; }
        public Courses? Course { get; set; }
    }
}
