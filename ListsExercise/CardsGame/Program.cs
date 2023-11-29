using System.Collections.Generic;
using System.Numerics;

namespace CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondLine = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                if (firstLine[0] > secondLine[0])
                {
                    firstLine.Add(firstLine[0]);
                    firstLine.Add(secondLine[0]);
                }
                else if (firstLine[0] < secondLine[0])
                {
                    secondLine.Add(secondLine[0]);
                    secondLine.Add(firstLine[0]);
                }
                firstLine.Remove(firstLine[0]);
                secondLine.Remove(secondLine[0]);

                if (firstLine.Count==0)
                {
                    int sum = secondLine.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (secondLine.Count==0)
                {
                    int sum = firstLine.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }

        }
    }
}