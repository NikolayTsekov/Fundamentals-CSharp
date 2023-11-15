using System.Text;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder cipher = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char original = text[i];
                cipher.Append((char)(original+3));
            }

            Console.WriteLine(cipher);
        }
    }
}