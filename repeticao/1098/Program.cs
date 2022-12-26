using System;

class URI
{

    static void Main(string[] args)
    {

        double i, k;
        int j;

        for (i = 0; i < 2.1; i += 0.2)
        {
            for (j = 1; j <= 3; j++)
            {
                k = i + j;
                if (i == 0 || i > 1.8 || (i > 0.9 && i < 1.1))
                {
                    Console.WriteLine($"I={i} J={k}");
                }
                else
                {
                    Console.WriteLine($"I={i} J={k}");
                }
            }
        }

    }

}