using System;

class URI
{

    static void Main(string[] args)
    {

        int x;
        int i;
        x = int.Parse(Console.ReadLine());

        i = 1;
        while (i <= x)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }

    }
}