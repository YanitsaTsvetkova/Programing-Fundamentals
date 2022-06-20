using System;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugField = new int[fieldSize];

            string[] occupiedIndexes = Console.ReadLine().Split(); 

            for (int i = 0; i < occupiedIndexes.Length; i++)
            {
                int currentIndex = int.Parse(occupiedIndexes[i]);

                if (currentIndex >= 0 && currentIndex < fieldSize)
                {
                    ladyBugField[currentIndex] = 1; 
                }
            }

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                int currentIndex = int.Parse(commands[0]); 

                bool isFirst = true; // dali bubolechkata e purva

                while (currentIndex >= 0 && currentIndex < fieldSize && ladyBugField[currentIndex] != 0) 
                {
                    if (isFirst)
                    {
                        ladyBugField[currentIndex] = 0;
                        isFirst = false; // vehe ne e purva
                    }

                    string direction = commands[1];
                    int flightLenght = int.Parse(commands[2]);

                    if (direction == "left")
                    {
                        currentIndex -= flightLenght;

                        if (currentIndex >= 0 && currentIndex < fieldSize)
                        {
                            if (ladyBugField[currentIndex] == 0) // dali mqstoto e 0, t.e e prazno
                            {
                                ladyBugField[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        currentIndex += flightLenght;

                        if (currentIndex >= 0 && currentIndex < fieldSize)
                        {
                            if (ladyBugField[currentIndex] == 0)
                            {
                                ladyBugField[currentIndex] = 1;
                                break;
                            }

                        }
                    }
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", ladyBugField));
        }
    }
}
