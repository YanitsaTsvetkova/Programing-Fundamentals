﻿using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballCount = int.Parse(Console.ReadLine());

            int bestSnowballSnow = 0;
            int bestSnowbalTime= 0;
            int bestSnowballQuality = 0;
            BigInteger bestSnowballValue = BigInteger.Zero;

            for (int i = 0; i < snowballCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int snowBallDivide = snowballSnow / snowballTime;

                BigInteger snowballValue = BigInteger.Pow(snowBallDivide, snowballQuality);

                if (snowballValue >= bestSnowballValue)
                {
                    bestSnowballSnow = snowballSnow;
                    bestSnowbalTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                    bestSnowballValue = snowballValue;
                }

            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowbalTime} = {bestSnowballValue} ({bestSnowballQuality})");
        }
    }
}
