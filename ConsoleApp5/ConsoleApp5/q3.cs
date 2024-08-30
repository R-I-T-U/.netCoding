// write a c# program to create property and indexer.
using System;

namespace q3
{

    class Student
    {
        private string[] sub = new string[5];
        public string Name { get; set; }

        public string this[int index]
        {
            set
            {
                if (index >= 0 && index < sub.Length)
                {
                    sub[index] = value; 
                }
            }
            get
            {
                if (index >= 0 && index < sub.Length)
                {
                    return sub[index];
                }
                else
                {
                    return null;
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Student s = new Student(); 

            s.Name = "ritu";

            s[0] = "Networking";
            s[1] = "Dotnet Technology";
            s[2] = "MIS";
            s[3] = "Management";
            s[4] = "Computer Graphics";

            Console.WriteLine("Name: " + s.Name);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {s[i]}");
            }
            Console.ReadKey();
        }
    }
}
