using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharetance
{
    class car
    {
        public string model;
        public string color;
        public int price;

        public void carFeature()
        {
            Console.WriteLine("Model " + model);
            Console.WriteLine("color " + color);
            Console.WriteLine("Price " + price);
            Console.ReadLine();
        }
    }
    class maruti : car
    {
        float mailage;

        public void printMailage()
        {
            Console.WriteLine("Mailage" + mailage);
        }
        class program
        {
            public static void main(string[] args)
            {
                maruti myCar = new maruti();
                myCar.model = "Alto";
                myCar.color = "Black";
                myCar.price = 300000;
                myCar.mailage = 20.2f;
                myCar.printMailage();
                Console.ReadLine();

            }

        }
    }
}