using OnlineTutor.Entity.Concrete;

namespace OnlineTutor.Web.Models
{
    public class ShowCardDetailsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal? Price { get; set; }
        //public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public List<Category> Categories { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<SubjectCategory> SubjectCategories { get; set; }
        public Teacher? Teacher { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
