using System;
using System.Collections.Generic;
using System.IO;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
}

public class CSVHandler
{
    public static List<Student> ReadStudentsFromCsv(string filePath)
    {
        var students = new List<Student>();
        using (var reader = new StreamReader(filePath))
        {
            // Bỏ qua dòng tiêu đề nếu có
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                var student = new Student
                {
                    Id = int.Parse(values[0]),
                    Name = values[1],
                    Age = int.Parse(values[2]),
                    Grade = values[3]
                };

                students.Add(student);
            }
        }
        return students;
    }

    public static void WriteStudentsToCsv(string filePath, List<Student> students)
    {
        using (var writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Id,Name,Age,Grade"); // Dòng tiêu đề
            foreach (var student in students)
            {
                writer.WriteLine($"{student.Id},{student.Name},{student.Age},{student.Grade}");
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        string csvFilePath = "students.csv";

        // Ghi danh sách sinh viên vào tệp CSV
        var studentsToWrite = new List<Student>
        {
            new Student { Id = 1, Name = "Nhi", Age = 20, Grade = "A" },
            new Student { Id = 2, Name = "Trang", Age = 22, Grade = "B" }
        };
        CSVHandler.WriteStudentsToCsv(csvFilePath, studentsToWrite);

        // Đọc danh sách sinh viên từ tệp CSV
        var studentsFromCsv = CSVHandler.ReadStudentsFromCsv(csvFilePath);

        // Hiển thị danh sách sinh viên đã đọc
        foreach (var student in studentsFromCsv)
        {
            Console.WriteLine($"{student.Id}, {student.Name}, {student.Age}, {student.Grade}");
        }
    }
}
