using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
namespace Restaurant_Managmetn_System
{
    class customerList
    {

        string connString = @"Server=IbrahimPc\NAME2;
                             Database=A1Restaurant;
                            Integrated Security=True;
                          ";

        public int id { set; get; }
        public string productsIds { set; get; }
        public string customerId { set; get; }
        public string quantity { set; get; }
        public string prices { set; get; }

        public string totalPrice { set; get; }
        public string dateOrder { set; get; }

       public  List<customerList> customerListsData ()
        {
            List<customerList> customerLists = new List<customerList>();

            using (SqlConnection conn = new SqlConnection(connString)) {
                conn.Open();
                string selectData = "Select * from orders";

                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        customerList cList = new customerList();

                        cList.id = Convert.ToInt32(reader["id"]);
                        cList.customerId = reader["customerId"].ToString();
                        cList.productsIds = reader["productids"].ToString();
                        cList.quantity = reader["quantities"].ToString();
                        cList.prices = reader["prices"].ToString();
                        cList.totalPrice = reader["total"].ToString();
                        cList.dateOrder = ((DateTime)reader["date_order"]).ToString("MM-dd-yyyy");


                        customerLists.Add(cList);
                    }
                }
            }

            return customerLists;
        }



        public List<customerList> TodaySalleCusteerListDate()
        {
            List<customerList> customerLists = new List<customerList>();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string selectData = "Select * from orders  where date_order = @date" ;

                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {

                    DateTime today = DateTime.Now;

                    string getDate = today.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@date", getDate);

                    //cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                    
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        customerList cList = new customerList();

                        cList.id = Convert.ToInt32(reader["id"]);
                        cList.customerId = reader["customerId"].ToString();
                        cList.productsIds = reader["productids"].ToString();
                        cList.quantity = reader["quantities"].ToString();
                        cList.prices = reader["prices"].ToString();
                        cList.totalPrice = reader["total"].ToString();
                        cList.dateOrder = ((DateTime)reader["date_order"]).ToString("MM-dd-yyyy");


                        customerLists.Add(cList);
                    }
                }
            }

            return customerLists;
        }





    }
}
