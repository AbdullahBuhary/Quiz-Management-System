namespace Quiz_Management
{
    partial class CandidateRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateRegister));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CandidatePtl = new System.Windows.Forms.PictureBox();
            this.LecturerPtl = new System.Windows.Forms.PictureBox();
            this.ExaminerPtl = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.CNameTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.CAgeTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatePtl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerPtl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExaminerPtl)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(200, 480);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(43, 369);
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
            this.label5.Location = new System.Drawing.Point(51, 258);
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
            this.label4.Location = new System.Drawing.Point(46, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Examiner";
            // 
            // CandidatePtl
            // 
            this.CandidatePtl.BackColor = System.Drawing.Color.DodgerBlue;
            this.CandidatePtl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CandidatePtl.Image = ((System.Drawing.Image)(resources.GetObject("CandidatePtl.Image")));
            this.CandidatePtl.Location = new System.Drawing.Point(44, 301);
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
            this.LecturerPtl.Location = new System.Drawing.Point(44, 189);
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
            this.ExaminerPtl.Location = new System.Drawing.Point(44, 74);
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
            this.label3.Location = new System.Drawing.Point(300, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Candidate Registeration";
            // 
            // PasswordTb
            // 
            this.PasswordTb.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PasswordTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTb.Location = new System.Drawing.Point(318, 149);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(266, 29);
            this.PasswordTb.TabIndex = 17;
            // 
            // CNameTb
            // 
            this.CNameTb.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CNameTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CNameTb.Location = new System.Drawing.Point(318, 79);
            this.CNameTb.Name = "CNameTb";
            this.CNameTb.Size = new System.Drawing.Size(266, 29);
            this.CNameTb.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(318, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(316, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // PhoneTb
            // 
            this.PhoneTb.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PhoneTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneTb.Location = new System.Drawing.Point(318, 298);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(266, 29);
            this.PhoneTb.TabIndex = 21;
            // 
            // CAgeTb
            // 
            this.CAgeTb.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CAgeTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CAgeTb.Location = new System.Drawing.Point(318, 228);
            this.CAgeTb.Name = "CAgeTb";
            this.CAgeTb.Size = new System.Drawing.Size(266, 29);
            this.CAgeTb.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(318, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(318, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Age";
            // 
            // AddressTb
            // 
            this.AddressTb.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AddressTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressTb.Location = new System.Drawing.Point(318, 364);
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(266, 29);
            this.AddressTb.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(318, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Address";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.Lime;
            this.RegisterBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterBtn.ForeColor = System.Drawing.Color.Navy;
            this.RegisterBtn.Location = new System.Drawing.Point(386, 422);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(134, 30);
            this.RegisterBtn.TabIndex = 24;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(652, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(472, 193);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 19);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CandidateRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 480);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.CAgeTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.CNameTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CandidateRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandidateRegister";
            this.Load += new System.EventHandler(this.CandidateRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatePtl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerPtl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExaminerPtl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox CandidatePtl;
        private PictureBox LecturerPtl;
        private PictureBox ExaminerPtl;
        private Label label3;
        private TextBox PasswordTb;
        private TextBox CNameTb;
        private Label label8;
        private Label label1;
        private TextBox PhoneTb;
        private TextBox CAgeTb;
        private Label label9;
        private Label label2;
        private TextBox AddressTb;
        private Label label7;
        private Button RegisterBtn;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
    }
}