namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int targets = 0;
            int originalValue = n;
            while (n >= m)
            {
                n -= m;
                targets++;
                if (n == originalValue * 0.50 && y != 0)
                {
                    n /= y;
                }
            }
            Console.WriteLine($"{n}");
            Console.WriteLine($"{targets}");
        }
    }
}