using System;
using System.Collections.Generic;

// a. Tạo lớp trừu tượng Person
public abstract class Person
{
    public string Name { get; set; }
    public string Id { get; set; }
}

// b. Tạo interface Kpi
public interface Kpi
{
    float Kpi();
}

// c. Tạo lớp Student kế thừa Person và implement interface Kpi
public class Student : Person, Kpi
{
    private string _department;
    public string Department
    {
        get { return _department; }
        set
        {
            if (value == "ICT" || value == "ECO")
                _department = value;
            else
                throw new ArgumentException("Sai department. Chi chap nhan 'ICT' hoac 'ECO'.");
        }
    }

    private float _gpa;
    public float Kpi()
    {
        return _gpa;
    }

    public Student(string name, string id, string department, float gpa)
    {
        Name = name;
        Id = CheckId(id);
        Department = department;
        _gpa = gpa;
    }

    private string CheckId(string id)
    {
        if (id.Length == 8 && int.TryParse(id, out _))
            return id;
        else
            throw new ArgumentException("Sai ma sinh vien. Phai co 8 ky tu so.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // d. Khai báo obs kiểu Person và gán null
        Person obs = null;

        // e. Cấp phát obs là Student và hiển thị kpi()
        obs = new Student("Nguyen Tien Dung", "12345678", "ICT", 8.5f);
        Console.WriteLine($"Kpi cua sinh vien: {((Student)obs).Kpi()}");

        // g. Cấp phát obs bị sai về id hoặc department
        try
        {
            obs = new Student("Nguyen Van Nam", "123456789", "BUS", 7.5f);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        // h. Khai báo danh sách list1, list2 các đối tượng Person
        List<Person> list1 = new List<Person>();
        List<Person> list2 = new List<Person>();

        // Nhập danh sách list1
        Console.WriteLine("Nhap danh sach sinh vien ban 1:");
        while (true)
        {
            Console.Write("Ten: ");
            string name = Console.ReadLine();
            if (name == "#") break;
            Console.Write("Ma sinh vien: ");
            string id = Console.ReadLine();
            Console.Write("Diem GPA: ");
            float gpa = float.Parse(Console.ReadLine());
            Console.Write("Khoa: ");
            string department = Console.ReadLine();
            list1.Add(new Student(name, id, department, gpa));
        }

        // Nhập danh sách list2
        Console.WriteLine("Nhap danh sach sinh vien ban 2:");
        while (true)
        {
            Console.Write("Ten: ");
            string name = Console.ReadLine();
            if (name == "#") break;
            Console.Write("Ma sinh vien: ");
            string id = Console.ReadLine();
            Console.Write("Diem GPA: ");
            float gpa = float.Parse(Console.ReadLine());
            Console.Write("Khoa: ");
            string department = Console.ReadLine();
            list2.Add(new Student(name, id, department, gpa));
        }

        // Hiển thị list1, list2
        Console.WriteLine("Danh sach sinh vien bàn 1:");
        foreach (var student in list1)
            Console.WriteLine($"Ten: {student.Name}, Ma: {student.Id}, Khoa: {((Student)student).Department}, Diem: {((Student)student).Kpi()}");

        Console.WriteLine("Danh sach sinh vien ban 2:");
        foreach (var student in list2)
            Console.WriteLine($"Ten: {student.Name}, Ma: {student.Id}, Khoa: {((Student)student).Department}, Diem: {((Student)student).Kpi()}");

        // k. Khai báo list_list và bổ sung list1, list2
        List<List<Person>> list_list = new List<List<Person>>();
        list_list.Add(list1);
        list_list.Add(list2);

        // Hiển thị list_list
        Console.WriteLine("Danh sach cac danh sach sinh vien:");
        foreach (var list in list_list)
        {
            Console.WriteLine("---");
            foreach (var student in list)
                Console.WriteLine($"Ten: {student.Name}, Ma: {student.Id}, Khoa: {((Student)student).Department}, Diem: {((Student)student).Kpi()}");
        }

        // l. Tạo Dictionary dic11 cho list1 và tìm sinh viên tên "Nam"
        Dictionary<string, Student> dic11 = new Dictionary<string, Student>();
        foreach (var student in list1)
            dic11[student.Id] = (Student)student;

        Console.WriteLine("Sinh vien ten 'Nam' trong list1:");
        foreach (var student in dic11.Values)
            if (student.Name.Contains("Nam"))
                Console.WriteLine($"Ten: {student.Name}, Ma: {student.Id}, Khoa: {student.Department}, Diem: {student.Kpi()}");
    }
}