namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int seconfNum = int.Parse(Console.ReadLine());
            double firstFactorial = Factorial(firstNum);
            double secondFactorial = Factorial(seconfNum);
            
            Console.WriteLine($"{(firstFactorial / secondFactorial):f2}");
        }

        static double Factorial(int firstNum)
        {
            double firstFactorial = 1;
            for (int i = 1; i <= firstNum; i++)
            {
                firstFactorial = firstFactorial * i;
            }

            return firstFactorial;
        }
    }
}