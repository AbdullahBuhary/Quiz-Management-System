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
    public partial class Login : Form
    {

        
        
        public Login()
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

        public static String CandName = "",subName="";

       

        private void SubjectCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                PassTb.PasswordChar = '\0';
                checkBox1.Text = "Hide Password";
            }
            else
            {
                PassTb.PasswordChar = '*';
                checkBox1.Text = "Show Password";
            }
        }

        private void RegisterLbl_Click(object sender, EventArgs e)
        {
            CandidateRegister obj = new CandidateRegister();
            obj.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UserTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Missing Username or Password");
            }
            else
            {
                
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CandidateTbl where CPass='" + PassTb.Text + "' and CName='" + UserTb.Text+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CandName = UserTb.Text;
                    
                    CandidatePortal obj = new CandidatePortal();
                    obj.Show();
                    this.Hide();
                    con.Close();
                }else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
                con.Close();
            }
        }
    }
}
