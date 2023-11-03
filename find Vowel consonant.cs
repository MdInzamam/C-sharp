using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_Vowel_consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "AbCdef";
            string small = str.ToLower();
            int vowel = 0;
            int consonant = 0;
            foreach (char character in small)
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    vowel++;
                }
                else
                {
                    consonant++;
                }
            }
            Console.WriteLine("Vowel"+ vowel);
            Console.WriteLine("Consonant"+consonant);
            Console.ReadLine();
        }
    }
}