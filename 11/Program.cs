using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element {i}");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }

            Console.WriteLine("Sorted array");
            foreach (int i in arr)
            {
                Console.Write($"{i}\t");
            }
        }
    }
}
