namespace ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*You will be given an integer that will be a distance in meters. Create a program that converts meters to kilometers formatted to the second decimal point.*/
            int meters = int.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000m;
            Console.WriteLine($"{kilometers:f2}");

        }
    }
}