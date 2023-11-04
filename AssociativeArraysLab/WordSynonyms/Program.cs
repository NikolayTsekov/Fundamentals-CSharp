namespace WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = synonym;
                }
                else
                {
                    dictionary[word] += ", " + synonym;
                }
            }

            foreach (KeyValuePair<string, string> item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}