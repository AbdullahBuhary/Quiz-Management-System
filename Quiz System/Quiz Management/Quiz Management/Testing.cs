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

namespace Quiz_Management
{
    public partial class Testing : Form
    {
        public Testing()
        {
            
            InitializeComponent();
            
            CNameLbl.Text = Login.CandName;
            SubLbl.Text = Login.subName;

            qn = countQuestion();
            
            multiRan();
            fetchQuestions();
            timer1.Start();


            exitPop.Visible = false;
            logoutPop.Visible = false;
        }

        

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuizSystem;Integrated Security=True");

        string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;

        int chrono = 1100;
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            chrono -= 1;
            count += 1;
            TimeBar.Value = count;
            TimeLbl.Text = "" + chrono;
            if (TimeBar.Value == 1100)
            {
                TimeBar.Value = 0;
                timer1.Stop();
                MessageBox.Show("Time Over");
                Login log = new Login();
                log.Show();
                this.Hide();

            }
        }


        private int countQuestion()
        {
            int Qnum;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from QuestionTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Qnum = Convert.ToInt32(dt.Rows[0][0]);

            con.Close();
            //MessageBox.Show("" + Qnum);
            return Qnum;
        }

        string[] Ua = new string[10];

        private int generateRandom()
        {
            Random rd = new Random();
            int x = rd.Next(1, 4);
            int y = rd.Next(1, 4);
            int z = rd.Next(1, 4);
            MessageBox.Show("" + x + "and" + y + "and" + z);
            return x;
        }

        int[] keys = new int[10];
        int qn;
        private void multiRan()
        {
            HashSet<int> numbers = new HashSet<int>();
            var rnd = new Random();
            while (numbers.Count < 10)
            {
                numbers.Add(rnd.Next(1, qn));
            }

            for (int i = 0; i < 10; i++)
            {
                keys[i] = numbers.ElementAt(i);
            }

            //Generate 10 Random Numbers

        }



