using System;

class URI
{

    static void Main(string[] args)
    {

        int p = 0;
        double total = 0;
        for (int i = 0; i < 6; i++)
        {
            double valor = double.Parse(Console.ReadLine());
            if (valor > 0)
            {
                p++;
                total += valor;
            }
        }
        double media = total / p;
        Console.WriteLine($"{p} valores positivos\n{media:F1}");
    }

}