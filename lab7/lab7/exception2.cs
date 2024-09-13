using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class exception2
    {
        public static void Main()
        {
            try
            {
                int[] arr = { 1, 2, 20 };
                Console.WriteLine(arr[6]);
            }
            catch (IndexOutOfRangeException ex)
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
