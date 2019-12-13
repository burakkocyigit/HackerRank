using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }

        static void miniMaxSum(int[] arr)
        {
            long minToplam = 0;
            long maxToplam = 0;
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minToplam += arr[i];
            }
            for (int i = 1; i < arr.Length; i++)
            {
                maxToplam += arr[i];
            }
            Console.WriteLine("min :" + minToplam + " max :" + maxToplam);
            Console.ReadLine();
        }
    }
}
