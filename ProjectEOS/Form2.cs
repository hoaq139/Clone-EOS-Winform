using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;
using WinForm_ADO;
using System.Timers;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Security.Cryptography;
using Microsoft.CSharp.RuntimeBinder;
using System.Security.Cryptography;

namespace ProjectEOS
{
    public partial class Form2 : Form
    {
        int count;
        double point = 0;
        int id = 1;
        int numberofQuestion;
        int[] option = new int[100];
        int countdownmins = 60;


        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string name, string subject)
        {

            TimerCount();
            CountNumber();
            InitializeComponent();
            Text = "Bai thi " + name;
            lblID.Visible = false;
            lblName2.Text = name;
            lblSubject2.Text = subject;
            btnSubmit.Enabled = false;
            lblID.Text = Convert.ToString(id);
            lblSoCauHoi.Text = numberofQuestion.ToString();
            lblSoCauDung.Text = Convert.ToString(count);
            lblAnswer.Visible = false;
            lblSoCauHoi.Visible = false;
            lblSoCauDung.Visible = false;
            lblAnswerSQL.Visible = false;
            lblDapAn.Visible = false;
            LoadData();
            getServerName();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        DataProvider dt = new DataProvider();

        private void LoadData()
        {
            List<Question> data = new List<Question>();
            string sql1 = "select * from QuestionPRN211 where QuestionID = @id";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id", lblID.Text)
            };

            using (IDataReader dr = dt.executeQuery2(sql1, parameters))
            {
                while (dr.Read())
                {
                    string QuestionsID = dr.GetString(1);
                    string SubjectID = dr.GetString(0);
                    string Questions = dr.GetString(2);
                    string AnswerA = dr.GetString(3);
                    string AnswerB = dr.GetString(4);
                    string AnswerC = dr.GetString(5);
                    string AnswerD = dr.GetString(6);
                    string AnswerRight = dr.GetString(7);
                    Question c = new Question(SubjectID, QuestionsID, Questions, AnswerA, AnswerB, AnswerC, AnswerD, AnswerRight);
                    tbxQuestion.Text = Questions;
                    checkBox1.Text = AnswerA;
                    checkBox2.Text = AnswerB;
                    checkBox3.Text = AnswerC;
                    checkBox4.Text = AnswerD;
                    lblAnswerSQL.Text = AnswerRight;

                    data.Add(c);
                }

            }

            if (option[id] == 1)
            {
                checkBox1.Checked = true;
            }
            else if (option[id] == 2)
            {
                checkBox2.Checked = true;
            }
            else if (option[id] == 3)
            {
                checkBox3.Checked = true;
            }
            else if (option[id] == 4)
            {
                checkBox4.Checked = true;
            }
            else if (option[id] == 0)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
            lblSoCau.Text = "Cau hoi so: " + id.ToString() + "/" + numberofQuestion.ToString();
            generateButton();
        }






        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                option[id] = 2;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                option[id] = 1;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                option[id] = 3;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox1.Checked = false;
                option[id] = 4;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveAll();
            TinhDiem();
            MessageBox.Show("Ban dat " + point + " diem");
            Application.Exit();
            ResetAllChoice();
        }

        private void cbxSubmit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSubmit.Checked)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }

        }




        private void btnNext_Click(object sender, EventArgs e)
        {
            id = RandomNumberGenerator.GetInt32(1, numberofQuestion);

            if (id > numberofQuestion)
            {
                id = 1;
            }
            lblID.Text = Convert.ToString(id);
            LoadData();

            if (checkBox1.Checked == true)
            {
                lblAnswer.Text = checkBox1.Text;
            }
            else if (checkBox2.Checked == true)
            {
                lblAnswer.Text = checkBox2.Text;
            }
            else if (checkBox3.Checked == true)
            {
                lblAnswer.Text = checkBox3.Text;
            }
            else if (checkBox4.Checked == true)
            {
                lblAnswer.Text = checkBox4.Text;
            }


            string sql2 = "IF EXISTS (SELECT * FROM StudentChoice WHERE QuestionID = @id) " +
                "BEGIN " +
                "UPDATE StudentChoice " +
                "SET Choice = @choice " +
                "WHERE QuestionID = @id " +
                "END " +
                "ELSE " +
                "BEGIN " +
                "INSERT INTO StudentChoice (QuestionID, Choice) " +
                "VALUES (@id, @choice) " +
                "END";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id", lblID.Text),
                new SqlParameter("@choice", lblAnswer.Text)
            };
            dt.executeQuery2(sql2, parameters);


        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            id--;
            if (id == 0)
            {
                id = numberofQuestion;
            }
            lblID.Text = Convert.ToString(id);
            LoadData();

            if (checkBox1.Checked == true)
            {
                lblAnswer.Text = checkBox1.Text;
            }
            else if (checkBox2.Checked == true)
            {
                lblAnswer.Text = checkBox2.Text;
            }
            else if (checkBox3.Checked == true)
            {
                lblAnswer.Text = checkBox3.Text;
            }
            else if (checkBox4.Checked == true)
            {
                lblAnswer.Text = checkBox4.Text;
            }


            string sql2 = "IF EXISTS (SELECT * FROM StudentChoice WHERE QuestionID = @id) " +
                "BEGIN " +
                "UPDATE StudentChoice " +
                "SET Choice = @choice " +
                "WHERE QuestionID = @id " +
                "END " +
                "ELSE " +
                "BEGIN " +
                "INSERT INTO StudentChoice (QuestionID, Choice) " +
                "VALUES (@id, @choice) " +
                "END";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id", lblID.Text),
                new SqlParameter("@choice", lblAnswer.Text)
            };
            dt.executeQuery2(sql2, parameters);
        }

        private void CountNumber()
        {
            using (IDataReader dr = dt.executeQuery2("Select COUNT(QuestionID) From QuestionPRN211"))
            {
                while (dr.Read())
                {
                    numberofQuestion = dr.GetInt32(0);
                }
            }
        }

        private void TinhDiem()
        {
            string sql3 = "SELECT COUNT(*) AS SameValueCount " +
                "FROM QuestionPRN211 t1 " +
                "JOIN StudentChoice t2 ON t1.AnswerRight = t2.Choice " +
                "WHERE t1.AnswerRight = t2.Choice;";
            using (IDataReader dr = dt.executeQuery2(sql3))
            {
                while (dr.Read())
                {
                    count = dr.GetInt32(0);
                }
            }
            point = Convert.ToDouble(count) / Convert.ToDouble(numberofQuestion) * Convert.ToDouble(10);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void ResetAllChoice()
        {
            dt.executeQuery("UPDATE StudentChoice" +
                " SET Choice = 0;");
        }

        public void SaveAll()
        {
            for (int i = 0; i < numberofQuestion; i++)
            {
                id++;
                if (id > numberofQuestion)
                {
                    id = 1;
                }
                lblID.Text = Convert.ToString(id);
                LoadData();

                if (checkBox1.Checked == true)
                {
                    lblAnswer.Text = checkBox1.Text;
                }
                else if (checkBox2.Checked == true)
                {
                    lblAnswer.Text = checkBox2.Text;
                }
                else if (checkBox3.Checked == true)
                {
                    lblAnswer.Text = checkBox3.Text;
                }
                else if (checkBox4.Checked == true)
                {
                    lblAnswer.Text = checkBox4.Text;
                }


                string sql2 = "IF EXISTS (SELECT * FROM StudentChoice WHERE QuestionID = @id) " +
                    "BEGIN " +
                    "UPDATE StudentChoice " +
                    "SET Choice = @choice " +
                    "WHERE QuestionID = @id " +
                    "END " +
                    "ELSE " +
                    "BEGIN " +
                    "INSERT INTO StudentChoice (QuestionID, Choice) " +
                    "VALUES (@id, @choice) " +
                    "END";
                SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id", lblID.Text),
                new SqlParameter("@choice", lblAnswer.Text)
            };
                dt.executeQuery2(sql2, parameters);

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count2--;
            if (count2 == 0)
            {
                timer1.Stop();
                OnTimerElapsed();
            }

            int hours = count2 / 60;
            string formattedNumberHours = hours.ToString("00");
            int minutes = count2 - hours * 60;
            string formattedNumberMinutes = minutes.ToString("00");
            lblMinute.Text = formattedNumberHours;
            lblSecond.Text = formattedNumberMinutes;
        }

        int count2 = 60 * 60;

        public void TimerCount()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void OnTimerElapsed()
        {
            SaveAll();
            TinhDiem();
            MessageBox.Show("Ban dat " + point + " diem");
            Application.Exit();
            ResetAllChoice();
        }

        private string getServerName()
        {

            String strSelect = "SELECT name" +
                " FROM sys.servers" +
                " WHERE is_linked = 0;";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@sub",lblServerName.Text)
            };

            using (IDataReader dr = dt.executeQuery2(strSelect, param))
            {
                if (dr.Read())
                {
                    string server = dr.GetString(0);
                    lblServerName.Text = server;
                }
                dr.Close();
            }

            return "";
        }

        private void lblSecond_Click(object sender, EventArgs e)
        {

        }

        private void lblServerName_Click(object sender, EventArgs e)
        {

        }

        private void lblSoCau_Click(object sender, EventArgs e)
        {

        }



        public void generateButton()
        {
            for (int i = 1; i <= numberofQuestion; i++)
            {
                Button button = new Button()
                {
                    Location = new Point(270 + 20 * i, 392),
                    Size = new Size(19, 22),
                    Text = $"{i}",
                    Name = $"{i}"
                };
                Controls.Add(button);
                button.Click += btn_Click;
            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(((Button)sender).Name);
            lblID.Text = Convert.ToString(id);
            LoadData();

            if (checkBox1.Checked == true)
            {
                lblAnswer.Text = checkBox1.Text;
            }
            else if (checkBox2.Checked == true)
            {
                lblAnswer.Text = checkBox2.Text;
            }
            else if (checkBox3.Checked == true)
            {
                lblAnswer.Text = checkBox3.Text;
            }
            else if (checkBox4.Checked == true)
            {
                lblAnswer.Text = checkBox4.Text;
            }


            string sql2 = "IF EXISTS (SELECT * FROM StudentChoice WHERE QuestionID = @id) " +
                "BEGIN " +
                "UPDATE StudentChoice " +
                "SET Choice = @choice " +
                "WHERE QuestionID = @id " +
                "END " +
                "ELSE " +
                "BEGIN " +
                "INSERT INTO StudentChoice (QuestionID, Choice) " +
                "VALUES (@id, @choice) " +
                "END";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id", lblID.Text),
                new SqlParameter("@choice", lblAnswer.Text)
            };
            dt.executeQuery2(sql2, parameters);
        }

        private void tbxQuestion_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
