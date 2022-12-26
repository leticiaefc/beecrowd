using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] n = Console.ReadLine().Split(' ');
        double num1 = double.Parse(n[0], CultureInfo.InvariantCulture);
        double num2 = double.Parse(n[1], CultureInfo.InvariantCulture);
        double num3 = double.Parse(n[2], CultureInfo.InvariantCulture);

        double delta = (num2 * num2) - (4 * num1 * num3);
        double raiz1 = (-num2 + Math.Sqrt(delta)) / (2 * num1);
        double raiz2 = (-num2 - Math.Sqrt(delta)) / (2 * num1);

        if (num1 != 0 && delta > 0)
        {
            Console.WriteLine("R1 = " + raiz1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + raiz2.ToString("F5", CultureInfo.InvariantCulture));
            Console.Read();
        }
        else
        {
            Console.WriteLine("Impossivel calcular");
            Console.Read();
        }

    }

}