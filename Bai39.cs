using System;
using System.Collections.Generic;

class Bai39
{
    public static void Main()
    {
        // Tạo danh sách các album
        List<string> albums = new List<string>() { "Red", "Midnight", "Reputation" };

        // Duyệt qua danh sách albums và hiển thị từng phần tử
        for (int i = 0; i < albums.Count; i++)
        {
            Console.WriteLine(albums[i]);
        }
    }
}
