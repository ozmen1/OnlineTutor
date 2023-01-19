using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Entity.Concrete
{
    public class SubjectCategoryShowCard
    {
        public int Id { get; set; }
        public int SubjectCategoryId { get; set; }
        public SubjectCategory SubjectCategory { get; set; }
        public int ShowCardId { get; set; }
        public ShowCard ShowCard { get; set; }
    }
}
