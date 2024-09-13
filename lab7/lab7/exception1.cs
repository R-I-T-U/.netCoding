using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class exception1
    {
        public static void Main()
        {
            try
            {
                Console.Write("enter num:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("enter denum:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException ex)
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
