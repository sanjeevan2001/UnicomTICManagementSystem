namespace UnicomTICManagementSystem.View
{
    partial class MarkForm
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
            this.labelmarkstudent = new System.Windows.Forms.Label();
            this.lablemarkexam = new System.Windows.Forms.Label();
            this.lablemarkscore = new System.Windows.Forms.Label();
            this.comboboxmarkstudent = new System.Windows.Forms.ComboBox();
            this.comboboxmarkexam = new System.Windows.Forms.ComboBox();
            this.textboxmarkscore = new System.Windows.Forms.TextBox();
            this.btnmarkadd = new System.Windows.Forms.Button();
            this.btnmarkedit = new System.Windows.Forms.Button();
            this.buttonmarkdelete = new System.Windows.Forms.Button();
            this.datamark = new System.Windows.Forms.DataGridView();
            this.labelmarkerror = new System.Windows.Forms.Label();
            this.textboxmarkstudentid = new System.Windows.Forms.TextBox();
            this.textboxmarkexamid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datamark)).BeginInit();
            this.SuspendLayout();
            // 
            // labelmarkstudent
            // 
            this.labelmarkstudent.AutoSize = true;
            this.labelmarkstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelmarkstudent.Location = new System.Drawing.Point(124, 45);
            this.labelmarkstudent.Name = "labelmarkstudent";
            this.labelmarkstudent.Size = new System.Drawing.Size(80, 25);
            this.labelmarkstudent.TabIndex = 0;
            this.labelmarkstudent.Text = "Student";
            // 
            // lablemarkexam
            // 
            this.lablemarkexam.AutoSize = true;
            this.lablemarkexam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lablemarkexam.Location = new System.Drawing.Point(124, 85);
            this.lablemarkexam.Name = "lablemarkexam";
            this.lablemarkexam.Size = new System.Drawing.Size(62, 25);
            this.lablemarkexam.TabIndex = 1;
            this.lablemarkexam.Text = "Exam";
            // 
            // lablemarkscore
            // 
            this.lablemarkscore.AutoSize = true;
            this.lablemarkscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lablemarkscore.Location = new System.Drawing.Point(124, 132);
            this.lablemarkscore.Name = "lablemarkscore";
            this.lablemarkscore.Size = new System.Drawing.Size(64, 25);
            this.lablemarkscore.TabIndex = 2;
            this.lablemarkscore.Text = "Score";
            // 
            // comboboxmarkstudent
            // 
            this.comboboxmarkstudent.FormattingEnabled = true;
            this.comboboxmarkstudent.Location = new System.Drawing.Point(251, 45);
            this.comboboxmarkstudent.Name = "comboboxmarkstudent";
            this.comboboxmarkstudent.Size = new System.Drawing.Size(243, 24);
            this.comboboxmarkstudent.TabIndex = 3;
            this.comboboxmarkstudent.SelectedIndexChanged += new System.EventHandler(this.comboboxmarkstudent_SelectedIndexChanged);
            // 
            // comboboxmarkexam
            // 
            this.comboboxmarkexam.FormattingEnabled = true;
            this.comboboxmarkexam.Location = new System.Drawing.Point(251, 89);
            this.comboboxmarkexam.Name = "comboboxmarkexam";
            this.comboboxmarkexam.Size = new System.Drawing.Size(243, 24);
            this.comboboxmarkexam.TabIndex = 4;
            this.comboboxmarkexam.SelectedIndexChanged += new System.EventHandler(this.comboboxmarkexam_SelectedIndexChanged);
            // 
            // textboxmarkscore
            // 
            this.textboxmarkscore.Location = new System.Drawing.Point(251, 136);
            this.textboxmarkscore.Name = "textboxmarkscore";
            this.textboxmarkscore.Size = new System.Drawing.Size(243, 22);
            this.textboxmarkscore.TabIndex = 5;
            // 
            // btnmarkadd
            // 
            this.btnmarkadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnmarkadd.Location = new System.Drawing.Point(526, 136);
            this.btnmarkadd.Name = "btnmarkadd";
            this.btnmarkadd.Size = new System.Drawing.Size(100, 31);
            this.btnmarkadd.TabIndex = 6;
            this.btnmarkadd.Text = "Add";
            this.btnmarkadd.UseVisualStyleBackColor = true;
            this.btnmarkadd.Click += new System.EventHandler(this.btnmarkadd_Click);
            // 
            // btnmarkedit
            // 
            this.btnmarkedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnmarkedit.Location = new System.Drawing.Point(406, 370);
            this.btnmarkedit.Name = "btnmarkedit";
            this.btnmarkedit.Size = new System.Drawing.Size(88, 38);
            this.btnmarkedit.TabIndex = 7;
            this.btnmarkedit.Text = "Edit";
            this.btnmarkedit.UseVisualStyleBackColor = true;
            // 
            // buttonmarkdelete
            // 
            this.buttonmarkdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonmarkdelete.Location = new System.Drawing.Point(526, 370);
            this.buttonmarkdelete.Name = "buttonmarkdelete";
            this.buttonmarkdelete.Size = new System.Drawing.Size(91, 38);
            this.buttonmarkdelete.TabIndex = 8;
            this.buttonmarkdelete.Text = "Delete";
            this.buttonmarkdelete.UseVisualStyleBackColor = true;
            // 
            // datamark
            // 
            this.datamark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamark.Location = new System.Drawing.Point(129, 202);
            this.datamark.Name = "datamark";
            this.datamark.RowHeadersWidth = 51;
            this.datamark.RowTemplate.Height = 24;
            this.datamark.Size = new System.Drawing.Size(497, 150);
            this.datamark.TabIndex = 9;
            // 
            // labelmarkerror
            // 
            this.labelmarkerror.AutoSize = true;
            this.labelmarkerror.Location = new System.Drawing.Point(238, 384);
            this.labelmarkerror.Name = "labelmarkerror";
            this.labelmarkerror.Size = new System.Drawing.Size(35, 16);
            this.labelmarkerror.TabIndex = 10;
            this.labelmarkerror.Text = "error";
            // 
            // textboxmarkstudentid
            // 
            this.textboxmarkstudentid.Location = new System.Drawing.Point(526, 48);
            this.textboxmarkstudentid.Name = "textboxmarkstudentid";
            this.textboxmarkstudentid.Size = new System.Drawing.Size(100, 22);
            this.textboxmarkstudentid.TabIndex = 11;
            // 
            // textboxmarkexamid
            // 
            this.textboxmarkexamid.Location = new System.Drawing.Point(526, 91);
            this.textboxmarkexamid.Name = "textboxmarkexamid";
            this.textboxmarkexamid.Size = new System.Drawing.Size(100, 22);
            this.textboxmarkexamid.TabIndex = 12;
            // 
            // MarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxmarkexamid);
            this.Controls.Add(this.textboxmarkstudentid);
            this.Controls.Add(this.labelmarkerror);
            this.Controls.Add(this.datamark);
            this.Controls.Add(this.buttonmarkdelete);
            this.Controls.Add(this.btnmarkedit);
            this.Controls.Add(this.btnmarkadd);
            this.Controls.Add(this.textboxmarkscore);
            this.Controls.Add(this.comboboxmarkexam);
            this.Controls.Add(this.comboboxmarkstudent);
            this.Controls.Add(this.lablemarkscore);
            this.Controls.Add(this.lablemarkexam);
            this.Controls.Add(this.labelmarkstudent);
            this.Name = "MarkForm";
            this.Text = "MarkForm";
            ((System.ComponentModel.ISupportInitialize)(this.datamark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmarkstudent;
        private System.Windows.Forms.Label lablemarkexam;
        private System.Windows.Forms.Label lablemarkscore;
        private System.Windows.Forms.ComboBox comboboxmarkstudent;
        private System.Windows.Forms.ComboBox comboboxmarkexam;
        private System.Windows.Forms.TextBox textboxmarkscore;
        private System.Windows.Forms.Button btnmarkadd;
        private System.Windows.Forms.Button btnmarkedit;
        private System.Windows.Forms.Button buttonmarkdelete;
        private System.Windows.Forms.DataGridView datamark;
        private System.Windows.Forms.Label labelmarkerror;
        private System.Windows.Forms.TextBox textboxmarkstudentid;
        private System.Windows.Forms.TextBox textboxmarkexamid;
    }
}