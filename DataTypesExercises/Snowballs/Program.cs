using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger highestsnowballValue = 0;
            int bestsnowballSnow = 0;
            int bestsnowballTime = 0;
            int bestsnowballQuality = 0;
            
            for (int i = 1; i <= numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > highestsnowballValue)
                {
                    highestsnowballValue = snowballValue;
                    bestsnowballTime = snowballTime;
                    bestsnowballQuality = snowballQuality;
                    bestsnowballSnow = snowballSnow;
                }
            }

            Console.WriteLine($"{bestsnowballSnow} : {bestsnowballTime} = {highestsnowballValue} ({bestsnowballQuality})");
        }
    }
}