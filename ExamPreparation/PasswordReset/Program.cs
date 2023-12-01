using System.Text;

namespace PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            

            string input;
            while ((input = Console.ReadLine()) != "Done") 
            {
                string[] tokens = input.Split(" ");
                string command = tokens[0];
                if (command == "TakeOdd") 
                {
                    string newPassword = string.Empty;
                    for (int i = 0; i < password.Length; i++)
                    {
                        
                        if (i % 2 != 0)
                        {
                            newPassword += password[i];
                        }
                        
                    }
                    password = newPassword;
                    Console.WriteLine(password);


                }
                else if (command == "Cut")
                {
                    int index = int.Parse(tokens[1]);
                    int length = int.Parse(tokens[2]);
                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if(command == "Substitute")
                {
                    string substring = tokens[1];
                    string substitute = tokens[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}