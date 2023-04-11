using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace Assignment6
{
    public partial class FormMain : Form
    {
        OrderService orderService = new OrderService();

        public event Action<FormEdit> ShowEditForm;//定义打开一个新窗口的方法
        public String Keyword { get; set; }

        public FormMain()
        {
            InitializeComponent();
            InitOrders();//对订单进行初始化
            Orders.DataSource = orderService.GetAllOrders();//订单更新时重新获取所有的订单
            SelectItems.SelectedIndex = 0;//下拉条目的初始状态是编号为0的条目
            InputKeywords.DataBindings.Add("Text", this, "Keyword");//数据绑定
            ShowEditForm += (f => { });
        }

        private void InitOrders()
        {
            Order order = new Order(1, new Customer("1", "yuyu"), new List<OrderDetail>());
            order.AddItem(new OrderDetail(1, new Goods("1", "glasses", 100.0), 1));
            order.AddItem(new OrderDetail(2, new Goods("2", "watches", 500.0), 1));
            orderService.AddOrder(order);
            Order order2 = new Order(2, new Customer("2", "zhusiyang"), new List<OrderDetail>());
            order2.AddItem(new OrderDetail(1, new Goods("2", "watches", 500.0), 2));
            orderService.AddOrder(order2);
        }

        //每次对订单进行修改后对所有订单进行更新并进行数据绑定
        public void QueryAll()
        {
            Orders.DataSource = orderService.GetAllOrders();
            Orders.ResetBindings(false);
        }

        //修改订单的函数
        private void EditOrder()
        {
            Order order = Orders.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            FormEdit form2 = new FormEdit(order, true, orderService);
            ShowEditForm(form2);
        }


        private void listBox1_Orders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Orders_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void InputKeywords_TextChanged(object sender, EventArgs e)
        {

        }

        //点击添加订单按钮，新建一个FormEdit窗口并显示进行操作
        private void AddOrder_Click(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit(new Order(), false, orderService);
            ShowEditForm(formEdit);
        }

        //点击修改订单按钮，执行修改订单的函数
        private void ChangeOrder_Click(object sender, EventArgs e)
        {
            EditOrder();
        }

        //点击删除订单按钮
        private void DelectOrder_Click(object sender, EventArgs e)
        {
            Order order = Orders.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            DialogResult result = MessageBox.Show($"确认要删除Id为{order.OrderId}的订单吗？", "删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                orderService.RemoveOrder(order.OrderId);
                QueryAll();//重新更新订单系统并进行数据绑定
            }
        }

        //点击导出订单按钮，新建文件夹
        private void ExportOrder_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String fileName = saveFileDialog1.FileName;
                orderService.Export(fileName);
            }
        }

        //点击导入订单按钮，选择导入的文件
        private void ImportOrder_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String fileName = openFileDialog1.FileName;
                orderService.Import(fileName);
                QueryAll();
            }
        }

        //点击查询按钮
        private void SearchOrder_Click(object sender, EventArgs e)
        {
            try
            {
                switch (SelectItems.SelectedIndex)
                {
                    case 0://所有订单
                        Orders.DataSource = orderService.GetAllOrders();
                        break;
                    case 1://根据ID查询
                        int id = Convert.ToInt32(Keyword);
                        Order order = orderService.GetOrder(id);
                        List<Order> result = new List<Order>();
                        if (order != null) result.Add(order);
                        Orders.DataSource = result;
                        break;
                    case 2://根据客户查询
                        Orders.DataSource = orderService.QueryOrdersByCustomerName(Keyword);
                        break;
                    case 3://根据货物查询
                        Orders.DataSource = orderService.QueryOrdersByGoodsName(Keyword);
                        break;
                    case 4://根据总价格查询（大于某个总价）
                        float totalPrice = Convert.ToInt32(Keyword);
                        Orders.DataSource =
                               orderService.QueryByTotalAmount(totalPrice);
                        break;
                }
                Orders.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //点击showOrders里的订单进行选中
        private void showOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditOrder();
        }
    }
}
