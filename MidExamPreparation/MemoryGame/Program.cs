namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> symbols = Console.ReadLine()
                .Split()
                .ToList();

            string input = default;
            int moves = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                int[] indexes = input.Split()
                    .Select(int.Parse)
                    .ToArray();
                int firstIndex = indexes[0];
                int secondIndex = indexes[1];
                moves++;
                if (firstIndex == secondIndex || (firstIndex<0 || firstIndex >= symbols.Count) || (secondIndex < 0 || secondIndex >= symbols.Count))
                {
                    string newSymbol = $"-{moves}a";
                    List<string> newElements = new List<string>(){newSymbol, newSymbol};
                    int middleIndex = symbols.Count / 2;
                    symbols.InsertRange(middleIndex, newElements);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (symbols[firstIndex] == symbols[secondIndex])
                    {
                        string element = symbols[firstIndex];
                        Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                        if (firstIndex < secondIndex)
                        {
                            symbols.RemoveAt(firstIndex);
                            symbols.RemoveAt(secondIndex-1);
                        }
                        else if (secondIndex < firstIndex)
                        {
                           symbols.RemoveAt(secondIndex);
                           symbols.RemoveAt(firstIndex-1);
                        }
                        

                    }
                    else if (symbols[firstIndex] != symbols[secondIndex])
                    {
                        Console.WriteLine($"Try again!");
                    }

                    if (symbols.Count == 0)
                    {
                        Console.WriteLine($"You have won in {moves} turns!");
                        break;
                    }
                }
            }

            if (symbols.Count != 0)
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(string.Join(" ", symbols));
            }
        }
    }
}