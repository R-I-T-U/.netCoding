using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class app9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The prime elements are: ");
            int[] arr = { 3,7,8,9,12,13 };

            foreach (int i in arr)
            {
                int flag = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        flag++;
                    }
                }

                if (flag == 2)
                {
                    Console.WriteLine(i + " ");
                }

                flag = 0;
            }
        }
    }
}
