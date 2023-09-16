using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quiz_Management
{
    public partial class Candidate : Form
    {
        public Candidate()
        {
            InitializeComponent();
            displayCandidates();
            logoutPop.Visible= false;
            exitPop.Visible = false;
        }

        private void reset()
        {
            
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuizSystem;Integrated Security=True");


        private void displayCandidates()
        {
            con.Open();
            String query = "Select * from CandidateTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CandidatesDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Subjects obj = new Subjects();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Subjects obj = new Subjects();
            obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            logoutPop.Visible=true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            logoutPop.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            exitPop.Visible=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exitPop.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Candidate obj = new Candidate();
            obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Testing obj = new Testing();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
