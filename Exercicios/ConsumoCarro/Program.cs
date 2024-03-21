using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        decimal y = Convert.ToDecimal(Console.ReadLine());
        var consumo = x / y;
        
        Console.WriteLine($"{consumo.ToString("F3", CultureInfo.InvariantCulture)} + Lm/L");

        Console.ReadLine();
    }
}