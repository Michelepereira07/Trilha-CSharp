using System.Globalization;

string[] Area = Console.ReadLine().Split(' ');

double A = double.Parse(Area[0], CultureInfo.InvariantCulture);
double B = double.Parse(Area[1], CultureInfo.InvariantCulture);
double C = double.Parse(Area[2], CultureInfo.InvariantCulture);

Console.WriteLine($"TRIANGULO: {(A * C / 2).ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"CIRCULO: {(A * C / 2).ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"TRAPEZIO: {(A * C / 2).ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"QUADRADO: {(A * C / 2).ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"RETANGULO: {(A * C / 2).ToString("F3", CultureInfo.InvariantCulture)}");

Console.ReadKey();
