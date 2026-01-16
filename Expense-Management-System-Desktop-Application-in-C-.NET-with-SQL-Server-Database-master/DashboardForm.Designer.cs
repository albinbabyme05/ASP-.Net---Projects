namespace ExpenseManagementSystemsVBDotNet
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            picExit = new PictureBox();
            panel2 = new Panel();
            btnLogout = new Button();
            btnExpenses = new Button();
            btnIncome = new Button();
            btnCategory = new Button();
            btnDashboard = new Button();
            lblDisplayName = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            ucDashboardForm1 = new UCDashboardForm();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(picExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 46);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.programmer;
            pictureBox2.Location = new Point(479, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(518, 13);
            label1.Name = "label1";
            label1.Size = new Size(229, 20);
            label1.TabIndex = 3;
            label1.Text = "Expense Management Systems ";
            // 
            // picExit
            // 
            picExit.Cursor = Cursors.Hand;
            picExit.Image = Properties.Resources.close;
            picExit.Location = new Point(1230, 6);
            picExit.Name = "picExit";
            picExit.Size = new Size(29, 26);
            picExit.SizeMode = PictureBoxSizeMode.Zoom;
            picExit.TabIndex = 2;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnExpenses);
            panel2.Controls.Add(btnIncome);
            panel2.Controls.Add(btnCategory);
            panel2.Controls.Add(btnDashboard);
            panel2.Controls.Add(lblDisplayName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 635);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SeaGreen;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(12, 571);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(153, 39);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "LogOut";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExpenses
            // 
            btnExpenses.BackColor = Color.SeaGreen;
            btnExpenses.Cursor = Cursors.Hand;
            btnExpenses.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnExpenses.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnExpenses.Location = new Point(20, 357);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(153, 39);
            btnExpenses.TabIndex = 7;
            btnExpenses.Text = "Expense";
            btnExpenses.UseVisualStyleBackColor = false;
            btnExpenses.Click += btnExpenses_Click;
            // 
            // btnIncome
            // 
            btnIncome.BackColor = Color.SeaGreen;
            btnIncome.Cursor = Cursors.Hand;
            btnIncome.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnIncome.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnIncome.Location = new Point(20, 299);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(153, 39);
            btnIncome.TabIndex = 6;
            btnIncome.Text = "Income";
            btnIncome.UseVisualStyleBackColor = false;
            btnIncome.Click += btnIncome_Click;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.SeaGreen;
            btnCategory.Cursor = Cursors.Hand;
            btnCategory.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnCategory.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnCategory.Location = new Point(20, 233);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(153, 39);
            btnCategory.TabIndex = 5;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.SeaGreen;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnDashboard.Location = new Point(20, 165);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(153, 39);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            lblDisplayName.ForeColor = Color.Yellow;
            lblDisplayName.Location = new Point(97, 102);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(48, 19);
            lblDisplayName.TabIndex = 4;
            lblDisplayName.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 102);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 3;
            label5.Text = "Welcome,";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Controls.Add(ucDashboardForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(1064, 635);
            panel3.TabIndex = 2;
            // 
            // ucDashboardForm1
            // 
            ucDashboardForm1.Location = new Point(6, 6);
            ucDashboardForm1.Name = "ucDashboardForm1";
            ucDashboardForm1.Size = new Size(1064, 635);
            ucDashboardForm1.TabIndex = 0;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox picExit;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label lblDisplayName;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnExpenses;
        private Button btnIncome;
        private Button btnCategory;
        private Panel panel3;
        private UCDashboardForm ucDashboardForm1;
    }
}