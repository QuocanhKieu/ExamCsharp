using System;
using System.Globalization;

public class Cylinder
{
    public double Radius { get; private set; }
    public double Height { get; private set; }

    public double BaseArea { get; private set; }
    public double LateralArea { get; private set; }
    public double TotalArea { get; private set; }
    public double Volume { get; private set; }

    public Cylinder()
    {
        double radius;
        double height;

        Console.WriteLine("Enter the dimensions of the cylinder:");
        Console.Write("Radius:");
        while (!double.TryParse(Console.ReadLine(),NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out radius) || radius <= 0)
        {
            Console.Write("Radius: ");
        }
        Radius = radius;

        Console.Write("Height: ");
        while (!double.TryParse(Console.ReadLine(),NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out height) || height <= 0)
        {
            Console.Write("Height: ");
        }
        Height = height;

        Process();
        
    }

    public void Process()
    {
        BaseArea = Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        LateralArea = Math.Round(2 * Math.PI * Radius * Height, 2);
        TotalArea = Math.Round(2 * BaseArea + LateralArea, 2);
        Volume = Math.Round(Math.PI * Math.Pow(Radius, 2) * Height, 2);
    }

    public void Result()
    {
        Console.WriteLine("Cylinder Characteristics");
        Console.WriteLine($"Radius: {Radius}, Height: {Height}");
        Console.WriteLine($"Base Area: {BaseArea} : Lateral Area: {LateralArea} : Total Area: {TotalArea} : Volume: {Volume}");
    }
}