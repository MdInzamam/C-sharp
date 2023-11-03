using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifier
{
    internal class Program
    {
    }
    class car
    {
        string model;
        string color;
        int price;

        private void carFeature()
        {
            Console.WriteLine("Model " + model);
            Console.WriteLine("color " + color);
            Console.WriteLine("Price " + price);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            car mycar = new car();
            mycar.model = "Alto";
            mycar.color = "Black";
            mycar.price = 300000;
            mycar.carFeature();


        }
    }
}
