using System;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;

namespace ManipulateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var changeArray = stringArray;

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                if (command == "Distinct")
                {
                    changeArray = changeArray.Distinct().ToArray();

                }

                if (command == "Reverse")
                {
                    Array.Reverse(changeArray);
                }

                if (command != "Distinct" && command != "Reverse")
                {
                    string[] replace = command.Split(' ').ToArray();
                    changeArray[int.Parse(replace[1])] = replace[2];
                }
            }

            Console.WriteLine(string.Join(", ", changeArray));

        }
    }
}