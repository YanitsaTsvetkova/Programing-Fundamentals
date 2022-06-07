using System;

namespace _2._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            do
            {
                sum += (num % 10);
                num /= 10;
                    
            } while (num > 0);

            Console.WriteLine(sum); 
        }
    }
}
