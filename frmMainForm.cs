using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Managmetn_System
{
    public partial class frmMainForm: Form
    {
        public frmMainForm()
        {
            InitializeComponent();
            userControlAboutUs2.Visible = false;

        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Conformation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout?", "Conformation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Form1 from = new Form1();
                this.Hide();
                from.Show();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            userControlDashBord2.Visible = true;




            userCoShop1.Visible = false;
            userConInvetnroy1.Visible = false;
            userConCatogry1.Visible = false;
            userCnCustomer1.Visible = false;
            userControlAboutUs2.Visible = false;



        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            userControlDashBord2.Visible = false;
            userCoShop1.Visible = true;
            userConInvetnroy1.Visible = false;
            userConCatogry1.Visible = false;
            userCnCustomer1.Visible = false;
            userControlAboutUs2.Visible = false;


        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            userControlDashBord2.Visible = false;
            userCoShop1.Visible = false;
            userConInvetnroy1.Visible = true;
            userConCatogry1.Visible = false;
            userCnCustomer1.Visible = false;
            userControlAboutUs2.Visible = false;


        }

        private void btnCatogres_Click(object sender, EventArgs e)
        {
            userControlDashBord2.Visible = false;
            userCoShop1.Visible = false;
            userConInvetnroy1.Visible = false;
            userConCatogry1.Visible = true;
            userCnCustomer1.Visible = false;
            userControlAboutUs2.Visible = false;


        }

        private void btnCustoer_Click(object sender, EventArgs e)
        {
            userControlDashBord2.Visible = false;
            userCoShop1.Visible = false;
            userConInvetnroy1.Visible = false;
            userConCatogry1.Visible = false;
            userCnCustomer1.Visible = true;
            userControlAboutUs2.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControlDashBord2.Visible = false;
            userCoShop1.Visible = false;
            userConInvetnroy1.Visible = false;
            userConCatogry1.Visible = false;
            userCnCustomer1.Visible = false;
            userControlAboutUs2.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
