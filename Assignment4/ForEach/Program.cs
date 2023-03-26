using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment4.Program;

namespace Assignment4
{
    internal class Program
    {
        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Data { get; set; }
            public Node(T t)
            {
                Next = null;
                Data = t;
            }
        }

        public class GenericList<T>
        {
            private Node<T> head;
            private Node<T> tail;

            public GenericList()
            {
                tail = head = null;
            }
            public Node<T> Head
            {
                get => head;
            }
            public void Add(T t)
            {
                Node<T> n = new Node<T>(t);
                if (tail == null)
                {
                    head = tail = n;
                }
                else
                {
                    tail.Next = n;
                    tail = n;
                }
            }
            public void ForEach(Action<T> action)
            {
                Node<T> temp = this.head;
                while (temp != null)
                {
                    action(temp.Data);
                    temp = temp.Next;
                }
            }

        }

        delegate double Funct(GenericList<int> genericList);
        
        
        static void Main(string[] args)
        {
            GenericList<int> genericList = new GenericList<int>();
            int n = 0;
            string s = "";
            Console.Write("请输入链表的长度:");
            s = Console.ReadLine();
            n = int.Parse(s);
            for (int i = 0; i < n; i++) {
                int t = 0;
                string st = "";
                Console.Write("");
                st = Console.ReadLine();
                t = int.Parse(st);
                genericList.Add(t);
            }

            int r = genericList.Head.Data;

            //打印链表
            //Action<int> print = (m => Console.WriteLine(m));
            //genericList.ForEach(print);

            //求最大值
            int max = r;
            genericList.ForEach(m => max = max > m ? max : m);
            Console.WriteLine("最大值为{0}", max);

            //求最小值
            int min = r;
            genericList.ForEach(m => min = min < m ? min : m);
            Console.WriteLine("最小值为{0}", min);

            //求和
            int sum = 0;
            genericList.ForEach(m => sum += m);
            Console.WriteLine("和为{0}", sum);


        }
    }
}
