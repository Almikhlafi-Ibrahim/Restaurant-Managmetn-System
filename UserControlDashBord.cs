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
using System.Configuration;

namespace Restaurant_Managmetn_System
{
    public partial class UserControlDashBord : UserControl
    {
        //string connString = @"Server=IbrahimPc\NAME2;
        //                     Database=A1Restaurant;
        //                    Integrated Security=True;
        //                  ";

        readonly string connString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;

        public UserControlDashBord()
        {
            InitializeComponent();

            displayTotalUsers();
            displayTotaProducs();
            displayTodaysRevnue();
            displayToatlsRevnue();
            displayTodysSales();
        }

        public void displayTodysSales()
        {

            customerList cList = new customerList();
            List<customerList> customerLists = cList.TodaySalleCusteerListDate();

            dataGridView10.DataSource = customerLists;


        }
        public void displayTotalUsers()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string selctData = "Select count(*) from users";

                using (SqlCommand cmd = new SqlCommand(selctData, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {

                        int Coutn = Convert.ToInt32(reader[0]);

                        dashbord_totalUser.Text = Coutn.ToString();
                        // You can process each row here if needed

                    }



                    //int totalUsers = (int)cmd.ExecuteScalar();
                }
            }
        }


        public void displayTotaProducs()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string selctData = "Select count(*) from products";
                using (SqlCommand cmd = new SqlCommand(selctData, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int Coutn = Convert.ToInt32(reader[0]);
                        dashbord_TotalProduct.Text = Coutn.ToString();
                        // You can process each row here if needed
                    }
                }

            }
        }



        public void displayTodaysRevnue()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string selctData = "Select sum(CAST(total as Decimal(10,2))) from orders where date_order = @date";
                using (SqlCommand cmd = new SqlCommand(selctData, conn))
                {

                    DateTime dateTime = DateTime.Now;
                    //dateTime.Date.ToString("yyyy-MM-dd");


                    cmd.Parameters.AddWithValue("@date", dateTime.Date.ToString("yyyy-MM-dd"));

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        //int Coutn = Convert.ToInt32(reader[0]);

                        if (reader[0] == DBNull.Value)
                        {
                            dashbord_TodayRevenue.Text = "$0.00";
                        }
                        else
                        {
                            decimal totalRevenue = Convert.ToDecimal(reader[0]);
                            dashbord_TodayRevenue.Text = "$" + totalRevenue.ToString("0.00");
                        }
                    }
                }

            }
        }

        public void displayToatlsRevnue()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string selctData = "Select sum(CAST(total as Decimal(10,2))) from orders "; 
                using (SqlCommand cmd = new SqlCommand(selctData, conn))
                {


                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int Coutn = Convert.ToInt32(reader[0]);
                        // You can process each row here if needed

                        if (reader[0] == DBNull.Value)
                        {
                            dashbord_totalRevenue.Text = "$0.00";
                        }
                        else
                        {
                            decimal totalRevenue = Convert.ToDecimal(reader[0]);
                            dashbord_totalRevenue.Text = "$" + totalRevenue.ToString("0.00");
                        }
                    }
                }

            }
        }


       




    }
}
