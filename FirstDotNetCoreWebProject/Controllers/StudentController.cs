using FirstDotNetCoreWebProject.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDotNetCoreWebProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMockStudentRepository _mockStudentRepository;
        public StudentController(IMockStudentRepository mockStudentRepository)
        {
            _mockStudentRepository = mockStudentRepository;
        }
        public IActionResult Index()
        {
            var students=_mockStudentRepository.GetAllStudents();
            return View(students);
        }
        public IActionResult Details(int id)
        {
            var student = _mockStudentRepository.GetStudentsById(id);
            return View(student);
        }
    }
}
