namespace UnicomTICManagementSystem.View
{
    partial class Staff_and_Lecturer
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
            this.labelstaff = new System.Windows.Forms.Label();
            this.textstaff = new System.Windows.Forms.TextBox();
            this.staffadd = new System.Windows.Forms.Button();
            this.textboxlecturer = new System.Windows.Forms.TextBox();
            this.labellecturer = new System.Windows.Forms.Label();
            this.staffpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lecturerpassword = new System.Windows.Forms.TextBox();
            this.labellecturepassword = new System.Windows.Forms.Label();
            this.lectureraddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lecturerphonenumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lectureradd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelstaff
            // 
            this.labelstaff.AutoSize = true;
            this.labelstaff.Location = new System.Drawing.Point(55, 48);
            this.labelstaff.Name = "labelstaff";
            this.labelstaff.Size = new System.Drawing.Size(70, 16);
            this.labelstaff.TabIndex = 0;
            this.labelstaff.Text = "Staff name";
            // 
            // textstaff
            // 
            this.textstaff.Location = new System.Drawing.Point(149, 41);
            this.textstaff.Name = "textstaff";
            this.textstaff.Size = new System.Drawing.Size(100, 22);
            this.textstaff.TabIndex = 1;
            // 
            // staffadd
            // 
            this.staffadd.Location = new System.Drawing.Point(301, 64);
            this.staffadd.Name = "staffadd";
            this.staffadd.Size = new System.Drawing.Size(75, 23);
            this.staffadd.TabIndex = 2;
            this.staffadd.Text = "Add";
            this.staffadd.UseVisualStyleBackColor = true;
            this.staffadd.Click += new System.EventHandler(this.staffadd_Click);
            // 
            // textboxlecturer
            // 
            this.textboxlecturer.Location = new System.Drawing.Point(182, 184);
            this.textboxlecturer.Name = "textboxlecturer";
            this.textboxlecturer.Size = new System.Drawing.Size(100, 22);
            this.textboxlecturer.TabIndex = 4;
            this.textboxlecturer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labellecturer
            // 
            this.labellecturer.AutoSize = true;
            this.labellecturer.Location = new System.Drawing.Point(88, 191);
            this.labellecturer.Name = "labellecturer";
            this.labellecturer.Size = new System.Drawing.Size(92, 16);
            this.labellecturer.TabIndex = 3;
            this.labellecturer.Text = "Lecturer name";
            this.labellecturer.Click += new System.EventHandler(this.label1_Click);
            // 
            // staffpassword
            // 
            this.staffpassword.Location = new System.Drawing.Point(149, 85);
            this.staffpassword.Name = "staffpassword";
            this.staffpassword.Size = new System.Drawing.Size(100, 22);
            this.staffpassword.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password";
            // 
            // lecturerpassword
            // 
            this.lecturerpassword.Location = new System.Drawing.Point(182, 282);
            this.lecturerpassword.Name = "lecturerpassword";
            this.lecturerpassword.Size = new System.Drawing.Size(100, 22);
            this.lecturerpassword.TabIndex = 8;
            // 
            // labellecturepassword
            // 
            this.labellecturepassword.AutoSize = true;
            this.labellecturepassword.Location = new System.Drawing.Point(88, 289);
            this.labellecturepassword.Name = "labellecturepassword";
            this.labellecturepassword.Size = new System.Drawing.Size(67, 16);
            this.labellecturepassword.TabIndex = 7;
            this.labellecturepassword.Text = "Password";
            // 
            // lectureraddress
            // 
            this.lectureraddress.Location = new System.Drawing.Point(182, 223);
            this.lectureraddress.Name = "lectureraddress";
            this.lectureraddress.Size = new System.Drawing.Size(100, 22);
            this.lectureraddress.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Address";
            // 
            // lecturerphonenumber
            // 
            this.lecturerphonenumber.Location = new System.Drawing.Point(182, 254);
            this.lecturerphonenumber.Name = "lecturerphonenumber";
            this.lecturerphonenumber.Size = new System.Drawing.Size(100, 22);
            this.lecturerphonenumber.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone number";
            // 
            // lectureradd
            // 
            this.lectureradd.Location = new System.Drawing.Point(333, 213);
            this.lectureradd.Name = "lectureradd";
            this.lectureradd.Size = new System.Drawing.Size(75, 23);
            this.lectureradd.TabIndex = 13;
            this.lectureradd.Text = "Add";
            this.lectureradd.UseVisualStyleBackColor = true;
            this.lectureradd.Click += new System.EventHandler(this.lectureradd_Click);
            // 
            // Staff_and_Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lectureradd);
            this.Controls.Add(this.lecturerphonenumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lectureraddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lecturerpassword);
            this.Controls.Add(this.labellecturepassword);
            this.Controls.Add(this.staffpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxlecturer);
            this.Controls.Add(this.labellecturer);
            this.Controls.Add(this.staffadd);
            this.Controls.Add(this.textstaff);
            this.Controls.Add(this.labelstaff);
            this.Name = "Staff_and_Lecturer";
            this.Text = "Staff_and_Lecturer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelstaff;
        private System.Windows.Forms.TextBox textstaff;
        private System.Windows.Forms.Button staffadd;
        private System.Windows.Forms.TextBox textboxlecturer;
        private System.Windows.Forms.Label labellecturer;
        private System.Windows.Forms.TextBox staffpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lecturerpassword;
        private System.Windows.Forms.Label labellecturepassword;
        private System.Windows.Forms.TextBox lectureraddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lecturerphonenumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button lectureradd;
    }
}