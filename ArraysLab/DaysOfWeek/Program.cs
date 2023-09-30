namespace DaysOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            else
            {
                Console.WriteLine(days[number - 1]);
            }
        }
    }
}