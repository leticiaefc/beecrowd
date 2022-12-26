using System;

class URI
{

    static void Main(string[] args)
    {

        int x;
        int impar = 0;

        x = int.Parse(Console.ReadLine());
        while (impar < 6)
        {
            if (x % 2 != 0)
            {
                Console.WriteLine(x);
                impar++;
            }
            x++;
        }
    }

}