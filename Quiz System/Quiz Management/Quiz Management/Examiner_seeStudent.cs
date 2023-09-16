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
    public partial class Examiner_seeStudent : Form
    {
        public Examiner_seeStudent()
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


        private void label2_Click(object sender, EventArgs e)
        {
            Examiner_AddQuestion obj = new Examiner_AddQuestion();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Examiner_AddQuestion obj = new Examiner_AddQuestion();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Examiner_addLecturer obj = new Examiner_addLecturer();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Examiner_addLecturer obj = new Examiner_addLecturer();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Examiner_seeStudent obj = new Examiner_seeStudent();
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Examiner_seeStudent obj = new Examiner_seeStudent();
            obj.Show();
            this.Hide();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            exitPop.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exitPop.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Testing2 ob = new Testing2();
            ob.Show();
            this.Hide();
        }

        private void ResultsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
