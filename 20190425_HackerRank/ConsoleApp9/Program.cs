using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter tw = new StreamWriter(System.Reflection.Assembly.GetExecutingAssembly().CodeBase.Remove(0, 8).Remove(95) + "output.txt", true);

            string s = Console.ReadLine();

            string result = timeConversion(s);

            tw.WriteLine(result);

            tw.Flush();
            tw.Close();
        }

        static string timeConversion(string s)
        {
            string[] arr = s.Split(':');
            if (arr[2].Substring(arr[2].Length - 2) == "PM" && int.Parse(arr[0]) != 12)
            {
                return (int.Parse(arr[0]) + 12) + ":" + arr[1] + ":" + arr[2].Remove(arr[2].Length - 2);
            }
            else if (arr[2].Substring(arr[2].Length - 2) == "PM" && int.Parse(arr[0]) == 12)
            {
                return (arr[0]) + ":" + arr[1] + ":" + arr[2].Remove(arr[2].Length - 2);
            }
            else if (arr[2].Substring(arr[2].Length - 2) == "AM" && int.Parse(arr[0]) != 12)
            {
                return (arr[0] + ":" + arr[1] + ":" + arr[2].Remove(arr[2].Length - 2));
            }
            else if (arr[2].Substring(arr[2].Length - 2) == "AM" && int.Parse(arr[0]) == 12)
            {
                return ("00:" + arr[1] + ":" + arr[2].Remove(arr[2].Length - 2));
            }
            else
                return string.Empty;
        }
    }
}
