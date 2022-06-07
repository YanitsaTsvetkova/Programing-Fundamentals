using System;

namespace _4._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char cerrCh = char.Parse(Console.ReadLine());
                int currChCode = (int)cerrCh; // izvlichane na chislov kod ot aski tablica, moje i da se propusne, zashtoto programata si go razbira

                sum += currChCode;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
