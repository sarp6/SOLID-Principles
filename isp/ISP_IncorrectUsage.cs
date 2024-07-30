// ISP - Interface Segregation Principle
// Kullanıcıları gereksiz arayüz metodları implement etmeye zorlamayın.
// Yanlış Kullanım

public interface IMultiFunctionDevice
{
    void Print(string content);
    void Scan(string content);
}

public class Printer : IMultiFunctionDevice
{
    public void Print(string content)
    {
        Console.WriteLine("Printing: " + content);
    }

    public void Scan(string content)
    {
        // Printer sınıfı bu metodu implement etmek zorunda ama kullanmaz
        throw new NotImplementedException();
    }
}

public class Scanner : IMultiFunctionDevice
{
    public void Print(string content)
    {
        // Scanner sınıfı bu metodu implement etmek zorunda ama kullanmaz
        throw new NotImplementedException();
    }

    public void Scan(string content)
    {
        Console.WriteLine("Scanning: " + content);
    }
}
