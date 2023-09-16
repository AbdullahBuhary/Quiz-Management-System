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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Quiz_Management
{
    public partial class ExaminerRegister : Form
    {
        public ExaminerRegister()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuizSystem;Integrated Security=True");

        private void reset()
        {
            ENameTb.Text = "";
            
            PasswordTb.Text = "";
        }



        private void ExaminerRegister_Load(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (ENameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ExaminerTbl (EName,EPass) values (@En,@Ep)", con);
                    cmd.Parameters.AddWithValue("@En", ENameTb.Text);
                    
                    cmd.Parameters.AddWithValue("@Ep", PasswordTb.Text);

                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully");
                    con.Close();
                    reset();
                    Login3 obj = new Login3();
                    obj.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ExaminerPtl_Click(object sender, EventArgs e)
        {
            Login3 obj = new Login3();
            obj.Show();
            this.Hide();
        }

        private void LecturerPtl_Click(object sender, EventArgs e)
        {
            Login2 obj = new Login2();
            obj.Show();
            this.Hide();
        }

        private void CandidatePtl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                PasswordTb.PasswordChar = '\0';
                checkBox1.Text = "Hide Password";
            }
            else
            {
                PasswordTb.PasswordChar = '*';
                checkBox1.Text = "Show Password";
            }
        }
    }
}
