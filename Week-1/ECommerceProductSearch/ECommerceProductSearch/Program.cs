using System;

namespace ECommerceProductSearch
{
    internal class Program
    {
        public static Product LinearSearch(Product[] products, string targetName)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(targetName, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }

        public static Product BinarySearch(Product[] products, string targetName)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int comparison = string.Compare(products[mid].ProductName, targetName, true);

                if (comparison == 0)
                    return products[mid];
                else if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return null;
        }


        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
        new Product(1, "Laptop", "Electronics"),
        new Product(2, "Shoes", "Fashion"),
        new Product(3, "Watch", "Accessories"),
        new Product(4, "Headphones", "Electronics"),
        new Product(5, "T-shirt", "Fashion")
            };

            // Linear Search
            Console.WriteLine("Enter product name to search (Linear):");
            string searchName = Console.ReadLine();
            var resultLinear = LinearSearch(products, searchName);
            Console.WriteLine(resultLinear != null ? $"Found: {resultLinear}" : "Product not found (Linear Search)");

            // Binary Search requires sorted array
            Array.Sort(products, (p1, p2) => string.Compare(p1.ProductName, p2.ProductName, true));

            Console.WriteLine("Enter product name to search (Binary):");
            string searchNameBinary = Console.ReadLine();
            var resultBinary = BinarySearch(products, searchNameBinary);
            Console.WriteLine(resultBinary != null ? $"Found: {resultBinary}" : "Product not found (Binary Search)");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }
}

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int productId, string productName, string category)
    {
        ProductId = productId;
        ProductName = productName;
        Category = category;
    }

    public override string ToString()
    {
        return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
    }
}
