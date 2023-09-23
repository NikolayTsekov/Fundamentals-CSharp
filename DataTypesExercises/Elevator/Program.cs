namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfPersons = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)numberOfPeople / capacityOfPersons);
            Console.WriteLine(courses);

        }
    }
}