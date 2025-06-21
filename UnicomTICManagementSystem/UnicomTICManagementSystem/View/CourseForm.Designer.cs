namespace UnicomTICManagementSystem.View
{
    partial class CourseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textboxcoursename = new System.Windows.Forms.TextBox();
            this.datacourse = new System.Windows.Forms.DataGridView();
            this.btncourseadd = new System.Windows.Forms.Button();
            this.labelcourseerror = new System.Windows.Forms.Label();
            this.btncourseedit = new System.Windows.Forms.Button();
            this.btncoursedelete = new System.Windows.Forms.Button();
            this.labelcoursecourseID = new System.Windows.Forms.Label();
            this.textboxcoursecourseID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datacourse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // textboxcoursename
            // 
            this.textboxcoursename.Location = new System.Drawing.Point(258, 47);
            this.textboxcoursename.Name = "textboxcoursename";
            this.textboxcoursename.Size = new System.Drawing.Size(277, 22);
            this.textboxcoursename.TabIndex = 1;
            // 
            // datacourse
            // 
            this.datacourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacourse.Location = new System.Drawing.Point(128, 106);
            this.datacourse.Name = "datacourse";
            this.datacourse.RowHeadersWidth = 51;
            this.datacourse.RowTemplate.Height = 24;
            this.datacourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datacourse.Size = new System.Drawing.Size(504, 150);
            this.datacourse.TabIndex = 2;
            this.datacourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.datacourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btncourseadd
            // 
            this.btncourseadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncourseadd.Location = new System.Drawing.Point(557, 38);
            this.btncourseadd.Name = "btncourseadd";
            this.btncourseadd.Size = new System.Drawing.Size(75, 35);
            this.btncourseadd.TabIndex = 3;
            this.btncourseadd.Text = "Add";
            this.btncourseadd.UseVisualStyleBackColor = true;
            this.btncourseadd.Click += new System.EventHandler(this.btncourseadd_Click);
            // 
            // labelcourseerror
            // 
            this.labelcourseerror.AutoSize = true;
            this.labelcourseerror.Location = new System.Drawing.Point(329, 402);
            this.labelcourseerror.Name = "labelcourseerror";
            this.labelcourseerror.Size = new System.Drawing.Size(35, 16);
            this.labelcourseerror.TabIndex = 4;
            this.labelcourseerror.Text = "error";
            // 
            // btncourseedit
            // 
            this.btncourseedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncourseedit.Location = new System.Drawing.Point(332, 350);
            this.btncourseedit.Name = "btncourseedit";
            this.btncourseedit.Size = new System.Drawing.Size(107, 35);
            this.btncourseedit.TabIndex = 5;
            this.btncourseedit.Text = "Edit";
            this.btncourseedit.UseVisualStyleBackColor = true;
            this.btncourseedit.Click += new System.EventHandler(this.btncourseedit_Click);
            // 
            // btncoursedelete
            // 
            this.btncoursedelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncoursedelete.Location = new System.Drawing.Point(445, 350);
            this.btncoursedelete.Name = "btncoursedelete";
            this.btncoursedelete.Size = new System.Drawing.Size(93, 35);
            this.btncoursedelete.TabIndex = 6;
            this.btncoursedelete.Text = "Delete";
            this.btncoursedelete.UseVisualStyleBackColor = true;
            this.btncoursedelete.Click += new System.EventHandler(this.btncoursedelete_Click);
            // 
            // labelcoursecourseID
            // 
            this.labelcoursecourseID.AutoSize = true;
            this.labelcoursecourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcoursecourseID.Location = new System.Drawing.Point(199, 301);
            this.labelcoursecourseID.Name = "labelcoursecourseID";
            this.labelcoursecourseID.Size = new System.Drawing.Size(100, 25);
            this.labelcoursecourseID.TabIndex = 7;
            this.labelcoursecourseID.Text = "Course ID";
            // 
            // textboxcoursecourseID
            // 
            this.textboxcoursecourseID.Location = new System.Drawing.Point(332, 295);
            this.textboxcoursecourseID.Name = "textboxcoursecourseID";
            this.textboxcoursecourseID.Size = new System.Drawing.Size(206, 22);
            this.textboxcoursecourseID.TabIndex = 8;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxcoursecourseID);
            this.Controls.Add(this.labelcoursecourseID);
            this.Controls.Add(this.btncoursedelete);
            this.Controls.Add(this.btncourseedit);
            this.Controls.Add(this.labelcourseerror);
            this.Controls.Add(this.btncourseadd);
            this.Controls.Add(this.datacourse);
            this.Controls.Add(this.textboxcoursename);
            this.Controls.Add(this.label1);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.datacourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxcoursename;
        private System.Windows.Forms.DataGridView datacourse;
        private System.Windows.Forms.Button btncourseadd;
        private System.Windows.Forms.Label labelcourseerror;
        private System.Windows.Forms.Button btncourseedit;
        private System.Windows.Forms.Button btncoursedelete;
        private System.Windows.Forms.Label labelcoursecourseID;
        private System.Windows.Forms.TextBox textboxcoursecourseID;
    }
}