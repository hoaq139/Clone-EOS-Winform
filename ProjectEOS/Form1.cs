using Microsoft.Data.SqlClient;
using System.Data;
using WinForm_ADO;

namespace ProjectEOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        DataProvider d = new DataProvider();

        private void btnLogin_Click(object sender, EventArgs e)
        {


            String strSelect = "select * from Users " +
                "where account=@acc " +
                "and password=@pass " +
                "and subject = @subject";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@acc",txtAccount.Text),
                new SqlParameter("@pass",txtPassword.Text),
                new SqlParameter("@subject",txtSubject.Text),
            };
            using (IDataReader dr = d.executeQuery2(strSelect, param))
            {
                if (dr.Read())
                {
                    MessageBox.Show("Login success");
                    String name = getNamebyAccount(txtAccount.Text);
                    String subject = getSubjectbyAccount(txtSubject.Text);
                    Form2 f = new Form2(name, subject);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login failed");
                }

            }

        }

        private string getNamebyAccount(string acc)
        {
            String strSelect = "select * from Users where account=@acc";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@acc",txtAccount.Text)
            };

            using (IDataReader dr = d.executeQuery2(strSelect, param))
            {
                if (dr.Read())
                {
                    string name = dr.GetString(2);
                    return name;

                }
                dr.Close();
            }
            return "";
        }

        private string getSubjectbyAccount(string sub)
        {

            String strSelect = "select * from Users where subject=@sub";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@sub",txtSubject.Text)
            };

            using (IDataReader dr = d.executeQuery2(strSelect, param))
            {
                if (dr.Read())
                {
                    string subject = dr.GetString(3);
                    return subject;
                }
                dr.Close();
            }

            return "";
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}