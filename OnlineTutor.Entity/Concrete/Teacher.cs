using OnlineTutor.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Entity.Concrete
{
    public class Teacher : User
    {
        public string TeacherInfo { get; set; }
        public string Department { get; set; }
        public byte TeacherPoint { get; set; }
        public string? ResponseRange { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<ShowCard>? ShowCards { get; set; }
    }
}
