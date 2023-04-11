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
    public partial class FormDetailEdit : Form
    {
        //获取订单明细
        public OrderDetail Detail { get; set; }
        public FormDetailEdit()
        {
            InitializeComponent();
        }
        //向Detail中导入两项数据
        public FormDetailEdit(OrderDetail detail) : this()
        {
            this.Detail = detail;
            this.Details.DataSource = detail;
            Goods.Add(new Goods("1", "glasses", 100.0));
            Goods.Add(new Goods("2", "watches", 500.0));
        }
    }
}
