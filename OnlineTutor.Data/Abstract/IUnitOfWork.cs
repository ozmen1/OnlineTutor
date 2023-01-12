using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Categories { get; }
        IShowCardRepository ShowCards { get; }
        ITeacherRepository Teachers { get; }
        ISubjectRepository Subjects { get; }
        IStudentRepository Students { get; }
        IRequestRepository Requests { get; }
        ICommentRepository Comments { get; }
        Task SaveAsync();
        void Save();
    }
}
