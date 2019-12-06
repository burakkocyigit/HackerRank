using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }
        static void plusMinus(int[] arr)
        {
            int negatives = 0;
            int zeros = 0;
            int positives = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] * -1 < 0)
                    negatives++;
                else if (arr[i] == 0)
                    zeros++;
                else if (arr[i] * -1 > 0)
                    positives++;
            }            
            Console.WriteLine(Math.Round(((double)negatives) / arr.Length, 5));
            Console.WriteLine(Math.Round(((double)positives) / arr.Length, 6));
            Console.WriteLine(Math.Round(((double)zeros) / arr.Length, 6));
            Console.ReadLine();
        }
    }
}
