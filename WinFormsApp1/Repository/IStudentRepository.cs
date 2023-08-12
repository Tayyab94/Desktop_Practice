using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudent();
        void AddStudent(string studentName);
    }
}
