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
    public partial class LecturerRegister : Form
    {
        public LecturerRegister()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuizSystem;Integrated Security=True");


        private void reset()
        {
            LNameTb.Text = "";
            UidTb.Text = "";
            LPassTb.Text = "";
            LphoneTb.Text = "";

        }


        private void LecturerRegister_Load(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (LNameTb.Text == "" || UidTb.Text == "" || LPassTb.Text == "" || LphoneTb.Text == "")
            {
                MessageBox.Show("Incomplete Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into LecturerTbl (LName,LUnId,LPass,LPhone) values (@Ln,@Lu,@Lp,@Lph)", con);
                    cmd.Parameters.AddWithValue("@Ln", LNameTb.Text);
                    cmd.Parameters.AddWithValue("@Lu", UidTb.Text);
                    cmd.Parameters.AddWithValue("@Lp", LPassTb.Text);
                    cmd.Parameters.AddWithValue("@Lph", LphoneTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lecturer Successfully Added");
                    con.Close();
                    reset();
                    Login2 obj = new Login2();
                    obj.Show();
                    this.Hide();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CandidatePtl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void LecturerPtl_Click(object sender, EventArgs e)
        {
            Login2 obj = new Login2();
            obj.Show();
            this.Hide();
        }

        private void ExaminerPtl_Click(object sender, EventArgs e)
        {
            Login3 obj = new Login3();
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
                LPassTb.PasswordChar = '\0';
                checkBox1.Text = "Hide Password";
            }
            else
            {
                LPassTb.PasswordChar = '*';
                checkBox1.Text = "Show Password";
            }
        }
    }
}
