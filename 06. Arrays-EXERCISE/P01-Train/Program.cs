using System;
using System.Linq;

namespace E01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfwagons = int.Parse(Console.ReadLine());

            int[] numOfPeople = new int [numOfwagons]; // n na broi elementi, dulvina na masiwa e kolkoto podadenoto ot konzolata

            int sumOfPeople = 0; 

            for (int i = 0; i < numOfPeople.Length; i++)
            {
                int people = int.Parse(Console.ReadLine());

                numOfPeople[i] = people; // pylnim indeksite ot podadenoto ot konzolata, i e tekushtiq indekx

                sumOfPeople += people;
            }

            Console.WriteLine(string.Join(' ', numOfPeople)); // tova moje i s foreach

            //foreach (int num in numOfPeople)
            //{
            //    Console.Write(numOfPeople + " ");
            //}

            Console.WriteLine(sumOfPeople);
           
        }
    }
}
