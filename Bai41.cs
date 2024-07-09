using System;
using System.Collections.Generic;

class Bai41
{
    public static void Main()
    {
        // Khởi tạo danh sách myList của kiểu List<List<string>>
        List<List<string>> myList = new List<List<string>>();

        // Thêm các danh sách con vào myList
        myList.Add(new List<string> { "a", "b" });
        myList.Add(new List<string> { "c", "d", "e" });
        myList.Add(new List<string> { "qwerty", "asdf", "zxcv" });
        myList.Add(new List<string> { "a", "b" });

        // Duyệt qua myList sử dụng vòng lặp for theo chỉ số
        for (int i = 0; i < myList.Count; i++)
        {
            // Lấy danh sách con từ myList
            List<string> subList = myList[i];

            // Duyệt qua danh sách con và hiển thị từng phần tử
            for (int j = 0; j < subList.Count; j++)
            {
                string item = subList[j];
                Console.WriteLine(item);
            }
        }
    }
}

