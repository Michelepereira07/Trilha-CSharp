int raio;
double pi;
double volume;

pi = 3.14159;
raio = int.Parse(Console.ReadLine());

volume = (4 / 3.0) * pi * Math.Pow(raio, 3);

Console.WriteLine("VOLUME = " + volume);


