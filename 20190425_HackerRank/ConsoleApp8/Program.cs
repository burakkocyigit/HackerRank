using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(System.Reflection.Assembly.GetExecutingAssembly().CodeBase.Remove(0, 8).Remove(95) + "input.txt", true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = birthdayCakeCandles(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        static int birthdayCakeCandles(int[] ar)
        {
            Array.Sort(ar);
            for (int i = ar.Length - 1; i > 0; i--)
            {
                if (ar[i] != ar[i - 1])
                {
                    return ar.Length - i;
                }
            }
            return ar.Length;
        }
    }
}
