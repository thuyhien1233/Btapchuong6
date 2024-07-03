using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}

public class JSONHandler
{
    public static List<Product> ReadProductsFromJson(string filePath)
    {
        var jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Product>>(jsonString);
    }

    public static void WriteProductsToJson(string filePath, List<Product> products)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var jsonString = JsonSerializer.Serialize(products, options);
        File.WriteAllText(filePath, jsonString);
    }
}
class Bai3_Chuong6
{
    static void Main(string[] args)
    {
        string jsonFilePath = "products.json";

        // Ghi danh sách sản phẩm vào tệp JSON
        var productsToWrite = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200.99m, Category = "Electronics" },
            new Product { Id = 2, Name = "Chair", Price = 99.99m, Category = "Furniture" }
        };
        JSONHandler.WriteProductsToJson(jsonFilePath, productsToWrite);

        // Đọc danh sách sản phẩm từ tệp JSON
        var productsFromJson = JSONHandler.ReadProductsFromJson(jsonFilePath);

        // Hiển thị danh sách sản phẩm đã đọc
        foreach (var product in productsFromJson)
        {
            Console.WriteLine($"{product.Id}, {product.Name}, {product.Price}, {product.Category}");
        }
    }
}
