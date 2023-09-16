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
    public partial class Examiner_AddQuestion : Form
    {
        public Examiner_AddQuestion()
        {
            InitializeComponent();
            logoutPop.Visible = false;
            exitPop.Visible = false;
            getSubjects();
            displayQuestions();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuizSystem;Integrated Security=True");


        private void getSubjects()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select SName from SubjectTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SName", typeof(string));
            dt.Load(rdr);
            SubjectCb.ValueMember = "SName";
            SubjectCb.DataSource = dt;

            con.Close();
        }

        private void reset()
        {
            QuestTb.Text = "";
            Op1Tb.Text = "";
            Op2Tb.Text = "";
            Op3Tb.Text = "";
            Op4Tb.Text = "";
            AnswerTb.Text = "";
            SubjectCb.SelectedIndex = 0;



        }

        private void displayQuestions()
        {


            con.Open();
            String query = "Select * from QuestionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            QuestionDGV.DataSource = ds.Tables[0];
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
            logoutPop.Visible= true;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into QuestionTbl (QDesc,QO1,QO2,QO3,QO4,QA,QS) values (@Qd,@Qo1,@Qo2,@Qo3,@Qo4,@Qans,@Qsub)", con);
                    cmd.Parameters.AddWithValue("@Qd", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@Qo1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@Qo2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@Qo3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@Qo4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@Qans", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@Qsub", SubjectCb.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Successfully Added");
                    con.Close();
                    reset();
                    displayQuestions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Testing2 ob = new Testing2();
            ob.Show();
            this.Hide();
        }
    }
}
