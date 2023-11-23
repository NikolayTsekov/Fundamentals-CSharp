using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Message
    {

        public string PlanetName { get; set; }
        public uint Population { get; set; }
        public string AttackType { get; set; }
        public uint SoldierCount { get; set;}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Message> messages = new List<Message>();
            int messagesCount = int.Parse(Console.ReadLine());

            string starPattern = @"[SsTtAaRr]";
            string msgPattern = @"\@(?<Planet>[A-Za-z]+)[^\@\-\!\:\>]*:(?<Population>\d+)[^\@\-\!\:\>]*\!(?<Type>A|D)\![^\@\-\!\:\>]*\-\>(?<Soldiers>\d+)";
            for (int i = 0; i < messagesCount; i++) 
            {
                string encryptMsg = Console.ReadLine();
                int decryptionKey = Regex.Matches(encryptMsg, starPattern).Count();
                StringBuilder builder = new StringBuilder();
                for (int j = 0; j < encryptMsg.Length; j++)
                {
                    builder.Append((char)(encryptMsg[j] - decryptionKey));
                }
                string decryptedMessage = builder.ToString();

                Match match = Regex.Match(decryptedMessage, msgPattern);
                if (!Regex.IsMatch(decryptedMessage, msgPattern))
                {
                    continue;
                }

                Message message = new Message();
                message.PlanetName = match.Groups["Planet"].Value;
                message.Population = uint.Parse(match.Groups["Population"].Value);
                message.AttackType = match.Groups["Type"].Value;
                message.SoldierCount = uint.Parse(match.Groups["Soldiers"].Value);

                messages.Add(message);
            }
            var filteredMessages = messages.Where(m=>m.AttackType == "A").OrderBy(m=>m.PlanetName).ToList();

            Console.WriteLine($"Attacked planets: {filteredMessages.Count}");
            filteredMessages.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));
            
            filteredMessages = messages.Where(m=>m.AttackType=="D").OrderBy(m=>m.PlanetName).ToList();

            Console.WriteLine($"Destroyed planets: {filteredMessages.Count}");
            filteredMessages.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));
        }
    }
}