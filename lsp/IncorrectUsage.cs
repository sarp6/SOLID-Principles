// LSP - Liskov Substitution Principle
// Türeyen sınıflar, türediği sınıfların yerine kullanılabilmeli.
// Yanlış Kullanım

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double GetArea()
    {
        return Width * Height;
    }
}

public class Square : Rectangle
{
    public new double Width
    {
        set { base.Width = base.Height = value; }
    }

    public new double Height
    {
        set { base.Width = base.Height = value; }
    }
}
