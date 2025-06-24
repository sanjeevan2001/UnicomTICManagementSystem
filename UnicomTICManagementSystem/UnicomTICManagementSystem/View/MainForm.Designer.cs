namespace UnicomTICManagementSystem.View
{
    partial class MainForm
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
            this.labelmainwelcome = new System.Windows.Forms.Label();
            this.btnmaincourses = new System.Windows.Forms.Button();
            this.btnmainstudents = new System.Windows.Forms.Button();
            this.btnmainsubjects = new System.Windows.Forms.Button();
            this.btnmainexams = new System.Windows.Forms.Button();
            this.btnmainmarks = new System.Windows.Forms.Button();
            this.btnmaintimetable = new System.Windows.Forms.Button();
            this.btnmainlogout = new System.Windows.Forms.Button();
            this.btnmainroom = new System.Windows.Forms.Button();
            this.btnmainstudentview = new System.Windows.Forms.Button();
            this.staffandlecturer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelmainwelcome
            // 
            this.labelmainwelcome.AutoSize = true;
            this.labelmainwelcome.Location = new System.Drawing.Point(301, 33);
            this.labelmainwelcome.Name = "labelmainwelcome";
            this.labelmainwelcome.Size = new System.Drawing.Size(65, 16);
            this.labelmainwelcome.TabIndex = 0;
            this.labelmainwelcome.Text = "Welcome";
            this.labelmainwelcome.Click += new System.EventHandler(this.labelmainwelcome_Click);
            // 
            // btnmaincourses
            // 
            this.btnmaincourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnmaincourses.Location = new System.Drawing.Point(136, 179);
            this.btnmaincourses.Name = "btnmaincourses";
            this.btnmaincourses.Size = new System.Drawing.Size(91, 37);
            this.btnmaincourses.TabIndex = 1;
            this.btnmaincourses.Text = "Courses ";
            this.btnmaincourses.UseVisualStyleBackColor = true;
            this.btnmaincourses.Click += new System.EventHandler(this.btnmaincourses_Click);
            // 
            // btnmainstudents
            // 
            this.btnmainstudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnmainstudents.Location = new System.Drawing.Point(431, 95);
            this.btnmainstudents.Name = "btnmainstudents";
            this.btnmainstudents.Size = new System.Drawing.Size(114, 64);
            this.btnmainstudents.TabIndex = 2;
            this.btnmainstudents.Text = "Students";
            this.btnmainstudents.UseVisualStyleBackColor = true;
            this.btnmainstudents.Click += new System.EventHandler(this.btnmainstudents_Click);
            // 
            // btnmainsubjects
            // 
            this.btnmainsubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnmainsubjects.Location = new System.Drawing.Point(351, 179);
            this.btnmainsubjects.Name = "btnmainsubjects";
            this.btnmainsubjects.Size = new System.Drawing.Size(105, 37);
            this.btnmainsubjects.TabIndex = 3;
            this.btnmainsubjects.Text = "Subjects";
            this.btnmainsubjects.UseVisualStyleBackColor = true;
            this.btnmainsubjects.Click += new System.EventHandler(this.btnmainsubjects_Click);
            // 
            // btnmainexams
            // 
            this.btnmainexams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnmainexams.Location = new System.Drawing.Point(479, 179);
            this.btnmainexams.Name = "btnmainexams";
            this.btnmainexams.Size = new System.Drawing.Size(93, 37);
            this.btnmainexams.TabIndex = 4;
            this.btnmainexams.Text = "Exams";
            this.btnmainexams.UseVisualStyleBackColor = true;
            this.btnmainexams.Click += new System.EventHandler(this.btnmainexams_Click);
            // 
            // btnmainmarks
            // 
            this.btnmainmarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnmainmarks.Location = new System.Drawing.Point(363, 244);
            this.btnmainmarks.Name = "btnmainmarks";
            this.btnmainmarks.Size = new System.Drawing.Size(93, 33);
            this.btnmainmarks.TabIndex = 5;
            this.btnmainmarks.Text = "Marks";
            this.btnmainmarks.UseVisualStyleBackColor = true;
            this.btnmainmarks.Click += new System.EventHandler(this.btnmainmarks_Click);
            // 
            // btnmaintimetable
            // 
            this.btnmaintimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnmaintimetable.Location = new System.Drawing.Point(597, 179);
            this.btnmaintimetable.Name = "btnmaintimetable";
            this.btnmaintimetable.Size = new System.Drawing.Size(116, 37);
            this.btnmaintimetable.TabIndex = 6;
            this.btnmaintimetable.Text = "Timetable";
            this.btnmaintimetable.UseVisualStyleBackColor = true;
            this.btnmaintimetable.Click += new System.EventHandler(this.btnmaintimetable_Click);
            // 
            // btnmainlogout
            // 
            this.btnmainlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnmainlogout.Location = new System.Drawing.Point(363, 367);
            this.btnmainlogout.Name = "btnmainlogout";
            this.btnmainlogout.Size = new System.Drawing.Size(93, 36);
            this.btnmainlogout.TabIndex = 7;
            this.btnmainlogout.Text = "Log out";
            this.btnmainlogout.UseVisualStyleBackColor = true;
            this.btnmainlogout.Click += new System.EventHandler(this.btnmainlogout_Click);
            // 
            // btnmainroom
            // 
            this.btnmainroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnmainroom.Location = new System.Drawing.Point(246, 179);
            this.btnmainroom.Name = "btnmainroom";
            this.btnmainroom.Size = new System.Drawing.Size(80, 37);
            this.btnmainroom.TabIndex = 8;
            this.btnmainroom.Text = "Room add";
            this.btnmainroom.UseVisualStyleBackColor = true;
            this.btnmainroom.Click += new System.EventHandler(this.btnmainroom_Click);
            // 
            // btnmainstudentview
            // 
            this.btnmainstudentview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnmainstudentview.Location = new System.Drawing.Point(331, 301);
            this.btnmainstudentview.Name = "btnmainstudentview";
            this.btnmainstudentview.Size = new System.Drawing.Size(143, 37);
            this.btnmainstudentview.TabIndex = 9;
            this.btnmainstudentview.Text = "Studentview";
            this.btnmainstudentview.UseVisualStyleBackColor = true;
            this.btnmainstudentview.Click += new System.EventHandler(this.button1_Click);
            // 
            // staffandlecturer
            // 
            this.staffandlecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.staffandlecturer.Location = new System.Drawing.Point(246, 95);
            this.staffandlecturer.Name = "staffandlecturer";
            this.staffandlecturer.Size = new System.Drawing.Size(139, 64);
            this.staffandlecturer.TabIndex = 10;
            this.staffandlecturer.Text = "Staff and Lecturer";
            this.staffandlecturer.UseVisualStyleBackColor = true;
            this.staffandlecturer.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.staffandlecturer);
            this.Controls.Add(this.btnmainstudentview);
            this.Controls.Add(this.btnmainroom);
            this.Controls.Add(this.btnmainlogout);
            this.Controls.Add(this.btnmaintimetable);
            this.Controls.Add(this.btnmainmarks);
            this.Controls.Add(this.btnmainexams);
            this.Controls.Add(this.btnmainsubjects);
            this.Controls.Add(this.btnmainstudents);
            this.Controls.Add(this.btnmaincourses);
            this.Controls.Add(this.labelmainwelcome);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmainwelcome;
        private System.Windows.Forms.Button btnmaincourses;
        private System.Windows.Forms.Button btnmainstudents;
        private System.Windows.Forms.Button btnmainsubjects;
        private System.Windows.Forms.Button btnmainexams;
        private System.Windows.Forms.Button btnmainmarks;
        private System.Windows.Forms.Button btnmaintimetable;
        private System.Windows.Forms.Button btnmainlogout;
        private System.Windows.Forms.Button btnmainroom;
        private System.Windows.Forms.Button btnmainstudentview;
        private System.Windows.Forms.Button staffandlecturer;
    }
}