namespace Cracker._12306
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_EndStation = new System.Windows.Forms.Label();
            this.cbx_EndStation = new System.Windows.Forms.ComboBox();
            this.btn_SwapStation = new System.Windows.Forms.Button();
            this.lbl_StartStation = new System.Windows.Forms.Label();
            this.cbx_StartStation = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订票选项";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_EndStation);
            this.panel1.Controls.Add(this.cbx_EndStation);
            this.panel1.Controls.Add(this.btn_SwapStation);
            this.panel1.Controls.Add(this.lbl_StartStation);
            this.panel1.Controls.Add(this.cbx_StartStation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 92);
            this.panel1.TabIndex = 0;
            // 
            // lbl_EndStation
            // 
            this.lbl_EndStation.AutoSize = true;
            this.lbl_EndStation.Location = new System.Drawing.Point(224, 15);
            this.lbl_EndStation.Name = "lbl_EndStation";
            this.lbl_EndStation.Size = new System.Drawing.Size(41, 12);
            this.lbl_EndStation.TabIndex = 4;
            this.lbl_EndStation.Text = "目的：";
            // 
            // cbx_EndStation
            // 
            this.cbx_EndStation.FormattingEnabled = true;
            this.cbx_EndStation.Location = new System.Drawing.Point(271, 12);
            this.cbx_EndStation.Name = "cbx_EndStation";
            this.cbx_EndStation.Size = new System.Drawing.Size(121, 20);
            this.cbx_EndStation.TabIndex = 3;
            // 
            // btn_SwapStation
            // 
            this.btn_SwapStation.Location = new System.Drawing.Point(183, 10);
            this.btn_SwapStation.Name = "btn_SwapStation";
            this.btn_SwapStation.Size = new System.Drawing.Size(35, 23);
            this.btn_SwapStation.TabIndex = 2;
            this.btn_SwapStation.Text = "<->";
            this.btn_SwapStation.UseVisualStyleBackColor = true;
            // 
            // lbl_StartStation
            // 
            this.lbl_StartStation.AutoSize = true;
            this.lbl_StartStation.Location = new System.Drawing.Point(9, 15);
            this.lbl_StartStation.Name = "lbl_StartStation";
            this.lbl_StartStation.Size = new System.Drawing.Size(41, 12);
            this.lbl_StartStation.TabIndex = 1;
            this.lbl_StartStation.Text = "出发：";
            // 
            // cbx_StartStation
            // 
            this.cbx_StartStation.FormattingEnabled = true;
            this.cbx_StartStation.Location = new System.Drawing.Point(56, 12);
            this.cbx_StartStation.Name = "cbx_StartStation";
            this.cbx_StartStation.Size = new System.Drawing.Size(121, 20);
            this.cbx_StartStation.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 206);
            this.panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 206);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 696);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "12306订票助手----Cracker";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_StartStation;
        private System.Windows.Forms.ComboBox cbx_StartStation;
        private System.Windows.Forms.Button btn_SwapStation;
        private System.Windows.Forms.Label lbl_EndStation;
        private System.Windows.Forms.ComboBox cbx_EndStation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}

