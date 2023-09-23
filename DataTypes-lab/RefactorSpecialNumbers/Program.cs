namespace RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*You are given a working code that is a solution to Problem 5. Special Numbers. However, the variables are  improperly named, declared before they are needed and some of them are used for multiple purposes. Without using your previous solution, modify the code, so that it is easy to read and understand. 
             * Hints
             • Reduce the span of the variables by declaring them at the moment they receive a value, not before.
            • Rename your variables to represent their real purpose (example: "toe" should become isSpecialNum, etc.).
            • Search for variables that have multiple purposes. If you find any, introduce a new variable*/
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpacial = false;

            for (int i = 1; i <= n; i++)
            {
                int digit = i;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }
                isSpacial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpacial}");
                sum = 0;
            }
            

        }
    }
}