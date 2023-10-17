using System.Threading.Channels;

namespace KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSequence = int.Parse(Console.ReadLine());

            int longestSunsequence = -1;
            int[] bestDNA = new int[lengthOfSequence];
            int longestIndex = -1;
            int biggestSum = -1;

            int row = 0;
            int bestRow = 0;
            
            string command = Console.ReadLine();
            while (command != "Clone them!")
            {
                int[] currentDNA = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int counter = 0;
                int subsequence = -1;
                int index = -1;
                int sum = 0;

                row++;
                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i]==1)
                    {
                        counter++;
                        sum++;
                        if (counter>subsequence)
                        {
                            subsequence = counter;
                            index = i;
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }

                if (subsequence > longestSunsequence)
                {
                    longestSunsequence = subsequence;
                    bestDNA = currentDNA;
                    longestIndex = index;
                    biggestSum = sum;
                    bestRow = row;
                }
                else if (subsequence == longestSunsequence && index < longestIndex)
                {
                    longestSunsequence = subsequence;
                    bestDNA = currentDNA;
                    longestIndex = index;
                    biggestSum = sum;
                    bestRow = row;
                }
                else if (subsequence == longestSunsequence && index == longestIndex && biggestSum < sum)
                {
                    longestSunsequence = subsequence;
                    bestDNA = currentDNA;
                    longestIndex = index;
                    biggestSum = sum;
                    bestRow = row;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestRow} with sum: {biggestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}