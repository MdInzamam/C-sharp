using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Fibonacci_by_recursive
{
    internal class Program
    {
            public static void Main(string[] args)
            {
                int n = 9;
                print_fibo(n);
                Console.ReadLine();
            }
            public static int Fibonacci(int n)
            {
                if (n <= 1)
                {
                    return n;
                }
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }
            public static void print_fibo(int num)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine(Fibonacci(i));
                }
            }
    }
}
