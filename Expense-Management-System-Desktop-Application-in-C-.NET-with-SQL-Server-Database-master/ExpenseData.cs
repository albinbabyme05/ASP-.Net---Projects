using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExpenseManagementSystemsVBDotNet
{
    internal class ExpenseData
    {
        string cs = @"Data Source=DESKTOP-I69OQPV\SQLEXPRESS; Initial Catalog=ExpenseManagementSystemDB;Integrated Security=True";
        public int ID { set; get; }
        public string Category { set; get; }
        public string Item { set; get; }
        public string Expense { set; get; }
        public string Description { set; get; }
        public string Date { set; get; }



        public List<ExpenseData> ExpenseListData()
        {
            List<ExpenseData> listData = new List<ExpenseData>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string selectData = "select id,category, item, expense, description, date_expense, date_insert from tblExpenses";
                using (SqlCommand cmd = new SqlCommand(selectData, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ExpenseData iData = new ExpenseData();
                        iData.ID = (int)reader["id"];
                        iData.Category = reader["category"].ToString();
                        iData.Item = reader["item"].ToString();
                        iData.Expense = reader["expense"].ToString();
                        iData.Description = reader["description"].ToString();
                        iData.Date = ((DateTime)reader["date_expense"]).ToString("MM-dd-yyyy");
                        
                        listData.Add(iData);
                    }
                }
            }
            return listData;

        }
    }
}
