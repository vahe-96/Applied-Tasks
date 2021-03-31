using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");

            int s = 0;

            while (s == 0)
            {
                if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
                {
                    if (age >= 16)
                    {
                        Console.WriteLine("You can take a driving test!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry but people under the age 16 can't take a driving test!");
                    }

                    s = 1;
                }

                else
                {
                    Console.WriteLine("Entered expression is wrong for age, Please enter again!");
                }
            }

        }
    }
}
