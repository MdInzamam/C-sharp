using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "ABCDE";
            string rev = "";
            for(int i = 0; i < str.Length; i++) 
            {
                rev = str[i] + rev;
            }
            Console.WriteLine(rev);
            Console.ReadLine(); 
        }
    }
}
