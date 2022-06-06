using System;

namespace _02._Convert Meters To Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            decimal kilometers = (decimal)(meters / 1000.0f);

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
