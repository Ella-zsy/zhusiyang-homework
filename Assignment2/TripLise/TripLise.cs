using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    internal class TripLise
    {
        static bool TripLise1(int m,int n, int[,] a){
            int k = a[0,0];
            int x = 1;
            for (int i = 1; i < m; i++)
            {
                if (a[i,i] != k)
                    break;
                else
                    x++;
            }

            if (x == m)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            string s = "";
            int m = 0;
            int n = 0;
            Console.Write("请输入矩阵的行数:");
            s = Console.ReadLine();
            m = int.Parse(s);
            Console.Write("请输入矩阵的列数:");
            s = Console.ReadLine();
            n = int.Parse(s);
            int[,] a = new int[m,n];
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    string r = "";
                    int p = 0;
                    Console.Write("");
                    r = Console.ReadLine();
                    p = int.Parse(r);
                    a[i,j] = p;
                }
            }

            TripLise1(m, n, a);
            

        }
    }
}
