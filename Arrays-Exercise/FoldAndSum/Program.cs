namespace FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int leftIndex = array.Length / 4 - 1;
            int rightIndex = 3 * array.Length / 4;

            int[] topArray = new int[array.Length/2];
            int numbersSoFar = 0;
            for (int i = leftIndex; i >=0; i--) 
            {
                numbersSoFar++;
                topArray[leftIndex-i] = array[i];
            }
            for (int i = array.Length-1; i >=rightIndex; i--)
            {
                topArray[array.Length - 1 - i + numbersSoFar] = array[i];
            }
            int[] bottomArray = new int[array.Length/2];
            for (int i = leftIndex+1;i <rightIndex;i++)
            {
                bottomArray[i-numbersSoFar] = array[i];
            }
            for (int i = 0; i < topArray.Length; i++)
            {
                Console.Write(topArray[i] + bottomArray[i] + " ");
            }
        }
    }
}