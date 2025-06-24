namespace UnicomTICManagementSystem.View
{
    partial class StudentviewForm
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
            this.studentviewwelcome = new System.Windows.Forms.Label();
            this.timetable = new System.Windows.Forms.DataGridView();
            this.marks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marks)).BeginInit();
            this.SuspendLayout();
            // 
            // studentviewwelcome
            // 
            this.studentviewwelcome.AutoSize = true;
            this.studentviewwelcome.Location = new System.Drawing.Point(341, 38);
            this.studentviewwelcome.Name = "studentviewwelcome";
            this.studentviewwelcome.Size = new System.Drawing.Size(64, 16);
            this.studentviewwelcome.TabIndex = 0;
            this.studentviewwelcome.Text = "welcome ";
            // 
            // timetable
            // 
            this.timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetable.Location = new System.Drawing.Point(125, 115);
            this.timetable.Name = "timetable";
            this.timetable.RowHeadersWidth = 51;
            this.timetable.RowTemplate.Height = 24;
            this.timetable.Size = new System.Drawing.Size(565, 109);
            this.timetable.TabIndex = 1;
            this.timetable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.timetable_CellClick);
            // 
            // marks
            // 
            this.marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marks.Location = new System.Drawing.Point(125, 267);
            this.marks.Name = "marks";
            this.marks.RowHeadersWidth = 51;
            this.marks.RowTemplate.Height = 24;
            this.marks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.marks.Size = new System.Drawing.Size(565, 109);
            this.marks.TabIndex = 2;
            this.marks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.marks_CellClick);
            this.marks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.marks_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "timetable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "marks";
            // 
            // Studentview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marks);
            this.Controls.Add(this.timetable);
            this.Controls.Add(this.studentviewwelcome);
            this.Name = "Studentview";
            this.Text = "Studentview";
            ((System.ComponentModel.ISupportInitialize)(this.timetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentviewwelcome;
        private System.Windows.Forms.DataGridView timetable;
        private System.Windows.Forms.DataGridView marks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}