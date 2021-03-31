using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password includes 8 digits, which are only latin lowercases");

            Random random = new Random();

            for (int i = 0; i < 8; i++)
            {
                Console.Write((char)((int)'a' + random.Next(0, 25)));          //a-ic hashvac minchev z
            }

            Console.WriteLine();
        }
    }
}
