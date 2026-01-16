using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExpenseManagementSystemsVBDotNet
{
    public partial class UCDashboardForm : UserControl
    {
        string cs = @"Data Source=DESKTOP-I69OQPV\SQLEXPRESS; Initial Catalog=ExpenseManagementSystemDB;Integrated Security=True";
        
        public UCDashboardForm()
        {
            InitializeComponent();
            TodayIncome();
            YesterdayIncome();
            ThisMonthIncome();
            YearlyIncome();
            TotalIncome();
            //expense
            TodayExpense();
            YesterdayExpense();
            ThisMonthExpense();
            YearlyExpense();
            TotalExpense();

        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            InitializeComponent();
            TodayIncome();
            YesterdayIncome();
            ThisMonthIncome();
            YearlyIncome();
            TotalIncome();
            //expense
            TodayExpense();
            YesterdayExpense();
            ThisMonthExpense();
            YearlyExpense();
            TotalExpense();
        }

        public void TodayIncome()
        {
            using (SqlConnection con=new SqlConnection(cs))
            {
                con.Open();
                string qr = "select sum(income)as income from tblIncome where date_income=@date_in";
                using (SqlCommand cmd=new SqlCommand(qr,con))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_in",today);
                    object result = cmd.ExecuteScalar();
                    if(result!=DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);
                        lblTodayIncome.Text = todayCost.ToString("c");
                    }
                    else
                    {
                        lblTodayIncome.Text = "$0.00";
                    }

                }
            }
        }

        public void YesterdayIncome()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string qr = "Select sum(income)as income from tblIncome where Convert(DATE,date_income)= DATEADD(day,DATEDIFF(day,0,GETDATE()),-1)";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {                    
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal YesterdayCost = Convert.ToDecimal(result);
                        lblYesterdayIncome.Text = YesterdayCost.ToString("c");
                    }
                    else
                    {
                        lblYesterdayIncome.Text = "$0.00";
                    }

                }
            }
        }

        public void ThisMonthIncome()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);
                string qr = "Select sum(income)as income from tblIncome where date_income>=@startMonth and date_income<=@endMonth";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal MonthlyCost = Convert.ToDecimal(result);
                        lblMonthIncome.Text = MonthlyCost.ToString("C");
                    }
                    else
                    {
                        lblMonthIncome.Text = "$0.00";
                    }

                }
            }
        }

        public void YearlyIncome()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);
                string qr = "Select sum(income)as income from tblIncome where date_income>=@startYear and date_income<=@endYear";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal YearCost = Convert.ToDecimal(result);
                        lblYearlyIncome.Text = YearCost.ToString("C");
                    }
                    else
                    {
                        lblYearlyIncome.Text = "$0.00";
                    }

                }
            }
        }

        public void TotalIncome()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                
                string qr = "Select sum(income)as income from tblIncome";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {                   
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal Totalincome = Convert.ToDecimal(result);
                        lblTotalIncome.Text = Totalincome.ToString("C");
                    }
                    else
                    {
                        lblTotalIncome.Text = "$0.00";
                    }

                }
            }
        }

        //Expense
        public void TodayExpense()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string qr = "select sum(expense)as income from tblExpenses where date_expense=@date_in";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_in", today);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);
                        lblTodayExpense.Text = todayCost.ToString("c");
                    }
                    else
                    {
                        lblTodayExpense.Text = "$0.00";
                    }

                }
            }
        }
        public void YesterdayExpense()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string qr = "Select sum(expense)as expense from tblExpenses where Convert(DATE,date_expense)= DATEADD(day,DATEDIFF(day,0,GETDATE()),-1)";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal Yesterdayexpense = Convert.ToDecimal(result);
                        lblYesterdayExpense.Text = Yesterdayexpense.ToString("c");
                    }
                    else
                    {
                        lblYesterdayExpense.Text = "$0.00";
                    }

                }
            }
        }
        public void ThisMonthExpense()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);
                string qr = "Select sum(expense)as expense from tblExpenses where date_expense>=@startMonth and date_expense<=@endMonth";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal Monthlyexpense = Convert.ToDecimal(result);
                        lblMonthlyExpense.Text = Monthlyexpense.ToString("C");
                    }
                    else
                    {
                        lblMonthlyExpense.Text = "$0.00";
                    }

                }
            }
        }

        public void YearlyExpense()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);
                string qr = "Select sum(expense)as expense from tblExpenses where date_expense>=@startYear and date_expense<=@endYear";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal Yearexpense = Convert.ToDecimal(result);
                        lblYearlyExpense.Text = Yearexpense.ToString("C");
                    }
                    else
                    {
                        lblYearlyExpense.Text = "$0.00";
                    }

                }
            }
        }

        public void TotalExpense()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string qr = "Select sum(expense)as expense from tblExpenses";
                using (SqlCommand cmd = new SqlCommand(qr, con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal Totalexpense = Convert.ToDecimal(result);
                        lblTotalExpense .Text = Totalexpense.ToString("C");
                    }
                    else
                    {
                        lblTotalExpense.Text = "$0.00";
                    }

                }
            }
        }
        //--------
    }
}
