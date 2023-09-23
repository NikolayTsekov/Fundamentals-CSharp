namespace ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a program to enter n numbers and calculate and print their exact sum (without rounding).*/
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += decimal.Parse(Console.ReadLine()); 
            }
            Console.WriteLine(sum);

        }
    }
}