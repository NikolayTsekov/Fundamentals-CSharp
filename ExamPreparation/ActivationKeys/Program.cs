namespace ActivationKeys
{
    internal class Program
    {
        static string activationKey;
        static void Contains(string substring)
        {
            if (activationKey.Contains(substring))
            {
                Console.WriteLine($"{activationKey} contains {substring}");

            }
            else
            {
                Console.WriteLine($"Substring not found!");

            }
        }
        private static void FlipUpper(int startIndex, int endIndex)
        {
            string prefix = activationKey.Substring(0, startIndex);
            string middle = activationKey.Substring(startIndex, endIndex - startIndex).ToUpper();
            string suffix = activationKey.Substring(endIndex);
            activationKey = prefix + middle + suffix;
            Console.WriteLine(activationKey);
        }
        private static void FlipLower(int startIndex, int endIndex)
        {
            string prefix = activationKey.Substring(0, startIndex);
            string middle = activationKey.Substring(startIndex, endIndex - startIndex).ToLower();
            string suffix = activationKey.Substring(endIndex);
            activationKey = prefix + middle + suffix;
            Console.WriteLine(activationKey);
        }
        private static void Slice(int firstIndex, int endIndex)
        {

            string firstPart = activationKey.Substring(0, firstIndex);
            string secondPart = activationKey.Substring(endIndex);
            //activationKey = firstPart + secondPart;
            activationKey = $"{firstPart}{secondPart}";
            Console.WriteLine(activationKey);
        }
        static void Main(string[] args)
        {
            activationKey = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Generate")  
            {
                string[] arguments = input.Split(">>>");
                switch (arguments[0])
                {
                    case "Contains":
                        Contains(arguments[1]);
                        break;
                    case "Flip":
                        if (arguments[1] == "Upper")
                        {
                            FlipUpper(int.Parse(arguments[2]), int.Parse(arguments[3]));
                        }
                        else
                        {
                            FlipLower(int.Parse(arguments[2]), int.Parse(arguments[3]));
                        }
                        break;
                    case "Slice":
                        Slice(int.Parse(arguments[1]), int.Parse(arguments[2]));

                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");

        }

       


    }
}