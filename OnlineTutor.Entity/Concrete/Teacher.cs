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
        public string Department { get; set; }
        public byte Point { get; set; }
    }
}
