using System.Text;
using System.Text.RegularExpressions;

class Participant
{
    public Participant (string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public uint Distance { get; set; }
}
namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participantNames = Console.ReadLine().Split(", ").ToList();
            List<Participant> participans = new List<Participant>();
            

            foreach (string name in participantNames) 
            {
                Participant participant = new Participant(name);
                participans.Add(participant);
            }

            string input;
            while ((input = Console.ReadLine()) != "end of race") 
            {
                StringBuilder nameBuilder = new StringBuilder();
                string lettersPattern = @"[A-Za-z]";

                foreach (Match match in Regex.Matches(input, lettersPattern))
                {
                    nameBuilder.Append(match.Value);
                }
                string participantName = nameBuilder.ToString();
                uint distance = 0;
                string digitsPattern = @"\d";
                foreach (Match match in Regex.Matches(input, digitsPattern))
                {
                    distance += uint.Parse(match.Value);
                }

                Participant foundParticipant = participans.FirstOrDefault(p => p.Name == participantName);
                if (foundParticipant != null)
                {
                    foundParticipant.Distance += distance;
                }
                
            }
            List<Participant> firstParticipants = participans.OrderByDescending(p => p.Distance).Take(3).ToList();
            Console.WriteLine($"1st place: {firstParticipants[0].Name}");
            Console.WriteLine($"2nd place: {firstParticipants[1].Name}");
            Console.WriteLine($"3rd place: {firstParticipants[2].Name}");
        }
    }
}