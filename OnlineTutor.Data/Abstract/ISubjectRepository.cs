using OnlineTutor.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Data.Abstract
{
    public interface ISubjectRepository : IRepository<Subject>
    {
        Task CreateAsync(Subject subject, int[] categoryIds);
        Task UpdateAsync(Subject subject, int[] categoryIds);
        void IsDeleted(Subject subject);
        Task<Subject> GetSubjectWithCategoryAsync(int id); //dersi kategorisi ile birlikte getir
        Task<List<Category>> GetSubjectWithShowCardsAsync(int id); //bir dersi ilanlarla birlikte getir
    }
}
