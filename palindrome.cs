using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_practice
{
    internal class Program
    {
        public static Boolean palindrome(int num)
        {
            int reverse = 0, rem, temp;
            temp = num;
            while (temp != 0)
            {
                rem = temp % 10;
                reverse = reverse * 10 + rem;
                temp = temp / 10;
            }
            if (num == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main(string[] args)
        {
            int num = 12021;
            Console.WriteLine(palindrome(num));
            Console.ReadLine();

        }

    }
}
