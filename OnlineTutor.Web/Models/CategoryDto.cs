using OnlineTutor.Entity.Concrete;

namespace OnlineTutor.Web.Models
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public List<SubjectDto> SubjectDtos { get; set; }
    }

    public class SubjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
