using System;
using System.Collections.Generic;

// 1. Single Responsibility Principle (SRP)
// Her sınıf sadece bir sorumluluğa sahip olmalı.
public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }

    // Customer sınıfı sadece müşteri bilgilerini tutar.
}

public class CustomerRepository
{
    private List<Customer> customers = new List<Customer>();

    public void Add(Customer customer)
    {
        customers.Add(customer);
    }

    public List<Customer> GetAll()
    {
        return customers;
    }

    // CustomerRepository sınıfı sadece müşteri verilerini yönetir.
}

// 2. Open/Closed Principle (OCP)
// Sınıflar genişletilmeye açık, değiştirilmeye kapalı olmalı.
public interface IDiscount
{
    double ApplyDiscount(double price);
}

public class NoDiscount : IDiscount
{
    public double ApplyDiscount(double price)
    {
        return price;
    }
}

public class PercentageDiscount : IDiscount
{
    private double percentage;

    public PercentageDiscount(double percentage)
    {
        this.percentage = percentage;
    }

    public double ApplyDiscount(double price)
    {
        return price - (price * percentage / 100);
    }
}

// 3. Liskov Substitution Principle (LSP)
// Türeyen sınıflar, türediği sınıfların yerine kullanılabilmeli.
public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public virtual double GetDiscountedPrice(IDiscount discount)
    {
        return discount.ApplyDiscount(Price);
    }
}

// 4. Interface Segregation Principle (ISP)
// Kullanıcıları gereksiz arayüz metodları implement etmeye zorlamayın.
public interface IPrinter
{
    void Print(string content);
}

public interface IScanner
{
    void Scan(string content);
}

public class Printer : IPrinter
{
    public void Print(string content)
    {
        Console.WriteLine("Printing: " + content);
    }
}

public class Scanner : IScanner
{
    public void Scan(string content)
    {
        Console.WriteLine("Scanning: " + content);
    }
}

// 5. Dependency Inversion Principle (DIP)
// Yüksek seviye modüller düşük seviye modüllere bağımlı olmamalı. Her ikisi de soyutlamalara bağımlı olmalı.
public class OrderService
{
    private readonly IDiscount discount;

    public OrderService(IDiscount discount)
    {
        this.discount = discount;
    }

    public double GetFinalPrice(Product product)
    {
        return product.GetDiscountedPrice(discount);
    }
}

// Kullanım
public class Program
{
    public static void Main(string[] args)
    {
        // SRP
        var customerRepository = new CustomerRepository();
        customerRepository.Add(new Customer { Name = "John Doe", Email = "john.doe@example.com" });

        // OCP ve LSP
        var product = new Product { Name = "Laptop", Price = 1000 };
        IDiscount discount = new PercentageDiscount(10);
        var finalPrice = product.GetDiscountedPrice(discount);
        Console.WriteLine($"Final price after discount: {finalPrice}");

        // ISP
        IPrinter printer = new Printer();
        printer.Print("Document content");

        IScanner scanner = new Scanner();
        scanner.Scan("Document content");

        // DIP
        var orderService = new OrderService(new NoDiscount());
        double priceWithNoDiscount = orderService.GetFinalPrice(product);
        Console.WriteLine($"Price with no discount: {priceWithNoDiscount}");
    }
}
