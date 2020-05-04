using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManager_CSharp
{
    public partial class InputBoxUpload : Form
    {
        public InputBoxUpload()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (getnames.Text.ToString().Equals(""))
            {
                MessageBox.Show("检查是否输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else
            {
                UpCloudCon upCloudUpload = new UpCloudCon();
                upCloudUpload.WriteFileAsync(getnames.Text.ToString());
                MessageBox.Show("上传成功");
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
