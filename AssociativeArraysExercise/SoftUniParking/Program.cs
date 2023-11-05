using System.ComponentModel.Design;

namespace SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());
            Dictionary<string, User> users = new Dictionary<string, User>();

            for (int i = 0; i < commandCount; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string command = arguments[0];
                string userName = arguments[1];

                switch (command)
                {
                    case "register":
                        string licensePlate = arguments[2];
                        User newUser = new User(userName, licensePlate);
                        //to do...
                        if (users.ContainsKey(userName))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }
                        else
                        {
                            users.Add(userName, newUser);
                            Console.WriteLine($"{userName} registered {licensePlate} successfully");
                        }
                        break;
                    case "unregister":
                        //to do...
                        if (users.ContainsKey(userName))
                        {
                            users.Remove(userName);
                            Console.WriteLine($"{userName} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        break;
                }
            }

            foreach (KeyValuePair<string, User> userPair in users)
            {
                Console.WriteLine(userPair.Value);
            }
           
        }
    }

    internal class User
    {
        public User(string username, string licensePlate)
        {
            UserName = username;
            LicensePlate = licensePlate;
        }

        public string UserName { get; set; }
        public string LicensePlate { get; set; }

        public override string ToString()
        {
            return $"{UserName} => {LicensePlate}";
        }
    }
}