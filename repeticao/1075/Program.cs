using System;

class URI
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int i = 0;
        do
        {
            if (i % n == 2)
            {
                Console.WriteLine(i);
            }
            i++;
        } while (i >= 1 && i < 10000);

    }

}