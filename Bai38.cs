using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Tạo danh sách các số thực 4 byte
        List<float> listf = new List<float>();

        // Thêm các số 3.5, -1.2, 7.8, -5 vào cuối danh sách
        listf.Add(3.5f);
        listf.Add(-1.2f);
        listf.Add(7.8f);
        listf.Add(-5f);

        // Duyệt danh sách theo chỉ số để hiển thị các phần tử
        Console.WriteLine("Cac phan tu trong danh sach:");
        for (int i = 0; i < listf.Count; i++)
        {
            Console.WriteLine(listf[i]);
        }

        // Sắp xếp danh sách theo thứ tự tăng dần
        listf.Sort();

        Console.WriteLine("\nDanh sach sau khi sap xep:");
        for (int i = 0; i < listf.Count; i++)
        {
            Console.WriteLine(listf[i]);
        }
    }
}