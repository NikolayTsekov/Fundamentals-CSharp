using System.Numerics;

namespace ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> copiedNumbers = new List<int> (numbers);
            List<int> evenNumbers = new List<int> ();
            List<int> oddNumbers = new List<int> ();
            string input = Console.ReadLine();
            while (input  != "end")
            {
                List<string> commands = input
                    .Split()
                    .ToList();
                string command = commands[0];
                List<int> filteredNumbers = new List<int> ();
                if (command == "Add")
                {
                    int numberToAdd = int.Parse(commands[1]);
                    copiedNumbers.Add (numberToAdd);
                }
                else if (command == "Remove")
                {
                    int numberToRemove = int.Parse(commands[1]);
                    copiedNumbers.Remove(numberToRemove);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(commands[1]);
                    copiedNumbers.RemoveAt (index);

                }
                else if (command == "Insert")
                {
                    int numberToInsert = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    copiedNumbers.Insert (index, numberToInsert);
                }
                else if (command == "Contains")
                {
                    int containedNumber = int.Parse(commands[1]);
                    if (numbers.Contains(containedNumber))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    PrintingEvenNumbers(numbers, evenNumbers);
                }
                else if(command == "PrintOdd")
                {
                    PrintingOddNumbers(numbers, oddNumbers);
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command == "Filter")
                {
                    FilterCommand(numbers, commands, filteredNumbers);
                }
                input = Console.ReadLine();

            }
            CheckingForChanges(numbers, copiedNumbers);
        }
        static void CheckingForChanges(List<int> numbers, List<int> copiedNumbers)
        {
            if (numbers.Count == copiedNumbers.Count)
            {
                bool areEqual = false;
                for (int i = 0; i < numbers.Count; i++) 
                {
                    for (int j = 0; j < copiedNumbers.Count; j++)
                    {
                        if (numbers[i] == copiedNumbers[j])
                        {
                            areEqual = true;
                        }
                        else
                        {
                            areEqual = false;
                        }
                    }
                }
                if (!areEqual)
                {
                    Console.WriteLine(string.Join(" ", copiedNumbers));
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ", copiedNumbers));

            }
        }
        static void FilterCommand(List<int> numbers, List<string> commands, List<int> filteredNumbers)
        {
            string condition = commands[1];
            int filterNumber = int.Parse(commands[2]);
            if (condition == "<")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < filterNumber)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", filteredNumbers));
            }
            else if (condition == ">")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > filterNumber)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", filteredNumbers));
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= filterNumber)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", filteredNumbers));
            }
            else if (condition == "<=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= filterNumber)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", filteredNumbers));
            }
        }
         static void PrintingOddNumbers(List<int> numbers, List<int> oddNumbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNumbers.Add(numbers[i]);
                }

            }
            Console.WriteLine(string.Join(" ", oddNumbers));
        }

        static void PrintingEvenNumbers(List<int> numbers, List<int> evenNumbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", evenNumbers));
        }
    }
}