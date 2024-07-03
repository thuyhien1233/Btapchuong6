using System;
using System.IO;
using System.Text;

class Bai1_Chuong6
{
    // Khai báo biến chuỗi không đổi
    private const string FilePath = "data.txt";

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Gọi phương thức CreateFile
        CreateFile(FilePath);

        // Gọi phương thức WriteToFile với nội dung mẫu
        WriteToFile(FilePath, "Đây là nội dung mẫu đầu tiên.");

        // Gọi phương thức ReadFromFile để xác minh rằng tệp đã được ghi chính xác
        ReadFromFile(FilePath);

        // Gọi phương thức AppendToFile với nội dung mẫu khác
        AppendToFile(FilePath, "\nĐây là nội dung mẫu được nối thêm.");

        // Gọi lại phương thức ReadFromFile để xem nội dung cập nhật
        ReadFromFile(FilePath);

        // Gọi phương thức DeleteFile để xóa tệp
        DeleteFile(FilePath);
    }

    // Phương thức CreateFile
    static void CreateFile(string filePath)
    {
        using (FileStream fs = File.Create(filePath))
        {
            // Tạo tệp tại filePath
        }
        Console.WriteLine($"File '{filePath}' đã được tạo.");
    }

    // Phương thức WriteToFile
    static void WriteToFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
        Console.WriteLine($"Đã ghi vào file '{filePath}'.");
    }

    // Phương thức ReadFromFile
    static void ReadFromFile(string filePath)
    {
        string content = File.ReadAllText(filePath);
        Console.WriteLine($"Nội dung của file '{filePath}':\n{content}");
    }

    // Phương thức AppendToFile
    static void AppendToFile(string filePath, string content)
    {
        File.AppendAllText(filePath, content);
        Console.WriteLine($"Đã nối vào file '{filePath}'.");
    }

    // Phương thức DeleteFile
    static void DeleteFile(string filePath)
    {
        File.Delete(filePath);
        Console.WriteLine($"File '{filePath}' đã được xóa.");
    }
}
