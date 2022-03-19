namespace API_example.Data.Models
{
    public class Authors
    {

        public int id { get; set; }

        public String Name { get; set; }

        public List<Courses_Authors> Course_Authors { get; set; }
    }
}
