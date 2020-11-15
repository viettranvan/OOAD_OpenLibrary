namespace OpenLibrary
{
    partial class frmChanPassword
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
            this.lblTitleChangePassword = new System.Windows.Forms.Label();
            this.grbChangePassword = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTitleConfirmPassword = new System.Windows.Forms.Label();
            this.lblTitleNewPassword = new System.Windows.Forms.Label();
            this.lblTitleCurentPassword = new System.Windows.Forms.Label();
            this.btnConfirmChangePassword = new System.Windows.Forms.Button();
            this.btnCancelChangePassword = new System.Windows.Forms.Button();
            this.grbChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleChangePassword
            // 
            this.lblTitleChangePassword.AutoSize = true;
            this.lblTitleChangePassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChangePassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitleChangePassword.Location = new System.Drawing.Point(145, 26);
            this.lblTitleChangePassword.Name = "lblTitleChangePassword";
            this.lblTitleChangePassword.Size = new System.Drawing.Size(385, 26);
            this.lblTitleChangePassword.TabIndex = 0;
            this.lblTitleChangePassword.Text = "CẬP NHẬT MẬT KHẨU CỦA BẠN";
            // 
            // grbChangePassword
            // 
            this.grbChangePassword.Controls.Add(this.textBox3);
            this.grbChangePassword.Controls.Add(this.textBox2);
            this.grbChangePassword.Controls.Add(this.textBox1);
            this.grbChangePassword.Controls.Add(this.lblTitleConfirmPassword);
            this.grbChangePassword.Controls.Add(this.lblTitleNewPassword);
            this.grbChangePassword.Controls.Add(this.lblTitleCurentPassword);
            this.grbChangePassword.Location = new System.Drawing.Point(73, 75);
            this.grbChangePassword.Name = "grbChangePassword";
            this.grbChangePassword.Size = new System.Drawing.Size(497, 150);
            this.grbChangePassword.TabIndex = 1;
            this.grbChangePassword.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(247, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 22);
            this.textBox1.TabIndex = 0;
            // 
            // lblTitleConfirmPassword
            // 
            this.lblTitleConfirmPassword.AutoSize = true;
            this.lblTitleConfirmPassword.Location = new System.Drawing.Point(37, 111);
            this.lblTitleConfirmPassword.Name = "lblTitleConfirmPassword";
            this.lblTitleConfirmPassword.Size = new System.Drawing.Size(134, 17);
            this.lblTitleConfirmPassword.TabIndex = 0;
            this.lblTitleConfirmPassword.Text = "Xác nhận mật khẩu:";
            // 
            // lblTitleNewPassword
            // 
            this.lblTitleNewPassword.AutoSize = true;
            this.lblTitleNewPassword.Location = new System.Drawing.Point(37, 75);
            this.lblTitleNewPassword.Name = "lblTitleNewPassword";
            this.lblTitleNewPassword.Size = new System.Drawing.Size(96, 17);
            this.lblTitleNewPassword.TabIndex = 0;
            this.lblTitleNewPassword.Text = "Mật khẩu mới:";
            // 
            // lblTitleCurentPassword
            // 
            this.lblTitleCurentPassword.AutoSize = true;
            this.lblTitleCurentPassword.Location = new System.Drawing.Point(37, 41);
            this.lblTitleCurentPassword.Name = "lblTitleCurentPassword";
            this.lblTitleCurentPassword.Size = new System.Drawing.Size(89, 17);
            this.lblTitleCurentPassword.TabIndex = 0;
            this.lblTitleCurentPassword.Text = "Mật khẩu cũ:";
            // 
            // btnConfirmChangePassword
            // 
            this.btnConfirmChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmChangePassword.Image = global::OpenLibrary.Properties.Resources.Edit666;
            this.btnConfirmChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmChangePassword.Location = new System.Drawing.Point(328, 249);
            this.btnConfirmChangePassword.Name = "btnConfirmChangePassword";
            this.btnConfirmChangePassword.Size = new System.Drawing.Size(113, 41);
            this.btnConfirmChangePassword.TabIndex = 3;
            this.btnConfirmChangePassword.Text = "Xác nhận";
            this.btnConfirmChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnCancelChangePassword
            // 
            this.btnCancelChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelChangePassword.Image = global::OpenLibrary.Properties.Resources.exit__2_;
            this.btnCancelChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelChangePassword.Location = new System.Drawing.Point(168, 249);
            this.btnCancelChangePassword.Name = "btnCancelChangePassword";
            this.btnCancelChangePassword.Size = new System.Drawing.Size(113, 41);
            this.btnCancelChangePassword.TabIndex = 10;
            this.btnCancelChangePassword.Text = "Thoát";
            this.btnCancelChangePassword.UseVisualStyleBackColor = true;
            this.btnCancelChangePassword.Click += new System.EventHandler(this.btnCancelChangePassword_Click);
            // 
            // frmChanPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 318);
            this.Controls.Add(this.btnConfirmChangePassword);
            this.Controls.Add(this.btnCancelChangePassword);
            this.Controls.Add(this.grbChangePassword);
            this.Controls.Add(this.lblTitleChangePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmChanPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.grbChangePassword.ResumeLayout(false);
            this.grbChangePassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleChangePassword;
        private System.Windows.Forms.GroupBox grbChangePassword;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTitleConfirmPassword;
        private System.Windows.Forms.Label lblTitleNewPassword;
        private System.Windows.Forms.Label lblTitleCurentPassword;
        private System.Windows.Forms.Button btnCancelChangePassword;
        private System.Windows.Forms.Button btnConfirmChangePassword;
    }
}