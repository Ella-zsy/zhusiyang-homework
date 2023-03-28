using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public class OrderService
    {
        new List<Order> orders;

        public void order_by_id(List<Order> orders)
        {
            var query = orders
                .OrderBy(m => m.order_id);
            foreach(Order m in query)
            {
                m.ToString();
            }
        }

        public List<Order> ChangeOrder(List<Order> orders,Order order)
        {
            var changeorder = from n in orders
                              where n.order_id == order.order_id
                              select n;
            if (changeorder == null)
            {
                Console.WriteLine("找不到需要修改的订单");
            }
            else
            {
                orders.Remove(changeorder.First());
                orders.Add(order);
            }
            return orders;
        }

        public List<Order> AddOrder(List<Order> orders, Order order)
        {
            foreach (Order m in orders)
            {
                if (m.Equals(order))
                {
                    Console.WriteLine("添加的订单已存在");
                    return orders;
                }
            }
            orders.Add(order);
            return orders;
        }

        public List<Order> DeleteOrder(List<Order> orders, Order order)
        {
            var delete_order = from n in orders
                               where n == order
                               select n;
            if (delete_order==null)
            {
                Console.WriteLine("删除订单失败");
            }
            else
            {
                orders.Remove(order);
            }
            return orders;
        }

        public void GetOrders(List<Order> orders)
        {
            string s = "";
            Console.WriteLine("请选择订单查询方式");
            s=Console.ReadLine();

            switch (s)
            {
                case "订单号":
                    string t0 = "";
                    Console.WriteLine("请输入订单号");
                    t0 = Console.ReadLine();
                    var query0 = orders
                        .Where(m => m.order_id == t0)
                        .OrderBy(m => m.order_price);
                    foreach(Order m in query0)
                    {
                        m.ToString();
                    }
                    break;
                case "商品名称":
                    string t1 = "";
                    Console.WriteLine("请输入商品名称");
                    t1 = Console.ReadLine();
                    var query1 = orders
                        .Where(m => m.Goods_name == t1)
                        .OrderBy(m => m.order_price);
                    foreach (Order m in query1)
                    {
                        m.ToString();
                    }
                    break;
                case "客户":
                    string t2 = "";
                    Console.WriteLine("请输入客户姓名");
                    t2 = Console.ReadLine();
                    var query2 = orders
                        .Where(m => m.Client_name == t2)
                        .OrderBy(m => m.order_price);
                    foreach (Order m in query2)
                    {
                        m.ToString();
                    }
                    break;
                case "订单金额":
                    string t3 = "";
                    Console.WriteLine("请输入订单金额");
                    t3 = Console.ReadLine();
                    var query3 = orders
                        .Where(m => m.order_price == t3)
                        .OrderBy(m => m.order_price);
                    foreach (Order m in query3)
                    {
                        m.ToString();
                    }
                    break;
            }
        }


    }
}
