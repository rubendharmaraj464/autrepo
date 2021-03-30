using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TestAutomation
{
    class DataBase
    {
        public void ReadDbValues()
        {
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-M6IOO3R\SQLEXPRESS; initial catalog =Selenium; Integrated Security = true");
            String sqlquery = "SELECT * FROM [Selenium].[dbo].[Students]";
            

            SqlCommand commond = new SqlCommand(sqlquery , conn);
            conn.Open();
            SqlDataReader reader =  commond.ExecuteReader();
            int count = reader.VisibleFieldCount;

            Console.WriteLine(count);
  
                while (reader.Read())
                {
                   for (int i = 0; i <= count - 1; i++)
                   {
   
                    string cellval = reader.GetString(i);
                    Console.WriteLine(cellval);

                  }


            }
          
            conn.Close();

        }
    }
}
