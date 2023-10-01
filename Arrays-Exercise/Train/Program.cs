namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] passengers = new int[n];
            for (int i = 0; i < passengers.Length; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < passengers.Length; i++)
            {
                
                Console.Write($"{passengers[i]} ");
                sum += passengers[i];
                
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}