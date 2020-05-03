namespace WindowsFormsApp1
{
    partial class Manager
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
            this.label1 = new System.Windows.Forms.Label();
            this.timeChange = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Talk = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 25F);
            this.label1.Location = new System.Drawing.Point(-4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "本地时间";
            // 
            // timeChange
            // 
            this.timeChange.AutoSize = true;
            this.timeChange.Font = new System.Drawing.Font("宋体", 40F);
            this.timeChange.Location = new System.Drawing.Point(12, 43);
            this.timeChange.Name = "timeChange";
            this.timeChange.Size = new System.Drawing.Size(158, 54);
            this.timeChange.TabIndex = 1;
            this.timeChange.Text = "10:10";
            this.timeChange.Click += new System.EventHandler(this.timeChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 25F);
            this.label2.Location = new System.Drawing.Point(-4, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "寄语";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Talk
            // 
            this.Talk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Talk.Font = new System.Drawing.Font("宋体", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Talk.Location = new System.Drawing.Point(12, 134);
            this.Talk.Name = "Talk";
            this.Talk.Size = new System.Drawing.Size(158, 96);
            this.Talk.TabIndex = 3;
            this.Talk.Text = "昨天再好，走不回去，明天再难，也要抬脚继续";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(87, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "版本:0.0.1(a)";
            // 
            // Manager
            // 
            this.ClientSize = new System.Drawing.Size(182, 239);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Talk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeChange);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label timeChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Talk;
        private System.Windows.Forms.Label label3;
    }
}

