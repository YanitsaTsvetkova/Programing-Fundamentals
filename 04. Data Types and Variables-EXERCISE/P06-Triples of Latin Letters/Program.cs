﻿using System;

namespace _6._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int letterCount = int.Parse(Console.ReadLine()) + 'a';

            //for (char i = 'a' ; i < letterCount; i++)
            //{
            //    for (char j = 'a'; j < letterCount; j++)
            //    {
            //        for (char k = 'a'; k < letterCount; k++)
            //        {
            //            string letterString = "" + i + j + k;    
            //            Console.WriteLine(letterString);
            //        }
            //    }
            //}

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + k);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }



        }
    }
}
