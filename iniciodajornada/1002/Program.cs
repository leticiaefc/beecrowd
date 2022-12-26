using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double A, R;
        R = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        A = (3.14159 * R * R);
        Console.WriteLine($"A={A.ToString("F4", CultureInfo.InvariantCulture)}");
        Console.ReadKey();

    }

}