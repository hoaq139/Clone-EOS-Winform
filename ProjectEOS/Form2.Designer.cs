namespace ProjectEOS
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            tbxQuestion = new RichTextBox();
            lblName1 = new Label();
            lblName2 = new Label();
            lblSubject1 = new Label();
            lblSubject2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            btnSubmit = new Button();
            cbxSubmit = new CheckBox();
            btnBack = new Button();
            btnNext = new Button();
            lblSoCau = new Label();
            lblID = new Label();
            lblDapAn = new Label();
            lblSoCauHoi = new Label();
            lblSoCauDung = new Label();
            lblAnswerSQL = new Label();
            lblAnswer = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblSecond = new Label();
            lblMinute = new Label();
            lblSplit = new Label();
            lblServerName = new Label();
            lblServer = new Label();
            lblTimeLeft = new Label();
            SuspendLayout();
            // 
            // tbxQuestion
            // 
            tbxQuestion.Location = new Point(160, 114);
            tbxQuestion.Name = "tbxQuestion";
            tbxQuestion.ReadOnly = true;
            tbxQuestion.Size = new Size(602, 261);
            tbxQuestion.TabIndex = 1;
            tbxQuestion.Text = "";
            tbxQuestion.TextChanged += tbxQuestion_TextChanged;
            // 
            // lblName1
            // 
            lblName1.AutoSize = true;
            lblName1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName1.Location = new Point(53, 33);
            lblName1.Name = "lblName1";
            lblName1.Size = new Size(43, 15);
            lblName1.TabIndex = 2;
            lblName1.Text = "Name:";
            // 
            // lblName2
            // 
            lblName2.AutoSize = true;
            lblName2.Location = new Point(101, 33);
            lblName2.Name = "lblName2";
            lblName2.Size = new Size(37, 15);
            lblName2.TabIndex = 3;
            lblName2.Text = "name";
            // 
            // lblSubject1
            // 
            lblSubject1.AutoSize = true;
            lblSubject1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubject1.Location = new Point(53, 70);
            lblSubject1.Name = "lblSubject1";
            lblSubject1.Size = new Size(52, 15);
            lblSubject1.TabIndex = 4;
            lblSubject1.Text = "Subject:";
            // 
            // lblSubject2
            // 
            lblSubject2.AutoSize = true;
            lblSubject2.Location = new Point(108, 70);
            lblSubject2.Name = "lblSubject2";
            lblSubject2.Size = new Size(45, 15);
            lblSubject2.TabIndex = 5;
            lblSubject2.Text = "subject";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(36, 141);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(36, 184);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(36, 232);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(36, 279);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 19);
            checkBox4.TabIndex = 9;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(36, 429);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // cbxSubmit
            // 
            cbxSubmit.AutoSize = true;
            cbxSubmit.Location = new Point(36, 395);
            cbxSubmit.Name = "cbxSubmit";
            cbxSubmit.Size = new Size(208, 19);
            cbxSubmit.TabIndex = 11;
            cbxSubmit.Text = "Check this box when you are done";
            cbxSubmit.UseVisualStyleBackColor = true;
            cbxSubmit.CheckedChanged += cbxSubmit_CheckedChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(36, 317);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 24);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(87, 317);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(45, 24);
            btnNext.TabIndex = 13;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblSoCau
            // 
            lblSoCau.AutoSize = true;
            lblSoCau.Location = new Point(36, 105);
            lblSoCau.Name = "lblSoCau";
            lblSoCau.Size = new Size(66, 15);
            lblSoCau.TabIndex = 14;
            lblSoCau.Text = "Cau hoi so:";
            lblSoCau.Click += lblSoCau_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(779, 184);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 15);
            lblID.TabIndex = 15;
            // 
            // lblDapAn
            // 
            lblDapAn.AutoSize = true;
            lblDapAn.Location = new Point(736, 70);
            lblDapAn.Name = "lblDapAn";
            lblDapAn.Size = new Size(38, 15);
            lblDapAn.TabIndex = 16;
            lblDapAn.Text = "label1";
            // 
            // lblSoCauHoi
            // 
            lblSoCauHoi.AutoSize = true;
            lblSoCauHoi.Location = new Point(779, 141);
            lblSoCauHoi.Name = "lblSoCauHoi";
            lblSoCauHoi.Size = new Size(38, 15);
            lblSoCauHoi.TabIndex = 17;
            lblSoCauHoi.Text = "label1";
            // 
            // lblSoCauDung
            // 
            lblSoCauDung.AutoSize = true;
            lblSoCauDung.Location = new Point(575, 70);
            lblSoCauDung.Name = "lblSoCauDung";
            lblSoCauDung.Size = new Size(38, 15);
            lblSoCauDung.TabIndex = 18;
            lblSoCauDung.Text = "label1";
            // 
            // lblAnswerSQL
            // 
            lblAnswerSQL.AutoSize = true;
            lblAnswerSQL.Location = new Point(575, 33);
            lblAnswerSQL.Name = "lblAnswerSQL";
            lblAnswerSQL.Size = new Size(38, 15);
            lblAnswerSQL.TabIndex = 19;
            lblAnswerSQL.Text = "label1";
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Location = new Point(736, 33);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(38, 15);
            lblAnswer.TabIndex = 24;
            lblAnswer.Text = "label5";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Location = new Point(330, 33);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(19, 15);
            lblSecond.TabIndex = 25;
            lblSecond.Text = "SS";
            lblSecond.Click += lblSecond_Click;
            // 
            // lblMinute
            // 
            lblMinute.AutoSize = true;
            lblMinute.Location = new Point(302, 33);
            lblMinute.Name = "lblMinute";
            lblMinute.Size = new Size(29, 15);
            lblMinute.TabIndex = 26;
            lblMinute.Text = "MM";
            // 
            // lblSplit
            // 
            lblSplit.AutoSize = true;
            lblSplit.Location = new Point(321, 33);
            lblSplit.Name = "lblSplit";
            lblSplit.Size = new Size(10, 15);
            lblSplit.TabIndex = 27;
            lblSplit.Text = ":";
            // 
            // lblServerName
            // 
            lblServerName.AutoSize = true;
            lblServerName.Location = new Point(321, 70);
            lblServerName.Name = "lblServerName";
            lblServerName.Size = new Size(68, 15);
            lblServerName.TabIndex = 28;
            lblServerName.Text = "servername";
            lblServerName.Click += lblServerName_Click;
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblServer.Location = new Point(228, 70);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(87, 15);
            lblServer.TabIndex = 29;
            lblServer.Text = "Server Name: ";
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.AutoSize = true;
            lblTimeLeft.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimeLeft.Location = new Point(228, 33);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new Size(61, 15);
            lblTimeLeft.TabIndex = 31;
            lblTimeLeft.Text = "Time left:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 476);
            Controls.Add(lblTimeLeft);
            Controls.Add(lblServer);
            Controls.Add(lblServerName);
            Controls.Add(lblSplit);
            Controls.Add(lblMinute);
            Controls.Add(lblSecond);
            Controls.Add(lblAnswer);
            Controls.Add(lblAnswerSQL);
            Controls.Add(lblSoCauDung);
            Controls.Add(lblSoCauHoi);
            Controls.Add(lblDapAn);
            Controls.Add(lblID);
            Controls.Add(lblSoCau);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(cbxSubmit);
            Controls.Add(btnSubmit);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(lblSubject2);
            Controls.Add(lblSubject1);
            Controls.Add(lblName2);
            Controls.Add(lblName1);
            Controls.Add(tbxQuestion);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName1;
        private Label lblName2;
        private Label lblSubject1;
        private Label lblSubject2;
        private RichTextBox tbxQuestion;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button btnSubmit;
        private CheckBox cbxSubmit;
        private Button btnBack;
        private Button btnNext;
        private Label lblSoCau;
        private Label lblID;
        private Label lblDapAn;
        private Label lblSoCauHoi;
        private Label lblSoCauDung;
        private Label lblAnswerSQL;
        private Label lblAnswer;
        private System.Windows.Forms.Timer timer1;
        private Label lblSecond;
        private Label lblMinute;
        private Label lblSplit;
        private Label lblServerName;
        private Label lblServer;
        private Label lblTimeLeft;
        private Label lblNumber;
    }
}