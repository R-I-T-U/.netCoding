using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Person
    {
        public void msg(string n, double op, double np)
        {
            Console.WriteLine("stock of "+n," is ",np," from "+op);
        }
    }
    public delegate void PriceChanged(String n, double op, double np);
    public class stockTicker
    {
        public event PriceChanged pc;
        private double price;
        private string stockName;
        public stockTicker(string n, double ip)
        {
            stockName = n;
            price = ip;
        }
        public string name
        {
            get { return stockName; }
        }
        public double Price
        {
            get { return price; }
            set {
                double op = price;
                price = value;
                if(pc != null) 
                    pc(stockName,op,price);
            }
        }

    }
    public class eventHandling
    {
        static void Main()
        {
            Person p = new Person();
            stockTicker s = new stockTicker("ritu",600);
            s.pc += p.msg;
            s.Price = 700;
            s.Price = 500;
            Console.ReadKey();

        }
    }
}
