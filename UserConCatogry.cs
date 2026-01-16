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
using System.Configuration;

namespace Restaurant_Managmetn_System
{
    public partial class UserConCatogry : UserControl
    {
        readonly string connString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;

        public UserConCatogry()
        {
            InitializeComponent();
            displayCategories();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtCatotry.Text) || String.IsNullOrEmpty(comboBoxStatus.Text))
            {
                MessageBox.Show("Catagorey and Statust Cant be Null ");
                return;
            }



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

                    if (dateTable1.Rows.Count > 0)
                    {
                        MessageBox.Show($"{txtCatotry.Text.Trim()} Already Exixt" ,"Warangin");
                    }
                    else 
                    {
                        string insrtStirn = "insert into categories (category, status, date_inserted ) values (@cat ,@state, @date)";

                        using (SqlCommand sqlcom = new SqlCommand(insrtStirn, conn))
                        {
                            try
                            {

                                sqlcom.Parameters.AddWithValue("@cat", txtCatotry.Text.Trim());
                                sqlcom.Parameters.AddWithValue("@state", comboBoxStatus.Text.Trim());
                                DateTime date = DateTime.Now;
                                sqlcom.Parameters.AddWithValue("@date", date.ToString());


                                sqlcom.ExecuteNonQuery();

                                MessageBox.Show("Added Successfully ", "inforatin Message", MessageBoxButtons.OK);




                            }
                            catch (SqlException ss)
                            {
                                MessageBox.Show(ss.Message);
                            }



                            //sqlcom.Parameters.AddWithValue("@date", comboBoxStatus.Text.Trim());


                        }


                            conn.Close();

                        _clear();



                    }

                }
            }
                        displayCategories();
        }


        void _clear()
        {
            txtCatotry.Clear();
            comboBoxStatus.Text = "";
            getID = 0;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            _clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtCatotry.Text) || String.IsNullOrEmpty(comboBoxStatus.Text))
            {
                MessageBox.Show("Catagorey and Statust Cant be Null ");
                return;
            }

            if (getID == 0)
            {
                MessageBox.Show("Select Item First ", "Erroer Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
           


            using (SqlConnection conn = new SqlConnection(connString))

            {
                conn.Open();
                string slectStrin = "Select * from categories where category = @cat";

                using (SqlCommand sqlCommand = new SqlCommand(slectStrin, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@cat", txtCatotry.Text.Trim());

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dateTable1 = new DataTable();
                    dataAdapter.Fill(dateTable1);

                    if (dateTable1.Rows.Count > 0)
                    {
                        MessageBox.Show($"{txtCatotry.Text.Trim()} Already Exixt", "Warangin");
                    }
                    else
                    {

                 
                        string insrtStirn = "update  categories set  category = @cat , status = @stat , date_inserted = @date where id =@id ";

                        using (SqlCommand sqlcom = new SqlCommand(insrtStirn, conn))
                        {
                            try
                            {

                                sqlcom.Parameters.AddWithValue("@cat", txtCatotry.Text.Trim());
                                sqlcom.Parameters.AddWithValue("@stat", comboBoxStatus.Text.Trim());
                                sqlcom.Parameters.AddWithValue("@id", getID);
                                DateTime date = DateTime.Now;
                                sqlcom.Parameters.AddWithValue("@date", date.ToString());


                                sqlcom.ExecuteNonQuery();

                                MessageBox.Show("Updated  Successfully ", "inforatin Message", MessageBoxButtons.OK , MessageBoxIcon.Information);




                            }
                            catch (SqlException ss)
                            {
                                MessageBox.Show(ss.Message);
                            }



                            //sqlcom.Parameters.AddWithValue("@date", comboBoxStatus.Text.Trim());


                        }


                        conn.Close();

                        _clear();



                    }

                }
            }
            displayCategories();
        }


        public void  displayCategories()
        {
            categoriesList cData = new categoriesList();

            List<categoriesList> listDate = cData.categoriesListDate();

            dataGridView1.DataSource = listDate;
            
        }

        private void UserConCatogry_Load(object sender, EventArgs e)
        {
             
        }
        
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                txtCatotry.Text = row.Cells[1].Value.ToString();
                comboBoxStatus.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCatotry.Text) || String.IsNullOrEmpty(comboBoxStatus.Text))
            {
                MessageBox.Show("Catagorey and Statust Cant be Null ");
                return;
            }

            if (getID == 0)
            {
                MessageBox.Show("Select Item First ", "Erroer Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            using (SqlConnection conn = new SqlConnection(connString))

            {
                conn.Open();
                string DeletString = "delete categories where id =@id";

              

                        using (SqlCommand sqlcom = new SqlCommand(DeletString, conn))
                        {
                            try
                            {
                                sqlcom.Parameters.AddWithValue("@id", getID);
                                sqlcom.ExecuteNonQuery();
                                MessageBox.Show("Deletec   Successfully ", "inforatin Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (SqlException ss)
                            {
                                MessageBox.Show(ss.Message);
                            }

                        }
                        conn.Close();

                        _clear();
                    }

                
            
            displayCategories();

        }
    }
}
