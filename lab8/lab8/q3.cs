using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Students
{
    public string name, address, clz;
    public Students(string n, string a, string c)
    {
        name = n;
        address = a;
        clz = c;
    }
}
public class q3
{
    static void Main(string[] args)
    {
        List<Students> l = new List<Students>();
        l.Add(new Students("sunita", "butwal", "pmc"));
        l.Add(new Students("anu", "kritipur", "pmc"));
        l.Add(new Students("mana", "pokhara", "pk"));

        var res = l.Where(s => s.address == "kritipur" && s.clz == "pmc");
        foreach (var r in res)
        {
            Console.WriteLine(r.name + " from " + r.address + " studied at " + r.clz);
        }
        Console.ReadKey();
    }
}

