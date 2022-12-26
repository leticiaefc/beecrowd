using System;

class URI
{

    static void Main(string[] args)
    {

        int I = 1;
        int J = 60;
        do
        {
            Console.WriteLine($"I={I} J={J}");
            I += 3;
            J -= 5;

        } while (J >= 0);

    }

}