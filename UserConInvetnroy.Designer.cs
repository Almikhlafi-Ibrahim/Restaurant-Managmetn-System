namespace Restaurant_Managmetn_System
{
    partial class UserConInvetnroy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comBoxCatogry = new System.Windows.Forms.Panel();
            this.btnInventoryUpdate = new System.Windows.Forms.Button();
            this.btnInventoryAdd = new System.Windows.Forms.Button();
            this.btnInventoryDelete = new System.Windows.Forms.Button();
            this.btnInventoryClear = new System.Windows.Forms.Button();
            this.btn_inventroy_import = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cobBoxSatus = new System.Windows.Forms.ComboBox();
            this.comBoxCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.comBoxCatogry.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 385);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(17, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 26;
            this.dataGridView2.Size = new System.Drawing.Size(1019, 319);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Sales";
            // 
            // comBoxCatogry
            // 
            this.comBoxCatogry.BackColor = System.Drawing.Color.White;
            this.comBoxCatogry.Controls.Add(this.btnInventoryUpdate);
            this.comBoxCatogry.Controls.Add(this.btnInventoryAdd);
            this.comBoxCatogry.Controls.Add(this.btnInventoryDelete);
            this.comBoxCatogry.Controls.Add(this.btnInventoryClear);
            this.comBoxCatogry.Controls.Add(this.btn_inventroy_import);
            this.comBoxCatogry.Controls.Add(this.panel3);
            this.comBoxCatogry.Controls.Add(this.cobBoxSatus);
            this.comBoxCatogry.Controls.Add(this.comBoxCategory);
            this.comBoxCatogry.Controls.Add(this.label7);
            this.comBoxCatogry.Controls.Add(this.label4);
            this.comBoxCatogry.Controls.Add(this.txtPrice);
            this.comBoxCatogry.Controls.Add(this.txtProductName);
            this.comBoxCatogry.Controls.Add(this.label6);
            this.comBoxCatogry.Controls.Add(this.label3);
            this.comBoxCatogry.Controls.Add(this.txtStock);
            this.comBoxCatogry.Controls.Add(this.label5);
            this.comBoxCatogry.Controls.Add(this.txtProductId);
            this.comBoxCatogry.Controls.Add(this.label2);
            this.comBoxCatogry.Location = new System.Drawing.Point(15, 431);
            this.comBoxCatogry.Name = "comBoxCatogry";
            this.comBoxCatogry.Size = new System.Drawing.Size(1052, 275);
            this.comBoxCatogry.TabIndex = 1;
            // 
            // btnInventoryUpdate
            // 
            this.btnInventoryUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnInventoryUpdate.FlatAppearance.BorderSize = 0;
            this.btnInventoryUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.btnInventoryUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.btnInventoryUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryUpdate.ForeColor = System.Drawing.Color.White;
            this.btnInventoryUpdate.Location = new System.Drawing.Point(354, 207);
            this.btnInventoryUpdate.Name = "btnInventoryUpdate";
            this.btnInventoryUpdate.Size = new System.Drawing.Size(125, 49);
            this.btnInventoryUpdate.TabIndex = 11;
            this.btnInventoryUpdate.Text = "UPDATE";
            this.btnInventoryUpdate.UseVisualStyleBackColor = false;
            this.btnInventoryUpdate.Click += new System.EventHandler(this.btnInventoryUpdate_Click);
            // 
            // btnInventoryAdd
            // 
            this.btnInventoryAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnInventoryAdd.FlatAppearance.BorderSize = 0;
            this.btnInventoryAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.btnInventoryAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.btnInventoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryAdd.ForeColor = System.Drawing.Color.White;
            this.btnInventoryAdd.Location = new System.Drawing.Point(33, 207);
            this.btnInventoryAdd.Name = "btnInventoryAdd";
            this.btnInventoryAdd.Size = new System.Drawing.Size(125, 49);
            this.btnInventoryAdd.TabIndex = 9;
            this.btnInventoryAdd.Text = "ADD";
            this.btnInventoryAdd.UseVisualStyleBackColor = false;
            this.btnInventoryAdd.Click += new System.EventHandler(this.btnInventoryAdd_Click);
            // 
            // btnInventoryDelete
            // 
            this.btnInventoryDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnInventoryDelete.FlatAppearance.BorderSize = 0;
            this.btnInventoryDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.btnInventoryDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.btnInventoryDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryDelete.ForeColor = System.Drawing.Color.White;
            this.btnInventoryDelete.Location = new System.Drawing.Point(550, 207);
            this.btnInventoryDelete.Name = "btnInventoryDelete";
            this.btnInventoryDelete.Size = new System.Drawing.Size(125, 49);
            this.btnInventoryDelete.TabIndex = 12;
            this.btnInventoryDelete.Text = "DELETE";
            this.btnInventoryDelete.UseVisualStyleBackColor = false;
            this.btnInventoryDelete.Click += new System.EventHandler(this.btnInventoryDelete_Click);
            // 
            // btnInventoryClear
            // 
            this.btnInventoryClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnInventoryClear.FlatAppearance.BorderSize = 0;
            this.btnInventoryClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.btnInventoryClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.btnInventoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryClear.ForeColor = System.Drawing.Color.White;
            this.btnInventoryClear.Location = new System.Drawing.Point(195, 207);
            this.btnInventoryClear.Name = "btnInventoryClear";
            this.btnInventoryClear.Size = new System.Drawing.Size(125, 49);
            this.btnInventoryClear.TabIndex = 10;
            this.btnInventoryClear.Text = "CLEAER";
            this.btnInventoryClear.UseVisualStyleBackColor = false;
            this.btnInventoryClear.Click += new System.EventHandler(this.btnInventoryClear_Click);
            // 
            // btn_inventroy_import
            // 
            this.btn_inventroy_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btn_inventroy_import.FlatAppearance.BorderSize = 0;
            this.btn_inventroy_import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.btn_inventroy_import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.btn_inventroy_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventroy_import.ForeColor = System.Drawing.Color.White;
            this.btn_inventroy_import.Location = new System.Drawing.Point(892, 165);
            this.btn_inventroy_import.Name = "btn_inventroy_import";
            this.btn_inventroy_import.Size = new System.Drawing.Size(115, 45);
            this.btn_inventroy_import.TabIndex = 0;
            this.btn_inventroy_import.Text = "Import";
            this.btn_inventroy_import.UseVisualStyleBackColor = false;
            this.btn_inventroy_import.Click += new System.EventHandler(this.btn_inventroy_import_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(892, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 119);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cobBoxSatus
            // 
            this.cobBoxSatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cobBoxSatus.FormattingEnabled = true;
            this.cobBoxSatus.Items.AddRange(new object[] {
            "Avalaible",
            "Inavalaible"});
            this.cobBoxSatus.Location = new System.Drawing.Point(505, 131);
            this.cobBoxSatus.Name = "cobBoxSatus";
            this.cobBoxSatus.Size = new System.Drawing.Size(238, 28);
            this.cobBoxSatus.TabIndex = 7;
            // 
            // comBoxCategory
            // 
            this.comBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comBoxCategory.FormattingEnabled = true;
            this.comBoxCategory.Location = new System.Drawing.Point(128, 136);
            this.comBoxCategory.Name = "comBoxCategory";
            this.comBoxCategory.Size = new System.Drawing.Size(238, 28);
            this.comBoxCategory.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Catogry:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrice.Location = new System.Drawing.Point(495, 91);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(238, 26);
            this.txtPrice.TabIndex = 5;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProductName.Location = new System.Drawing.Point(128, 90);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(238, 26);
            this.txtProductName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Name:";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStock.Location = new System.Drawing.Point(495, 48);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(238, 26);
            this.txtStock.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Stock";
            // 
            // txtProductId
            // 
            this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProductId.Location = new System.Drawing.Point(128, 41);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(238, 26);
            this.txtProductId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product ID:";
            // 
            // UserConInvetnroy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comBoxCatogry);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "UserConInvetnroy";
            this.Size = new System.Drawing.Size(1085, 727);
            this.Load += new System.EventHandler(this.UserConInvetnroy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.comBoxCatogry.ResumeLayout(false);
            this.comBoxCatogry.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel comBoxCatogry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBoxCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobBoxSatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_inventroy_import;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInventoryUpdate;
        private System.Windows.Forms.Button btnInventoryAdd;
        private System.Windows.Forms.Button btnInventoryDelete;
        private System.Windows.Forms.Button btnInventoryClear;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
