namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            var pascalTriangle = new int[rows][];

            pascalTriangle[0] = new int[1];
            pascalTriangle[0][0] = 1;
            for (int row = 1; row < rows; row++)
            {
                pascalTriangle[row] = new int[row + 1];
                pascalTriangle[row][0] = 1;
                pascalTriangle[row][pascalTriangle[row].Length - 1] = 1;
                for (int col = 1; col < pascalTriangle[row].Length-1; col++)
                {
                    pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                }
            }

            foreach (var row in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}