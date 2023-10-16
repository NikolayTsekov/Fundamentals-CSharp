namespace ListOperations
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
            while ((input = Console.ReadLine()) != "End")
            {
                string[] argument = input.Split();
                if (argument[0] == "Add")
                {
                    int number = int.Parse(argument[1]);
                    list.Add(number);
                }
                else if (argument[0] == "Insert")
                {
                    int number = int.Parse(argument[1]);
                    int index = int.Parse(argument[2]);
                    if (IsNotValidIndex(index, list.Count))
                    {
                        Console.WriteLine($"Invalid index");
                    }
                    else
                    {
                        list.Insert(index, number);

                    }
                }
                else if (argument[0] == "Remove")
                {
                    int index = int.Parse(argument[1]);
                    if (IsNotValidIndex(index, list.Count()))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {                   
                        list.RemoveAt(index);

                    }
                }
                else if (argument[0] == "Shift")
                {
                    int count = int.Parse(argument[2]);
                    string direction = argument[1];
                    count %= list.Count;
                    if (direction == "left")
                    {
                        List<int> shiftedPart = list.GetRange(0, count);
                        list.RemoveRange(0, count);
                        list.InsertRange(list.Count, shiftedPart);
                    }
                    else if (direction == "right")
                    {
                        List<int> shiftedPart = list.GetRange(list.Count - count, count);
                        list.RemoveRange(list.Count - count, count);
                        list.InsertRange(0, shiftedPart);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }

        private static bool IsNotValidIndex(int index, int listCount)
        {
            return index < 0 || index >= listCount;
        }
    }
}