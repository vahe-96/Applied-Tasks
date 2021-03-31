using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature of room in °C");

            int s = 0;

            while (s == 0)
            {
                if (Double.TryParse(Console.ReadLine(), out double tmp))
                {
                    if (tmp <= 18)
                    {
                        Console.WriteLine("It's a cold weather");
                    }
                    else if (tmp >= 24)
                    {
                        Console.WriteLine("It's a hot weather");
                    }
                    else
                    {
                        Console.WriteLine("It's a nice weather");
                    }

                    s = 1;
                }

                else
                {
                    Console.WriteLine("Entered expression is wrong for temperature, Please enter again!");
                }
            }

        }
    }
}
