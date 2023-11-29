using System.Text;

namespace TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(text);

            string input;
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] tokens = input.Split("|");
                string command = tokens[0];
                if (command == "ChangeAll") 
                {
                    string substring = tokens[1];
                    string replacement = tokens[2];
                    sb.Replace(substring, replacement);
                    
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    string value = tokens[2];
                    sb.Insert(index, value);
                }
                else if (command == "Move")
                {
                    int numberOfLetters = int.Parse(tokens[1]);
                    string substring = sb.ToString().Substring(0, numberOfLetters);
                    sb.Remove(0, numberOfLetters);
                    sb.Append(substring);
                    
                }
               
            }
            Console.WriteLine($"The decrypted message is: {sb}");
        }
    }
}