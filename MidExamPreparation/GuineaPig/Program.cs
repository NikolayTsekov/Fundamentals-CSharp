namespace GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantityOfFood = double.Parse(Console.ReadLine())* 1000;
            double hay = double.Parse(Console.ReadLine())* 1000;
            double cover = double.Parse(Console.ReadLine())* 1000;
            double pigsWeight = double.Parse(Console.ReadLine())* 1000;

            for (int day =1; day <= 30; day++)
            {
                quantityOfFood -= 300;
                if (day % 2 == 0)
                {
                    double amountOfHay = quantityOfFood * 0.05;
                    hay -= amountOfHay;
                }
                if (day % 3 == 0)
                {
                    double amountOfCover = pigsWeight / 3;
                    cover -= amountOfCover;
                }
                if (quantityOfFood<=0 || hay<=0 || cover<=0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }


            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityOfFood/1000:f2}, Hay: {hay/1000:f2}, Cover: {cover/1000:f2}.");

        }
    }
}