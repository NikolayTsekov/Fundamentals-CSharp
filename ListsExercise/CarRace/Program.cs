namespace CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            double leftRacer = 0;
            double rightRacer = 0;
            for (int i = 0; i < numbers.Count/2; i++) 
            {
                leftRacer += numbers[i];
                if (numbers[i] == 0)
                {
                    leftRacer *= 0.8;
                }
            }
            for (int i = numbers.Count - 1; i > numbers.Count/2; i--)
            {
                rightRacer += numbers[i];
                if (numbers[i]==0)
                {
                    rightRacer *= 0.8;
                }
            }
            if (leftRacer < rightRacer)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacer}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightRacer}");
            }
        }
    }
}