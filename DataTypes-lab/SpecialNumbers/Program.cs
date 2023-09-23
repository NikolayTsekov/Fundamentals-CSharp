namespace SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A number is special when its sum of digits is 5, 7 or 11. Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not (True / False).*/
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sumDigits = 0;
                int digits = i;
                while (digits > 0)
                {
                    sumDigits += digits % 10;
                    digits /= 10;
                }
                bool isSpecial = sumDigits == 5 || sumDigits == 7 || sumDigits == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}