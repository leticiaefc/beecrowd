using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] pontos = Console.ReadLine().Split(' ');
        double A = double.Parse(pontos[0], CultureInfo.InvariantCulture);
        double B = double.Parse(pontos[1], CultureInfo.InvariantCulture);
        double C = double.Parse(pontos[2], CultureInfo.InvariantCulture);

        if (A + B > C && A + C > B && B + C > A)
        {
            double Perimetro = A + B + C;
            Console.WriteLine($"Perimetro = " + Perimetro.ToString("F1", CultureInfo.InvariantCulture));
        }
        else
        {
            double area = ((A + B) * C) / 2;
            Console.WriteLine($"Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
        }
    }

}