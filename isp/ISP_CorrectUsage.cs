// ISP - Interface Segregation Principle
// Kullanıcıları gereksiz arayüz metodları implement etmeye zorlamayın.
// Doğru Kullanım

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

