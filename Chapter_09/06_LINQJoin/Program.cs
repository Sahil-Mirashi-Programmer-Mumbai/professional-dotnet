/*
Program to demonstrate LINQ Join in C# with Visual Studio
Programmer: Sahil Mirashi

Explanation: "join" combines data from multiple collections based on a common key.
Application: Merging relational data like database tables.
*/

namespace LINQJoin
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Score
    {
        public int StudentID { get; set; }
        public int Marks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate LINQ Join in C# with Visual Studio\n");

            // List of students
            List<Student> students = new List<Student>
            {
                new Student { ID = 1, Name = "Alice" },
                new Student { ID = 2, Name = "Bob" }
            };

            // List of scores
            List<Score> scores = new List<Score>
            {
                new Score { StudentID = 1, Marks = 95 },
                new Score { StudentID = 2, Marks = 88 }
            };

            // Joining students with their scores
            var studentScores = from student in students
                                join score in scores
                                on student.ID equals score.StudentID
                                select new { student.Name, score.Marks };

            // Displaying results
            Console.WriteLine("Student Scores:");
            foreach (var item in studentScores)
            {
                Console.WriteLine($"{item.Name}: {item.Marks}");
            }
        }
    }
}