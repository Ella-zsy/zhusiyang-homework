namespace Assignment6
{
    partial class FormParents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.orderMainLink = new System.Windows.Forms.LinkLabel();
            this.orderEditLink = new System.Windows.Forms.LinkLabel();
            this.content = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.orderMainLink);
            this.flowLayoutPanel1.Controls.Add(this.orderEditLink);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 46);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // orderMainLink
            // 
            this.orderMainLink.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.orderMainLink.AutoSize = true;
            this.orderMainLink.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orderMainLink.Location = new System.Drawing.Point(3, 0);
            this.orderMainLink.Name = "orderMainLink";
            this.orderMainLink.Size = new System.Drawing.Size(96, 28);
            this.orderMainLink.TabIndex = 0;
            this.orderMainLink.TabStop = true;
            this.orderMainLink.Text = "订单管理";
            this.orderMainLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.orderMainLink_LinkClicked);
            // 
            // orderEditLink
            // 
            this.orderEditLink.AutoSize = true;
            this.orderEditLink.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orderEditLink.LinkColor = System.Drawing.Color.Black;
            this.orderEditLink.Location = new System.Drawing.Point(105, 0);
            this.orderEditLink.Name = "orderEditLink";
            this.orderEditLink.Size = new System.Drawing.Size(96, 28);
            this.orderEditLink.TabIndex = 1;
            this.orderEditLink.TabStop = true;
            this.orderEditLink.Text = "添加订单";
            // 
            // content
            // 
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 46);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(800, 404);
            this.content.TabIndex = 1;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // FormParents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.content);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormParents";
            this.Text = "FormParents";
            this.Load += new System.EventHandler(this.FormParents_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel orderMainLink;
        private System.Windows.Forms.LinkLabel orderEditLink;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel content;
    }
}