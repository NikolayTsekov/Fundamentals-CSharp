using System.Text.RegularExpressions;

namespace MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\#{1}[A-z]{3,}\#{2}[A-z]{3,}\#{1}|\@{1}[A-z]{3,}\@{2}[A-z]{3,}\@{1}";

            Regex regex = new Regex(pattern);
            List<string> validPairs = new List<string>();
            List<string> mirrorPairs = new List<string>();

            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches) 
            {
                validPairs.Add(match.ToString());
            }
            for (int i = 0; i < validPairs.Count; i++) 
            {
                string currentPair = validPairs[i];
                string firstPart = "";
                string secondPart = "";
                for (int j = 0; j < currentPair.Length/2; j++) 
                {
                    firstPart += currentPair[j];
                }
                for (int k = currentPair.Length-1; k >= currentPair.Length/2; k--)
                {
                    secondPart += currentPair[k];
                }
                if (firstPart == secondPart)
                {
                    mirrorPairs.Add(currentPair);
                }
            }
            if(validPairs.Count>0)
            {
                Console.WriteLine($"{validPairs.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            List<string> finalPairs = new List<string>();
            if (mirrorPairs.Count>0)
            {
                Console.WriteLine("The mirror words are:");
                string finalResult = "";
                foreach (var item in mirrorPairs)
                {
                    string currentItem = item.Substring(1, (item.Length / 2) - 2);
                    string currentItem1 = item.Substring(item.Length/2+1, (item.Length-((item.Length/2)+2)));
                    finalResult = $"{currentItem} <=> {currentItem1}";
                    finalPairs.Add(finalResult);
                }
                Console.WriteLine($"{string.Join(", ", finalPairs)}");
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}