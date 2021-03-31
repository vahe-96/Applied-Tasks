using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double pertax = 23;
            int salary = 450000;

            Console.WriteLine($"Programmer who earns {salary} dram salary, " +
                                    $"must pay {TaxPaymant(salary, pertax)} tax");
        }

        static double TaxPaymant(int x, double p)
        {
            return x * p / 100;
        }
    }
}
