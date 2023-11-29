namespace Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<char> text = new List<char>();
            text.AddRange(Console.ReadLine());

            for (int i = 0; i < numbers.Count; ++i)
            {
                int sum = 0;
                while (numbers[i] != 0)
                {
                    sum += numbers[i] % 10;
                    numbers[i] /= 10;
                }
                int times = sum / text.Count;
                sum = sum - times * text.Count;
                Console.Write(text[sum]);
                text.RemoveAt(sum);
            }


        }
    }
}