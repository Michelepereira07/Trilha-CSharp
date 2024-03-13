using System.Drawing;
using System.Globalization;

int funcionario= 1;
int horas= 200;
double salario = 20.50;

var resultado = horas * salario;

var teste = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "US$ {0:####.##}", resultado);

Console.WriteLine($"NUMBER = {funcionario}");
Console.WriteLine($"SALARY = {resultado}");
Console.WriteLine(teste);
