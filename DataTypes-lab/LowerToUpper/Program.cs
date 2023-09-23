namespace LowerToUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that prints whether a given character is upper-case or lower case.*/
            char letter = char.Parse(Console.ReadLine());
            bool isUpper = char.IsUpper(letter);
            if (isUpper == true)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }

        }
    }
}