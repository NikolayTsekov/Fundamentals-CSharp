namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();
                if (arguments[0] == "Delete")
                {
                    int element = int.Parse(arguments[1]);
                    list.Remove(element);
                }
                else if (arguments[0] == "Insert")
                {
                    int element = int.Parse(arguments[1]);
                    int index = int.Parse(arguments[2]);
                    list.Insert(index, element);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}