using System;
using System.Linq;

namespace P05_Top_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] topIntegers = new int[arr.Length];
            int topIntegerIndex = 0;

            for (int i = 0; i < arr.Length; i++) // minavame po cqlata dulvina na masiva
            {
                int currentNum = arr[i];

                bool isTopInteger = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int nextNum = arr[j];

                    if (nextNum >= currentNum)
                    {
                        isTopInteger = false;
                        break;
                    }

                }
                if (isTopInteger)
                {
                    topIntegers[topIntegerIndex] = currentNum;
                    topIntegerIndex++;

                    //topIntegers[topIntegerIndex++] = currentNum;
                }

            }
            for (int i = 0; i < topIntegerIndex; i++)
            {
                Console.Write($"{topIntegers[i]} ");
            }


            //int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    bool isBigger = true;
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] <= array[j])
            //        {
            //            isBigger = false;
            //            break;
            //        }
            //    }
            //    if (isBigger)
            //    {
            //        Console.Write($"{array[i]} ");
            //    }
        }

    }
}
