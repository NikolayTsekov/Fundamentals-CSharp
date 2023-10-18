namespace EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stringNumber = int.Parse(Console.ReadLine());

            string[] sequenceOfStrings = new string[stringNumber];
            int[] valueOfString = new int[stringNumber];
            for (int i = 0; i < sequenceOfStrings.Length; i++)
            {
                sequenceOfStrings[i] = Console.ReadLine();
                int sumVowels = 0;
                int sumConsonants = 0;
                foreach (char index in sequenceOfStrings[i])
                {
                    if (index == 'a' || index == 'e' || index == 'i' || index == 'o' || index == 'u' || index == 'A' ||
                        index == 'E' || index == 'I' || index == 'O' || index == 'U')
                    {
                        sumVowels += ((int)index * sequenceOfStrings[i].Length);


                    }
                    else 
                    {
                        sumConsonants += ((int)index / sequenceOfStrings[i].Length);
                    }
                }
                int stringSum = sumVowels + sumConsonants;
                valueOfString[i] = stringSum;

            }
            Array.Sort(valueOfString);
            foreach (int value in valueOfString)
            {
                Console.WriteLine(value);
            }

        }
    }
}