using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int n = 0;
            Console.Write("请输入数组大小:");
            s = Console.ReadLine();
            n = int.Parse(s);

            int[] a1;
            a1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                string r = "";
                int m = 0;
                Console.Write("");
                r = Console.ReadLine();
                m = int.Parse(r);
                a1[i] = m;
            }

            Console.WriteLine("最大值为{0}", a1.Max());
            Console.WriteLine("最小值为{0}", a1.Min());
            Console.WriteLine("平均值为{0}", a1.Average());
        }
    }
}
