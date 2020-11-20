using Solid_3;
using System;

//Який принцип S.O.L.I.D. порушено? Виправте!

/// OCP, SRP

class Rectangle : IShape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public double GetArea()
    {
        return Width * Height;
    }
}

class Square : IShape
{
    public double Width { get; set; }
    public double GetArea()
    {
        return Width * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.Width = 5;

        Console.WriteLine(square.GetArea());
        Console.ReadKey();
    }
}
