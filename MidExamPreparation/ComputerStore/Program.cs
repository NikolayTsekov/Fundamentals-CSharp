namespace ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            decimal totalPrice = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "special" || input == "regular")
                {
                    break;
                }

                decimal price = decimal.Parse(input); 
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                totalPrice += price;
               
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                decimal taxes = totalPrice * (20m/100m); 
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                decimal priceWithTaxes = totalPrice + taxes;
                if (input == "special")
                {
                    priceWithTaxes -= (priceWithTaxes * 10m)/100m;
                }
                Console.WriteLine($"Total price: {priceWithTaxes:f2}$");
            } 
           
        }
    }
}