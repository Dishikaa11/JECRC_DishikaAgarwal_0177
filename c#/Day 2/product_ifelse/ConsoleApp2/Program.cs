using System;
class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public DateTime ExpiryDate { get; set; }
    public int Quantity { get; set; }
    public string Brand { get; set; }
    public bool ISOStandard { get; set; }

    public void GetProductData()
    {
        Console.WriteLine("Enter Product Id:");
        ProductId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Product Name:");
        Name = Console.ReadLine();

        Console.WriteLine("Enter Expiry Date:");
        ExpiryDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter Quantity:");
        Quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Brand:");
        Brand = Console.ReadLine();

        Console.WriteLine("Is Product ISO Certified? (true/false):");
        ISOStandard = Convert.ToBoolean(Console.ReadLine());
    }

    public void CheckISO()
    {
        if (ISOStandard)
        {
            Console.WriteLine("Product is ISO Certified");
        }
        else
        {
            Console.WriteLine("Product is NOT ISO Certified");
        }
    }

    public void DisplayProductData()
    {
        Console.WriteLine("\nProduct Details:");
        Console.WriteLine($"Id: {ProductId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Expiry Date: {ExpiryDate.ToShortDateString()}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Brand: {Brand}");
    }
}

class Program
{
    static void Main()
    {
        Product p = new Product();
        p.GetProductData();
        p.DisplayProductData();
        p.CheckISO();
    }
}

