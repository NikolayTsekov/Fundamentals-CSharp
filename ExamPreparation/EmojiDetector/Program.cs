using System.Text.RegularExpressions;

namespace EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coolThresholdPatter = @"\d";
            string emojiPattern = @"(\*{2}|\:{2})(?<Emoji>[A-Z][a-z]{2,})\1";
            List<string> coolEmojies = new List<string>();

            string input = Console.ReadLine();
            ulong coolThreshold = 1;

            foreach (Match match in Regex.Matches(input, coolThresholdPatter))
            {
                coolThreshold *= ulong.Parse(match.Value);
            }
            MatchCollection matches = Regex.Matches(input, emojiPattern);
            foreach (Match match in matches)
            {
                string emojiStr = match.Groups["Emoji"].Value;

                ulong totalEmojies = 0;
                foreach (char character in emojiStr)
                {
                    totalEmojies += character;
                }
                if (totalEmojies > coolThreshold)
                {
                    coolEmojies.Add(match.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            coolEmojies.ForEach(emoji => Console.WriteLine(emoji));
        }
    }
}