using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Entity.Concrete
{
    public class ShowCard
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal LessonPrice { get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public List<Request> Requests { get; set; }
    }
}
