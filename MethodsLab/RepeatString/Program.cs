namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = RepeatString(text, n);
            Console.WriteLine(result);
        }
        static string RepeatString(string text, int r)
        {
            string newText = " ";
            for (int i = 0; i < r; i++)
            {
                newText += text;
            }
            return newText;
        }
    }
}