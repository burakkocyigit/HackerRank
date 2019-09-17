using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"C:\Users\burak.kocyigit\source\repos\20190425_HackerRank\ConsoleApp1\bin\Debug\array.txt", true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
            Console.ReadLine();
        }
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> sonuc = new List<int>() { 0, 0 };
            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                {
                    sonuc[0]++;
                }
                else if (a[i] < b[i])
                {
                    sonuc[1]++;
                }
            }
            return sonuc;

        }
    }
}
