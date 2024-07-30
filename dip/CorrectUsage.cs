// DIP - Dependency Inversion Principle
// Yüksek seviye modüller düşük seviye modüllere bağımlı olmamalı. Her ikisi de soyutlamalara bağımlı olmalı.
// Doğru Kullanım

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

public class OrderService
{
    private readonly IDiscount discount;

    public OrderService(IDiscount discount)
    {
        this.discount = discount;
    }

    public double GetFinalPrice(double price)
    {
        return discount.ApplyDiscount(price);
    }
}
