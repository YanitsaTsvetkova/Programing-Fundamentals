using System;

namespace _6.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            long factorielSum = 0;

            for (int i = 0; i <= number.Length - 1; i++)
            {
               // digit as an ASCCI character
                char currCh = number[i];
                int currDigit = (int)currCh - 48;

                long currDigitFactorial = 1; 

                for (int r = currDigit; r > 1; r--)
                {
                    currDigitFactorial *= r;
                }

                factorielSum += currDigitFactorial;
            }

            if (factorielSum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

            //var n = int.Parse(Console.ReadLine());
            //var nCopy = n;
            //int sum = 0;

            //while (n > 0)
            //{
            //    var factoriel = 1;
            //    var number = n % 10;
            //    n /= 10;

            //    for (int i = 2; i <= number; i++)
            //    {
            //        factoriel *= i;
            //    }

            //    sum += factoriel;
            //}
            //if (sum == nCopy)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");












            }
    }
}
