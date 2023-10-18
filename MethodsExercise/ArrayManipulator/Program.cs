using System.Diagnostics.Metrics;
using System.Security.Authentication;

namespace ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                switch (arguments[0])
                {
                    case "exchange":
                        int index = int.Parse(arguments[1]);
                        numbers = Exchange(numbers, index);
                        break;
                    case "max":
                        string maxType = arguments[1];
                        PrintMaxNumber(numbers, maxType);
                        break;
                    case "min":
                        string minType = arguments[1];
                        PrintMinNumber(numbers, minType);
                        break;
                    case "first":
                        int firstLength = int.Parse(arguments[1]);
                        string firstType = arguments[2];
                        PrintFirstElement(numbers, firstLength, firstType);
                        break;
                    case "last":
                        int lastLength = int.Parse(arguments[1]);
                        string lastType = arguments[2];
                        PrintLastElement(numbers, lastLength, lastType);
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
        static int[] Exchange(int[] numbers, int index)
        {
            if (CheckForOutOfBound(numbers, index))
            {
                Console.WriteLine("Invalid index");
                return numbers;

            }
            int[] changedArray = new int[numbers.Length];
            int changedArrayIndex = 0;

            for (int i = index + 1; i <= numbers.Length - 1; i++)
            {
                changedArray[changedArrayIndex] = numbers[i];
                changedArrayIndex++;
            }
            for (int i = 0; i <= index; i++)
            {
                changedArray[changedArrayIndex] = numbers[i];
                changedArrayIndex++;
            }

            return changedArray;
        }

        static void PrintMaxNumber(int[] numbers, string type)
        {
            int maxIndex = -1;
            int maxNumber = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsOddOrEven(numbers[i], type))
                {
                    if (numbers[i] >= maxNumber)
                    {
                        maxNumber = numbers[i];
                        maxIndex = i;
                    }
                }
            }
            PrintIndex(maxIndex);
        }

        static void PrintMinNumber(int[] numbers, string type)
        {
            int minIndex = -1;
            int minNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsOddOrEven(numbers[i], type))
                {
                    if (numbers[i] <= minNumber)
                    {
                        minNumber = numbers[i];
                        minIndex = i;
                    }
                }
            }
            PrintIndex(minIndex);
        }
        static void PrintFirstElement(int[] numbers, int count, string type)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string firstElement = "";
            int elementCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsOddOrEven(numbers[i], type))
                {
                    firstElement += $"{numbers[i]}, ";
                    elementCount++;
                    if (elementCount >= count)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{firstElement.Trim(' ', ',')}]");
        }

        static void PrintLastElement(int[] numbers, int count, string type)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string lastElement = "";
            int elementCount = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (IsOddOrEven(numbers[i], type))
                {
                    lastElement += $"{numbers[i]}, " + lastElement;
                    elementCount++;
                    if (elementCount == count)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{lastElement.Trim(' ', ',')}]");
        }
        static bool CheckForOutOfBound(int[] array, int index)
        {
            return index < 0 || index >= array.Length;
        }
        private static void PrintIndex(int maxIndex)
        {
            if (maxIndex != -1)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        private static bool IsOddOrEven(int numbers, string type)
        {
            return (type == "even" && numbers % 2 != 0) 
                ||
                (type == "even" && numbers % 2 == 0);
        }
    }
}