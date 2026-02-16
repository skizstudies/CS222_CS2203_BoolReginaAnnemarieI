using System;
using System.ComponentModel.DataAnnotations;

class Pentagon
{
    private double side;

    public Pentagon()
    {
        side = 0;
    }

    public Pentagon(double length)
    {
        this.side = length;
    }

    public double GetPerimeter()
    {
        return 5 * side;
    }

    public double GetArea()
    {
        return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side) / 4;
    }

    public void Display()
    {
        Console.WriteLine("-------------------------");

        Console.WriteLine($"Side Length: {side}");
        Console.WriteLine($"Perimeter: {GetPerimeter():F3}");
        Console.WriteLine($"Area: {GetArea():F3}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pentagon p1 = new Pentagon(0);
        Console.WriteLine("Pentagon p1");
        p1.Display();

        Console.WriteLine("");

        Pentagon p2 = new Pentagon(5);
        Console.WriteLine("Pentagon p2");
        p2.Display();

    }
}