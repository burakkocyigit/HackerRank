using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"C:\Users\burak.kocyigit\source\repos\20190425_HackerRank\ConsoleApp1\bin\Debug\array.txt", true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = simpleArraySum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
            Console.ReadLine();
        }
        static int simpleArraySum(int[] ar)
        {
            /*
             * Write your code here.
             */
            int sonuc = default(int);
            for (int i = 0; i < ar.Length; i++)
            {
                sonuc += ar[i];
            }
            return sonuc;
        }
    }
}
