namespace AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Създавам речник
            Dictionary<string, uint> resourceMap = new Dictionary<string, uint>();
            //1. Създавам while цикъл
            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                //3.Проверявам дали има такъв ключ вече
                if (!resourceMap.ContainsKey(input))
                {
                    resourceMap.Add(input, 0);
                }
                //4.Чета количеството
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