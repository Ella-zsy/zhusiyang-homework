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
    public partial class FormParents : Form
    {
        FormMain formMain = new FormMain();
        public FormParents()
        {
            InitializeComponent();
        }

        

        private void ShowMainForm()
        {
            this.orderMainLink.Enabled = false;
            this.orderEditLink.Visible = false;
            showFormInPanel(formMain);
            formMain.QueryAll();
        }


        private void ShowEditForm(FormEdit formEdit)
        {
            this.orderMainLink.Enabled = true;
            this.orderEditLink.Visible = true;
            this.orderEditLink.Text = formEdit.EditModel ? "修改订单" : "添加订单";
            formEdit.CloseEditFrom += (form => ShowMainForm());
            showFormInPanel(formEdit);
        }


        private void showFormInPanel(Form from)
        {
            this.content.SuspendLayout();
            this.content.Controls.Clear();
            from.TopLevel = false;
            from.FormBorderStyle = FormBorderStyle.None;
            from.Dock = DockStyle.Fill;
            from.Visible = true;
            this.content.Controls.Add(from);
            this.content.ResumeLayout();
        }

        private void orderMainLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowMainForm();
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormParents_Load(object sender, EventArgs e)
        {
            formMain.ShowEditForm += this.ShowEditForm;
            ShowMainForm();
        }
    }
}
