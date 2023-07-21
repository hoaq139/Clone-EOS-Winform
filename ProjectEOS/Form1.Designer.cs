namespace ProjectEOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAccount = new TextBox();
            txtPassword = new TextBox();
            lblAccount = new Label();
            lblPassword = new Label();
            btnExit = new Button();
            btnLogin = new Button();
            txtSubject = new TextBox();
            lblSubject = new Label();
            EOS = new Label();
            SuspendLayout();
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(221, 127);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(195, 23);
            txtAccount.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(221, 178);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(195, 23);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Location = new Point(102, 130);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(60, 15);
            lblAccount.TabIndex = 2;
            lblAccount.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(102, 186);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(341, 295);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(147, 295);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(221, 234);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(195, 23);
            txtSubject.TabIndex = 6;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(102, 242);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(46, 15);
            lblSubject.TabIndex = 7;
            lblSubject.Text = "Subject";
            // 
            // EOS
            // 
            EOS.AutoSize = true;
            EOS.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            EOS.Location = new Point(147, 50);
            EOS.Name = "EOS";
            EOS.Size = new Size(227, 37);
            EOS.TabIndex = 8;
            EOS.Text = "Welcome to EOS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 368);
            Controls.Add(EOS);
            Controls.Add(lblSubject);
            Controls.Add(txtSubject);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Controls.Add(lblPassword);
            Controls.Add(lblAccount);
            Controls.Add(txtPassword);
            Controls.Add(txtAccount);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAccount;
        private TextBox txtPassword;
        private Label lblAccount;
        private Label lblPassword;
        private Button btnExit;
        private Button btnLogin;
        private TextBox txtSubject;
        private Label lblSubject;
        private Label EOS;
    }
}