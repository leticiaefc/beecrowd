using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double nota1, nota2, t;

        do
        {
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (nota1 < 0.0f || nota1 > 10.0f)
            {
                Console.WriteLine("nota invalida");
            }

        } while (nota1 < 0.0f || nota1 > 10.0f);

        do
        {
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (nota2 < 0.0f || nota2 > 10.0f)
            {
                Console.WriteLine("nota invalida");
            }

        } while (nota2 < 0.0f || nota2 > 10.0f);


        double media = (nota1 + nota2) / 2;

        Console.WriteLine($"media = " + media, CultureInfo.InvariantCulture);

    }

}