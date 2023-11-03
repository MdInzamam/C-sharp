using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace total_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "asfgh";
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}