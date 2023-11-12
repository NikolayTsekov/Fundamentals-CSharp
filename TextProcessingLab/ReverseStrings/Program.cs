namespace ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string reversed = "";
                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reversed += command[i];
                }
                Console.WriteLine($"{command} = {reversed}");

            }

        }
    }
}