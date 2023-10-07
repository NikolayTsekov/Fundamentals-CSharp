namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;  
            while ((input = Console.ReadLine()) != "END")
            {
                bool isNumberPalindrome = isPalindrome(input);
                Console.WriteLine(isNumberPalindrome);
            }
        }

        static bool isPalindrome(string symbols)
        {
            int left = 0;
            int right = symbols.Length - 1;
            while (left < right)
            {
                if (symbols[left] != symbols[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}