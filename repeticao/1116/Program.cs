using System;

class URI
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] num = Console.ReadLine().Split(' ');
            int x = int.Parse(num[0]);
            int y = int.Parse(num[1]);
            if (y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else if (x == 0)
            {
                Console.WriteLine("0.0");
            }
            else
            {
                double divisao = (double)x / y;
                Console.WriteLine($"{divisao:F1}");
            }
        }

    }

}