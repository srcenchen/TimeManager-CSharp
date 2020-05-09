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
            this.NewTalkButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewTalkButton
            // 
            this.NewTalkButton.Location = new System.Drawing.Point(13, 49);
            this.NewTalkButton.Name = "NewTalkButton";
            this.NewTalkButton.Size = new System.Drawing.Size(235, 29);
            this.NewTalkButton.TabIndex = 0;
            this.NewTalkButton.Text = "新建寄语配置";
            this.NewTalkButton.UseVisualStyleBackColor = true;
            this.NewTalkButton.Click += new System.EventHandler(this.NewTalkButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "从服务器中载入寄语";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "寄语制作器";
            // 
            // formsc
            // 
            this.ClientSize = new System.Drawing.Size(260, 125);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NewTalkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formsc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewTalkButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

