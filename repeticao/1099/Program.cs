using System;

class URI
{

    static void Main(string[] args)
    {

        int a, A;
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);
            int total = 0;
            if (x < y)
            {
                a = x;
                A = y;
            }
            else
            {
                a = y;
                A = x;
            }
            for (int j = a + 1; j < A; j++)
            {
                if (j % 2 != 0)
                    total += j;
            }
            Console.WriteLine(total);
        }

    }

}