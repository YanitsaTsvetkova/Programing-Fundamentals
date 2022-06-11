using System;

namespace P03_Arrays_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int dayNumber = int.Parse(Console.ReadLine());

            string[] daysOfTehWeek = new string[]
            {
                "Monday", // 0
                "Tuesday", // 1
                "Wednesday", //2
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (dayNumber >= 1 && dayNumber <= daysOfTehWeek.Length)
            {
                Console.WriteLine(daysOfTehWeek[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
