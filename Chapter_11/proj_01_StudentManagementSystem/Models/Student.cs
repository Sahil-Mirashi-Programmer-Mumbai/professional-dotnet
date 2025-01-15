namespace proj_01_StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; } // Unique identifier for a student
        public string Name { get; set; } // Student's name
        public int Age { get; set; } // Student's age
        public string Grade { get; set; } // Student's grade (e.g., A, B, C)
    }
}