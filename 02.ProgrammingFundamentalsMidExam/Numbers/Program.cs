using System.Threading.Channels;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            double averageNumber = 0;
            if (array.Length==0)
            {
                Console.WriteLine("No");
                return;
            }
            averageNumber = array.Sum()/(double)array.Length;
            int matchingNumbersCount = array.Where(x=>x>averageNumber).ToArray().Length;
            if (matchingNumbersCount == 0)
            {
                Console.WriteLine("No");
            }
            else if (array.Length<5)
            {
                Console.WriteLine("Less than 5 numbers");
            }
            else
            {
                var result = array.OrderByDescending(x=>x).Where(x=>x>averageNumber).Take(5).ToArray();
                Console.WriteLine(string.Join(" ", result));
            }
           

        }
    }
}