using System;
using System.Linq;

class URI
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        double a, b, c;


        for (int i = 0; i < n; i++)
        {
            String entrada = Console.ReadLine();
            double[] valores = entrada.Split(' ').Select(x => double.Parse(x)).ToArray();
            a = valores[0] * 2;
            b = valores[1] * 3;
            c = valores[2] * 5;
            double media = (a + b + c) / 10;

            Console.WriteLine($"{Math.Round(media, 1):F1}");
        }


    }

}