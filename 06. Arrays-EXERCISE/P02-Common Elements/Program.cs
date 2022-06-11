using System;
using System.Linq;

namespace P02_Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] arr2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.Write($"{arr2[j]} ");
                    }
                }
                
            }
            Console.WriteLine();
            
            //foreach (string element in arr2)
            //{
            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        string elementsOne = arr1[i];
            //        if (arr2 == arr1)
            //        { 
            //            Console.WriteLine(arr2 + " ");
            //            break;
            //        }
            //    }
            //}
        }
    }
}
