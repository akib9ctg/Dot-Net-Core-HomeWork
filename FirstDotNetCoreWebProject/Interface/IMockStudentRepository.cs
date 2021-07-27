using FirstDotNetCoreWebProject.Model;
using System.Collections.Generic;

namespace FirstDotNetCoreWebProject.Interface
{
    public interface IMockStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentsById(int id);
    }
}