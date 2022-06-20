using System;
using System.Linq;

namespace 9._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = string.Empty;

            //int length = int.Parse(Console.ReadLine());
            //int[] lss = new int[length];

            //int lssLength = int.MinValue, lssIndex = int.MinValue, lssSum = int.MinValue, lssStart = -1;
            //int index = 1;

            //while ((input = Console.ReadLine()) != "Clone them!")
            //{
            //    int[] data = input
            //        .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
            //        .Select(int.Parse)
            //        .ToArray();

            //}

            int sequenceLenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] DNA = new int[sequenceLenght];

            int dnaSum = 0;

            int dnaCount = -1; 

            int dnaStartIndex = -1; 

            int dnaSamples = -1; 

            int sample = 0;

            while (input != "Clone them!")
            {
                // currend DNA info
                sample++; 

                int[] currentDna = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                 
                int currentCount = 0;

                int currentStartIndex = 0;

                int currentEndIndex = 0;

                int currentDnaSum = 0;

                bool isCurrDnaBetter = false;

                int count = 0; 

                for (int i = 0; i < currentDna.Length; i++)
                {
                    if (currentDna[i] != 1)
                    {
                        count = 0;
                        continue;
                    }
                    count++;

                    if (count > currentCount)
                    {
                        currentCount = count;
                        currentEndIndex = i;
                    }

                }
                // 0 1 1 10 1 => 1 1 (endIndex = 2) => (startIndex 2 - 2 = 0 + 1 = 1)
                currentStartIndex = currentEndIndex - currentCount + 1;
                // 0 1 1 0 1 .Sum () = 3
                currentDnaSum = currentDna.Sum();

                // chek current DNA with Best DNA

                if (currentCount > dnaCount)
                {
                    isCurrDnaBetter = true;
                }
                else if (currentCount == dnaCount)
                {
                    if (currentStartIndex < dnaStartIndex)
                    {
                        isCurrDnaBetter = true;
                    }
                    else if (currentStartIndex == dnaStartIndex)
                    {
                        if (currentDnaSum > dnaSum)
                        {
                            isCurrDnaBetter = true;
                        }
                    }

                }
                if (isCurrDnaBetter)
                {
                    DNA = currentDna;
                    dnaCount = currentCount;
                    dnaStartIndex = currentStartIndex;
                    dnaSum = currentDnaSum;
                    dnaSamples = sample;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {dnaSamples} with sum: {dnaSum}.");
            Console.WriteLine(string.Join(" ", DNA));
        }
    }
}
