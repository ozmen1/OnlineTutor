using OnlineTutor.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetByIdWithShowCards();
        Task<List<Category>> GetCategoryWithSubjectsAsync(int id);
        Task<List<Category>> GetCategoryWithShowCardsAsync(int id);
        Task<Category> GetCategoryWithSubjectAsync(int id);
        Task<List<Category>> GetCategoriesWithSubjectsAsync(int id);
    }
}
