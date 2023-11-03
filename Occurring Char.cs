using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occurring_Char
{
    internal class Program
    {
        static void GetOccurringChar(string str)
        {
            int[] count = new int[256];

            for (int i = 0; i < str.Length; i++)
                count[str[i]]++;

            for (int i = 0; i < str.Length; i++)
            {
                if (count[str[i]] != 0)
                {
                    Console.WriteLine($"{str[i]} is: {count[str[i]]}");
                    count[str[i]] = 0;
                }
            }
        }
        static void Main(string[] args)
        {
            string str = "this is a string occurrence";
            GetOccurringChar(str);
            Console.ReadLine();
        }
    }
}
