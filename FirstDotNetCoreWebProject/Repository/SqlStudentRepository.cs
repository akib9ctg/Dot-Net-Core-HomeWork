using FirstDotNetCoreWebProject.Interface;
using FirstDotNetCoreWebProject.Model;
using FirstDotNetCoreWebProject.SQLRepository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDotNetCoreWebProject.Repository
{
    public class SqlStudentRepository : IStudentRepository
    {
        private SqlDbContext _sqlDbContext;
        public SqlStudentRepository(SqlDbContext sqlDbContext)
        {
            _sqlDbContext = sqlDbContext;
        }
        public Student Add(Student student)
        {
            _sqlDbContext.Add(student);
            _sqlDbContext.SaveChanges();
            return student;
        }
        public List<Student> GetAllStudents()
        {
            return _sqlDbContext.Students.ToList();
        }

        public Student GetStudentsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
