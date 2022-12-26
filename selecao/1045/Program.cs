using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] valores = Console.ReadLine().Split(' ');
        double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

        double aux;

        if (A < B)
        {
            aux = A;
            A = B;
            B = aux;
        }
        if (A < C)
        {
            aux = A;
            A = C;
            C = aux;
        }
        if (B < C)
        {
            aux = B;
            B = C;
            C = aux;
        }

        if (A >= B + C)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if ((A * A) == (B * B) + (C * C))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if ((A * A) > (B * B) + (C * C))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if ((A * A) < (B * B) + (C * C))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (A == B && A == C && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (A == B || A == C || B == C)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }

    }

}