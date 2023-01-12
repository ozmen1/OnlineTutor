using OnlineTutor.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Business.Abstract
{
    public interface ISubjectService
    {
        Task<List<Subject>> GetAllAsync();
        Task CreateAsync(Subject subject, int[] categoryIds);
        void Update(Subject subject, int[] categoryIds);
        void IsDeleted(Subject subject);
    }
}
