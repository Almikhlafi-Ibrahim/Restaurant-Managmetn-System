using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Managmetn_System
{
    class clsproductList
    {


        string connString = @"Server=IbrahimPc\NAME2;
                             Database=A1Restaurant;
                            Integrated Security=True;
                          ";

        public int ProductId { set; get; }
        public string ProductName { set; get; }
        public string Catetory { set; get; }
        public string Stock { set; get; }
        public string price { set; get; }
        public string Status { set; get; }
        public string image { set; get; }
        public string DateInsert { set; get; }
        public string DateUpdate { set; get; }

        public List<clsproductList> productListDate()
        {
            List<clsproductList> listData = new List<clsproductList>();

            using (SqlConnection connect = new SqlConnection(connString))
            {
                connect.Open();

                string selctDate = "Select * from products";

                using (SqlCommand cmd = new SqlCommand(selctDate, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        clsproductList pDate = new clsproductList();
                        pDate.ProductId = (int)reader["productid"];
                        pDate.ProductName = reader["Productname"].ToString();
                        pDate.Catetory = reader["category"].ToString();
                        pDate.Stock = reader["stock"].ToString();
                        pDate.price = reader["price"].ToString();
                        pDate.Status = reader["status"].ToString();
                        pDate.image = reader["imge"].ToString();
                        pDate.DateInsert = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");

                        if (reader["date_update"] != DBNull.Value)
                        {
                            pDate.DateUpdate = ((DateTime)reader["date_update"]).ToString("MM-dd-yyyy");

                        }
                        else { pDate.DateUpdate = "Null"; }


                            listData.Add(pDate);



                    }
                }
            }

            return listData;
        }

    }
}
