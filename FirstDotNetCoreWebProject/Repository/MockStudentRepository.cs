using FirstDotNetCoreWebProject.Interface;
using FirstDotNetCoreWebProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDotNetCoreWebProject.Repository
{
    public class MockStudentRepository : IMockStudentRepository
    {
        private List<Student> _students;
        public MockStudentRepository()
        {
            _students = new List<Student>{
                new Student { Id = 1, FirstName = "A", LastName = "Joe", DOB = new DateTime(1998,12, 11), Department = "CSE" },
                new Student { Id = 2, FirstName = "B", LastName = "Doe", DOB = new DateTime(1993, 01 , 23), Department = "EEE" },
                new Student { Id = 3, FirstName = "C", LastName = "Mac", DOB = new DateTime(1996 , 02 , 26), Department = "EEE" },
                new Student { Id = 4, FirstName = "D", LastName = "Jack", DOB = new DateTime(1999 , 12 , 01), Department = "CSE" },
                new Student { Id = 5, FirstName = "E", LastName = "Ron", DOB = new DateTime(1995 , 06 , 03), Department = "ELL" },
                new Student { Id = 6, FirstName = "F", LastName = "Due", DOB = new DateTime(1993 , 09 , 16), Department = "ETE" },
                new Student { Id = 7, FirstName = "G", LastName = "Cran", DOB = new DateTime(1995 , 11 , 30), Department = "CSE" },
                new Student { Id = 8, FirstName = "H", LastName = "Anothony", DOB = new DateTime(1998 , 05 , 13), Department = "ELL" },
                new Student { Id = 9, FirstName = "I", LastName = "Roy", DOB = new DateTime(1996 , 03 , 02), Department = "ETE" },
                new Student { Id = 10, FirstName = "J", LastName = "Julia", DOB = new DateTime(1999 , 06 , 12), Department = "CSE" },

            };
        }
        public List<Student> GetAllStudents()
        {
            return _students;
        }
        public Student GetStudentsById(int id)
        {
            return _students.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
