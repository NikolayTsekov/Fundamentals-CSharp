namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(filter))
            {
                text = text.Remove(text.IndexOf(filter), filter.Length);
            }

            Console.WriteLine(text);
        }
    }
}