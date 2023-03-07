using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    internal class Program
    {
        static void calculator(int a, string p, int b)
        {
            if (p == "+")
                Console.WriteLine($"a+b={a + b}");
            if (p == "-")
                Console.WriteLine($"a-b={a - b}");
            if (p == "*")
                Console.WriteLine($"a*b={a * b}");
            if (p == "/")
                Console.WriteLine($"a/b={a / b}");
        }
        static void Main(string[] args)
        {
            string s = "";
            string p = "";
            int a = 0;
            int b = 0;
            Console.Write("Please input an number:");
            s = Console.ReadLine();
            a = int.Parse(s);

            Console.Write("Please input an operator:");
            p = Console.ReadLine();

            Console.Write("Please input an number:");
            s = Console.ReadLine();
            b = int.Parse(s);

            calculator(a, p, b);

        }
    }
}
