using System;

class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public DateTime ExpiryDate { get; set; }
    public int Quantity { get; set; }
    public string Brand { get; set; }
    public bool ISOStandard { get; set; }

    // Parameterized Constructor
    public Product(int id, string name, DateTime expiry, int quantity, string brand, bool iso)
    {
        ProductId = id;
        Name = name;
        ExpiryDate = expiry;
        Quantity = quantity;
        Brand = brand;
        ISOStandard = iso;
    }

    public void DisplayProductData()
    {
        Console.WriteLine("\nProduct Details:");
        Console.WriteLine($"Id: {ProductId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Expiry Date: {ExpiryDate.ToShortDateString()}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"ISO Certified: {ISOStandard}");
    }
}

class Program
{
    static void Main()
    {
        // Object creation with values passed in constructor
        Product p = new Product(
            101,
            "Milk",
            new DateTime(2026, 3, 25),
            10,
            "Amul",
            true
        );

        p.DisplayProductData();

        Console.ReadLine();
    }
}
