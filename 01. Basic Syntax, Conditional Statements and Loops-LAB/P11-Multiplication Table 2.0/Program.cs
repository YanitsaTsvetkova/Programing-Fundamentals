using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());

            if (time > 10)
            {
                Console.WriteLine($"{number} X {time} = {number * time}");
            }
            else
            {
                for (int i = time; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }


           
        }
    }
}
