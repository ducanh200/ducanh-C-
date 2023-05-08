using System.Collections.Generic;
using T2207A;
class Program
{
    static List<Product> products = new List<Product>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add product ");
            Console.WriteLine("2. Display product");
            Console.WriteLine("3. Delete product by Id");
            Console.WriteLine("4. Exit");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    DisplayProducts();
                    break;
                case 3:
                    DeleteProduct();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void AddProduct()
    {
        Console.Write("Enter product ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter product price: ");
        double price = double.Parse(Console.ReadLine());

        Product product = new Product(id, name, price);
        products.Add(product);

        Console.WriteLine("Product added .");
    }

    static void DisplayProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products found.");
        }
        else
        {
            Console.WriteLine("Product records:");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
    }

    static void DeleteProduct()
    {
        Console.Write("Enter product ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        bool found = false;
        foreach (Product product in products)
        {
            if (product.Id == id)
            {
                products.Remove(product);
                Console.WriteLine("Product deleted.");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Product not found.");
        }
    }
}