namespace IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int addingOperation = firstNumber + secondNumber;
            int dividingOperation = addingOperation / thirdNumber;
            int multiplyOperation = dividingOperation * fourthNumber;
            Console.WriteLine(multiplyOperation);
        }
    }
}