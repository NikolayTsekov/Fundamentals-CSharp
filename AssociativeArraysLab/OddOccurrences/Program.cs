namespace OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ")
                .Select(x => x.ToLower())
                .ToArray();
            Dictionary<string, int> numberOccurences = new Dictionary<string, int>();
            
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (!numberOccurences.ContainsKey(currentWord))
                {
                    numberOccurences.Add(currentWord, 0);
                }

                numberOccurences[currentWord]++;
            }

            foreach (KeyValuePair<string, int> word in numberOccurences)
            {
                if (word.Value%2==1)
                {
                    Console.Write($"{word.Key} ");

                }
            }

        }
    }
}