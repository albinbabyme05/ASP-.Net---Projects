using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExpenseManagementSystemsVBDotNet
{
    internal class CategoryData
    {
        string cs = @"Data Source=DESKTOP-I69OQPV\SQLEXPRESS; Initial Catalog=ExpenseManagementSystemDB;Integrated Security=True";
        public int ID { set; get; }
        public string Category { set; get; }
        public string Type { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }



        public List<CategoryData> categoryListData()
        {
            List<CategoryData> listData = new List<CategoryData>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string selectData = "Select id,category,type,status,date_insert from tblCategories";
                using (SqlCommand cmd = new SqlCommand(selectData, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CategoryData cData = new CategoryData();
                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Type = reader["type"].ToString();
                        cData.Status = reader["status"].ToString();
                        cData.Date = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");
                        listData.Add(cData);
                    }
                }
            }
            return listData;

        }
    }
}
