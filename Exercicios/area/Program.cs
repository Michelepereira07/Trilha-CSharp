using System;

class URI
{

    static void Main(string[] args)
    {
        string values = Console.ReadLine();
        string[] splitted = values.Split(' ');

        double A = double.Parse(splitted[0]);
        double B = double.Parse(splitted[1]);
        double C = double.Parse(splitted[2]);

        double triangle = (A * C) / 2;
        double circle = 3.14159 * Math.Pow(C, 2);
        double trapezium = ((A + B) * C) / 2;
        double square = B * B;
        double rectangle = A * B;

        Console.WriteLine("TRIANGULO: " + triangle.ToString("0.000"));
        Console.WriteLine("CIRCULO: " + circle.ToString("0.000"));
        Console.WriteLine("TRAPEZIO: " + trapezium.ToString("0.000"));
        Console.WriteLine("QUADRADO: " + square.ToString("0.000"));
        Console.WriteLine("RETANGULO: " + rectangle.ToString("0.000"));
    }

}