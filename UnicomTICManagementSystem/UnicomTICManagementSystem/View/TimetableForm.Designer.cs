namespace UnicomTICManagementSystem.View
{
    partial class TimetableForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btntimetableadd = new System.Windows.Forms.Button();
            this.btntimetableedit = new System.Windows.Forms.Button();
            this.btntimetabledelete = new System.Windows.Forms.Button();
            this.datatimetable = new System.Windows.Forms.DataGridView();
            this.textboxtimetabletimeslot = new System.Windows.Forms.TextBox();
            this.comboboxtimetableroom = new System.Windows.Forms.ComboBox();
            this.comboboxtimetablesubject = new System.Windows.Forms.ComboBox();
            this.labeltimetableerror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datatimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time slot";
            // 
            // btntimetableadd
            // 
            this.btntimetableadd.Location = new System.Drawing.Point(52, 156);
            this.btntimetableadd.Name = "btntimetableadd";
            this.btntimetableadd.Size = new System.Drawing.Size(120, 23);
            this.btntimetableadd.TabIndex = 3;
            this.btntimetableadd.Text = "Add time slot";
            this.btntimetableadd.UseVisualStyleBackColor = true;
            // 
            // btntimetableedit
            // 
            this.btntimetableedit.Location = new System.Drawing.Point(20, 373);
            this.btntimetableedit.Name = "btntimetableedit";
            this.btntimetableedit.Size = new System.Drawing.Size(75, 23);
            this.btntimetableedit.TabIndex = 4;
            this.btntimetableedit.Text = "Edit";
            this.btntimetableedit.UseVisualStyleBackColor = true;
            // 
            // btntimetabledelete
            // 
            this.btntimetabledelete.Location = new System.Drawing.Point(189, 372);
            this.btntimetabledelete.Name = "btntimetabledelete";
            this.btntimetabledelete.Size = new System.Drawing.Size(75, 23);
            this.btntimetabledelete.TabIndex = 5;
            this.btntimetabledelete.Text = "Delete";
            this.btntimetabledelete.UseVisualStyleBackColor = true;
            // 
            // datatimetable
            // 
            this.datatimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatimetable.Location = new System.Drawing.Point(30, 201);
            this.datatimetable.Name = "datatimetable";
            this.datatimetable.RowHeadersWidth = 51;
            this.datatimetable.RowTemplate.Height = 24;
            this.datatimetable.Size = new System.Drawing.Size(446, 150);
            this.datatimetable.TabIndex = 6;
            // 
            // textboxtimetabletimeslot
            // 
            this.textboxtimetabletimeslot.Location = new System.Drawing.Point(133, 108);
            this.textboxtimetabletimeslot.Name = "textboxtimetabletimeslot";
            this.textboxtimetabletimeslot.Size = new System.Drawing.Size(121, 22);
            this.textboxtimetabletimeslot.TabIndex = 7;
            // 
            // comboboxtimetableroom
            // 
            this.comboboxtimetableroom.FormattingEnabled = true;
            this.comboboxtimetableroom.Location = new System.Drawing.Point(133, 66);
            this.comboboxtimetableroom.Name = "comboboxtimetableroom";
            this.comboboxtimetableroom.Size = new System.Drawing.Size(121, 24);
            this.comboboxtimetableroom.TabIndex = 8;
            // 
            // comboboxtimetablesubject
            // 
            this.comboboxtimetablesubject.FormattingEnabled = true;
            this.comboboxtimetablesubject.Location = new System.Drawing.Point(133, 25);
            this.comboboxtimetablesubject.Name = "comboboxtimetablesubject";
            this.comboboxtimetablesubject.Size = new System.Drawing.Size(121, 24);
            this.comboboxtimetablesubject.TabIndex = 9;
            // 
            // labeltimetableerror
            // 
            this.labeltimetableerror.AutoSize = true;
            this.labeltimetableerror.Location = new System.Drawing.Point(441, 108);
            this.labeltimetableerror.Name = "labeltimetableerror";
            this.labeltimetableerror.Size = new System.Drawing.Size(35, 16);
            this.labeltimetableerror.TabIndex = 10;
            this.labeltimetableerror.Text = "error";
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeltimetableerror);
            this.Controls.Add(this.comboboxtimetablesubject);
            this.Controls.Add(this.comboboxtimetableroom);
            this.Controls.Add(this.textboxtimetabletimeslot);
            this.Controls.Add(this.datatimetable);
            this.Controls.Add(this.btntimetabledelete);
            this.Controls.Add(this.btntimetableedit);
            this.Controls.Add(this.btntimetableadd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TimetableForm";
            this.Text = "TimetableForm";
            ((System.ComponentModel.ISupportInitialize)(this.datatimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntimetableadd;
        private System.Windows.Forms.Button btntimetableedit;
        private System.Windows.Forms.Button btntimetabledelete;
        private System.Windows.Forms.DataGridView datatimetable;
        private System.Windows.Forms.TextBox textboxtimetabletimeslot;
        private System.Windows.Forms.ComboBox comboboxtimetableroom;
        private System.Windows.Forms.ComboBox comboboxtimetablesubject;
        private System.Windows.Forms.Label labeltimetableerror;
    }
}