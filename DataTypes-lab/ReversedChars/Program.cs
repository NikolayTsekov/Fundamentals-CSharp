namespace ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that takes 3 lines of characters and prints them in reversed order with a space between them.*/
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            Console.Write($"{input3} {input2} {input}");
        }
    }
}