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
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(DbContext context) : base(context)
        {
        }
        private OnlineTutorContext OnlineTutorContext
        {
            get { return _context as OnlineTutorContext; }
        }
        public Category GetByIdWithShowCards()
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetCategoryWithShowCardsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetCategoriesWithSubjectsAsync(int id)
        {
            return await OnlineTutorContext
               .Categories
               .Include(p => p.SubjectCategories)
               .ThenInclude(sc => sc.Subject)
               .ToListAsync();
        }

        public Task<List<Category>> GetCategoryWithSubjectsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryWithSubjectAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
