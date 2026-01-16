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
    public partial class UCExpenseForm : UserControl
    {
        string cs = @"Data Source=DESKTOP-I69OQPV\SQLEXPRESS; Initial Catalog=ExpenseManagementSystemDB;Integrated Security=True";

        public UCExpenseForm()
        {
            InitializeComponent();
            DisplayCategory();
            displayExpenseList();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            DisplayCategory();
            displayExpenseList();
        }
        public void DisplayCategory()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select category from tblCategories where type=@type and status=@status", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@type", "Expense");
                    cmd.Parameters.AddWithValue("@status", "Active");
                    cmbCategory.Items.Clear();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmbCategory.Items.Add(dr["category"].ToString());
                    }
                }
                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.SelectedIndex == -1 || txtItem.Text == "" || txtExpenseCost.Text == "" || txtDesc.Text == "")
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        string InsertData = "insert into tblExpenses(category, item, expense, description, date_expense, date_insert) values(@category, @item, @expense, @description, @date_expense, Getdate())";
                        using (SqlCommand cmd = new SqlCommand(InsertData, con))
                        {
                            cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", txtItem.Text.Trim());
                            cmd.Parameters.AddWithValue("@expense", txtExpenseCost.Text.Trim());
                            cmd.Parameters.AddWithValue("@description", txtDesc.Text.Trim());
                            cmd.Parameters.AddWithValue("@date_expense", dtpdate.Value);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        con.Close();
                    }
                    clrControl();
                    displayExpenseList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clrControl()
        {
            cmbCategory.SelectedIndex = -1;
            txtItem.Text = txtExpenseCost.Text = txtDesc.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clrControl();
        }
        public void displayExpenseList()
        {
            ExpenseData iData = new ExpenseData();
            List<ExpenseData> listData = iData.ExpenseListData();
            dataGridView1.DataSource = listData;
            //dataGridView1.Columns["Date"].DefaultCellStyle.Format = "MM-dd-yyyy";
        }
        private int getID = 0;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.SelectedIndex == -1 || txtItem.Text == "" || txtExpenseCost.Text == "" || txtDesc.Text == "")
                {
                    MessageBox.Show("Please select  record", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to update ID" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            con.Open();
                            string InsertData = "UPDATE tblExpenses SET category=@category,item=@item,expense = @expense , description = @description,date_expense=@date_expense WHERE id = @id";
                            using (SqlCommand cmd = new SqlCommand(InsertData, con))
                            {
                                cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem);
                                cmd.Parameters.AddWithValue("@item", txtItem.Text.Trim());
                                cmd.Parameters.AddWithValue("@expense", txtExpenseCost.Text.Trim());
                                cmd.Parameters.AddWithValue("@description", txtDesc.Text.Trim());
                                cmd.Parameters.AddWithValue("@date_expense", dtpdate.Value);
                                cmd.Parameters.AddWithValue("@id", getID);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            con.Close();
                        }
                        clrControl();
                        displayExpenseList();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.SelectedIndex == -1 || txtItem.Text == "" || txtExpenseCost.Text == "" || txtDesc.Text == "")
                {
                    MessageBox.Show("Please select  record", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Delete Record ID" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            con.Open();
                            string InsertData = "Delete from tblExpenses WHERE id = @id";
                            using (SqlCommand cmd = new SqlCommand(InsertData, con))
                            {
                                cmd.Parameters.AddWithValue("@id", getID);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            con.Close();
                        }
                        clrControl();
                        displayExpenseList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = Convert.ToInt32(row.Cells[0].Value);
                cmbCategory.SelectedItem = row.Cells[1].Value.ToString();
                txtItem.Text = row.Cells[2].Value.ToString();
                txtExpenseCost.Text = row.Cells[3].Value.ToString();
                txtDesc.Text = row.Cells[4].Value.ToString();
                dtpdate.Text = row.Cells[5].Value.ToString();
                dtpdate.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            }
        }
    }
}
