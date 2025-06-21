namespace UnicomTICManagementSystem.View
{
    partial class SubjectForm
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
            this.labelsubjectcoursename = new System.Windows.Forms.Label();
            this.labelsubjectsubjectname = new System.Windows.Forms.Label();
            this.comboboxsubjectcoursename = new System.Windows.Forms.ComboBox();
            this.textboxsubjectsubjectname = new System.Windows.Forms.TextBox();
            this.datasubject = new System.Windows.Forms.DataGridView();
            this.btnsubjectadd = new System.Windows.Forms.Button();
            this.btnsubjectedit = new System.Windows.Forms.Button();
            this.btnsubjectdelete = new System.Windows.Forms.Button();
            this.labelsubjecterror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datasubject)).BeginInit();
            this.SuspendLayout();
            // 
            // labelsubjectcoursename
            // 
            this.labelsubjectcoursename.AutoSize = true;
            this.labelsubjectcoursename.Location = new System.Drawing.Point(82, 51);
            this.labelsubjectcoursename.Name = "labelsubjectcoursename";
            this.labelsubjectcoursename.Size = new System.Drawing.Size(87, 16);
            this.labelsubjectcoursename.TabIndex = 0;
            this.labelsubjectcoursename.Text = "Course name";
            // 
            // labelsubjectsubjectname
            // 
            this.labelsubjectsubjectname.AutoSize = true;
            this.labelsubjectsubjectname.Location = new System.Drawing.Point(82, 96);
            this.labelsubjectsubjectname.Name = "labelsubjectsubjectname";
            this.labelsubjectsubjectname.Size = new System.Drawing.Size(92, 16);
            this.labelsubjectsubjectname.TabIndex = 1;
            this.labelsubjectsubjectname.Text = "Subject Name";
            // 
            // comboboxsubjectcoursename
            // 
            this.comboboxsubjectcoursename.FormattingEnabled = true;
            this.comboboxsubjectcoursename.Location = new System.Drawing.Point(196, 43);
            this.comboboxsubjectcoursename.Name = "comboboxsubjectcoursename";
            this.comboboxsubjectcoursename.Size = new System.Drawing.Size(121, 24);
            this.comboboxsubjectcoursename.TabIndex = 3;
            this.comboboxsubjectcoursename.SelectedIndexChanged += new System.EventHandler(this.comboboxsubjectcoursename_SelectedIndexChanged);
            // 
            // textboxsubjectsubjectname
            // 
            this.textboxsubjectsubjectname.Location = new System.Drawing.Point(196, 93);
            this.textboxsubjectsubjectname.Name = "textboxsubjectsubjectname";
            this.textboxsubjectsubjectname.Size = new System.Drawing.Size(121, 22);
            this.textboxsubjectsubjectname.TabIndex = 4;
            // 
            // datasubject
            // 
            this.datasubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasubject.Location = new System.Drawing.Point(85, 139);
            this.datasubject.Name = "datasubject";
            this.datasubject.RowHeadersWidth = 51;
            this.datasubject.RowTemplate.Height = 24;
            this.datasubject.Size = new System.Drawing.Size(529, 150);
            this.datasubject.TabIndex = 5;
            // 
            // btnsubjectadd
            // 
            this.btnsubjectadd.Location = new System.Drawing.Point(416, 88);
            this.btnsubjectadd.Name = "btnsubjectadd";
            this.btnsubjectadd.Size = new System.Drawing.Size(75, 23);
            this.btnsubjectadd.TabIndex = 6;
            this.btnsubjectadd.Text = "Add";
            this.btnsubjectadd.UseVisualStyleBackColor = true;
            this.btnsubjectadd.Click += new System.EventHandler(this.btnsubjectadd_Click);
            // 
            // btnsubjectedit
            // 
            this.btnsubjectedit.Location = new System.Drawing.Point(118, 311);
            this.btnsubjectedit.Name = "btnsubjectedit";
            this.btnsubjectedit.Size = new System.Drawing.Size(75, 23);
            this.btnsubjectedit.TabIndex = 7;
            this.btnsubjectedit.Text = "Edit";
            this.btnsubjectedit.UseVisualStyleBackColor = true;
            // 
            // btnsubjectdelete
            // 
            this.btnsubjectdelete.Location = new System.Drawing.Point(447, 311);
            this.btnsubjectdelete.Name = "btnsubjectdelete";
            this.btnsubjectdelete.Size = new System.Drawing.Size(75, 23);
            this.btnsubjectdelete.TabIndex = 8;
            this.btnsubjectdelete.Text = "Delete";
            this.btnsubjectdelete.UseVisualStyleBackColor = true;
            // 
            // labelsubjecterror
            // 
            this.labelsubjecterror.AutoSize = true;
            this.labelsubjecterror.Location = new System.Drawing.Point(295, 378);
            this.labelsubjecterror.Name = "labelsubjecterror";
            this.labelsubjecterror.Size = new System.Drawing.Size(35, 16);
            this.labelsubjecterror.TabIndex = 9;
            this.labelsubjecterror.Text = "error";
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelsubjecterror);
            this.Controls.Add(this.btnsubjectdelete);
            this.Controls.Add(this.btnsubjectedit);
            this.Controls.Add(this.btnsubjectadd);
            this.Controls.Add(this.datasubject);
            this.Controls.Add(this.textboxsubjectsubjectname);
            this.Controls.Add(this.comboboxsubjectcoursename);
            this.Controls.Add(this.labelsubjectsubjectname);
            this.Controls.Add(this.labelsubjectcoursename);
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.datasubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsubjectcoursename;
        private System.Windows.Forms.Label labelsubjectsubjectname;
        private System.Windows.Forms.ComboBox comboboxsubjectcoursename;
        private System.Windows.Forms.TextBox textboxsubjectsubjectname;
        private System.Windows.Forms.DataGridView datasubject;
        private System.Windows.Forms.Button btnsubjectadd;
        private System.Windows.Forms.Button btnsubjectedit;
        private System.Windows.Forms.Button btnsubjectdelete;
        private System.Windows.Forms.Label labelsubjecterror;
    }
}