        private void fetchQuestions()
        {
            try
            {
                //int Qnum = generateRandom();
                con.Open();
                string query = "select * from QuestionTbl where QId=" + keys[0] + "";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q1.Text = dr["QDesc"].ToString();
                    Q1O1.Text = dr["QO1"].ToString();
                    Q1O2.Text = dr["QO2"].ToString();
                    Q1O3.Text = dr["QO3"].ToString();
                    Q1O4.Text = dr["QO4"].ToString();
                    a1 = dr["QA"].ToString();

                }
                string query1 = "select * from QuestionTbl where QId=" + keys[1] + "";
                cmd = new SqlCommand(query1, con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q2.Text = dr["QDesc"].ToString();
                    Q2O1.Text = dr["QO1"].ToString();
                    Q2O2.Text = dr["QO2"].ToString();
                    Q2O3.Text = dr["QO3"].ToString();
                    Q2O4.Text = dr["QO4"].ToString();
                    a2 = dr["QA"].ToString();

                }
                string query2 = "select * from QuestionTbl where QId=" + keys[2] + "";
                cmd = new SqlCommand(query2, con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q3.Text = dr["QDesc"].ToString();
                    Q3O1.Text = dr["QO1"].ToString();
                    Q3O2.Text = dr["QO2"].ToString();
                    Q3O3.Text = dr["QO3"].ToString();
                    Q3O4.Text = dr["QO4"].ToString();
                    a3 = dr["QA"].ToString();

                }
                string query3 = "select * from QuestionTbl where QId=" + keys[3] + "";
                cmd = new SqlCommand(query3, con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q4.Text = dr["QDesc"].ToString();
                    Q4O1.Text = dr["QO1"].ToString();
                    Q4O2.Text = dr["QO2"].ToString();
                    Q4O3.Text = dr["QO3"].ToString();
                    Q4O4.Text = dr["QO4"].ToString();
                    a4 = dr["QA"].ToString();

                }
                string query4 = "select * from QuestionTbl where QId=" + keys[4] + "";
                cmd = new SqlCommand(query4, con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q5.Text = dr["QDesc"].ToString();
                    Q5O1.Text = dr["QO1"].ToString();
                    Q5O2.Text = dr["QO2"].ToString();
                    Q5O3.Text = dr["QO3"].ToString();
                    Q5O4.Text = dr["QO4"].ToString();
                    a5 = dr["QA"].ToString();

                }
                string query5 = "select * from QuestionTbl where QId=" + keys[5] + "";
                cmd = new SqlCommand(query5, con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q6.Text = dr["QDesc"].ToString();
                    Q6O1.Text = dr["QO1"].ToString();
                    Q6O2.Text = dr["QO2"].ToString();
                    Q6O3.Text = dr["QO3"].ToString();
                    Q6O4.Text = dr["QO4"].ToString();
                    a6 = dr["QA"].ToString();

                }
                string query6 = "select * from QuestionTbl where QId=" + keys[6] + "";
                cmd = new SqlCommand(query6, con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q7.Text = dr["QDesc"].ToString();
                    Q7O1.Text = dr["QO1"].ToString();
                    Q7O2.Text = dr["QO2"].ToString();
                    Q7O3.Text = dr["QO3"].ToString();
                    Q7O4.Text = dr["QO4"].ToString();
                    a7 = dr["QA"].ToString();

                }
                string query7 = "select * from QuestionTbl where QId=" + keys[7] + "";
                cmd = new SqlCommand(query7, con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q8.Text = dr["QDesc"].ToString();
                    Q8O1.Text = dr["QO1"].ToString();
                    Q8O2.Text = dr["QO2"].ToString();
                    Q8O3.Text = dr["QO3"].ToString();
                    Q8O4.Text = dr["QO4"].ToString();
                    a8 = dr["QA"].ToString();

                }
                string query8 = "select * from QuestionTbl where QId=" + keys[8] + "";
                cmd = new SqlCommand(query8, con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q9.Text = dr["QDesc"].ToString();
                    Q9O1.Text = dr["QO1"].ToString();
                    Q9O2.Text = dr["QO2"].ToString();
                    Q9O3.Text = dr["QO3"].ToString();
                    Q9O4.Text = dr["QO4"].ToString();
                    a9 = dr["QA"].ToString();

                }
                string query9 = "select * from QuestionTbl where QId=" + keys[9] + "";
                cmd = new SqlCommand(query9, con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q10.Text = dr["QDesc"].ToString();
                    Q10O1.Text = dr["QO1"].ToString();
                    Q10O2.Text = dr["QO2"].ToString();
                    Q10O3.Text = dr["QO3"].ToString();
                    Q10O4.Text = dr["QO4"].ToString();
                    a10 = dr["QA"].ToString();

                }
                con.Close();


            }
            catch (Exception ex)
            {
            }
        }

        int score = 0;

        private void CheckQ1()
        {
            if (Q1O1.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1O1.Text;
            }
            else if (Q1O2.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1O2.Text;
            }
            else if (Q1O3.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1O3.Text;
            }
            else if (Q1O4.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1O4.Text;
            }
            if (Ua[0] == a1)
            {
                score = score + 1;
            }
            else
            {
                //score= score ;
            }
        }

        private void CheckQ2()
        {
            if (Q2O1.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2O1.Text;
            }
            else if (Q1O2.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2O2.Text;
            }
            else if (Q2O3.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2O3.Text;
            }
            else if (Q2O4.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2O4.Text;
            }
            if (Ua[1] == a2)
            {
                score = score + 1;
            }
            else
            {
                // score = score;
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            score = 0;
            CheckQ1();
            CheckQ2();
            CheckQ3();
            CheckQ4();
            CheckQ5();
            CheckQ6();
            CheckQ7();
            CheckQ8();
            CheckQ9();
            CheckQ10();
            MessageBox.Show("Your Score out of 10 is " + score);

            
        }

        private void CheckQ3()
        {
            if (Q3O1.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3O1.Text;
            }
            else if (Q3O2.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3O2.Text;
            }
            else if (Q3O3.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3O3.Text;
            }
            else if (Q3O4.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3O4.Text;
            }
            if (Ua[2] == a3)
            {
                score = score + 1;
            }
            else
            {
                // score = score;
            }
        }

        private void CheckQ4()
        {
            if (Q4O1.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q4O1.Text;
            }
            else if (Q4O2.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q4O2.Text;
            }
            else if (Q4O3.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q4O3.Text;
            }
            else if (Q4O4.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q4O4.Text;
            }
            if (Ua[3] == a4)
            {
                score = score + 1;
            }
            else
            {
                // score = score;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            logoutPop.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login2 obj = new Login2();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Subjects obj = new Subjects();
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Candidate obj = new Candidate();
            obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Testing obj = new Testing();
            obj.Show();
            this.Hide();
        }

        private void CheckQ5()
        {
            if (Q4O1.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q5O1.Text;
            }
            else if (Q5O2.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q5O2.Text;
            }
            else if (Q5O3.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q5O3.Text;
            }
            else if (Q5O4.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q5O4.Text;
            }
            if (Ua[4] == a5)
            {
                score = score + 1;
            }
            else
            {
                // score = score;
            }
        }

        private void CheckQ6()
        {
            if (Q6O1.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q6O1.Text;
            }
            else if (Q6O2.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q6O2.Text;
            }
            else if (Q6O3.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q6O3.Text;
            }
            else if (Q6O4.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q6O4.Text;
            }
            if (Ua[5] == a6)
            {
                score = score + 1;
            }
            else
            {
                // score = score;
            }
        }

        private void CheckQ7()
        {
            if (Q7O1.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q7O1.Text;
            }
            else if (Q7O2.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q7O2.Text;
            }
            else if (Q7O3.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q7O3.Text;
            }
            else if (Q7O4.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q7O4.Text;
            }
            if (Ua[6] == a7)
            {
                score = score + 1;
            }
            else
            {
                // score = score;
            }
        }


        private void CheckQ8()
        {
            if (Q8O1.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q8O1.Text;
            }
            else if (Q8O2.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q8O2.Text;
            }
            else if (Q8O3.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q8O3.Text;
            }
            else if (Q8O4.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q8O4.Text;
            }
            if (Ua[7] == a8)
            {
                score = score + 1;
            }
            else
            {
                // score = score;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            logoutPop.Visible = true;
        }

        private void CheckQ9()
        {
            if (Q9O1.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q9O1.Text;
            }
            else if (Q9O2.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q9O2.Text;
            }
            else if (Q9O3.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q9O3.Text;
            }
            else if (Q9O4.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q9O4.Text;
            }
            if (Ua[8] == a9)
            {
                score = score + 1;
            }
            else
            {
                // score = score;
            }
        }

        private void CheckQ10()
        {
            if (Q10O1.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q10O1.Text;
            }
            else if (Q10O2.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q10O2.Text;
            }
            else if (Q10O3.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q10O3.Text;
            }
            else if (Q10O4.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q10O4.Text;
            }
            if (Ua[9] == a10)
            {
                score = score + 1;
            }
            else
            {
                // score = score;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

    }
}
