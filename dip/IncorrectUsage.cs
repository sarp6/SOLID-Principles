// DIP - Dependency Inversion Principle
// Yüksek seviye modüller düşük seviye modüllere bağımlı olmamalı. Her ikisi de soyutlamalara bağımlı olmalı.
// Yanlış Kullanım

public class OrderService
{
    public double GetFinalPrice(double price)
    {
        // İndirim doğrudan bu sınıfta uygulanıyor
        return price - (price * 0.10);
    }
}
