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
    public partial class UCCategoryForm : UserControl
    {
        string cs = @"Data Source=DESKTOP-I69OQPV\SQLEXPRESS; Initial Catalog=ExpenseManagementSystemDB;Integrated Security=True";

        public UCCategoryForm()
        {
            InitializeComponent();
            displayCategoryList();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategoryList();
        }
        public void displayCategoryList()
        {
            CategoryData cData = new CategoryData();
            List<CategoryData> listData = cData.categoryListData();
            dataGridView1.DataSource = listData;
            //dataGridView1.Columns["Date"].DefaultCellStyle.Format = "MM-dd-yyyy";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategory.Text == "" || cmbType.SelectedIndex == -1 || cmbStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        string InsertData = "Insert into tblCategories(category,type,status,date_insert) values(@category,@type,@status,GETDATE())";
                        using (SqlCommand cmd = new SqlCommand(InsertData, con))
                        {
                            cmd.Parameters.AddWithValue("@category", txtCategory.Text.Trim());
                            cmd.Parameters.AddWithValue("@type", cmbType.SelectedItem);
                            cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Added Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        con.Close();
                    }
                    ClrControl();
                    displayCategoryList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = Convert.ToInt32(row.Cells[0].Value);
                txtCategory.Text = row.Cells[1].Value.ToString();
                cmbType.SelectedItem = row.Cells[2].Value.ToString();
                cmbStatus.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategory.Text == "" || cmbType.SelectedIndex == -1 || cmbStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to update ID" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            con.Open();
                            string UpdateData = "update tblCategories set category=@category,type=@type,status=@status,date_insert=Getdate() where id=@id";
                            using (SqlCommand cmd = new SqlCommand(UpdateData, con))
                            {
                                cmd.Parameters.AddWithValue("@id", getID);
                                cmd.Parameters.AddWithValue("@category", txtCategory.Text.Trim());
                                cmd.Parameters.AddWithValue("@type", cmbType.SelectedItem);
                                cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Updated Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            con.Close();
                        }
                        ClrControl();
                        displayCategoryList();
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
                if (txtCategory.Text == "" || cmbType.SelectedIndex == -1 || cmbStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to Delete ID" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            con.Open();
                            string UpdateData = "delete from tblCategories where id=@id";
                            using (SqlCommand cmd = new SqlCommand(UpdateData, con))
                            {
                                cmd.Parameters.AddWithValue("@id", getID);                                
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Deleted Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            con.Close();
                        }
                        ClrControl();
                        displayCategoryList();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClrControl();
        }
        public void ClrControl()
        {
            txtCategory.Text = "";
            cmbStatus.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
        }
    }
}
