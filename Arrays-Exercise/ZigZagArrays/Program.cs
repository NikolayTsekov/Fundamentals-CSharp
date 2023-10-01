namespace ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] firstArray = new string[n];
            string[] secondArray = new string[n];
            bool isFirstArraySelected = true;
            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                string[] numbersArray = numbers.Split();

                if (i % 2 == 0) 
                {
                    firstArray[i] = numbersArray[0];
                    secondArray[i] = numbersArray[1];
                }
                else 
                {
                    firstArray[i] = numbersArray[1];
                    secondArray[i] = numbersArray[0];
                }
                isFirstArraySelected = !isFirstArraySelected;
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));

        }
    }
}