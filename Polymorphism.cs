using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Practice
{
    /*Compile time*/
    class compile_time
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public double add(double a, double b)
        {
            return a * b;
        }
    }

    /*Run time*/
    class run_Time
    {
        public void addRunTime()
        {
            int a = 4, b = 5;
            int c = a + b;
            Console.WriteLine(c);
        }
    }
    class run_times : run_Time 
    {
        public void addRunTime()
        {
            int a = 5, b = 5;
            int c = a + b;
            Console.WriteLine(c);
        }
        public static void Main(string[] args)
        {
            compile_time abc = new compile_time();
            Console.WriteLine(abc.add(4, 2));
            Console.WriteLine(abc.add(5.5, 2.5));

            Console.WriteLine("--------------------------------------------------");

            run_times xyz = new run_times();
            xyz.addRunTime();
            Console.ReadLine();
            
        }
    }
}
