using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class exception3
    {
        public static void Main()
        {
            try
            {
                object obj = 90;
                int n = (byte) obj;
                Console.WriteLine(n);
            }
            catch (InvalidCastException ex)
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
