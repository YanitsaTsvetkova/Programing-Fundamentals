using System;

namespace _4.Print_a_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int iterator = firstNum; iterator <= secondNum; iterator++)
            {
                Console.Write($"{iterator} ");
                sum += iterator;
            }
           
            Console.WriteLine();

            Console.Write($"Sum: {sum}");
        }
    }
}
