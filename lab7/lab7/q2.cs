using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
public class q2
{
        public delegate int squareDel(int x);
        public static void Main(string[] args)
        {
            squareDel del = delegate (int x)
            {
                return x * x;
            };
            Console.WriteLine("using anonymous method: square is " + del(2));
            squareDel del2 = x => x * x;
            Console.WriteLine("using lamda exp: square is "+del2(3));
            Console.ReadKey();

        }
}

