using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class PrimeNums
    {
        static void Main(string[] args)
        {
            int[] a;
            a = new int[99];
            for (int i = 2; i <= 100; i++)
            {
                a[i-2] = i;
            }

            for (int q = 2; q <= 50; q++)
            {
                for (int j = q-1; j < 99; j++)
                {
                    if (a[j] % q == 0)
                        a[j] = 0;
                }
            }

            for (int i = 0; i <= 99; i++)
            {
                if (a[i] != 0)
                    Console.WriteLine("{0}", a[i]);
            }
        }
    }
}
