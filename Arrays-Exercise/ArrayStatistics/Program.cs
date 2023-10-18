using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStatistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            int sum = 0;
            double average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                if (currentNumber > maxNumber)
                {
                   maxNumber = currentNumber;
                }
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
                sum += currentNumber;
                average = ((double) sum / array.Length);
            }

            Console.WriteLine($"Min = {minNumber}");
            Console.WriteLine($"Max = {maxNumber}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");

        }
    }
}