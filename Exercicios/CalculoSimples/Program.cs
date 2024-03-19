using System.Globalization;

int  codigo1, peca1;
int  codigo2, peca2;
double valor1, valor2, valor;

codigo1 = int.Parse(Console.ReadLine());
peca1 = int.Parse(Console.ReadLine());
valor1 = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("pt-BR"));
codigo2 = int.Parse(Console.ReadLine());
peca2 = int.Parse(Console.ReadLine());
valor2 = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("pt-BR"));


valor = peca1 * valor1 + peca2 * valor2;

Console.WriteLine("VALOR A PAGAR: R$ " + valor.ToString("F2", CultureInfo.CreateSpecificCulture("pt-BR")));
Console.ReadLine();