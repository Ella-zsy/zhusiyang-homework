namespace Assignment6
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchOrder = new System.Windows.Forms.Button();
            this.InputKeywords = new System.Windows.Forms.TextBox();
            this.SelectItems = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ImportOrder = new System.Windows.Forms.Button();
            this.ExportOrder = new System.Windows.Forms.Button();
            this.DelectOrder = new System.Windows.Forms.Button();
            this.ChangeOrder = new System.Windows.Forms.Button();
            this.AddOrder = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.showOrders = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showdetails = new System.Windows.Forms.DataGridView();
            this.Details = new System.Windows.Forms.BindingSource(this.components);
            this.detailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orders = new System.Windows.Forms.BindingSource(this.components);
            this.indexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsItemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.货物名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.SearchOrder);
            this.panel1.Controls.Add(this.InputKeywords);
            this.panel1.Controls.Add(this.SelectItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 51);
            this.panel1.TabIndex = 0;
            // 
            // SearchOrder
            // 
            this.SearchOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchOrder.Location = new System.Drawing.Point(738, 12);
            this.SearchOrder.Name = "SearchOrder";
            this.SearchOrder.Size = new System.Drawing.Size(120, 30);
            this.SearchOrder.TabIndex = 2;
            this.SearchOrder.Text = "查询";
            this.SearchOrder.UseVisualStyleBackColor = true;
            this.SearchOrder.Click += new System.EventHandler(this.SearchOrder_Click);
            // 
            // InputKeywords
            // 
            this.InputKeywords.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.InputKeywords.Location = new System.Drawing.Point(465, 12);
            this.InputKeywords.Name = "InputKeywords";
            this.InputKeywords.Size = new System.Drawing.Size(236, 28);
            this.InputKeywords.TabIndex = 1;
            this.InputKeywords.TextChanged += new System.EventHandler(this.InputKeywords_TextChanged);
            // 
            // SelectItems
            // 
            this.SelectItems.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SelectItems.FormattingEnabled = true;
            this.SelectItems.Items.AddRange(new object[] {
            "全部订单",
            "ID",
            "客户名",
            "货物名",
            "价格大于"});
            this.SelectItems.Location = new System.Drawing.Point(315, 12);
            this.SelectItems.Name = "SelectItems";
            this.SelectItems.Size = new System.Drawing.Size(121, 26);
            this.SelectItems.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ImportOrder);
            this.panel2.Controls.Add(this.ExportOrder);
            this.panel2.Controls.Add(this.DelectOrder);
            this.panel2.Controls.Add(this.ChangeOrder);
            this.panel2.Controls.Add(this.AddOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1257, 59);
            this.panel2.TabIndex = 1;
            // 
            // ImportOrder
            // 
            this.ImportOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ImportOrder.Location = new System.Drawing.Point(916, 6);
            this.ImportOrder.Name = "ImportOrder";
            this.ImportOrder.Size = new System.Drawing.Size(128, 37);
            this.ImportOrder.TabIndex = 4;
            this.ImportOrder.Text = "导入订单";
            this.ImportOrder.UseVisualStyleBackColor = true;
            this.ImportOrder.Click += new System.EventHandler(this.ImportOrder_Click);
            // 
            // ExportOrder
            // 
            this.ExportOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExportOrder.Location = new System.Drawing.Point(765, 6);
            this.ExportOrder.Name = "ExportOrder";
            this.ExportOrder.Size = new System.Drawing.Size(128, 37);
            this.ExportOrder.TabIndex = 3;
            this.ExportOrder.Text = "导出订单";
            this.ExportOrder.UseVisualStyleBackColor = true;
            this.ExportOrder.Click += new System.EventHandler(this.ExportOrder_Click);
            // 
            // DelectOrder
            // 
            this.DelectOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DelectOrder.Location = new System.Drawing.Point(615, 6);
            this.DelectOrder.Name = "DelectOrder";
            this.DelectOrder.Size = new System.Drawing.Size(128, 37);
            this.DelectOrder.TabIndex = 2;
            this.DelectOrder.Text = "删除订单";
            this.DelectOrder.UseVisualStyleBackColor = true;
            this.DelectOrder.Click += new System.EventHandler(this.DelectOrder_Click);
            // 
            // ChangeOrder
            // 
            this.ChangeOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ChangeOrder.Location = new System.Drawing.Point(465, 6);
            this.ChangeOrder.Name = "ChangeOrder";
            this.ChangeOrder.Size = new System.Drawing.Size(128, 37);
            this.ChangeOrder.TabIndex = 1;
            this.ChangeOrder.Text = "修改订单";
            this.ChangeOrder.UseVisualStyleBackColor = true;
            this.ChangeOrder.Click += new System.EventHandler(this.ChangeOrder_Click);
            // 
            // AddOrder
            // 
            this.AddOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddOrder.Location = new System.Drawing.Point(314, 6);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(128, 37);
            this.AddOrder.TabIndex = 0;
            this.AddOrder.Text = "添加订单";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 110);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.showOrders);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.showdetails);
            this.splitContainer1.Size = new System.Drawing.Size(1257, 454);
            this.splitContainer1.SplitterDistance = 619;
            this.splitContainer1.TabIndex = 4;
            // 
            // showOrders
            // 
            this.showOrders.AutoGenerateColumns = false;
            this.showOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.totalPriceDataGridViewTextBoxColumn,
            this.OrderId,
            this.CustomerName,
            this.CreateTime});
            this.showOrders.DataSource = this.Orders;
            this.showOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showOrders.Location = new System.Drawing.Point(0, 0);
            this.showOrders.Name = "showOrders";
            this.showOrders.RowHeadersWidth = 62;
            this.showOrders.RowTemplate.Height = 30;
            this.showOrders.Size = new System.Drawing.Size(619, 454);
            this.showOrders.TabIndex = 0;
            this.showOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showOrders_CellContentClick);
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.HeaderText = "订单号";
            this.OrderId.MinimumWidth = 8;
            this.OrderId.Name = "OrderId";
            this.OrderId.Width = 150;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "客户姓名";
            this.CustomerName.MinimumWidth = 8;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 150;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "下单时间";
            this.CreateTime.MinimumWidth = 8;
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.Width = 150;
            // 
            // showdetails
            // 
            this.showdetails.AutoGenerateColumns = false;
            this.showdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn1,
            this.goodsItemDataGridViewTextBoxColumn1,
            this.货物名称,
            this.单价});
            this.showdetails.DataSource = this.Details;
            this.showdetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showdetails.Location = new System.Drawing.Point(0, 0);
            this.showdetails.Name = "showdetails";
            this.showdetails.RowHeadersWidth = 62;
            this.showdetails.RowTemplate.Height = 30;
            this.showdetails.Size = new System.Drawing.Size(634, 454);
            this.showdetails.TabIndex = 0;
            // 
            // Details
            // 
            this.Details.DataSource = this.detailsBindingSource2;
            // 
            // detailsBindingSource2
            // 
            this.detailsBindingSource2.DataMember = "Details";
            this.detailsBindingSource2.DataSource = this.Orders;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "Details";
            this.detailsBindingSource.DataSource = this.Orders;
            // 
            // detailsBindingSource1
            // 
            this.detailsBindingSource1.DataMember = "Details";
            this.detailsBindingSource1.DataSource = this.Orders;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // Orders
            // 
            this.Orders.DataSource = typeof(OrderApp.Order);
            // 
            // indexDataGridViewTextBoxColumn1
            // 
            this.indexDataGridViewTextBoxColumn1.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn1.HeaderText = "序号";
            this.indexDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.indexDataGridViewTextBoxColumn1.Name = "indexDataGridViewTextBoxColumn1";
            this.indexDataGridViewTextBoxColumn1.Width = 150;
            // 
            // goodsItemDataGridViewTextBoxColumn1
            // 
            this.goodsItemDataGridViewTextBoxColumn1.DataPropertyName = "GoodsItem";
            this.goodsItemDataGridViewTextBoxColumn1.HeaderText = "货物数量";
            this.goodsItemDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.goodsItemDataGridViewTextBoxColumn1.Name = "goodsItemDataGridViewTextBoxColumn1";
            this.goodsItemDataGridViewTextBoxColumn1.Width = 150;
            // 
            // 货物名称
            // 
            this.货物名称.DataPropertyName = "GoodsName";
            this.货物名称.HeaderText = "货物名称";
            this.货物名称.MinimumWidth = 8;
            this.货物名称.Name = "货物名称";
            this.货物名称.ReadOnly = true;
            this.货物名称.Width = 150;
            // 
            // 单价
            // 
            this.单价.DataPropertyName = "UnitPrice";
            this.单价.HeaderText = "单价";
            this.单价.MinimumWidth = 8;
            this.单价.Name = "单价";
            this.单价.ReadOnly = true;
            this.单价.Width = 150;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderApp.Order);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 564);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "订单管理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ImportOrder;
        private System.Windows.Forms.Button ExportOrder;
        private System.Windows.Forms.Button DelectOrder;
        private System.Windows.Forms.Button ChangeOrder;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox SelectItems;
        private System.Windows.Forms.Button SearchOrder;
        private System.Windows.Forms.TextBox InputKeywords;
        private System.Windows.Forms.DataGridView showOrders;
        private System.Windows.Forms.DataGridView showdetails;
        private System.Windows.Forms.BindingSource Details;
        private System.Windows.Forms.BindingSource Orders;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource detailsBindingSource2;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private System.Windows.Forms.BindingSource detailsBindingSource1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsItemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 货物名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价;
    }
}

