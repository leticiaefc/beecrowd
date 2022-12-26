using System;

class URI
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int x;
        int i;
        for (i = 1; i <= n; i++)
        {
            x = int.Parse(Console.ReadLine());

            if (x == 0)
            { Console.WriteLine("NULL"); }
            else
            {
                if (x % 2 == 0)
                {
                    Console.Write("EVEN ");
                }
                else
                {
                    Console.Write("ODD ");
                }
                if (x > 0)

                {
                    Console.WriteLine("POSITIVE");
                }
                else
                {
                    Console.WriteLine("NEGATIVE");
                }
            }

        }

    }

}