using System;
using System.Linq;

namespace P06_Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                int rightSum = 0;

                for (int k = array.Length - 1; k > i; k--)
                {
                    rightSum += array[k];
                }

                if (leftSum == rightSum && !isFound)
                {
                    isFound = true;
                    Console.WriteLine(i);
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }


        }
    }
}
