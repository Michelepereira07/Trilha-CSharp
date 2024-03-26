using System.Globalization;

int tempo = int.Parse(Console.ReadLine());

int velocidade = int.Parse(Console.ReadLine());

double distancia = (tempo * velocidade);
double quantidadeDeCombustivel = (distancia / 12);

Console.WriteLine(quantidadeDeCombustivel.ToString("F3", CultureInfo.InvariantCulture));

Console.ReadLine();






