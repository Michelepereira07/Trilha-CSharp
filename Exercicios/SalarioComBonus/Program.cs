using System.Globalization;

string name = Console.ReadLine();
//converter
double salario = double.Parse(Console.ReadLine(),CultureInfo.CreateSpecificCulture("en-US"));
double totalVendas = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("en-US"));


double salarioLiquido = salario + (totalVendas * 0.15);

Console.WriteLine("TOTAL = R$ " + salarioLiquido.ToString("F2", CultureInfo.CreateSpecificCulture("EN-us")));
Console.ReadLine();







