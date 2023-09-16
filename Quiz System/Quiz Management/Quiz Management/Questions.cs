using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Quiz_Management
{
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
            getSubjects();
            displayQuestions();
            exitPop.Visible = false;
            logoutPop.Visible = false;

        }

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
            SubjectCb.SelectedIndex= 0;



        }




        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuizSystem;Integrated Security=True");

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

        private void label4_Click(object sender, EventArgs e)
        {
            Candidate obj = new Candidate();
            obj.Show();
            this.Hide();
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

        private void QuestionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            logoutPop.Visible = true;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {

        }

        private void SubjectCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AnswerTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Op4Tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Op3Tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Op2Tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Op1Tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuestTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Candidate obj = new Candidate();
            obj.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            logoutPop.Visible= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login2 obj = new Login2();
            obj.Show();
            this.Hide();

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Testing obj = new Testing();
            obj.Show();
            this.Hide();
        }
    }
}