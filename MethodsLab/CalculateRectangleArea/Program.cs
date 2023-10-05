namespace CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = RectangleArea(w, h);
            Console.WriteLine(area);
        }
        static double RectangleArea (double w, double h)
        {
            return w * h;
        }
    }
}