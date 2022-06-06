using System;

namespace _02._CSharp_Fundamentals_Data_Types_and_Variables_Lab
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
