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
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Quiz_Management
{
    public partial class Examiner_addLecturer : Form
    {
        public Examiner_addLecturer()
        {
            InitializeComponent();
            logoutPop.Visible = false;
            displayLecturer();
            exitPop.Visible = false;
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuizSystem;Integrated Security=True");

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
            logoutPop.Visible= true;
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

        private void displayLecturer()
        {
            con.Open();
            String query = "Select * from LecturerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            LecturerDGV.DataSource = ds.Tables[0];
            con.Close();
        }



        private void reset()
        {
           
            
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            exitPop.Visible= true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exitPop.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Testing2 ob = new Testing2();
            ob.Show();
            this.Hide();
        }
    }
}
