using StudentApi.Models;
using BCrypt.Net;

namespace StudentApi.DataSimulation
{
    public class StudentDataSimulation
    {
        public static readonly List<Student> StudentsList = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "Ali Ahmed",
                Age = 20,
                Grade = 88,
                Email = "ali.ahmed@student.com",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("password1"),
                Role = "Student"
            },
            new Student
            {
                Id = 2,
                Name = "Emre Demir",
                Age = 22,
                Grade = 77,
                Email = "emre.demir@student.com",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("password2"),
                Role = "Student"
            },
            new Student
            {
                Id = 3,
                Name = "Kamil Jaber",
                Age = 21,
                Grade = 66,
                Email = "kamil.jaber@student.com",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("password3"),
                Role = "Student"
            },
            new Student
            {
                Id = 4,
                Name = "efe can",
                Age = 19,
                Grade = 44,
                Email = "alia.maher@admin.com",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin123"),
                Role = "Admin"
            }
        };
    }
}
