using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Entity.Concrete
{
    public class Request
    {
        public string Expectations { get; set; }
        public string ContactNumber { get; set; }
        public DateTime? ResponseTime { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public ShowCard ShowCard { get; set; }
        public int ShowCardId { get; set; }
    }
}
