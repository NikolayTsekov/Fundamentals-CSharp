namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());

            string biggestKegsModel = string.Empty;
            decimal biggestKegVolume = 0;

            for (int i = 0; i < kegs; i++)
            {
                string kegsModel = Console.ReadLine();
                decimal kegsRadius = decimal.Parse(Console.ReadLine());
                decimal kegsHeight = decimal.Parse(Console.ReadLine());
                decimal volume = (decimal)Math.PI * (kegsRadius * kegsRadius) * kegsHeight;
                if (volume > biggestKegVolume)
                {
                    biggestKegsModel = kegsModel;
                    biggestKegVolume = volume;
                }
            }
            Console.WriteLine(biggestKegsModel);
        }
    }
}