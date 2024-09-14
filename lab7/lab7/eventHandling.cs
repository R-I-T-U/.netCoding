using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Person
    {
        public void display(String name, double op, double np)
        {
            Console.WriteLine("The stock of " +
                name + " is changed to " + np + " from " + op);
        }
    }
    public delegate void priceChanged(string name, double op, double np);
    public class stockTicker
    {
        public event priceChanged pc;
        public string name { get; set; }
        public double price;
        public double Price
        {
            get { return price; }
            set
            {
                double oldprice = price;
                price = value;
                if (pc != null)
                {
                    pc(name, oldprice, price);
                }

            }

        }

    }
    public class eventHandling
    {
        private static string name;

        public static int Price { get; private set; }

        public static void Main(string[] args)
{
    Person p = new Person();
    stockTicker s = new stockTicker();
    
    s.name = "Sunrise";
    s.Price = 900;
    
    s.pc += p.display;
    
    s.Price = 1000;
    s.Price = 1500;

    Console.ReadKey();
}

    }
}