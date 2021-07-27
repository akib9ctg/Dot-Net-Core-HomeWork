using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDotNetCoreWebProject.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DOB { get; set; }
        public string  StudentId { get; set; }
        public string Department { get; set; }
    }
}
