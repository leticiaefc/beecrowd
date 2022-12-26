using System;

class URI
{

    static void Main(string[] args)
    {

        for (int I = 1, J = 7; I <= 9; J--)
        {
            Console.WriteLine($"I={I} J={J}");
            if (J - I == 4)
            {
                I += 2;
                J += 5;
            }
        }

    }

}