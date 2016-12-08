namespace Cracker._12306
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pic_PassCode = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pic_Refresh = new System.Windows.Forms.PictureBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PassCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_PassCode
            // 
            this.pic_PassCode.Location = new System.Drawing.Point(10, 92);
            this.pic_PassCode.Name = "pic_PassCode";
            this.pic_PassCode.Size = new System.Drawing.Size(293, 190);
            this.pic_PassCode.TabIndex = 0;
            this.pic_PassCode.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Location = new System.Drawing.Point(12, 291);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(293, 23);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // pic_Refresh
            // 
            this.pic_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("pic_Refresh.Image")));
            this.pic_Refresh.Location = new System.Drawing.Point(252, 99);
            this.pic_Refresh.Name = "pic_Refresh";
            this.pic_Refresh.Size = new System.Drawing.Size(51, 18);
            this.pic_Refresh.TabIndex = 2;
            this.pic_Refresh.TabStop = false;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(8, 23);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(47, 12);
            this.lbl_UserName.TabIndex = 3;
            this.lbl_UserName.Text = "用户名:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserName.Location = new System.Drawing.Point(65, 19);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(238, 21);
            this.txt_UserName.TabIndex = 4;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(8, 57);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(47, 12);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "密  码:";
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Location = new System.Drawing.Point(65, 53);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(238, 21);
            this.txt_Password.TabIndex = 6;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 319);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.pic_Refresh);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.pic_PassCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.pic_PassCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_PassCode;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pic_Refresh;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
    }
}