namespace WindowsFormsApp1
{
    partial class formsc
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formsc));
            this.label1 = new System.Windows.Forms.Label();
            this.timeChange = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Talk = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.VersionID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(-4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间";
            // 
            // timeChange
            // 
            this.timeChange.AutoSize = true;
            this.timeChange.Font = new System.Drawing.Font("宋体", 40F);
            this.timeChange.Location = new System.Drawing.Point(12, 36);
            this.timeChange.Name = "timeChange";
            this.timeChange.Size = new System.Drawing.Size(158, 54);
            this.timeChange.TabIndex = 1;
            this.timeChange.Text = "10:10";
            this.timeChange.Click += new System.EventHandler(this.timeChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(-4, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "寄语";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Talk
            // 
            this.Talk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Talk.Font = new System.Drawing.Font("宋体", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Talk.Location = new System.Drawing.Point(12, 120);
            this.Talk.Name = "Talk";
            this.Talk.Size = new System.Drawing.Size(158, 81);
            this.Talk.TabIndex = 3;
            this.Talk.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "寄语管理";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "切换视图";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(84, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "版本:";
            // 
            // VersionID
            // 
            this.VersionID.AutoSize = true;
            this.VersionID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VersionID.Location = new System.Drawing.Point(114, 189);
            this.VersionID.Name = "VersionID";
            this.VersionID.Size = new System.Drawing.Size(35, 12);
            this.VersionID.TabIndex = 10;
            this.VersionID.Text = "0.4.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(146, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "(R)";
            // 
            // formsc
            // 
            this.ClientSize = new System.Drawing.Size(182, 210);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VersionID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Talk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeChange);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formsc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label timeChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Talk;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label VersionID;
        private System.Windows.Forms.Label label6;
    }
}

