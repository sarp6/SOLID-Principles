
// OCP - Open/Closed Principle
// Sınıflar genişletilmeye açık, değiştirilmeye kapalı olmalı.
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
