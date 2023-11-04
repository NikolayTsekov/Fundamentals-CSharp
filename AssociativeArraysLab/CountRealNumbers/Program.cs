namespace CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
           
            var numberOccurences = new SortedDictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
               
                int currentNumber = numbers[i];
                if (!numberOccurences.ContainsKey(currentNumber))
                {
                    numberOccurences[currentNumber] = 1;
                }
                else
                {
                    numberOccurences[currentNumber]++;
                }

            }
            foreach (KeyValuePair<int, int> item in numberOccurences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }



        }
    }
}