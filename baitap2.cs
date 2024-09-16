using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Nguyên", Age = 16 },
            new Student { Id = 2, Name = "Nghi", Age = 17 },
            new Student { Id = 3, Name = "Thanh", Age = 15 },
            new Student { Id = 4, Name = "Ngân", Age = 18 },
            new Student { Id = 5, Name = "Dat", Age = 16 }
        };

        // a. 
        Console.WriteLine("Danh sách toàn bộ học sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // b.
        var studentsAge15to18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
        Console.WriteLine("\nDanh sách học sinh có tuổi từ 15 đến 18:");
        foreach (var student in studentsAge15to18)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // c. 
        var studentsNameStartWithA = students.Where(s => s.Name.StartsWith("A"));
        Console.WriteLine("\nDanh sách học sinh có tên bắt đầu bằng chữ 'A':");
        foreach (var student in studentsNameStartWithA)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // d. 
        var totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {totalAge}");

        // e. 
        var oldestStudent = students.OrderByDescending(s => s.Age).First();
        Console.WriteLine($"\nHọc sinh có tuổi lớn nhất: Id: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

        // f. 
        var sortedStudents = students.OrderBy(s => s.Age);
        Console.WriteLine("\nDanh sách học sinh sau khi sắp xếp theo tuổi tăng dần:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}