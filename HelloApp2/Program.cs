using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name}");
            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine($"your {age}");

        }
    }
}
