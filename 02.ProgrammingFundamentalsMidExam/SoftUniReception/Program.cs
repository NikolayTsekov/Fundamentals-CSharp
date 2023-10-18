namespace SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents1 = int.Parse(Console.ReadLine());
            int numberOfStudents2 = int.Parse(Console.ReadLine());
            int numberOfStudents3 = int.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());

            int hourCount = 0;
            int answersPerHour = numberOfStudents1 + numberOfStudents2 + numberOfStudents3;
            if (studentCount % answersPerHour == 0)
            {
                hourCount = studentCount/ answersPerHour;

            }
            else
            {
                hourCount = studentCount / answersPerHour + 1;
            }

            if (hourCount>3 && hourCount % 3==0)
            {
                hourCount += hourCount / 3 - 1;
            }
            else if (hourCount>3)
            {
                hourCount += hourCount / 3;
            }

            Console.WriteLine($"Time needed: {hourCount}h.");
        }
    }
}