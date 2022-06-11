using System;
using System.Linq;

namespace P07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = Console.ReadLine()
            //               .Split()
            //               .Select(int.Parse)
            //               .ToArray();
            //int counter = 0;
            //int winningCounter = 0;
            //int index = 0;
            //string number = string.Empty;

            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    if (numbers[i] == numbers[i + 1])
            //    {
            //        counter++;
            //        if (counter > winningCounter)
            //        {
            //            winningCounter = counter;
            //            index = i;
            //            number = numbers[i].ToString();
            //        }
            //    }
            //    else
            //    {
            //        counter = 0;
            //    }
            //}
            //for (int i = 0; i <= winningCounter; i++)
            //{
            //    Console.Write(number + " ");
            //}


            int[] numbers = Console.ReadLine()
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

            int maxCount = 0;
            int digit = 0;
            int counter = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    counter++;

                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        digit = numbers[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{digit} ");
            }
        }


    }
    
}

