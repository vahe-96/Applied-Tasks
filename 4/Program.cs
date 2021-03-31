using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double size = 4.23;
            double speed = 12.5;
            TimeofDownloading(size, speed);
        }
        static void TimeofDownloading(double size, double speed)
        {
            double time = (size * 1024 * 8 / speed) / 60;
            Console.WriteLine($"With {speed} Mbit/s speed of network {size} GB file can be " +
                                            $"downloaded in {time} minutes");
        }
    }
}
