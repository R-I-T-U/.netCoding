using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace hm
{
    public class Employee
    {
        public string name, address;
        public Employee(string n, string a)
        {
            name = n;
            address = a;
        }
    }
    public class q2
    {
        static void Main(string[] args)
        {
            List<Employee> l = new List<Employee>();
            l.Add(new Employee("samridi", "butwal"));
            l.Add(new Employee("roshani", "ktm"));
            l.Add(new Employee("ramila", "pokhara"));

            var res = l.OrderByDescending(e => e.name);
            Console.WriteLine("Employee in descending order wrt name are:");
            foreach (var e in res)
            {
                Console.WriteLine(e.name);
            }
            Console.ReadKey();
        }
    }
}
