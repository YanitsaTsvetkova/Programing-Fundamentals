using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num;

            //do
            //{
            //    num = int.Parse(Console.ReadLine());

            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine($"The number is: {Math.Abs(num)}");
            //        break;
            //    }
            //    Console.WriteLine("Please write an even number.");

            //} while (num % 2 != 0);


        
            int num = int.Parse(Console.ReadLine());

            while (num % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");

                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    break;
                }
            }
            Console.WriteLine($"The number is: {Math.Abs(num)}");

        }
    }
}
