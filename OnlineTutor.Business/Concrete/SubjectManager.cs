using OnlineTutor.Business.Abstract;
using OnlineTutor.Data.Abstract;
using OnlineTutor.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Business.Concrete
{
    public class SubjectManager : ISubjectService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SubjectManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task CreateAsync(Subject subject, int[] categoryIds)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Subject>> GetAllAsync()
        {
            return await _unitOfWork.Subjects.GetAllAsync();
        }

        public void IsDeleted(Subject subject)
        {
            throw new NotImplementedException();
        }

        public void Update(Subject subject, int[] categoryIds)
        {
            throw new NotImplementedException();
        }
    }
}
