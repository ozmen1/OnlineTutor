using Microsoft.AspNetCore.Identity;
using OnlineTutor.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Entity.Concrete.Identity
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
