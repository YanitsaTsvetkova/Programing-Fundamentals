using System;

namespace _3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0;
            double price = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }

            totalPrice = countOfPeople * price;

            if (type == "Students" && countOfPeople >= 30)
            {
                totalPrice *= 0.85;
            }
            else if (type == "Business" && countOfPeople >= 100)
            {
                if (day == "Friday")
                {
                    totalPrice -= 10 * 10.90;
                }
                else if (day == "Saturday")
                {
                    totalPrice -= 10 * 15.60;
                }
                else if (day == "Sunday")
                {
                    totalPrice -= 10 * 16;
                }
            }
            else if (type == "Regilar" && countOfPeople >= 10 && countOfPeople >= 20)
            {
                totalPrice *= 0.95;
            }
            

            Console.WriteLine($"Total price: {(decimal)totalPrice:f2}");
        }
    }
}
