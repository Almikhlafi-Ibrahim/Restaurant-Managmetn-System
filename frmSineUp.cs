using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace Restaurant_Managmetn_System
{
    public partial class frmSineUp: Form
    {

        //string connString = @"Data Source=IbrahimPc\NAME2;
        //                    Initial Catalog=A1Restaurant;
        //                    Integrated Security=True;
        //                    Connect Timeout=30;Encrypt=False
        //                  ";
        readonly string connString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;

        public frmSineUp()
        {
            InitializeComponent();
        }

        private void lblNoAcount_Click(object sender, EventArgs e)
        {

          Form1 form = new Form1();
            this.Hide(); // Hide the current form
            form.Show(); // Show the Form1
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
            txtConfirmPassowrd.PasswordChar = chkShowPassword.Checked ? '\0' : '*';

        }

        private void btnSineIN_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string SlectQure = "Select * from users where username =@usern";

                using (SqlCommand myCommand =new SqlCommand(SlectQure ,conn))
                {
                    myCommand.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());

                    SqlDataAdapter dataAdap = new SqlDataAdapter(myCommand);
                    DataTable dataTable1 = new DataTable() ;
                    dataAdap.Fill(dataTable1);

                    if(dataTable1.Rows.Count >0)
                    {
                        MessageBox.Show($"{txtUsername.Text.Trim()} was aready Takcen ", "Errore Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else if (txtPassword.Text.Trim() != txtConfirmPassowrd.Text.Trim())
                    {
                        MessageBox.Show($"Passwor Must Match", "Errore Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if(txtPassword.Text.Trim().Length <8)
                    {
                        MessageBox.Show($"Invalid Password, at least 8 characters required.", "Error Massage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        string insertDate = "insert into users (username ,password, status,date_created) values (@usern ,@pass, @status ,@date)";
                        using (SqlCommand myCommand2 = new SqlCommand(insertDate, conn))
                        {
                            myCommand2.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());
                            myCommand2.Parameters.AddWithValue("@pass", txtConfirmPassowrd.Text.Trim());
                            myCommand2.Parameters.AddWithValue("@status", "Active");
                            DateTime dateTime =  DateTime.Now;


                            myCommand2.Parameters.AddWithValue("@date", dateTime.ToString());

                            //int n = (int)myCommand2.Exno;
                            int n = Convert.ToInt32(myCommand2.ExecuteScalar());
                            if (n > 1) MessageBox.Show("Rigister Successfully!" , "!Information Message" ,MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                            Form1 formq = new Form1();
                            formq.Show();
                            this.Hide();

                        }
                    }



                }

                conn.Close();
            }

        }
    }
}
