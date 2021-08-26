using FirstDotNetCoreWebProject.Model;
using System.Collections.Generic;

namespace FirstDotNetCoreWebProject.Interface
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentsById(int id);
    }
}