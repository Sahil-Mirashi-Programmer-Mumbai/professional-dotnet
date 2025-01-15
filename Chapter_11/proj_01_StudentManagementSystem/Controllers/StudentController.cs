using Microsoft.AspNetCore.Mvc;
using proj_01_StudentManagementSystem.Models;
using proj_01_StudentManagementSystem.Services;

namespace proj_01_StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService; // Inject the service
        }

        // Display the list of students
        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents();
            return View(students);
        }

        // Show the Add Student form
        public IActionResult Create()
        {
            return View();
        }

        // Handle the Add Student form submission
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.AddStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // Show the Edit Student form
        public IActionResult Edit(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // Handle the Edit Student form submission
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.UpdateStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // Confirm student deletion
        public IActionResult Delete(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // Handle student deletion
        [HttpPost, ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int id)
        {
            _studentService.DeleteStudent(id);
            return RedirectToAction("Index");
        }
    }
}
