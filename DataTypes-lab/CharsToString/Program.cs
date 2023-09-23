namespace CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that reads 3 lines of input. On each line, you get a single character. Combine all the characters into one string and print it on the console.*/
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            Console.WriteLine($"{first}{second}{third}");
            

        }
    }
}