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
    public partial class CandidatePortal : Form
    {
        public CandidatePortal()
        {
            InitializeComponent();
            displayResults();
            logoutPop.Visible = false;
            exitPop.Visible = false;
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuizSystem;Integrated Security=True");

        private void displayResults()
        {
            con.Open();
            String query = "Select * from ResultTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ResultsDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void CandidatePortal_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            exitPop.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exitPop.Visible=false;
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
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CandidatePortal obj = new CandidatePortal();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Exams obj = new Exams();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CandidatePortal obj = new CandidatePortal();
            obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Exams obj = new Exams();
            obj.Show();
            this.Hide();
        }
    }
}
