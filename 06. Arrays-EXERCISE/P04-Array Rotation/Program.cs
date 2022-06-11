using System;
using System.Linq;

namespace P04_Arrays_Rortation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //работене с два масива едновременно
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rotationsCount = int.Parse(Console.ReadLine());
            int rotationsCountReduced = rotationsCount % arr.Length; // za da ne se bawi programata

            for (int rot = 0; rot < rotationsCount; rot++)
            {
                int first = arr[0]; // temorary int

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = first;
            }

            Console.WriteLine(String.Join(" ", arr));

        }
    }
}
