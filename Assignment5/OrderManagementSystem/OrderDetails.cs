using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public class OrderDetails
    {
        public Goods goods = new Goods();
        public string goods_number { get; set; }

        public string Goods_name => goods.goods_name;
        public string Goods_number => goods_number;

        public override bool Equals(object obj)
        {
            Order m = obj as Order;
            return m != null && m.Goods_name == Goods_name && m.Goods_number == Goods_number;
        }

    }
}
