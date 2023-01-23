using OnlineTutor.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Business.Abstract
{
    public interface ITeacherService
    {
        Task<Teacher> GetByIdAsync(string id);
        Task<List<Teacher>> GetAllAsync();
        Task CreateAsync(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(Teacher teacher);
    }
}
