using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Collections.Specialized;
using System.Configuration;


namespace Restaurant_Managmetn_System
{
    public partial class userCoShop: UserControl
    {
        public userCoShop()
        {
            InitializeComponent();
            loadProducts();
        }
        //string connString = @"Server=IbrahimPc\NAME2;
        //                     Database=A1Restaurant;
        //                    Integrated Security=True;
        //                  ";
        readonly string connString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void cardItems(int id, string productname, string stock, string price, Image image, string category, string Quanttiy)
        {
            var card = new UserControlProductCard()

            {
                productId = id,
                productName = productname,
                ProductStock = stock,
                ProductPrice = price,
                productImage = image,
                Category = category,
                productQuantity = Quanttiy,

            };
            flowLayoutPanel1.Controls.Add(card);


            card.selectCard += (q, w) =>
            {
                var selectedCArd = (UserControlProductCard)q;
                bool flag = false;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["id"].Value != null && (int)row.Cells["id"].Value == selectedCArd.productId)
                    {
                        decimal getPrice = Convert.ToDecimal(selectedCArd.ProductPrice.Replace("$", ""));
                        int getQuantiy = Convert.ToInt32(selectedCArd.productQuantity);
                  
                        row.Cells["QTY"].Value = selectedCArd.productQuantity;
                        row.Cells["Price"].Value = getPrice * getQuantiy;


                        updateTotalPrice();

                        flag = true;
                        return;
                    }

                }

                if (!flag)
                {
                    decimal getPrice = Convert.ToDecimal(selectedCArd.ProductPrice.Replace("$", ""));
                    int getQuantiy = Convert.ToInt32(selectedCArd.productQuantity);
                    dataGridView2.Rows.Add(selectedCArd.productId, selectedCArd.productName ,getQuantiy , getPrice * getQuantiy);
                }

