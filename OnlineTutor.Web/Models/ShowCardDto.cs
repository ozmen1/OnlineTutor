using OnlineTutor.Entity.Concrete;

namespace OnlineTutor.Web.Models
{
    public class ShowCardDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public decimal Price { get; set; }
        public Teacher? Teacher { get; set; }
    }
}
