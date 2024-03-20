internal class Program
{
    private static void Main(string[] args)
    {
        string[] Maior = Console.ReadLine().Split(' ');

        int a = int.Parse(Maior[0]);
        int b = int.Parse(Maior[1]);
        int c = int.Parse(Maior[2]);

        int MaiorAB = (a + b + Math.Abs(a - b)) / 2;
        int Omaior = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;

        Console.WriteLine($"{Omaior} + eh o maior ");
        Console.ReadKey();
    }
}