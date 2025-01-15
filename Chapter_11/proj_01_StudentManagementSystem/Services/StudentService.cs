using proj_01_StudentManagementSystem.Models;

namespace proj_01_StudentManagementSystem.Services
{
    // Service to manage students
    public class StudentService
    {
        private readonly List<Student> _students;

        public StudentService()
        {
            // Initialize with some sample data
            _students = new List<Student>
            {
                new Student { Id = 1, Name = "Alice", Age = 20, Grade = "A" },
                new Student { Id = 2, Name = "Bob", Age = 22, Grade = "B" }
            };
        }

        // Retrieve all students
        public List<Student> GetAllStudents()
        {
            return _students;
        }

        // Add a new student
        public void AddStudent(Student student)
        {
            student.Id = _students.Count + 1; // Auto-generate ID
            _students.Add(student);
        }

        // Find a student by ID
        public Student GetStudentById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        // Update an existing student
        public void UpdateStudent(Student student)
        {
            var existingStudent = GetStudentById(student.Id);
            if (existingStudent != null)
            {
                existingStudent.Name = student.Name;
                existingStudent.Age = student.Age;
                existingStudent.Grade = student.Grade;
            }
        }

        // Delete a student
        public void DeleteStudent(int id)
        {
            var student = GetStudentById(id);
            if (student != null)
            {
                _students.Remove(student);
            }
        }
    }
}
