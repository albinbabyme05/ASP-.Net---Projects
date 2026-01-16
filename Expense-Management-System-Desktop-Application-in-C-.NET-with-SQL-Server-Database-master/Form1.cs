using System.Data;
using System.Data.SqlClient;

namespace ExpenseManagementSystemsVBDotNet
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I69OQPV\SQLEXPRESS; Initial Catalog=ExpenseManagementSystemDB;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }
        public static string username;
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            RegisterForm registerfrm = new RegisterForm();
            registerfrm.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkShowPassword.Checked;
            txtPassword.UseSystemPasswordChar = !isChecked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try { 
                if(txtUsername.Text=="" || txtPassword.Text=="")
                {
                    MessageBox.Show("invalid username and password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string qr = "select username, password from tblUsers where username =@user and password=@pass";
                    using (SqlCommand cmd=new SqlCommand(qr,con))
                    {
                        cmd.Parameters.AddWithValue("@user",txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass",txtPassword.Text.Trim());
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if(dt.Rows.Count>0)
                        {
                            username = txtUsername.Text;
                            //MessageBox.Show("Login Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DashboardForm dfrm = new DashboardForm();
                            dfrm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("incorrect username/password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
            finally
            {
                con.Close();
            }
        }
    }
}