                updateTotalPrice();
            };

        
        }

        private void updateTotalPrice()
        {
            decimal totalPrice = 0;
            

            foreach(DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["id"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                    totalPrice += price;
                }
            }

            shop_total.Text = $"${totalPrice:F2}";
        }

        //public void loadProducts()
        //{
        //    try
        //    {

        //        using (SqlConnection conn  = new SqlConnection (connString))
        //        {
        //            conn.Open();
        //            string seleData = "Select * from products";

        //            using (SqlCommand cmd = new SqlCommand(seleData, conn))
        //            {
        //                SqlDataAdapter add = new SqlDataAdapter(cmd);
        //                DataTable table = new DataTable();


        //                add.Fill(table);

        //                flowLayoutPanel1.Controls.Clear();

        //                foreach(DataRow row in table.Rows)
        //                {
        //                    int id = row["productid"] != DBNull.Value ? (int)row["productid"] : 0;
        //                    string  productName = row["productname"] != DBNull.Value ? row["productname"] .ToString(): "N/A";
        //                    string  Stock = row["stock"] != DBNull.Value ? row["Stock"] .ToString(): "0";
        //                    //string quantiy = row[""]
        //                    string  Price = row["price"] != DBNull.Value ? $"${row["price"] .ToString()}.00": "0.00";
        //                    string Catogry = row["category"] != DBNull.Value ? row["category"] .ToString(): "N/A";

        //                    //Image  image = row["imge"] != DBNull.Value ? (Image)row["imge"]: null;

        //                    Image image = null;

        //                    if (row["imge"] != DBNull.Value)
        //                    {
        //                        string imagePathe = row["imge"].ToString();
        //                        if (!string.IsNullOrEmpty(imagePathe) && File.Exists(imagePathe))
        //                        {
        //                            try
        //                            {
        //                                image = Image.FromFile(imagePathe); 

        //                            }
        //                            catch (Exception ess)
        //                            {
        //                                image = null;
        //                            }
        //                        }
        //                    }

        //                    cardItems(id, productName, Stock, Price, image, Catogry ,"0");


        //                }




        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Errow {ex} ");
        //    }
        //}

        public void loadProducts()
        {
            clearDAtaGridVie();

            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string seleData = "Select * from products";

                    using (SqlCommand cmd = new SqlCommand(seleData, conn))
                    {
                        SqlDataAdapter add = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();


                        add.Fill(table);

                        flowLayoutPanel1.Controls.Clear();

                        foreach (DataRow row in table.Rows)
                        {
                            int id = row["productid"] != DBNull.Value ? (int)row["productid"] : 0;
                            string productName = row["productname"] != DBNull.Value ? row["productname"].ToString() : "N/A";
                            string Stock = row["stock"] != DBNull.Value ? row["Stock"].ToString() : "0";
                            //string quantiy = row[""]
                            string Price = row["price"] != DBNull.Value ? $"${row["price"].ToString()}.00" : "0.00";
                            string Catogry = row["category"] != DBNull.Value ? row["category"].ToString() : "N/A";

                            //Image  image = row["imge"] != DBNull.Value ? (Image)row["imge"]: null;

                            Image image = null;

                            if (row["imge"] != DBNull.Value)
                            {
                                string imagePathe = row["imge"].ToString();
                                if (!string.IsNullOrEmpty(imagePathe) && File.Exists(imagePathe))
                                {
                                    try
                                    {
                                        image = Image.FromFile(imagePathe);

                                    }
                                    catch (Exception ess)
                                    {
                                        image = null;
                                    }
                                }
                            }

                            cardItems(id, productName, Stock, Price, image, Catogry, "0");


                        }




                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Errow {ex} ");
            }



            dataGridView2.DataBindingComplete += (s, e) =>
            {
                dataGridView2.ClearSelection();
            };
        }


        public void clearDAtaGridVie()
        {

            shop_total.Text = $"${0:F2}";
            shop_change.Text = "";
            shop_amount.Text = $"${0:F2}";


            dataGridView2.Rows.Clear();


        }

        private void userCoShop_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void shop_change_TextChanged(object sender, EventArgs e)
        {

        }

        bool check = false;

       

        private void shop_change_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    decimal getTotal = Convert.ToDecimal(shop_total.Text.ToString().Replace("$", "").Replace(",", ""));
                    decimal getChange = Convert.ToDecimal(shop_change.Text);

                    if (getTotal > getChange)
                    {
                        MessageBox.Show("Invalid: Insufficient Amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        check = true;
                        shop_amount.Text = $"${getChange - getTotal:0.00}";
                        e.SuppressKeyPress = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //private void shop_placeOrderbtn_Click(object sender, EventArgs e)
        //{

        //    if (!check)
        //    {
        //        MessageBox.Show("Invalid: Insufficient Amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        if (MessageBox.Show("Are you sure you want to proceed?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            using (SqlConnection connect = new SqlConnection(connString))
        //            {
        //                connect.Open();

        //                string countData = "SELECT COUNT(*) FROM orders";
        //                int count = 1;

        //                using (SqlCommand cData = new SqlCommand(countData, connect))
        //                {
        //                    count = Convert.ToInt32(cData.ExecuteScalar()) + 1;
        //                }

        //                List<string> productIds = new List<string>();
        //                List<string> quantities = new List<string>();
        //                List<string> prices = new List<string>();

        //                foreach (DataGridViewRow row in dataGridView2.Rows)
        //                {
        //                    if (row.Cells["Id"].Value != null && row.Cells["QTY"].Value != null && row.Cells["price"].Value != null)
        //                    {
        //                        productIds.Add(row.Cells["Id"].Value.ToString());
        //                        quantities.Add(row.Cells["QTY"].Value.ToString());
        //                        prices.Add(row.Cells["price"].Value.ToString());
        //                    }
        //                }
        //                //==============

        //                string productIdsStr = string.Join(",", productIds);
        //                string quantitiesStr = string.Join(",", quantities);
        //                string pricesStr = string.Join(",", prices);

        //                decimal totalAmount = Convert.ToDecimal(shop_total.Text.Replace("$", ""));

        //                string insertData = "INSERT INTO orders (customerId, productIds, quantities, prices, total, date_order) VALUES (@cId, @pId, @qty, @price,@total, @date)";

        //                using (SqlCommand cmd = new SqlCommand(insertData, connect))
        //                {
        //                    cmd.Parameters.AddWithValue("@cId", $"CID-{count}");
        //                    cmd.Parameters.AddWithValue("@pId", productIdsStr);
        //                    cmd.Parameters.AddWithValue("@qty", quantitiesStr);
        //                    cmd.Parameters.AddWithValue("@price", pricesStr);
        //                    cmd.Parameters.AddWithValue("@total", totalAmount);

        //                    DateTime today = DateTime.Now;

        //                    cmd.Parameters.AddWithValue("@date", today);


        //                    try
        //                    {

        //                        int rowAffected = cmd.ExecuteNonQuery();
        //                        if (rowAffected > 0)
        //                        {
        //                            for (int q = 0; q < productIds.Count; q++)
        //                            {

        //                                string getStockDate = "Select stock from  products where productid = @id";
        //                                int cuuetStock = 0;
        //                                using (SqlCommand getSd = new SqlCommand(getStockDate, connect))
        //                                {
        //                                    getSd.Parameters.AddWithValue("@id", productIds[q]);

        //                                    object result = getSd.ExecuteScalar();

        //                                    if (result != null)
        //                                    {
        //                                        cuuetStock = Convert.ToInt32(result);
        //                                    }

        //                                }

        //                                int newStock = cuuetStock - Convert.ToInt32(quantities[q]);

        //                                if (newStock < 0)
        //                                {
        //                                    MessageBox.Show($" Insufficient Stock for product Id {productIds[q]} ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                                    return;

        //                                }
        //                                //string updateData = "UPDATE products SET stock = stock - @qty WHERE productid = @id";
        //                                string updateData = "UPDATE products SET stock = CAST(stock AS INT) - CAST(@qty AS INT) WHERE productid = @id";

        //                                using (SqlCommand updateCmd = new SqlCommand(updateData, connect))
        //                                {
        //                                    updateCmd.Parameters.AddWithValue("@qty", newStock);
        //                                    updateCmd.Parameters.AddWithValue("@id", productIds[q]);

        //                                    updateCmd.ExecuteNonQuery();
        //                                }
        //                            }

        //                            MessageBox.Show("Order placed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Order placement failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                        }

        //                    }
        //                    catch (SqlException ex)

        //                    {
        //                        MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


        //                    }
        //                }
        //            }
        //        }

        //    }

        //}

        private void shop_placeOrderbtn_Click(object sender, EventArgs e)
        {

            if (!check)
            {
                MessageBox.Show("Invalid: Insufficient Amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to proceed?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connString))
                    {
                        connect.Open();

                        string countData = "SELECT COUNT(*) FROM orders";
                        int count = 1;

                        using (SqlCommand cData = new SqlCommand(countData, connect))
                        {
                            count = Convert.ToInt32(cData.ExecuteScalar()) + 1;
                        }

                        List<string> productIds = new List<string>();
                        List<string> quantities = new List<string>();
                        List<string> prices = new List<string>();

                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            if (row.Cells["Id"].Value != null && row.Cells["QTY"].Value != null && row.Cells["price"].Value != null)
                            {
                                productIds.Add(row.Cells["Id"].Value.ToString());
                                quantities.Add(row.Cells["QTY"].Value.ToString());
                                prices.Add(row.Cells["price"].Value.ToString());
                            }
                        }
                        //==============

                        string productIdsStr = string.Join(",", productIds);
                        string quantitiesStr = string.Join(",", quantities);
                        string pricesStr = string.Join(",", prices);

                        decimal totalAmount = Convert.ToDecimal(shop_total.Text.Replace("$", ""));

                        string insertData = "INSERT INTO orders (customerId, productIds, quantities, prices, total, date_order) VALUES (@cId, @pId, @qty, @price,@total, @date)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cId", $"CID-{count}");
                            cmd.Parameters.AddWithValue("@pId", productIdsStr);
                            cmd.Parameters.AddWithValue("@qty", quantitiesStr);
                            cmd.Parameters.AddWithValue("@price", pricesStr);
                            cmd.Parameters.AddWithValue("@total", totalAmount);

                            DateTime today = DateTime.Now;

                            cmd.Parameters.AddWithValue("@date", today);


                            try
                            {

                                int rowAffected = cmd.ExecuteNonQuery();
                                if (rowAffected > 0)
                                {
                                    for (int q = 0; q < productIds.Count; q++)
                                    {

                                        string getStockDate = "Select stock from  products where productid = @id";
                                        int cuuetStock = 0;
                                        using (SqlCommand getSd = new SqlCommand(getStockDate, connect))
                                        {
                                            getSd.Parameters.AddWithValue("@id", productIds[q]);

                                            object result = getSd.ExecuteScalar();

                                            if (result != null)
                                            {
                                                cuuetStock = Convert.ToInt32(result);
                                            }

                                        }

                                        int newStock = cuuetStock - Convert.ToInt32(quantities[q]);

                                        if (newStock < 0)
                                        {
                                            MessageBox.Show($" Insufficient Stock for product Id {productIds[q]} ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;

                                        }
                                        //string updateData = "UPDATE products SET stock = stock - @qty WHERE productid = @id";
                                        string updateData = "UPDATE products SET stock = @qty WHERE productid = @id";

                                        using (SqlCommand updateCmd = new SqlCommand(updateData, connect))
                                        {
                                            updateCmd.Parameters.AddWithValue("@qty", newStock);
                                            updateCmd.Parameters.AddWithValue("@id", productIds[q]);

                                            updateCmd.ExecuteNonQuery();
                                        }
                                    }

                                    loadProducts();

                                    MessageBox.Show("Order placed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Order placement failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            catch (SqlException ex)

                            {
                                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            }
                        }
                    }
                }

            }

        }

        private int rowIndex = 0;
        private void shopRecpientBtn_Click(object sender, EventArgs e)
        {

            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_BeginPrint);


            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;
            int tabletMargin = 20;


            Font font = new Font("Arial", 12);
            Font blod = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font lablFont = new Font("Arial", 14, FontStyle.Bold);

            float Margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string HeaderText = "Al-Shaibani  Restaurant";
            y = (Margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(HeaderText, headerFont, Brushes.Black, e.MarginBounds.Left + (dataGridView2.Columns.Count / 2) * colWidth, y, alignCenter);

            count++;
            y += tabletMargin;

            string[] header = { "ID", "ProdName", "QTY", "Price" };

            for (int q =0;q<header.Length;q++)
            {
                y = Margin + count * blod.GetHeight(e.Graphics) + tabletMargin;
                e.Graphics.DrawString(header[q], blod, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);

            }

            count++;

            float rspace = e.MarginBounds.Bottom - y;

            while (rowIndex < dataGridView2.Rows.Count)
            {
                DataGridViewRow row = dataGridView2.Rows[rowIndex];

                for (int q =0; q < dataGridView2.Columns.Count;q++)
                {
                    object cellValue = row.Cells[q].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = Margin + count * font.GetHeight(e.Graphics) + tabletMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
                    
                }

                count++;
                rowIndex++;

                if (y + font.GetHeight (e.Graphics ) > e.MarginBounds.Bottom )
                {
                    e.HasMorePages = true;
                    return;
                }



            }

            int labelMargin = (int)Math.Min(rspace, 200);

            DateTime tody = DateTime.Now;

            float lableIX = e.MarginBounds.Right - e.Graphics.MeasureString("----------------", lablFont).Width;

            y = e.MarginBounds.Bottom - labelMargin - lablFont.GetHeight(e.Graphics);

            e.Graphics.DrawString($"Total Price: \t${shop_total.Text.Trim()}\nAmount:\t${shop_change.Text.Trim()} \n\t\t----------------\nChange:\t{shop_amount.Text.Trim()}", lablFont, Brushes.Black, lableIX, y);


            labelMargin = (int)Math.Min(rspace, -40);

            string lableText = tody.ToString();

            y = e.MarginBounds.Bottom - labelMargin - lablFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(lableText, lablFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("---------------------------", lablFont).Width, y);



        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }
    }
}
