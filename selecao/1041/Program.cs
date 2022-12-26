using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] pontos = Console.ReadLine().Split(' ');
        double x = double.Parse(pontos[0], CultureInfo.InvariantCulture);
        double y = double.Parse(pontos[1], CultureInfo.InvariantCulture);
        double origem = 0.0;

        if (x == 0 && y == 0)
        {
            Console.WriteLine("Origem");
        }
        else if (x != 0 && y == 0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (x == 0 && y != 0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("Q1");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Q2");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Q3");
        }
        else
        {
            Console.WriteLine("Q4");
        }
    }

}