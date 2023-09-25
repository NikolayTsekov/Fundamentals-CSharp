namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int spices = 0;

            while (yield >= 100)
            {
                days++;
                spices += yield;
                spices -= 26;
                yield -= 10;
            }
            spices -= 26;
            if (spices < 0) 
            {
                spices = 0;
            }
            Console.WriteLine($"{days}");
            Console.WriteLine($"{spices}");
        }
    }
}