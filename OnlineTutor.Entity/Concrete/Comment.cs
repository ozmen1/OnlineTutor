using OnlineTutor.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Entity.Concrete
{
    public class Comment : IEntityBase
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public byte Point { get; set; }
        public Teacher Teacher { get; set; }
        public string TeacherId { get; set; }
        public Student Student { get; set; }
        public string StudentId { get; set; }
        public string Url { get; set; }
    }
}
