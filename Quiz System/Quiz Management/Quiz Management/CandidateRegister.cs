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
    public partial class CandidateRegister : Form
    {
        public CandidateRegister()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuizSystem;Integrated Security=True");

        private void CandidateRegister_Load(object sender, EventArgs e)
        {

        }

        private void reset()
        {
            CNameTb.Text = "";
            CAgeTb.Text = "";
            AddressTb.Text = "";
            PhoneTb.Text = "";
            PasswordTb.Text = "";
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {

            if (CNameTb.Text == "" || CAgeTb.Text == "" || PasswordTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CandidateTbl (CName,CAge,CPass,CAdd,CPhone) values (@Cn,@Ca,@Cp,@Cad,@Cph)", con);
                    cmd.Parameters.AddWithValue("@Cn", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ca", CAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Cp", PasswordTb.Text);
                    
                    cmd.Parameters.AddWithValue("@Cad", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@Cph", PhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully");
                    con.Close();
                    reset();
                    Login obj = new Login();
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
