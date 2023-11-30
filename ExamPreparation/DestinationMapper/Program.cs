using System.Text.RegularExpressions;
using System.Xml;

namespace DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([=/])([A-Z][A-Za-z]{2,})\1";
            Regex regex = new Regex(pattern, RegexOptions.Compiled);
            List<string> destinations = new List<string>();
            int travelPoints = 0;
            foreach (Match match in regex.Matches(input)) 
            {
                travelPoints += match.Groups[2].Length;
                string currentDestination = match.Groups[2].Value;
                destinations.Add(currentDestination);
            }
            string destinationList = String.Join(", ", destinations);
            Console.WriteLine($"Destinations: " + destinationList);
            Console.WriteLine($"Travel Points: " + travelPoints);
        }
    }
}