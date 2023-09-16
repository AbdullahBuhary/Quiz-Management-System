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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
            displaySubjects();
            exitPop.Visible = false;
            logoutPop.Visible = false;
        }

        
        private void reset()
        {
            SNameTb.Text = "";
            
            
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuizSystem;Integrated Security=True");


        private void displaySubjects()
        {
            con.Open();
            String query = "Select * from SubjectTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SubjectDGV.DataSource = ds.Tables[0];
            con.Close();
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SubjectTbl (SName) values (@Sn)", con);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Successfully Added");
                    con.Close();
                    reset();
                    displaySubjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void SubjectDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Candidate obj = new Candidate();
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Candidate obj = new Candidate();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            exitPop.Visible= true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exitPop.Visible= false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            logoutPop.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            logoutPop.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login2 obj = new Login2();
            obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Testing ob = new Testing();
            ob.Show();
            this.Hide();
        }
    }
}
