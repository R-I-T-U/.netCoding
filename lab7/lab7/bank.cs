using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class BalanceException : ApplicationException
    {
        public BalanceException(string msg):base(msg) { }
    }
    public class bank
    {
        public static void Main()
        {
            try
            {
                Console.Write("enter balance: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("enter withdraw amt: ");
                int w = int.Parse(Console.ReadLine());
                if (b > w)
                {
                    b -= w;
                    Console.WriteLine("remaining balance: "+b);
                }
                else
                {
                    throw (new BalanceException("Balance is too low"));
                }
            }
            catch (BalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("the end");
            }
            Console.ReadKey();
        }
    }
}
