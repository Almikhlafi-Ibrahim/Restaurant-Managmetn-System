using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace Restaurant_Managmetn_System
{
    public partial class Form1: Form
    {
        string connString = @"Data Source=IbrahimPc\NAME2;
                            Initial Catalog=A1Restaurant;
                            Integrated Security=True;
                            Connect Timeout=30;Encrypt=False
                          ";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?","Exit Confirmation", MessageBoxButtons.YesNo , MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblNoAcount_Click(object sender, EventArgs e)
        {
            frmSineUp frmSineUp = new frmSineUp();
            this.Hide(); // Hide the current form
            frmSineUp.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ////tem 
            ////MessageBox.Show($"Wellcome {txtUsername.Text.Trim()}good to go press ok to continue");
            //frmMainForm maainFomr = new frmMainForm();
            //this.Hide();
            //maainFomr.Show();

            
              using (SqlConnection conn = new SqlConnection(connString)) 
              {



                      conn.Open();
                      string qure = "Select * from users where username=@userName and password=@Password";

                  using (SqlCommand myCommnd = new SqlCommand(qure, conn))
                  {

                      myCommnd.Parameters.AddWithValue("@userName", txtUsername.Text.Trim());
                      myCommnd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                      SqlDataAdapter dataAdapter = new SqlDataAdapter(myCommnd);
                      DataTable MyTable = new DataTable();
                      dataAdapter.Fill(MyTable);

                      if(MyTable.Rows.Count >0)
                      {
                          MessageBox.Show($"Wellcome {txtUsername.Text.Trim()}good to go press ok to continue");
                          frmMainForm maainFomr = new frmMainForm();
                          this.Hide();
                          maainFomr.Show();

                      }
                      else
                      {
                          MessageBox.Show("Your are not registerd  ");

                      }


                  }

              }

              

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0': '*' ;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
