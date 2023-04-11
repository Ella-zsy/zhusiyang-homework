using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class FormEdit : Form
    {
        private OrderService orderService;

        //获取编辑模型
        public bool EditModel { get; set; }

        //实例化为当前选中的订单
        public Order CurrentOrder { get; set; }

        //关闭编辑页面
        public event Action<FormEdit> CloseEditFrom;
        public FormEdit(Order order, bool model, OrderService orderService)
        {
            InitializeComponent();
            CloseEditFrom += (f => { });
            //向Customers中导入两项数据项
            Customers.Add(new Customer("1", "yuyu"));
            Customers.Add(new Customer("2", "zhusiyang"));
            this.orderService = orderService;
            this.EditModel = model;

            //TODO 如果想实现不点保存只关窗口后订单不变化，需要把order深克隆给CurrentOrder
            this.CurrentOrder = order;
            Orders.DataSource = CurrentOrder;
            orderid.Enabled = !model;
        }


        //点击添加项的按钮
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //异常处理
            FormDetailEdit formItemEdit = new FormDetailEdit(new OrderDetail());
            try
            {
                if (formItemEdit.ShowDialog() == DialogResult.OK)
                {
                    int index = 0;
                    if (CurrentOrder.Details.Count != 0)
                    {
                        index = CurrentOrder.Details.Max(i => i.Index) + 1;
                    }
                    formItemEdit.Detail.Index = index;
                    CurrentOrder.AddItem(formItemEdit.Detail);
                    Details.ResetBindings(false);//数据绑定
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        //点击保存按钮
        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO 加上订单合法性验证
            try
            {
                if (this.EditModel)
                {
                    orderService.UpdateOrder(CurrentOrder);
                }
                else
                {
                    orderService.AddOrder(CurrentOrder);
                }
                CloseEditFrom(this);
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }

        }


        //编辑订单明细
        private void EditDetail()
        {
            OrderDetail detail = Details.Current as OrderDetail;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单项进行修改");
                return;
            }
            FormDetailEdit formDetailEdit = new FormDetailEdit(detail);
            if (formDetailEdit.ShowDialog() == DialogResult.OK)
            {
                Details.ResetBindings(false);//数据绑定
            }
        }

        //点击删除项目按钮
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            OrderDetail detail = Details.Current as OrderDetail;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单项进行删除");
                return;
            }
            CurrentOrder.RemoveDetail(detail);
            Details.ResetBindings(false);//数据绑定
        }
    }
}
