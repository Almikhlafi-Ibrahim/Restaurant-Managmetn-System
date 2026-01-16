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
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.Configuration;

namespace Restaurant_Managmetn_System
{
    public partial class UserConInvetnroy: UserControl
    {
        readonly string connString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;

        public UserConInvetnroy()
        {
            InitializeComponent();
            displayCategories();
            dislplayProcuct();
        }

        void displayCategories()
        {
            comBoxCategory.Items.Clear();




            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string SelectString = "Select * from categories";

                using (SqlCommand cmd = new SqlCommand(SelectString, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comBoxCategory.Items.Add(reader["category"]);
                    }
                }

            }
            
        }
        private void UserConInvetnroy_Load(object sender, EventArgs e)
        {
            

        }

        private void dislplayProcuct()
        {
            clsproductList pList = new clsproductList();

            List<clsproductList> listDate = pList.productListDate();

            dataGridView2.DataSource = listDate;

        }

        private void btn_inventroy_import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg, *.png|*.jpg;*.png)";
                string imgPathe = "";

                if (dialog.ShowDialog ()== DialogResult.OK)
                {
                    imgPathe = dialog.FileName;
                    pictureBox1.ImageLocation = imgPathe;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erroer Message ");
            }
        }

        private void btnInventoryAdd_Click(object sender, EventArgs e)
        {

            if (  string.IsNullOrEmpty(txtProductId.Text)||string.IsNullOrEmpty(txtPrice.Text) ||
                string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtStock.Text) ||
                string.IsNullOrEmpty(comBoxCategory.Text) || string.IsNullOrEmpty(cobBoxSatus.Text) ||
                   pictureBox1.Image == null )
            {
                MessageBox.Show("Epty Fields", "Erroes Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connect = new SqlConnection(connString))

            {
                connect.Open();
                string checkProductId = "Select * from products where productid = @prodid";


                using (SqlCommand Ckeckid = new SqlCommand(checkProductId, connect))
                {

                    try
                    {
                        Ckeckid.Parameters.AddWithValue("@prodid", txtProductId.Text.Trim());
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(Ckeckid);
                        DataTable table = new DataTable();

                        dataAdapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            MessageBox.Show($"{txtProductId.Text.Trim()} is existing already", "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                            string insertData = @"insert into products (productid , productname , category , stock , price , status , imge, date_insert)
                                        Values (@prodid ,@prodname, @cat, @stock , @price , @status,@img, @date ) ";

                            string relavtPateh = Path.Combine("products_Directory", txtProductId.Text.Trim() + ".jpg");

                            string path = Path.Combine(baseDirectory, relavtPateh);

                            string directoryPath = Path.GetDirectoryName(path);


                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(pictureBox1.ImageLocation, path, true);

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@prodid", txtProductId.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodname", txtProductName.Text.Trim());
                                cmd.Parameters.AddWithValue("@cat", comBoxCategory.Text.Trim());
                                cmd.Parameters.AddWithValue("@stock", txtStock.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", txtPrice.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", cobBoxSatus.Text.Trim());
                                cmd.Parameters.AddWithValue("@img", path);


                                DateTime today = DateTime.Now; 
                                cmd.Parameters.AddWithValue("@date", today .ToString());

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Added Successfully");
                                ClearFileds();
                                dislplayProcuct();
                            }

                        }
                    }

                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                 
                }


               
            
            }

        }

        void ClearFileds()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            comBoxCategory.SelectedIndex= -1;
            txtStock.Clear();
            txtPrice.Clear();
            cobBoxSatus.SelectedIndex = -1;
            pictureBox1.Image = null;
            getID = 0;
        }

        private int getID = 0;
        private void btnInventoryClear_Click(object sender, EventArgs e)
        {
            ClearFileds();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                txtProductId.Text = row.Cells[0].Value.ToString();
                txtProductName.Text = row.Cells[1].Value.ToString();
                comBoxCategory.Text = row.Cells[2].Value.ToString();
                txtStock.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
                cobBoxSatus.Text = row.Cells[5].Value.ToString();

                string  imagePath = row.Cells[6].Value.ToString();

                try
                {
                    if (imagePath  != null )
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error : {ex} ", "Erroor Message");
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInventoryUpdate_Click(object sender, EventArgs e)
        {
            if (getID ==0)
            {
                MessageBox.Show("Empty Fielsds ", "Wrroer Message");
                return;
            }

            using (SqlConnection connect = new SqlConnection(connString))
            {
                connect.Open();
                string CheckProductId = "Select * from products where productid = @prodid";

                using (SqlCommand check = new SqlCommand(CheckProductId , connect))
                {

                    int id  =Convert.ToInt32 ( txtProductId.Text.Trim());
                    check.Parameters.AddWithValue("@prodid", id);

                    SqlDataAdapter addapt = new SqlDataAdapter(check);
                    DataTable table = new DataTable();
                    addapt.Fill(table);
                    if (table.Rows.Count >=2)
                    {
                        MessageBox.Show(txtProductId.Text + " Already Exitst ");
                    }
                    else {
                
                        string updateDate = @"update products set productid = @prodId  ,productname = @proname  , category  = @cat, stock = @stock
                            , price = @price , status= @status , imge= @imge  , date_update = @date2 where productid = @p1 ";

                        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                        string relavtPateh = Path.Combine("products_Directory", txtProductId.Text.Trim() + ".jpg");

                        string path = Path.Combine(baseDirectory, relavtPateh);

                        string directoryPath = Path.GetDirectoryName(path);


                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        //File.Copy(pictureBox1.ImageLocation, path, true);

                        using ( SqlCommand comd = new SqlCommand (updateDate, connect))
                        {
                            comd.Parameters.AddWithValue("@prodId", txtProductId.Text.Trim());
                            comd.Parameters.AddWithValue("@proname", txtProductName.Text.Trim());
                            comd.Parameters.AddWithValue("@cat", comBoxCategory.Text.Trim());
                            comd.Parameters.AddWithValue("@stock", txtStock.Text.Trim());
                            comd.Parameters.AddWithValue("@status", cobBoxSatus.Text.Trim());
                            comd.Parameters.AddWithValue("@price", txtPrice .Text.Trim());
                            comd.Parameters.AddWithValue("@imge",path);

                            comd.Parameters.AddWithValue("@p1",getID);


                            DateTime today = DateTime.Now;
                            comd.Parameters.AddWithValue("@date2", today.ToString());


                            comd.ExecuteNonQuery();
                            MessageBox.Show("Added Successfully");
                            ClearFileds();
                            dislplayProcuct();

                        }


                            }
                }
            }
        }

        private void btnInventoryDelete_Click(object sender, EventArgs e)
        {
        
            if (getID == 0)
            {
                MessageBox.Show("Empty Fielsds ", "Wrroer Message");
                return;
            }

            using (SqlConnection connect = new SqlConnection(connString))
            {
                connect.Open();
                string CheckProductId = "Select * from products where productid = @prodid";

                using (SqlCommand check = new SqlCommand(CheckProductId, connect))
                {

                    int id = Convert.ToInt32(txtProductId.Text.Trim());
                    check.Parameters.AddWithValue("@prodid", id);

                    SqlDataAdapter addapt = new SqlDataAdapter(check);
                    DataTable table = new DataTable();
                    addapt.Fill(table);
                    if (table.Rows.Count >= 2)
                    {
                        MessageBox.Show("Id  does not Exist");
                    }
                    else
                    {


                        string deletString = "Delete from products where productid = @id";
                        using (SqlCommand comd = new SqlCommand(deletString, connect))
                        {

                            comd.Parameters.AddWithValue("@id", getID);


                         
                            comd.ExecuteNonQuery();
                            MessageBox.Show("Deleted  Successfully");
                            ClearFileds();
                            dislplayProcuct();

                        }


                    }
                }
            }
        

    }
}
}
