using System;

namespace _7
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
                    if (age < 16)
                    {
                        Console.WriteLine("Sorry but people under the age can't work!");
                    }
                    else if (age >= 18)
                    {
                        Console.WriteLine("you can be full worker!");
                    }

                    else
                    {
                        Console.WriteLine("You can work,but with limitations!");
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
