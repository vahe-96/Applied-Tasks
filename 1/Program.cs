using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dram = 0;

            Console.WriteLine("Enter amount of money in Dollars");
            while (dram == 0)
            {
                if (Decimal.TryParse(Console.ReadLine(), out decimal dollar) && dollar > 0)
                {
                    Console.WriteLine("Enter daily exchange rate");
                    while (dram == 0)
                    {
                        if (Decimal.TryParse(Console.ReadLine(), out decimal rate) && rate > 0)
                        {
                            dram = dollar * rate;
                            Console.WriteLine($"Amount of money in dram is {dram} dram ");
                        }
                        else
                        {
                            Console.WriteLine("Entered expression is wrong for exchange rate please enter again");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Entered expression is wrong for dollar please enter again");
                }
            }
        }
    }
}
