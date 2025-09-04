using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Restaurant_Managmetn_System
{
    public partial class UserConCatogry: UserControl
    {
        string connString = @"Data Source=IbrahimPc\NAME2;
                            Initial Catalog=A1Restaurant;
                            Integrated Security=True;
                            Connect Timeout=30;Encrypt=False
                          ";
        public UserConCatogry()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string slectStrin = "Select * from categories where category = @cat";

                using (SqlCommand sqlCommand = new SqlCommand(slectStrin ,conn))
                {
                    sqlCommand.Parameters.AddWithValue("@cat", txtCatotry.Text.Trim());

                    SqlDataAdapter dataAdapter = new  SqlDataAdapter(sqlCommand);
                    DataTable dateTable1 = new DataTable();
                    dataAdapter.Fill(dateTable1);

                    if (dateTable1.Rows.Count > 1)
                    {
                        MessageBox.Show($"{txtCatotry.Text.Trim()} Already Exixt" ,"Warangin");
                    }
                    else 
                    {
                        string insrtStirn = "insert into categories ";
                        conn.Close();
                    }

                }
            }
        }
    }
}
