using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManager_CSharp
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultstring = "";
            Encoding encoding = Encoding.Default;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://sancloud.lyqmc.cn/AppJson/"+ getnames1.Text.ToString() + "talk.json");//这里的url指要获取的数据网址
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default))
                {
                    resultstring = reader.ReadToEnd();
                }

                Console.WriteLine(resultstring);

                try {
                    System.IO.File.WriteAllText(@"./talk.json", resultstring, Encoding.Default);
                    MessageBox.Show("配置成功！");
                    Application.Exit();
                    System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                }
                catch (Exception)
                {
                    MessageBox.Show("在服务器上找到了配置文件，但替换失败！\n解决方法：\n关闭本软件，右键本软件图标，\n以管理员身份启动，这是一个已知Bug！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
                }

            }
            catch (Exception)
            {
                MessageBox.Show("在服务器上没有找到关于“" + getnames1.Text.ToString() + "”的记录！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
