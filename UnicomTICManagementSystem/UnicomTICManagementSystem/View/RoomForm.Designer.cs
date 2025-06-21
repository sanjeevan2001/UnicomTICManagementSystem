namespace UnicomTICManagementSystem.View
{
    partial class RoomForm
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
            this.textboxroomroomname = new System.Windows.Forms.TextBox();
            this.textboxroomroomtype = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataroom = new System.Windows.Forms.DataGridView();
            this.btnroomadd = new System.Windows.Forms.Button();
            this.btnroomedit = new System.Windows.Forms.Button();
            this.btnroomdelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textroomroomID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataroom)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxroomroomname
            // 
            this.textboxroomroomname.Location = new System.Drawing.Point(268, 52);
            this.textboxroomroomname.Name = "textboxroomroomname";
            this.textboxroomroomname.Size = new System.Drawing.Size(246, 22);
            this.textboxroomroomname.TabIndex = 0;
            // 
            // textboxroomroomtype
            // 
            this.textboxroomroomtype.Location = new System.Drawing.Point(268, 109);
            this.textboxroomroomtype.Name = "textboxroomroomtype";
            this.textboxroomroomtype.Size = new System.Drawing.Size(246, 22);
            this.textboxroomroomtype.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(133, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(133, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room type";
            // 
            // dataroom
            // 
            this.dataroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataroom.Location = new System.Drawing.Point(136, 168);
            this.dataroom.Name = "dataroom";
            this.dataroom.RowHeadersWidth = 51;
            this.dataroom.RowTemplate.Height = 24;
            this.dataroom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataroom.Size = new System.Drawing.Size(495, 150);
            this.dataroom.TabIndex = 4;
            this.dataroom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataroom_CellClick);
            this.dataroom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataroom_CellContentClick);
            // 
            // btnroomadd
            // 
            this.btnroomadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnroomadd.Location = new System.Drawing.Point(556, 74);
            this.btnroomadd.Name = "btnroomadd";
            this.btnroomadd.Size = new System.Drawing.Size(75, 33);
            this.btnroomadd.TabIndex = 5;
            this.btnroomadd.Text = "Add";
            this.btnroomadd.UseVisualStyleBackColor = true;
            this.btnroomadd.Click += new System.EventHandler(this.btnroomadd_Click);
            // 
            // btnroomedit
            // 
            this.btnroomedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnroomedit.Location = new System.Drawing.Point(439, 337);
            this.btnroomedit.Name = "btnroomedit";
            this.btnroomedit.Size = new System.Drawing.Size(75, 32);
            this.btnroomedit.TabIndex = 6;
            this.btnroomedit.Text = "Edit";
            this.btnroomedit.UseVisualStyleBackColor = true;
            this.btnroomedit.Click += new System.EventHandler(this.btnroomedit_Click);
            // 
            // btnroomdelete
            // 
            this.btnroomdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnroomdelete.Location = new System.Drawing.Point(548, 337);
            this.btnroomdelete.Name = "btnroomdelete";
            this.btnroomdelete.Size = new System.Drawing.Size(83, 32);
            this.btnroomdelete.TabIndex = 7;
            this.btnroomdelete.Text = "Delete";
            this.btnroomdelete.UseVisualStyleBackColor = true;
            this.btnroomdelete.Click += new System.EventHandler(this.btnroomdelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Room ID";
            // 
            // textroomroomID
            // 
            this.textroomroomID.Location = new System.Drawing.Point(231, 340);
            this.textroomroomID.Name = "textroomroomID";
            this.textroomroomID.Size = new System.Drawing.Size(100, 22);
            this.textroomroomID.TabIndex = 9;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textroomroomID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnroomdelete);
            this.Controls.Add(this.btnroomedit);
            this.Controls.Add(this.btnroomadd);
            this.Controls.Add(this.dataroom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxroomroomtype);
            this.Controls.Add(this.textboxroomroomname);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataroom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxroomroomname;
        private System.Windows.Forms.TextBox textboxroomroomtype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataroom;
        private System.Windows.Forms.Button btnroomadd;
        private System.Windows.Forms.Button btnroomedit;
        private System.Windows.Forms.Button btnroomdelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textroomroomID;
    }
}