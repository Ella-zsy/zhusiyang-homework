using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OrderManagementSystem;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class OrderService_test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Order order0 = new Order();
            order0.order_id = "01";
            order0.clients.client_name = "yuyu";
            order0.orderDetails.goods.goods_name = "glasses";
            order0.orderDetails.goods_number = "1";
            order0.order_price = "500";
            Order order1 = new Order();
            order1.order_id = "02";
            order1.clients.client_name = "zsy";
            order1.orderDetails.goods.goods_name = "watches";
            order1.orderDetails.goods_number = "2";
            order1.order_price = "50000";

            //添加订单单元测试
            //List<Order> array = null;
            //array.Add(order0);
            //List<Order> result = null;
            //result.Add(order0);
            //result.Add(order1);
            //OrderService orderService = new OrderService();
            //orderService.AddOrder(array,order1);
            //Assert.AreEqual(array, result);

            //修改订单单元测试
            //Order order2 = new Order();
            //order2.order_id = "02";
            //order2.clients.client_name = "zsy";
            //order2.orderDetails.goods.goods_name = "watches";
            //order2.orderDetails.goods_number = "1";
            //List<Order> array = null;
            //array.Add(order0);
            //array.Add(order1);
            //List<Order> result = null;
            //result.Add(order0);
            //result.Add(order2);
            //OrderService orderService = new OrderService();
            //orderService.ChangeOrder(array,order2);
            //Assert.AreEqual(array, result);

            //删除单元测试
            List<Order> array = null;
            array.Add(order0);
            array.Add(order1);
            List<Order> result = null;
            result.Add(order0);
            OrderService orderService = new OrderService();
            orderService.DeleteOrder(array,order1);
            Assert.AreEqual(array, result);

        }
    }
}
