namespace Restaurant_Managmetn_System
{
    partial class frmMainForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCatogres = new System.Windows.Forms.Button();
            this.btnCustoer = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControlAboutUs2 = new Restaurant_Managmetn_System.UserControlAboutUs();
            this.userCnCustomer1 = new Restaurant_Managmetn_System.userCnCustomer();
            this.userConCatogry1 = new Restaurant_Managmetn_System.UserConCatogry();
            this.userConInvetnroy1 = new Restaurant_Managmetn_System.UserConInvetnroy();
            this.userCoShop1 = new Restaurant_Managmetn_System.userCoShop();
            this.userControlDashBord1 = new Restaurant_Managmetn_System.UserControlDashBord();
            this.userControlDashBord2 = new Restaurant_Managmetn_System.UserControlDashBord();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1282, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 35);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurant Mangmetn System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnCatogres);
            this.panel2.Controls.Add(this.btnCustoer);
            this.panel2.Controls.Add(this.btnInventory);
            this.panel2.Controls.Add(this.btnShop);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 727);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(15, 679);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(228, 36);
            this.button5.TabIndex = 2;
            this.button5.Text = "LogOut";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCatogres
            // 
            this.btnCatogres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnCatogres.FlatAppearance.BorderSize = 0;
            this.btnCatogres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.btnCatogres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.btnCatogres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatogres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCatogres.ForeColor = System.Drawing.Color.White;
            this.btnCatogres.Location = new System.Drawing.Point(15, 397);
            this.btnCatogres.Name = "btnCatogres";
            this.btnCatogres.Size = new System.Drawing.Size(228, 36);
            this.btnCatogres.TabIndex = 2;
            this.btnCatogres.Text = "Catogeries";
            this.btnCatogres.UseVisualStyleBackColor = false;
            this.btnCatogres.Click += new System.EventHandler(this.btnCatogres_Click);
            // 
            // btnCustoer
            // 
            this.btnCustoer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnCustoer.FlatAppearance.BorderSize = 0;
            this.btnCustoer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.btnCustoer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.btnCustoer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustoer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCustoer.ForeColor = System.Drawing.Color.White;
            this.btnCustoer.Location = new System.Drawing.Point(15, 461);
            this.btnCustoer.Name = "btnCustoer";
            this.btnCustoer.Size = new System.Drawing.Size(228, 36);
            this.btnCustoer.TabIndex = 2;
            this.btnCustoer.Text = "Customers";
            this.btnCustoer.UseVisualStyleBackColor = false;
            this.btnCustoer.Click += new System.EventHandler(this.btnCustoer_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(15, 342);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(228, 36);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.btnShop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShop.ForeColor = System.Drawing.Color.White;
            this.btnShop.Location = new System.Drawing.Point(15, 279);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(228, 36);
            this.btnShop.TabIndex = 2;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(15, 224);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(228, 36);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(83, 142);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(122, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcom Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Managmetn_System.Properties.Resources.icons8_user_1001;
            this.pictureBox1.Location = new System.Drawing.Point(94, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.userControlDashBord2);
            this.panel3.Controls.Add(this.userControlAboutUs2);
            this.panel3.Controls.Add(this.userCnCustomer1);
            this.panel3.Controls.Add(this.userConCatogry1);
            this.panel3.Controls.Add(this.userConInvetnroy1);
            this.panel3.Controls.Add(this.userCoShop1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(257, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1085, 727);
            this.panel3.TabIndex = 3;
            // 
            // userControlAboutUs2
            // 
            this.userControlAboutUs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userControlAboutUs2.Location = new System.Drawing.Point(0, 0);
            this.userControlAboutUs2.Name = "userControlAboutUs2";
            this.userControlAboutUs2.Size = new System.Drawing.Size(1082, 724);
            this.userControlAboutUs2.TabIndex = 5;
            // 
            // userCnCustomer1
            // 
            this.userCnCustomer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userCnCustomer1.Location = new System.Drawing.Point(0, 0);
            this.userCnCustomer1.Name = "userCnCustomer1";
            this.userCnCustomer1.Size = new System.Drawing.Size(1085, 727);
            this.userCnCustomer1.TabIndex = 4;
            // 
            // userConCatogry1
            // 
            this.userConCatogry1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userConCatogry1.Location = new System.Drawing.Point(0, 0);
            this.userConCatogry1.Name = "userConCatogry1";
            this.userConCatogry1.Size = new System.Drawing.Size(1085, 727);
            this.userConCatogry1.TabIndex = 3;
            // 
            // userConInvetnroy1
            // 
            this.userConInvetnroy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userConInvetnroy1.Location = new System.Drawing.Point(0, 0);
            this.userConInvetnroy1.Name = "userConInvetnroy1";
            this.userConInvetnroy1.Size = new System.Drawing.Size(1085, 727);
            this.userConInvetnroy1.TabIndex = 2;
            // 
            // userCoShop1
            // 
            this.userCoShop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userCoShop1.Location = new System.Drawing.Point(0, -3);
            this.userCoShop1.Name = "userCoShop1";
            this.userCoShop1.Size = new System.Drawing.Size(1085, 727);
            this.userCoShop1.TabIndex = 1;
            // 
            // userControlDashBord1
            // 
            this.userControlDashBord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userControlDashBord1.Location = new System.Drawing.Point(0, -3);
            this.userControlDashBord1.Name = "userControlDashBord1";
            this.userControlDashBord1.Size = new System.Drawing.Size(1085, 727);
            this.userControlDashBord1.TabIndex = 0;
            // 
            // userControlDashBord2
            // 
            this.userControlDashBord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userControlDashBord2.Location = new System.Drawing.Point(0, -3);
            this.userControlDashBord2.Name = "userControlDashBord2";
            this.userControlDashBord2.Size = new System.Drawing.Size(1085, 730);
            this.userControlDashBord2.TabIndex = 6;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 762);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainForm";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnCatogres;
        private System.Windows.Forms.Button btnCustoer;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel panel3;
        private UserControlDashBord userControlDashBord1;

        private userCoShop userCoShop1;
        private UserConInvetnroy userConInvetnroy1;
        private UserConCatogry userConCatogry1;
        private userCnCustomer userCnCustomer1;
        private System.Windows.Forms.Button button1;
        //private UserControlAboutUs userControlAboutUs1;
        private UserControlAboutUs userControlAboutUs2;
        private UserControlDashBord userControlDashBord2;
    }
}