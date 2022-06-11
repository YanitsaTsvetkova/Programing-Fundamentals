using System;

namespace P02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumber = int.Parse(Console.ReadLine());

            int[] items = new int[numberOfNumber];

            for (int i = 0; i < numberOfNumber; i++)
            {
                items[i] = int.Parse(Console.ReadLine());
            }

            for (int i = items.Length - 1; i >= 0; i--)
            {
                Console.Write($"{items[i]} ");
            }
           // Console.WriteLine(String.Join(" ", items)); //optional

            Console.WriteLine();
        }
    }
}
