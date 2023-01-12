using OnlineTutor.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Entity.Concrete
{
    public class Student : User
    {
        public List<Comment>? Comments { get; set; }
        public List<Request>? Requests { get; set; }
        public string Url { get; set; }
    }
}
