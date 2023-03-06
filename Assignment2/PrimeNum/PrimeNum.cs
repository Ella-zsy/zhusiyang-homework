using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class PrimeNum
    {
        static void PrimeNum1(int m)
        {
            int j;
            for (j = 2; j < m; j++)
            {
                if (m % j == 0)
                    break;
            }
            if (j == m)
                Console.WriteLine(j);
        }
        static void Main(string[] args)
        {
            string s = "";
            int n = 0;
            Console.Write("请输入一个数:");
            s = Console.ReadLine();
            n = int.Parse(s);
            
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    PrimeNum1(i);
                }

            }
        }
    }
}
