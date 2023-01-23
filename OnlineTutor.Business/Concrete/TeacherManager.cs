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
    public class TeacherManager : ITeacherService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TeacherManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task CreateAsync(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public void Delete(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Teacher>> GetAllAsync()
        {
            return await _unitOfWork.Teachers.GetAllAsync();
        }

        public Task<Teacher> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
