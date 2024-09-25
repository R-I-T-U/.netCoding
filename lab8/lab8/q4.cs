using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class q4
{
    static void Main(string[] args)
    {
        int[] arr = { 14, 2, 6, 7, 90 };
        int sum = arr.Sum();
        int min = arr.Min();
        int max = arr.Max();
        int count = arr.Count();
        double avg = arr.Average();
        Console.WriteLine("sum is " + sum);
        Console.WriteLine("maximum no. is " + max);
        Console.WriteLine("minimum no. is " + min);
        Console.WriteLine("total count is " + count);
        Console.WriteLine("average is " + avg);
        Console.ReadKey();
    }
}

