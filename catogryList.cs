using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Managmetn_System
{
    class categoriesList
    {
        string connString = @"Data Source=.\NAME2;
                            Initial Catalog=A1Restaurant;
                            Integrated Security=True;
                          ";

        public int ID { set; get; }

        public string category { set; get; }
        public string status { set; get; }
        public string DeteInsrt { set; get; }



         public List<categoriesList> categoriesListDate()
        {
            List<categoriesList> lisDate = new List<categoriesList>();

            using (SqlConnection connect = new SqlConnection(connString)) 
            {
                connect.Open();

                string selctDate = "Select * from categories";

                using (SqlCommand cmd = new SqlCommand(selctDate, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();


                    while(reader.Read())
                    {
                        categoriesList cDate = new categoriesList();
                        cDate.ID = (int)reader["id"];
                        cDate.category = reader["category"].ToString();
                        cDate.status = reader["status"].ToString();
                        cDate.DeteInsrt = ((DateTime)reader["date_inserted"]).ToString("MM-dd-yyyy");


                        lisDate.Add(cDate);

                    }
                }
            }


            return lisDate;
        
        }
    }

  
}
