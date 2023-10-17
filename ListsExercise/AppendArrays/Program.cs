namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArrays = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            List<string> symbols = ExtractSymbols(stringArrays);
            Console.WriteLine(string.Join(" ", symbols));
        }

        private static List<string> ExtractSymbols(string[] stringArrays)
        {
            List<string> result = new List<string>();
            for (int i = stringArrays.Length-1; i >= 0; i--)
            {
                string str = stringArrays[i];
                string[] array = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(array);

            }
            
            return result;
        }
    }
}