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
using System.Drawing.Imaging;

namespace ExpenseManagementSystemsVBDotNet
{
    public partial class UCIncomeForm : UserControl
    {
        string cs = @"Data Source=DESKTOP-I69OQPV\SQLEXPRESS; Initial Catalog=ExpenseManagementSystemDB;Integrated Security=True";

        public UCIncomeForm()
        {
            InitializeComponent();
            DisplayCategory();
            displayIncomeList();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            DisplayCategory();
            displayIncomeList();
        }
        public void DisplayCategory()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("select category from tblCategories where type=@type and status=@status", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@type", "Income");
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
                if (cmbCategory.SelectedIndex == -1 || txtItem.Text == "" || txtIncome.Text == "" || txtDesc.Text == "")
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        string InsertData = "INSERT INTO tblIncome (category, item, income, description, date_income, date_insert) VALUES (@category, @item, @income, @description, @date_income, Getdate())";
                        using (SqlCommand cmd = new SqlCommand(InsertData, con))
                        {
                            cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", txtItem.Text.Trim());
                            cmd.Parameters.AddWithValue("@income", txtIncome.Text.Trim());
                            cmd.Parameters.AddWithValue("@description", txtDesc.Text.Trim());
                            cmd.Parameters.AddWithValue("@date_income", dtpdate.Value);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        con.Close();
                    }
                    clrControl();
                    displayIncomeList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clrControl();
        }
        public void clrControl()
        {
            cmbCategory.SelectedIndex = -1;
            txtItem.Text = txtIncome.Text = txtDesc.Text = "";

        }
        private int getID = 0;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.SelectedIndex == -1 || txtItem.Text == "" || txtIncome.Text == "" || txtDesc.Text == "")
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
                            string InsertData = "UPDATE tblIncome SET category=@category,item=@item,income = @income , description = @description,date_income=@date_income WHERE id = @id";
                            using (SqlCommand cmd = new SqlCommand(InsertData, con))
                            {
                                cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem);
                                cmd.Parameters.AddWithValue("@item", txtItem.Text.Trim());
                                cmd.Parameters.AddWithValue("@income", txtIncome.Text.Trim());
                                cmd.Parameters.AddWithValue("@description", txtDesc.Text.Trim());
                                cmd.Parameters.AddWithValue("@date_income", dtpdate.Value);
                                cmd.Parameters.AddWithValue("@id", getID);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            con.Close();
                        }
                        clrControl();
                        displayIncomeList();
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
                txtIncome.Text = row.Cells[3].Value.ToString();
                txtDesc.Text = row.Cells[4].Value.ToString();
                dtpdate.Text = row.Cells[5].Value.ToString();
                dtpdate.Value= Convert.ToDateTime(row.Cells[5].Value.ToString());
            }
        }
        public void displayIncomeList()
        {
            IncomeData iData = new IncomeData();
            List<IncomeData> listData = iData.IncomeListData();
            dataGridView1.DataSource = listData;
            //dataGridView1.Columns["Date"].DefaultCellStyle.Format = "MM-dd-yyyy";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.SelectedIndex == -1 || txtItem.Text == "" || txtIncome.Text == "" || txtDesc.Text == "")
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
                            string InsertData = "Delete from tblIncome WHERE id = @id";
                            using (SqlCommand cmd = new SqlCommand(InsertData, con))
                            {
                                cmd.Parameters.AddWithValue("@id", getID);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            con.Close();
                        }
                        clrControl();
                        displayIncomeList();
                    }                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
