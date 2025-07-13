// Big O notation describes the upper bound of an algorithm's running time as input size grows.
// Best, average, and worst-case scenarios help analyze performance in different situations.
// Linear search: O(n) time complexity. Binary search: O(log n) time complexity (requires sorted array).

using System;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }
    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class Program
{
    //Linear search: O(n)
    static int LinearSearch(Product[] products, int targetId)
    {
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].ProductId == targetId)
                return i;
        }
        return -1;
    }

    //Binary search: O(log n), array must be sorted by ProductId
    static int BinarySearch(Product[] products, int targetId)
    {
        int left = 0, right = products.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (products[mid].ProductId == targetId)
                return mid;
            else if (products[mid].ProductId < targetId)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }

    static void Main(string[] args)
    {
        Product[] products = new Product[]
        {
            new Product(3, "Laptop", "Electronics"),
            new Product(1, "Shirt", "Clothing"),
            new Product(2, "Book", "Books")
        };

        //Linear search (unsorted)
        int idx1 = LinearSearch(products, 2);
        Console.Write("Linear search result: ");
        Console.WriteLine(idx1 != -1 ? $"Found: {products[idx1].ProductName}" : "Not found");

        //Sort array by ProductId for binary search
        Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId));
        int idx2 = BinarySearch(products, 2);
        Console.Write("Binary search result: ");
        Console.WriteLine(idx2 != -1 ? $"Found: {products[idx2].ProductName}" : "Not found");

        //Analysis
        Console.WriteLine("\nAnalysis:");
        Console.WriteLine("Linear search: O(n) time, works on unsorted data.");
        Console.WriteLine("Binary search: O(log n) time, requires sorted data.");
        Console.WriteLine("Binary search is more suitable for large, sorted datasets due to its efficiency.");
    }
}
