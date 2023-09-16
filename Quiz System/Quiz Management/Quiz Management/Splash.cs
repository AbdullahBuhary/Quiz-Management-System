using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Management
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            
        }


        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           // chrono -= 1;
            count += 1;
            MyProgress.Value = count;
           // TimeLbl.Text = "" + chrono;
            if (MyProgress.Value == 50)
            {
                MyProgress.Value = 0;
                timer1.Stop();
              //  MessageBox.Show("Time Over");
                Login log = new Login();
                log.Show();
                this.Hide();


            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void MyProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
