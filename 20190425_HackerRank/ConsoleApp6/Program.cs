using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
        static void staircase(int n)
        {
            string stairCase = string.Empty;
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if ((i + j) < (n - 1))
                        stairCase += " ";
                    else
                        stairCase += "#";
                }
                Console.WriteLine(stairCase);
                stairCase = string.Empty;
            }
            Console.ReadLine();
        }
    }
}
