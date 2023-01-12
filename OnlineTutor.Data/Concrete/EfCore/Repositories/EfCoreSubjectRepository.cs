using Microsoft.EntityFrameworkCore;
using OnlineTutor.Data.Abstract;
using OnlineTutor.Data.Concrete.EfCore.Contexts;
using OnlineTutor.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Data.Concrete.EfCore.Repositories
{
    public class EfCoreSubjectRepository : EfCoreGenericRepository<Subject>, ISubjectRepository
    {
        public EfCoreSubjectRepository(OnlineTutorContext context) : base(context)
        {

        }

        private OnlineTutorContext OnlineTutorContext
        {
            get { return _context as OnlineTutorContext; }
        }

        public Task CreateAsync(Subject subject, int[] categoryIds)
        {
            throw new NotImplementedException();
        }

        public Task<Subject> GetSubjectWithCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetSubjectWithShowCardsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void IsDeleted(Subject subject)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Subject subject, int[] categoryIds)
        {
            throw new NotImplementedException();
        }
    }
}
