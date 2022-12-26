using System;

class URI
{

    static void Main(string[] args)
    {

        string[] valores = Console.ReadLine().Split(' ');
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);

        double area = (A * C) / 2;
        double Pi = 3.14159;
        double arearaio = C * C * Pi;
        double areatrapezio = (A + B) * C / 2;
        double areaquadrado = B * B;
        double arearetangulo = A * B;

        Console.WriteLine($"TRIANGULO: {area:F3}");
        Console.WriteLine($"CIRCULO: {arearaio:F3}");
        Console.WriteLine($"TRAPEZIO: {areatrapezio:F3}");
        Console.WriteLine($"QUADRADO: {areaquadrado:F3}");
        Console.WriteLine($"RETANGULO: {arearetangulo:F3}");
    }

}