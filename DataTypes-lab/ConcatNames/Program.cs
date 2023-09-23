namespace ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Read two names and a delimiter. Print the names joined by the delimiter.*/
            string name = Console.ReadLine();
            string name2 = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.Write($"{name}{delimiter}{name2}");

        }
    }
}