using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double pixels = 16;
            double unit = 32;

            SizeofPhoto(pixels, unit);

        }
        static void SizeofPhoto(double pixels, double unit)
        {
            double size = pixels * unit / 8;
            Console.WriteLine($"Photo containing {pixels} MP has {size} MB size (1 pixel need {unit} bit memory)");
        }
    }
}
