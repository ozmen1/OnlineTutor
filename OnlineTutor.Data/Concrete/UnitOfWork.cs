using OnlineTutor.Data.Abstract;
using OnlineTutor.Data.Concrete.EfCore.Contexts;
using OnlineTutor.Data.Concrete.EfCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OnlineTutorContext _context;

        public UnitOfWork(OnlineTutorContext context)
        {
            _context = context;
        }

        private EfCoreCategoryRepository _categoryRepository;
        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new EfCoreCategoryRepository(_context);

        private EfCoreShowCardRepository _showCardRepository;
        public IShowCardRepository ShowCards => _showCardRepository = _showCardRepository ?? new EfCoreShowCardRepository(_context);

        private EfCoreSubjectRepository _subjectRepository;
        public ISubjectRepository Subjects => _subjectRepository = _subjectRepository ?? new EfCoreSubjectRepository(_context);

        public ITeacherRepository Teachers => throw new NotImplementedException();

        public IStudentRepository Students => throw new NotImplementedException();

        public IRequestRepository Requests => throw new NotImplementedException();

        public ICommentRepository Comments => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
