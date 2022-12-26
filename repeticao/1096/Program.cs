using System;

class URI
{

    static void Main(string[] args)
    {

        for (int I = 1, J = 7; J >= 5 && I <= 9; J--)
        {
            Console.WriteLine($"I={I} J={J}");

            if (J == 5)
            {
                I += 2;
                J += 3;
            }
        }

    }

}