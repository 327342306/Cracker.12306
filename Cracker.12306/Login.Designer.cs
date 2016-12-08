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
            ((System.ComponentModel.ISupportInitialize)(this.pic_PassCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_PassCode
            // 
            this.pic_PassCode.Location = new System.Drawing.Point(12, 118);
            this.pic_PassCode.Name = "pic_PassCode";
            this.pic_PassCode.Size = new System.Drawing.Size(293, 190);
            this.pic_PassCode.TabIndex = 0;
            this.pic_PassCode.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Location = new System.Drawing.Point(12, 89);
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
            this.pic_Refresh.Location = new System.Drawing.Point(252, 122);
            this.pic_Refresh.Name = "pic_Refresh";
            this.pic_Refresh.Size = new System.Drawing.Size(51, 18);
            this.pic_Refresh.TabIndex = 2;
            this.pic_Refresh.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 319);
            this.Controls.Add(this.pic_Refresh);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.pic_PassCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pic_PassCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Refresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_PassCode;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pic_Refresh;
    }
}