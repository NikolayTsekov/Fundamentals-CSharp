namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentQuantity = 0;
            for (int i = 1; i <= n; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                if (currentQuantity + quantity > 255)
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
                else
                {
                    currentQuantity += quantity; 
                }
            }
            Console.WriteLine($"{currentQuantity}");
        }
    }
}