namespace UnicomTICManagementSystem.View
{
    partial class StudentForm
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
            this.labelstudentname = new System.Windows.Forms.Label();
            this.lablestudentcourse = new System.Windows.Forms.Label();
            this.textboxstudentname = new System.Windows.Forms.TextBox();
            this.comboboxstudentcourse = new System.Windows.Forms.ComboBox();
            this.btnstudentadd = new System.Windows.Forms.Button();
            this.btnstudentedit = new System.Windows.Forms.Button();
            this.btnstudentdelete = new System.Windows.Forms.Button();
            this.labelstudenterror = new System.Windows.Forms.Label();
            this.datastudent = new System.Windows.Forms.DataGridView();
            this.labelstudentpassword = new System.Windows.Forms.Label();
            this.textboxstudentpassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datastudent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelstudentname
            // 
            this.labelstudentname.AutoSize = true;
            this.labelstudentname.Location = new System.Drawing.Point(50, 43);
            this.labelstudentname.Name = "labelstudentname";
            this.labelstudentname.Size = new System.Drawing.Size(92, 16);
            this.labelstudentname.TabIndex = 0;
            this.labelstudentname.Text = "Student Name";
            // 
            // lablestudentcourse
            // 
            this.lablestudentcourse.AutoSize = true;
            this.lablestudentcourse.Location = new System.Drawing.Point(53, 100);
            this.lablestudentcourse.Name = "lablestudentcourse";
            this.lablestudentcourse.Size = new System.Drawing.Size(50, 16);
            this.lablestudentcourse.TabIndex = 1;
            this.lablestudentcourse.Text = "Course";
            // 
            // textboxstudentname
            // 
            this.textboxstudentname.Location = new System.Drawing.Point(148, 37);
            this.textboxstudentname.Name = "textboxstudentname";
            this.textboxstudentname.Size = new System.Drawing.Size(100, 22);
            this.textboxstudentname.TabIndex = 2;
            this.textboxstudentname.TextChanged += new System.EventHandler(this.textboxstudentname_TextChanged);
            // 
            // comboboxstudentcourse
            // 
            this.comboboxstudentcourse.FormattingEnabled = true;
            this.comboboxstudentcourse.Location = new System.Drawing.Point(129, 100);
            this.comboboxstudentcourse.Name = "comboboxstudentcourse";
            this.comboboxstudentcourse.Size = new System.Drawing.Size(121, 24);
            this.comboboxstudentcourse.TabIndex = 3;
            this.comboboxstudentcourse.SelectedIndexChanged += new System.EventHandler(this.comboboxstudentcourse_SelectedIndexChanged);
            // 
            // btnstudentadd
            // 
            this.btnstudentadd.Location = new System.Drawing.Point(539, 101);
            this.btnstudentadd.Name = "btnstudentadd";
            this.btnstudentadd.Size = new System.Drawing.Size(75, 23);
            this.btnstudentadd.TabIndex = 4;
            this.btnstudentadd.Text = "Add";
            this.btnstudentadd.UseVisualStyleBackColor = true;
            this.btnstudentadd.Click += new System.EventHandler(this.btnstudentadd_Click);
            // 
            // btnstudentedit
            // 
            this.btnstudentedit.Location = new System.Drawing.Point(82, 370);
            this.btnstudentedit.Name = "btnstudentedit";
            this.btnstudentedit.Size = new System.Drawing.Size(75, 23);
            this.btnstudentedit.TabIndex = 5;
            this.btnstudentedit.Text = "Edit";
            this.btnstudentedit.UseVisualStyleBackColor = true;
            // 
            // btnstudentdelete
            // 
            this.btnstudentdelete.Location = new System.Drawing.Point(190, 370);
            this.btnstudentdelete.Name = "btnstudentdelete";
            this.btnstudentdelete.Size = new System.Drawing.Size(75, 23);
            this.btnstudentdelete.TabIndex = 6;
            this.btnstudentdelete.Text = "Delete";
            this.btnstudentdelete.UseVisualStyleBackColor = true;
            // 
            // labelstudenterror
            // 
            this.labelstudenterror.AutoSize = true;
            this.labelstudenterror.Location = new System.Drawing.Point(112, 400);
            this.labelstudenterror.Name = "labelstudenterror";
            this.labelstudenterror.Size = new System.Drawing.Size(125, 16);
            this.labelstudenterror.TabIndex = 7;
            this.labelstudenterror.Text = "error message here";
            // 
            // datastudent
            // 
            this.datastudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datastudent.Location = new System.Drawing.Point(53, 178);
            this.datastudent.Name = "datastudent";
            this.datastudent.RowHeadersWidth = 51;
            this.datastudent.RowTemplate.Height = 24;
            this.datastudent.Size = new System.Drawing.Size(613, 150);
            this.datastudent.TabIndex = 8;
            // 
            // labelstudentpassword
            // 
            this.labelstudentpassword.AutoSize = true;
            this.labelstudentpassword.Location = new System.Drawing.Point(296, 43);
            this.labelstudentpassword.Name = "labelstudentpassword";
            this.labelstudentpassword.Size = new System.Drawing.Size(67, 16);
            this.labelstudentpassword.TabIndex = 9;
            this.labelstudentpassword.Text = "Password";
            // 
            // textboxstudentpassword
            // 
            this.textboxstudentpassword.Location = new System.Drawing.Point(395, 40);
            this.textboxstudentpassword.Name = "textboxstudentpassword";
            this.textboxstudentpassword.Size = new System.Drawing.Size(100, 22);
            this.textboxstudentpassword.TabIndex = 10;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxstudentpassword);
            this.Controls.Add(this.labelstudentpassword);
            this.Controls.Add(this.datastudent);
            this.Controls.Add(this.labelstudenterror);
            this.Controls.Add(this.btnstudentdelete);
            this.Controls.Add(this.btnstudentedit);
            this.Controls.Add(this.btnstudentadd);
            this.Controls.Add(this.comboboxstudentcourse);
            this.Controls.Add(this.textboxstudentname);
            this.Controls.Add(this.lablestudentcourse);
            this.Controls.Add(this.labelstudentname);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.datastudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelstudentname;
        private System.Windows.Forms.Label lablestudentcourse;
        private System.Windows.Forms.TextBox textboxstudentname;
        private System.Windows.Forms.ComboBox comboboxstudentcourse;
        private System.Windows.Forms.Button btnstudentadd;
        private System.Windows.Forms.Button btnstudentedit;
        private System.Windows.Forms.Button btnstudentdelete;
        private System.Windows.Forms.Label labelstudenterror;
        private System.Windows.Forms.DataGridView datastudent;
        private System.Windows.Forms.Label labelstudentpassword;
        private System.Windows.Forms.TextBox textboxstudentpassword;
    }
}