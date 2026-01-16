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
    public partial class RegisterForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I69OQPV\SQLEXPRESS; Initial Catalog=ExpenseManagementSystemDB;Integrated Security=True");

        public RegisterForm()
        {
            InitializeComponent();
        }
       public bool checkConnection()
        {
            return (con.State == ConnectionState.Closed) ? true : false;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Form1 loginfrm = new Form1();
            loginfrm.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //// Check if the checkbox is checked
            //if (chkShowPassword.Checked)
            //{
            //    // Show the password in the text box by disabling password char masking
            //    txtConfirmPass.UseSystemPasswordChar = false;
            //    txtPassword.UseSystemPasswordChar = false;
            //}
            //else
            //{
            //    // Hide the password by enabling password char masking
            //    txtConfirmPass.UseSystemPasswordChar = true;
            //    txtPassword.UseSystemPasswordChar = true;
            //}

            bool isChecked = chkShowPassword.Checked;
            txtConfirmPass.UseSystemPasswordChar = !isChecked;
            txtPassword.UseSystemPasswordChar = !isChecked;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmPass.Text == "")
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    con.Open();
                    string selectuser = "Select * from tblUsers where username=@username";
                    using (SqlCommand cmd = new SqlCommand(selectuser, con))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        SqlDataAdapter adpter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adpter.Fill(dt);
                        if (dt.Rows.Count != 0)
                        {
                            string tempUserName = txtUsername.Text.Substring(0, 1).ToUpper() + txtUsername.Text.Substring(1);
                            MessageBox.Show(tempUserName + "is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtPassword.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid password...! at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtPassword.Text != txtConfirmPass.Text)
                        {
                            MessageBox.Show("Invalid password...! Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string qryInsert = "Insert into tblUsers (username,password,date_create ) values(@username,@password,GetDate())";
                            using (SqlCommand cmd1 = new SqlCommand(qryInsert, con))
                            {
                                cmd1.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                                cmd1.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                                cmd1.ExecuteNonQuery();
                                MessageBox.Show("Registration successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form1 loginfrm = new Form1();
                                loginfrm.Show();
                                this.Hide();
                            }
                        }
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
