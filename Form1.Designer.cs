namespace hienthi1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTK = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTaikhoan = new System.Windows.Forms.Label();
            this.lblAddemail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTK
            // 
            this.lblTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.Location = new System.Drawing.Point(107, 96);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(100, 23);
            this.lblTK.TabIndex = 0;
            this.lblTK.Text = "Tài Khoản";
            this.lblTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(107, 184);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaikhoan
            // 
            this.lblTaikhoan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaikhoan.Location = new System.Drawing.Point(284, 96);
            this.lblTaikhoan.Name = "lblTaikhoan";
            this.lblTaikhoan.Size = new System.Drawing.Size(291, 23);
            this.lblTaikhoan.TabIndex = 2;
            this.lblTaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTaikhoan.Click += new System.EventHandler(this.lblTaikhoan_Click);
            // 
            // lblAddemail
            // 
            this.lblAddemail.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblAddemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddemail.Location = new System.Drawing.Point(284, 184);
            this.lblAddemail.Name = "lblAddemail";
            this.lblAddemail.Size = new System.Drawing.Size(291, 23);
            this.lblAddemail.TabIndex = 3;
            this.lblAddemail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddemail.Click += new System.EventHandler(this.lblAddemail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAddemail);
            this.Controls.Add(this.lblTaikhoan);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTK);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTaikhoan;
        private System.Windows.Forms.Label lblAddemail;
    }
}

