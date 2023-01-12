using OnlineTutor.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Entity.Concrete
{
    public class ShowCard
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsHome { get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
        public Teacher Teacher { get; set; }
        public string TeacherId { get; set; }
        public List<Request> Requests { get; set; }
        //public User User { get; set; }
        //public int UserId { get; set; }
    }
}
