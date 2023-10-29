namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                Students student = new Students();

                student.FirstName = studentArgs[0];
                student.LastName = studentArgs[1];
                student.Grade = float.Parse(studentArgs[2]);

                students.Add(student);
            }

            List<Students> orderedStudents = students.OrderByDescending(student => student.Grade).ToList();
            Console.WriteLine(string.Join("\n", orderedStudents));
        }
    }

    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}