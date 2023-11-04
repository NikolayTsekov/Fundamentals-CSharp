namespace CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Прочитам масива
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            //3. Създавам речник, който да пазим като ключ текущото число и колко пъти се е появило то
            var numberOccurences = new SortedDictionary<int, int>();
            //2. Обикалям числата, за да видим колко пъти се повтаря 
            for (int i = 0; i < numbers.Length; i++)
            {
                //4. Проверявам дали тази колекция съдържа ключ от текущото число
                int currentNumber = numbers[i];
                if (!numberOccurences.ContainsKey(currentNumber))
                {
                    numberOccurences[currentNumber] = 1;
                }
                //5. Ако вече го има само го увеличаваме
                else
                {
                    numberOccurences[currentNumber]++;
                }

            }
            //6. Минаваме през всички числа и отпечатваме резултата
            foreach (KeyValuePair<int, int> item in numberOccurences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }



        }
    }
}