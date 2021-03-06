using System;
using System.Linq;

namespace P08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();


            for (int i = 0; i < array.Length - 1; i++)
            {
                int[] condensed = new int[array.Length - 1]; // -1 zashtoto namalqvam pri wsqka operaciq

                for (int j = 0; j < condensed.Length; j++)
                {
                    condensed[j] = array[j] + array[j + 1];
                }

                array = condensed;
            }

            Console.WriteLine(array[0]);
        }
    }
}

