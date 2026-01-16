using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManagementSystemsVBDotNet
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            displayUsername();
        }
        public void displayUsername()
        {
            string getUsersname = Form1.username;
            lblDisplayName.Text = getUsersname.ToUpper();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginform = new Form1();
                loginform.Show();
                this.Hide();
            }
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            UCIncomeForm incomeForm = new UCIncomeForm();
            LoadFormInPanel(incomeForm);
            if (incomeForm != null)
            {
                incomeForm.refreshData();
            }
        }

        private void LoadFormInPanel(UserControl selectedForm)
        {
            panel3.Controls.Clear();
            selectedForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(selectedForm);
            selectedForm.BringToFront();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            UCCategoryForm uc_Category = new UCCategoryForm();
            LoadFormInPanel(uc_Category);
            if (uc_Category != null)
            {
                uc_Category.refreshData();
            }
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            UCExpenseForm uc_exp = new UCExpenseForm();
            LoadFormInPanel(uc_exp);
            if (uc_exp != null)
            {
                uc_exp.refreshData();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UCDashboardForm uc_Das = new UCDashboardForm();
            LoadFormInPanel(uc_Das);
            if(uc_Das!=null)
            {
                uc_Das.refreshData();
            }
        }
    }
}
