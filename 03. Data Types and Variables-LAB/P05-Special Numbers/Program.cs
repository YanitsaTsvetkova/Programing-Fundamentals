using System;

namespace _5._Special_Numbers
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int numToProcess = i;
                int sum = 0;

                while (numToProcess != 0)
                {
                    int currDigit = numToProcess % 10;
                    numToProcess /=  10;
                    sum += currDigit;
                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11 ;
                                
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
