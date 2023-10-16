namespace ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string line = default;
            while ((line = Console.ReadLine()) != "end") 
            {
                string[] lineTokens = line.Split().ToArray();
                string command = lineTokens[0];
                int number = int.Parse(lineTokens[1]);
                if (command == "Add")
                {
                    numbers.Add(number);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(lineTokens[2]);
                    numbers.Insert(index, number);
                }
                else if ( command == "Remove")
                {
                    numbers.Remove(number);
                }
                else
                {
                    numbers.RemoveAt(number);

                }
            }
            PrintList(numbers);
        }
        static void PrintList(List<int> numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}