using System.Drawing;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int id, horas;
        double valorHora, salario;

        //converter string para inteiro
        id = int.Parse(Console.ReadLine());
        horas = int.Parse(Console.ReadLine());
        valorHora = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("en-US"));

        salario = horas * valorHora;

        Console.WriteLine("NUMBER = " + id);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.CreateSpecificCulture("en-US")));
        Console.Read();
    }
}