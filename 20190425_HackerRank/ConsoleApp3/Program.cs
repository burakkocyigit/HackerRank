using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"C:\Users\burak.kocyigit\source\repos\20190425_HackerRank\ConsoleApp1\bin\Debug\array.txt", true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
            ;
            long result = aVeryBigSum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        static long aVeryBigSum(long[] ar)
        {
            long sonuc = default(long);
            for (long i = 0; i < ar.Length; i++)
            {
                sonuc += ar[i];
            }
            return sonuc;

        }
    }
}
