namespace RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            string result = string.Empty;
            foreach (string word in words)
            {
                int currentWordLength = word.Length;
                for (int i = 0; i < currentWordLength; i++)
                {
                    result += word;
                }
            }

            Console.WriteLine(result);

        }
    }
}