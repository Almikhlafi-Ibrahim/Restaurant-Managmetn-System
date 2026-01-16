namespace Restaurant_Managmetn_System
{
    partial class userCoShop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userCoShop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopRecpientBtn = new System.Windows.Forms.Button();
            this.shop_placeOrderbtn = new System.Windows.Forms.Button();
            this.shop_change = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shop_amount = new System.Windows.Forms.Label();
            this.shop_total = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(19, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 701);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(602, 683);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.shopRecpientBtn);
            this.panel2.Controls.Add(this.shop_placeOrderbtn);
            this.panel2.Controls.Add(this.shop_change);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.shop_amount);
            this.panel2.Controls.Add(this.shop_total);
            this.panel2.Controls.Add(this.show);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(656, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 701);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ProdName,
            this.QTY,
            this.Price});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(12, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 26;
            this.dataGridView2.Size = new System.Drawing.Size(384, 312);
            this.dataGridView2.TabIndex = 6;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // shopRecpientBtn
            // 
            this.shopRecpientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.shopRecpientBtn.FlatAppearance.BorderSize = 0;
            this.shopRecpientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.shopRecpientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.shopRecpientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopRecpientBtn.ForeColor = System.Drawing.Color.White;
            this.shopRecpientBtn.Location = new System.Drawing.Point(38, 639);
            this.shopRecpientBtn.Name = "shopRecpientBtn";
            this.shopRecpientBtn.Size = new System.Drawing.Size(353, 47);
            this.shopRecpientBtn.TabIndex = 5;
            this.shopRecpientBtn.Text = "RECEPIENT";
            this.shopRecpientBtn.UseVisualStyleBackColor = false;
            this.shopRecpientBtn.Click += new System.EventHandler(this.shopRecpientBtn_Click);
            // 
            // shop_placeOrderbtn
            // 
            this.shop_placeOrderbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.shop_placeOrderbtn.FlatAppearance.BorderSize = 0;
            this.shop_placeOrderbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.shop_placeOrderbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.shop_placeOrderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shop_placeOrderbtn.ForeColor = System.Drawing.Color.White;
            this.shop_placeOrderbtn.Location = new System.Drawing.Point(38, 499);
            this.shop_placeOrderbtn.Name = "shop_placeOrderbtn";
            this.shop_placeOrderbtn.Size = new System.Drawing.Size(353, 47);
            this.shop_placeOrderbtn.TabIndex = 5;
            this.shop_placeOrderbtn.Text = "PLACE ORDER";
            this.shop_placeOrderbtn.UseVisualStyleBackColor = false;
            this.shop_placeOrderbtn.Click += new System.EventHandler(this.shop_placeOrderbtn_Click);
            // 
            // shop_change
            // 
            this.shop_change.Location = new System.Drawing.Point(261, 433);
            this.shop_change.Name = "shop_change";
            this.shop_change.Size = new System.Drawing.Size(130, 23);
            this.shop_change.TabIndex = 4;
            this.shop_change.TextChanged += new System.EventHandler(this.shop_change_TextChanged);
            this.shop_change.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shop_change_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(196, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Change";
            // 
            // shop_amount
            // 
            this.shop_amount.AutoSize = true;
            this.shop_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.shop_amount.Location = new System.Drawing.Point(259, 466);
            this.shop_amount.Name = "shop_amount";
            this.shop_amount.Size = new System.Drawing.Size(24, 18);
            this.shop_amount.TabIndex = 2;
            this.shop_amount.Text = "00";
            // 
            // shop_total
            // 
            this.shop_total.AutoSize = true;
            this.shop_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.shop_total.Location = new System.Drawing.Point(259, 399);
            this.shop_total.Name = "shop_total";
            this.shop_total.Size = new System.Drawing.Size(24, 18);
            this.shop_total.TabIndex = 2;
            this.shop_total.Text = "00";
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.show.Location = new System.Drawing.Point(196, 466);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(59, 18);
            this.show.TabIndex = 1;
            this.show.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(196, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total($)";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // userCoShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "userCoShop";
            this.Size = new System.Drawing.Size(1085, 727);
            this.Load += new System.EventHandler(this.userCoShop_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label shop_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button shop_placeOrderbtn;
        private System.Windows.Forms.TextBox shop_change;
        private System.Windows.Forms.Label shop_amount;
        private System.Windows.Forms.Label show;
        private System.Windows.Forms.Button shopRecpientBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
