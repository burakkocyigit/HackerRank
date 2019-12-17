using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = System.Reflection.Assembly.GetExecutingAssembly().CodeBase.Remove(0, 8).Remove(96) + "output.txt";
            TextWriter textWriter = new StreamWriter(System.Reflection.Assembly.GetExecutingAssembly().CodeBase.Remove(0, 8).Remove(95) + "output.txt", true);

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Program.gradingStudents(grades);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }

        private static List<int> gradingStudents(List<int> grades)
        {
            List<int> newGrades = new List<int>();
            foreach (int item in grades)
            {
                if (item > 37 && item % 5 > 2)
                {
                    newGrades.Add(item - (item % 5) + 5);
                }
                else
                {
                    newGrades.Add(item);
                }
            }
            return newGrades;
        }
    }
}
