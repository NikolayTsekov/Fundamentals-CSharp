using System.Text;

namespace StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = ProcessExplosions(input);
            Console.WriteLine(result);

        }

        private static string ProcessExplosions(string input)
        {
            StringBuilder resultBuilder = new StringBuilder();
            int strenght = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='>')
                {
                    strenght += int.Parse(input[i + 1].ToString());
                    resultBuilder.Append(input[i]);

                }
                else if (strenght==0)
                {
                    resultBuilder.Append(input[i]);
                }
                else
                {
                    strenght--;
                }
            }
            return resultBuilder.ToString();
        }
    }
}