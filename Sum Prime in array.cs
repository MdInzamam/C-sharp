using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Prime_in_array
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            int[] arr = { 1, 4, 5, 8, 2, 9, 10, 71 };
            int sumPrime = 0;
            int sumNotPrime = 0;

            foreach (int num in arr)
            {
                if (IsPrime(num))
                {
                    sumPrime += num;
                }
                else
                {
                    sumNotPrime += num;
                }
            }

            Console.WriteLine("Sum of prime numbers: " + sumPrime);
            Console.WriteLine("Sum of non-prime numbers: " + sumNotPrime);
            Console.ReadLine();
        }

        public static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}