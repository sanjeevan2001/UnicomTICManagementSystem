namespace UnicomTICManagementSystem
{
    partial class LoginForm
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
            this.textboxloginusername = new System.Windows.Forms.TextBox();
            this.textboxloginpassword = new System.Windows.Forms.TextBox();
            this.btnloginlogin = new System.Windows.Forms.Button();
            this.lableloginerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textboxloginusername
            // 
            this.textboxloginusername.Location = new System.Drawing.Point(297, 105);
            this.textboxloginusername.Name = "textboxloginusername";
            this.textboxloginusername.Size = new System.Drawing.Size(289, 22);
            this.textboxloginusername.TabIndex = 2;
            // 
            // textboxloginpassword
            // 
            this.textboxloginpassword.Location = new System.Drawing.Point(297, 164);
            this.textboxloginpassword.Name = "textboxloginpassword";
            this.textboxloginpassword.Size = new System.Drawing.Size(289, 22);
            this.textboxloginpassword.TabIndex = 3;
            // 
            // btnloginlogin
            // 
            this.btnloginlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloginlogin.Location = new System.Drawing.Point(297, 221);
            this.btnloginlogin.Name = "btnloginlogin";
            this.btnloginlogin.Size = new System.Drawing.Size(139, 44);
            this.btnloginlogin.TabIndex = 4;
            this.btnloginlogin.Text = "Login";
            this.btnloginlogin.UseVisualStyleBackColor = true;
            this.btnloginlogin.Click += new System.EventHandler(this.btnloginlogin_Click);
            // 
            // lableloginerror
            // 
            this.lableloginerror.AutoSize = true;
            this.lableloginerror.ForeColor = System.Drawing.Color.Red;
            this.lableloginerror.Location = new System.Drawing.Point(294, 287);
            this.lableloginerror.Name = "lableloginerror";
            this.lableloginerror.Size = new System.Drawing.Size(0, 16);
            this.lableloginerror.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lableloginerror);
            this.Controls.Add(this.btnloginlogin);
            this.Controls.Add(this.textboxloginpassword);
            this.Controls.Add(this.textboxloginusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxloginusername;
        private System.Windows.Forms.TextBox textboxloginpassword;
        private System.Windows.Forms.Button btnloginlogin;
        private System.Windows.Forms.Label lableloginerror;
    }
}

