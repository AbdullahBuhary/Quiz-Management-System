namespace Quiz_Management
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CandidatePtl = new System.Windows.Forms.PictureBox();
            this.LecturerPtl = new System.Windows.Forms.PictureBox();
            this.ExaminerPtl = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserTb = new System.Windows.Forms.TextBox();
            this.PassTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.RegisterLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatePtl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerPtl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExaminerPtl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CandidatePtl);
            this.panel1.Controls.Add(this.LecturerPtl);
            this.panel1.Controls.Add(this.ExaminerPtl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 463);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(43, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Candidate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(51, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Lecturer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Examiner";
            // 
            // CandidatePtl
            // 
            this.CandidatePtl.BackColor = System.Drawing.Color.Silver;
            this.CandidatePtl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CandidatePtl.Image = ((System.Drawing.Image)(resources.GetObject("CandidatePtl.Image")));
            this.CandidatePtl.Location = new System.Drawing.Point(44, 283);
            this.CandidatePtl.Name = "CandidatePtl";
            this.CandidatePtl.Size = new System.Drawing.Size(102, 66);
            this.CandidatePtl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CandidatePtl.TabIndex = 22;
            this.CandidatePtl.TabStop = false;
            this.CandidatePtl.Click += new System.EventHandler(this.CandidatePtl_Click);
            // 
            // LecturerPtl
            // 
            this.LecturerPtl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LecturerPtl.Image = ((System.Drawing.Image)(resources.GetObject("LecturerPtl.Image")));
            this.LecturerPtl.Location = new System.Drawing.Point(44, 171);
            this.LecturerPtl.Name = "LecturerPtl";
            this.LecturerPtl.Size = new System.Drawing.Size(102, 66);
            this.LecturerPtl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LecturerPtl.TabIndex = 21;
            this.LecturerPtl.TabStop = false;
            this.LecturerPtl.Click += new System.EventHandler(this.LecturerPtl_Click);
            // 
            // ExaminerPtl
            // 
            this.ExaminerPtl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExaminerPtl.Image = ((System.Drawing.Image)(resources.GetObject("ExaminerPtl.Image")));
            this.ExaminerPtl.Location = new System.Drawing.Point(44, 56);
            this.ExaminerPtl.Name = "ExaminerPtl";
            this.ExaminerPtl.Size = new System.Drawing.Size(102, 66);
            this.ExaminerPtl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExaminerPtl.TabIndex = 20;
            this.ExaminerPtl.TabStop = false;
            this.ExaminerPtl.Click += new System.EventHandler(this.ExaminerPtl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(339, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quiz Management";
            // 
            // UserTb
            // 
            this.UserTb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.UserTb.Location = new System.Drawing.Point(278, 203);
            this.UserTb.Name = "UserTb";
            this.UserTb.Size = new System.Drawing.Size(345, 32);
            this.UserTb.TabIndex = 4;
            // 
            // PassTb
            // 
            this.PassTb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PassTb.Location = new System.Drawing.Point(278, 276);
            this.PassTb.Name = "PassTb";
            this.PassTb.PasswordChar = '*';
            this.PassTb.Size = new System.Drawing.Size(345, 32);
            this.PassTb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(278, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(278, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Lime;
            this.LoginBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.ForeColor = System.Drawing.Color.Navy;
            this.LoginBtn.Location = new System.Drawing.Point(339, 351);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(223, 48);
            this.LoginBtn.TabIndex = 18;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(358, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(515, 314);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 19);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RegisterLbl
            // 
            this.RegisterLbl.AutoSize = true;
            this.RegisterLbl.BackColor = System.Drawing.Color.Transparent;
            this.RegisterLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterLbl.ForeColor = System.Drawing.Color.Red;
            this.RegisterLbl.Location = new System.Drawing.Point(347, 416);
            this.RegisterLbl.Name = "RegisterLbl";
            this.RegisterLbl.Size = new System.Drawing.Size(208, 25);
            this.RegisterLbl.TabIndex = 32;
            this.RegisterLbl.Text = "Register as a Candidate";
            this.RegisterLbl.Click += new System.EventHandler(this.RegisterLbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(666, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegisterLbl);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.UserTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatePtl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerPtl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExaminerPtl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox UserTb;
        private TextBox PassTb;
        private Label label1;
        private Label label2;
        private Button LoginBtn;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox CandidatePtl;
        private PictureBox LecturerPtl;
        private PictureBox ExaminerPtl;
        private CheckBox checkBox1;
        private Label RegisterLbl;
        private PictureBox pictureBox1;
    }
}