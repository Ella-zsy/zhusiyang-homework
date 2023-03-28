using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public class Order
    {
        public string order_id { get; set; }

        public string order_price { get; set; }

        public Clients clients = new Clients();

        public OrderDetails orderDetails = new OrderDetails();

        public string Client_name => clients.client_name;
        public string Goods_name => orderDetails.Goods_name;
        public string Goods_number => orderDetails.Goods_number;

        public OrderService orderService = new OrderService();

        public override bool Equals(object obj)
        {
            Order m = obj as Order;
            return m != null && m.order_id == order_id && m.Client_name == clients.client_name
            && m.order_price == order_price;
        }

        public override string ToString()
        {
            return "订单编号:" + order_id + "客户姓名:" + Client_name + "订单金额:" + order_price+"商品名称:" + Goods_name + " 商品数量:" + Goods_number;
        }
    }
}
