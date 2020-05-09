namespace TimeManager_CSharp
{
    partial class AllScreen
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
            this.TimeLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.TalkBox = new System.Windows.Forms.RichTextBox();
            this.TalkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("宋体", 100F);
            this.TimeLabel.Location = new System.Drawing.Point(12, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(392, 134);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "10:10";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(203, 175);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(203, 146);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 2;
            this.changeButton.TabStop = false;
            this.changeButton.Text = "切换视图";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // TalkBox
            // 
            this.TalkBox.BackColor = System.Drawing.Color.White;
            this.TalkBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TalkBox.Font = new System.Drawing.Font("宋体", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TalkBox.Location = new System.Drawing.Point(12, 146);
            this.TalkBox.Name = "TalkBox";
            this.TalkBox.ReadOnly = true;
            this.TalkBox.Size = new System.Drawing.Size(185, 95);
            this.TalkBox.TabIndex = 3;
            this.TalkBox.Text = "";
            // 
            // TalkButton
            // 
            this.TalkButton.Location = new System.Drawing.Point(203, 204);
            this.TalkButton.Name = "TalkButton";
            this.TalkButton.Size = new System.Drawing.Size(75, 23);
            this.TalkButton.TabIndex = 4;
            this.TalkButton.Text = "寄语管理";
            this.TalkButton.UseVisualStyleBackColor = true;
            this.TalkButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AllScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 246);
            this.Controls.Add(this.TalkButton);
            this.Controls.Add(this.TalkBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.TimeLabel);
            this.Name = "AllScreen";
            this.Text = "AllScreen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AllScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.RichTextBox TalkBox;
        private System.Windows.Forms.Button TalkButton;
    }
}