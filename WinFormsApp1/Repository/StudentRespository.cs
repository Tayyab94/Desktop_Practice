using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repository
{
    public class StudentRespository : IStudentRepository
    {
        private readonly DataContext _dbContext;

        public StudentRespository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddStudent(string studentName)
        {
            _dbContext.Students.Add(new Student()
            {
                Name = studentName,
            });
            _dbContext.SaveChanges();
        }

        public List<Student> GetAllStudent()
        {
            return _dbContext.Students.ToList();
        }
    }
}
