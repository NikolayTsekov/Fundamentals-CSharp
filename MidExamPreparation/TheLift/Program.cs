namespace TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                int currentWagon = array[i];
                if (currentWagon < 4)
                {
                    int emptySeats = 4 - array[i];
                    peopleWaiting -= emptySeats;
                    if (peopleWaiting<0)
                    {
                        array[i] = 4 - Math.Abs(peopleWaiting);
                        Console.WriteLine("The lift has empty spots!");
                        Console.WriteLine(string.Join(" ", array));
                        return;
                    }

                    array[i] = 4;
                }
            }

            if (peopleWaiting!=0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            }

            
            Console.WriteLine(string.Join(" ", array));
        }
    }
}