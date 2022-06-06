using System;

namespace _2.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int devider = -1;

            if (num % 10 == 0)
            {
                devider = 10;
            }
            else if (num % 7 == 0)
            {
                devider = 7;
            }
            else if (num % 6 == 0)
            {
                devider = 6;
            }
            else if (num % 3 == 0)
            {
                devider = 3;
            }
            else if (num % 2 == 0)
            {
                devider = 2;
            }

            if (devider == -1)
            {
                Console.WriteLine($"Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {devider}");
            }
        }
    }
}
