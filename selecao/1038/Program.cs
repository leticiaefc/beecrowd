using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] pedido = Console.ReadLine().Split(' ');

        int code = int.Parse(pedido[0]);
        int quantidade = int.Parse(pedido[1]);

        double total;


        if (code == 1)
        {
            total = quantidade * 4.00;
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
        else if (code == 2)
        {
            total = quantidade * 4.50;
            Console.WriteLine($"Total: R$ {total:F2}");
        }
        else if (code == 3)
        {
            total = quantidade * 5.00;
            Console.WriteLine($"Total: R$ {total:0.00}");
        }
        else if (code == 4)
        {
            total = quantidade * 2.00;
            Console.WriteLine($"Total: R$ {total:F2}");
        }
        else if (code == 5)
        {
            total = quantidade * 1.50;
            Console.WriteLine($"Total: R$ {total:F2}");
        }
    }

}