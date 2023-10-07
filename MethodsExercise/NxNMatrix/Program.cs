namespace NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arr = new int[number];

            FillArray(number, arr);
            PrintMatrix(arr);
        }

        private static void PrintMatrix(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }

        private static void FillArray(int number, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number;
            }
        }
    }
}