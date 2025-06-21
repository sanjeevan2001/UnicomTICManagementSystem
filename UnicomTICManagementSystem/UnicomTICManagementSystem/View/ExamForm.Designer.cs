namespace UnicomTICManagementSystem.View
{
    partial class ExamForm
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
            this.textboxexamexamname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexamadd = new System.Windows.Forms.Button();
            this.dataexamview = new System.Windows.Forms.DataGridView();
            this.comboboxexamsubject = new System.Windows.Forms.ComboBox();
            this.labelexamerror = new System.Windows.Forms.Label();
            this.labelexamexamid = new System.Windows.Forms.Label();
            this.labelexamsubjectid = new System.Windows.Forms.Label();
            this.textboxexamexamid = new System.Windows.Forms.TextBox();
            this.textboxexamsubjectid = new System.Windows.Forms.TextBox();
            this.btnexamedit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataexamview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(141, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam Name";
            // 
            // textboxexamexamname
            // 
            this.textboxexamexamname.Location = new System.Drawing.Point(274, 55);
            this.textboxexamexamname.Name = "textboxexamexamname";
            this.textboxexamexamname.Size = new System.Drawing.Size(177, 22);
            this.textboxexamexamname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(141, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject";
            // 
            // btnexamadd
            // 
            this.btnexamadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnexamadd.Location = new System.Drawing.Point(480, 74);
            this.btnexamadd.Name = "btnexamadd";
            this.btnexamadd.Size = new System.Drawing.Size(139, 40);
            this.btnexamadd.TabIndex = 4;
            this.btnexamadd.Text = "Add exam";
            this.btnexamadd.UseVisualStyleBackColor = true;
            this.btnexamadd.Click += new System.EventHandler(this.btnexamadd_Click);
            // 
            // dataexamview
            // 
            this.dataexamview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataexamview.Location = new System.Drawing.Point(146, 170);
            this.dataexamview.Name = "dataexamview";
            this.dataexamview.RowHeadersWidth = 51;
            this.dataexamview.RowTemplate.Height = 24;
            this.dataexamview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataexamview.Size = new System.Drawing.Size(473, 150);
            this.dataexamview.TabIndex = 5;
            this.dataexamview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataexamview_CellClick);
            // 
            // comboboxexamsubject
            // 
            this.comboboxexamsubject.FormattingEnabled = true;
            this.comboboxexamsubject.Location = new System.Drawing.Point(274, 108);
            this.comboboxexamsubject.Name = "comboboxexamsubject";
            this.comboboxexamsubject.Size = new System.Drawing.Size(177, 24);
            this.comboboxexamsubject.TabIndex = 6;
            this.comboboxexamsubject.SelectedIndexChanged += new System.EventHandler(this.comboboxexamsubject_SelectedIndexChanged);
            // 
            // labelexamerror
            // 
            this.labelexamerror.AutoSize = true;
            this.labelexamerror.Location = new System.Drawing.Point(673, 304);
            this.labelexamerror.Name = "labelexamerror";
            this.labelexamerror.Size = new System.Drawing.Size(35, 16);
            this.labelexamerror.TabIndex = 7;
            this.labelexamerror.Text = "error";
            // 
            // labelexamexamid
            // 
            this.labelexamexamid.AutoSize = true;
            this.labelexamexamid.Location = new System.Drawing.Point(143, 356);
            this.labelexamexamid.Name = "labelexamexamid";
            this.labelexamexamid.Size = new System.Drawing.Size(57, 16);
            this.labelexamexamid.TabIndex = 8;
            this.labelexamexamid.Text = "Exam ID";
            this.labelexamexamid.Click += new System.EventHandler(this.labelexamexamid_Click);
            // 
            // labelexamsubjectid
            // 
            this.labelexamsubjectid.AutoSize = true;
            this.labelexamsubjectid.Location = new System.Drawing.Point(401, 356);
            this.labelexamsubjectid.Name = "labelexamsubjectid";
            this.labelexamsubjectid.Size = new System.Drawing.Size(68, 16);
            this.labelexamsubjectid.TabIndex = 9;
            this.labelexamsubjectid.Text = "Subject ID";
            // 
            // textboxexamexamid
            // 
            this.textboxexamexamid.Location = new System.Drawing.Point(206, 353);
            this.textboxexamexamid.Name = "textboxexamexamid";
            this.textboxexamexamid.Size = new System.Drawing.Size(154, 22);
            this.textboxexamexamid.TabIndex = 10;
            // 
            // textboxexamsubjectid
            // 
            this.textboxexamsubjectid.Location = new System.Drawing.Point(480, 356);
            this.textboxexamsubjectid.Name = "textboxexamsubjectid";
            this.textboxexamsubjectid.Size = new System.Drawing.Size(139, 22);
            this.textboxexamsubjectid.TabIndex = 11;
            // 
            // btnexamedit
            // 
            this.btnexamedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnexamedit.Location = new System.Drawing.Point(206, 395);
            this.btnexamedit.Name = "btnexamedit";
            this.btnexamedit.Size = new System.Drawing.Size(75, 35);
            this.btnexamedit.TabIndex = 12;
            this.btnexamedit.Text = "Edit";
            this.btnexamedit.UseVisualStyleBackColor = true;
            this.btnexamedit.Click += new System.EventHandler(this.btnexamedit_Click);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexamedit);
            this.Controls.Add(this.textboxexamsubjectid);
            this.Controls.Add(this.textboxexamexamid);
            this.Controls.Add(this.labelexamsubjectid);
            this.Controls.Add(this.labelexamexamid);
            this.Controls.Add(this.labelexamerror);
            this.Controls.Add(this.comboboxexamsubject);
            this.Controls.Add(this.dataexamview);
            this.Controls.Add(this.btnexamadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxexamexamname);
            this.Controls.Add(this.label1);
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataexamview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxexamexamname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnexamadd;
        private System.Windows.Forms.DataGridView dataexamview;
        private System.Windows.Forms.ComboBox comboboxexamsubject;
        private System.Windows.Forms.Label labelexamerror;
        private System.Windows.Forms.Label labelexamexamid;
        private System.Windows.Forms.Label labelexamsubjectid;
        private System.Windows.Forms.TextBox textboxexamexamid;
        private System.Windows.Forms.TextBox textboxexamsubjectid;
        private System.Windows.Forms.Button btnexamedit;
    }
}