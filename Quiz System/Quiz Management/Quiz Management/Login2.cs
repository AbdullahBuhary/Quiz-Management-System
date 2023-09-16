using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Management
{
    public partial class Login2 : Form
    {
        public Login2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuizSystem;Integrated Security=True");

        private void ExaminerPtl_Click(object sender, EventArgs e)
        {
            Login3 lo = new Login3();
            lo.Show();
            this.Hide();
        }

        private void LecturerPtl_Click(object sender, EventArgs e)
        {
            Login2 lo = new Login2();
            lo.Show();
            this.Hide();
        }

        private void CandidatePtl_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Show();
            this.Hide();
        }

        public static String LecId = "";
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || LpassTb.Text == "")
            {
                MessageBox.Show("Missing Id or Password");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from LecturerTbl where LPass='" + LpassTb.Text + "' and LUnId='" + IdTb.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    LecId =IdTb.Text;
                    
                    Questions obj = new Questions();
                    obj.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect ID or Password");
                }
                con.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true) 
            {
                LpassTb.PasswordChar = '\0';
                checkBox1.Text = "Hide Password";
            }
            else
            {
                LpassTb.PasswordChar = '*';
                checkBox1.Text = "Show Password";
            }
        }

        private void RegisterLbl_Click(object sender, EventArgs e)
        {
            LecturerRegister obj = new LecturerRegister();
            obj.Show();
            this.Hide();
        }

        private void Login2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
