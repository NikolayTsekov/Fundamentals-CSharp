namespace AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, uint> resourceMap = new Dictionary<string, uint>();
            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                if (!resourceMap.ContainsKey(input))
                {
                    resourceMap.Add(input, 0);
                }
                var quantity = uint.Parse(Console.ReadLine());

                resourceMap[input] += quantity;
            }

            foreach (var resourcePair in resourceMap)
            {
                Console.WriteLine($"{resourcePair.Key} -> {resourcePair.Value}");
            }
        }
    }
}