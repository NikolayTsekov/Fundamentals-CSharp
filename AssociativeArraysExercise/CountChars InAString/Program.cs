namespace CountChars_InAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            
            Dictionary<char, int> charOccurrences = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];
                if (character == ' ')
                {
                    continue;
                }
                if (!charOccurrences.ContainsKey(character))
                {
                    charOccurrences.Add(character, 0);
                }

                charOccurrences[character]++;
            }

            foreach (var charOccurrence in charOccurrences)
            {
                char character = charOccurrence.Key;
                int count = charOccurrence.Value;
                Console.WriteLine($"{character} -> {count}");
            }
        }
    }
}