namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = default;
            List<Student> students = new List<Student>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.Hometown = homeTown;
                students.Add(student);
            }
            string cityFilter = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Hometown == cityFilter)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        public class Student
        {
            //public Student(string firstName, string lastName, int age, string homeTown)
            //{
            //    FirstName = firstName;
            //    LastName = lastName;
            //    Age = age;
            //    Hometown = homeTown;
            //}

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Hometown { get; set; }

        }
    }
}