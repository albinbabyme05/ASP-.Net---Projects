namespace ExpenseManagementSystemsVBDotNet
{
    partial class RegisterForm
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
            panel1 = new Panel();
            btnSignIn = new Button();
            label5 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            btnRegister = new Button();
            chkShowPassword = new CheckBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            picExit = new PictureBox();
            txtConfirmPass = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 480);
            panel1.TabIndex = 9;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.Indigo;
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(47, 418);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(228, 50);
            btnSignIn.TabIndex = 9;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(107, 369);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 2;
            label5.Text = "SIGN IN HERE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 159);
            label1.Name = "label1";
            label1.Size = new Size(229, 20);
            label1.TabIndex = 1;
            label1.Text = "Expense Management Systems ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.programmer;
            pictureBox2.Location = new Point(107, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SeaGreen;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(385, 418);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(135, 50);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(528, 301);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(108, 19);
            chkShowPassword.TabIndex = 16;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(374, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(266, 29);
            txtPassword.TabIndex = 15;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(374, 128);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(266, 29);
            txtUsername.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(374, 179);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 13;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(374, 105);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 12;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(374, 57);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 11;
            label2.Text = "REGISTRATION";
            // 
            // picExit
            // 
            picExit.Cursor = Cursors.Hand;
            picExit.Image = Properties.Resources.close;
            picExit.Location = new Point(641, 8);
            picExit.Name = "picExit";
            picExit.Size = new Size(29, 26);
            picExit.SizeMode = PictureBoxSizeMode.Zoom;
            picExit.TabIndex = 10;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Segoe UI", 12F);
            txtConfirmPass.Location = new Point(374, 266);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(266, 29);
            txtConfirmPass.TabIndex = 19;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(374, 243);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 18;
            label6.Text = "Confirm Password:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 480);
            Controls.Add(txtConfirmPass);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(btnRegister);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(picExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSignIn;
        private Label label5;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btnRegister;
        private CheckBox chkShowPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox picExit;
        private TextBox txtConfirmPass;
        private Label label6;
    }
}