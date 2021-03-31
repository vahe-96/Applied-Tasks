using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double distance = 144;
            double v = 15.5;

            Console.WriteLine($"Bicycle will race from Yerevan to Gyumri with 15.5 km/h average speed in" +
                                    $"{distance / v} hours");
        }
    }
}
