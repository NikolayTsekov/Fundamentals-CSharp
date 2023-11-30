using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Travel") 
            {
                string[] tokens = input.Split(":").ToArray();
                string command = tokens[0];
                if (command == "Add Stop")
                {
                    int index = (int.Parse)(tokens[1]);
                    string country = tokens[2];
                    if (index >= 0 && index <= stops.Length)
                    {
                        stops = stops.Insert(index, country);
                    }
                    Console.WriteLine(stops);
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = (int.Parse)(tokens[1]);
                    int endIndex = (int.Parse)(tokens[2]);
                    if (startIndex >= 0 && endIndex >= 0 && startIndex <=stops.Length-1 && endIndex <= stops.Length-1)
                    {
                        stops = stops.Remove(startIndex, endIndex+1 -startIndex);
                    }
                    Console.WriteLine(stops);
                }
                else if (command == "Switch")
                {
                    if (stops.Contains(tokens[1]))
                    {
                        stops = stops.Replace(tokens[1], tokens[2]);
                    }
                 
                    Console.WriteLine(stops);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}