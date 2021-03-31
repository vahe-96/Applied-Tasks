using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int temp;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i}");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[n - 1 - i];
                arr[n - 1 - i] = temp;
            }

            Console.WriteLine("Here is inveresed Array");
            foreach (int i in arr)
            {
                Console.Write($"{i}\t");
            }
        }
    }
}
