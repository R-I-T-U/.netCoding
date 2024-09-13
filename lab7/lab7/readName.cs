using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{

    public class LengthException : ApplicationException
    {
        public LengthException(string msg) : base(msg) { }
    }
    public class readName
    {
        public static void Main()
        {
            try
            {
                Console.Write("enter your name: ");
                string n = Console.ReadLine();
              
                if (n.Length<10)
                {
                    Console.WriteLine("hello! " + n);
                }
                else
                {
                    throw (new LengthException("name is too long!"));
                }
            }
            catch (LengthException ex)
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
