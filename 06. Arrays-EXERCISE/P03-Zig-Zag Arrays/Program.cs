using System;
using System.Linq;

namespace P03_Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // zig zag fill element
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] currentRawData = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstNumber = currentRawData[0];
                int secondNumber = currentRawData[1];

                if (i % 2 != 0)
                {
                    arr1[i - 1] = firstNumber;
                    arr2[i - 1] = secondNumber;
                }
                else
                {
                    arr1[i - 1] = secondNumber;
                    arr2[i - 1] = firstNumber;
                }
            }

            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));

            //int number = int.Parse(Console.ReadLine());

            //int[] firstArray = new int[number];
            //int[] secondArray = new int[number];

            //for (int index = 0; index < number; index++)
            //{
            //    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray(); 

            //    if (index % 2 == 0)
            //    {
            //        firstArray[index] = input[0];
            //        secondArray[index] = input[1];
            //    }
            //    else
            //    {
            //        secondArray[index] = input[0];
            //        firstArray[index] = input[1];
            //    }
            //}

            //Console.WriteLine(string.Join(" ", firstArray));
            //Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
