// OCP - Open/Closed Principle
// Sınıflar genişletilmeye açık, değiştirilmeye kapalı olmalı.
// Yanlış Kullanım

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public double DiscountPercentage { get; set; }

    public double GetPrice()
    {
        return Price - (Price * DiscountPercentage / 100);
    }
}
