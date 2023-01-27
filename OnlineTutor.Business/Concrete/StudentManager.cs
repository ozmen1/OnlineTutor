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
    public class StudentManager : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(Student student)
        {
            await _unitOfWork.Students.CreateAsync(student);
        }

        public void Delete(Student student)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _unitOfWork.Students.GetAllAsync();
        }

        public Task<Student> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
