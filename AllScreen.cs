using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace TimeManager_CSharp
{
    public partial class AllScreen : Form
    {
        public AllScreen()
        {
            InitializeComponent();
            _syncContext = SynchronizationContext.Current;
        }
        SynchronizationContext _syncContext = null;
        private void AllScreen_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White; this.TransparencyKey = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;     //设置窗体为无边框样式
            this.WindowState = FormWindowState.Maximized;    //最大化窗体
            int x = this.Width;
            int y = this.Height;
            TimeLabel.SetBounds(x / 2 - 196, 10, 0, 0);
            changeButton.SetBounds(0, y - 30, 80, 30);
            exitButton.SetBounds(170, y - 30, 80, 30);
            TalkButton.SetBounds(85, y - 30, 80, 30);
            
            int geti = 0;
            for (int i = 0; i < exitButton.Location.Y - 144; i++)
            {
                geti = i;
            }
            TalkBox.SetBounds((x - x / 4 * 3) / 2, 144, x / 4 * 3, geti);

            Thread thread = new Thread(new ThreadStart(ChangeTimeThread));
            thread.IsBackground = true;
            thread.Start();

            thread1 = new Thread(new ThreadStart(ChangeTalkThread));
            thread1.IsBackground = true;
            thread1.Start();
        }
        Thread thread1;
        public void ChangeTalkThread()
        {
            try
            {
                StreamReader sr = new StreamReader("./talk.json", Encoding.Default);
                String line = sr.ReadLine();
                JsonTextReader jsonTextReader = new JsonTextReader(new StringReader(line));
                JObject jObject = (JObject)JToken.ReadFrom(jsonTextReader);
                int NumberTalk = (int)jObject["hownumber"];
                String[] talk = new String[NumberTalk];
                int[] talkStay = new int[NumberTalk];
                for (int i = 0; i < NumberTalk; i++)
                {
                    int i1 = i + 1;
                    talk[i] = (String)jObject[i + 1 + "t"];
                }

                for (int i = 0; i < NumberTalk; i++)
                {
                    int i1 = i + 1;
                    talkStay[i] = (int)jObject[i + 1 + "ts"];
                }

                sr.Close();

                while (true)
                {
                    for (int i = 0; i < NumberTalk; i++)
                    {
                        _syncContext.Post(SetLabelText1, talk[i]);
                        Thread.Sleep(talkStay[i]);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("使用了不匹配此版本的寄语配置文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                thread1.Abort();
            }

        }
        public void ChangeTimeThread()
        {
            while (true)
            {
                int dateHour = DateTime.Now.Hour;
                int dateMin = DateTime.Now.Minute;
                TimeFont timeFont = new TimeFont();

                //int Number = 0;
                _syncContext.Post(SetLabelText, timeFont.TimeFonts(dateHour) + ":" + timeFont.TimeFonts(dateMin));
                Thread.Sleep(700);
                //Number = 0;
                _syncContext.Post(SetLabelText, timeFont.TimeFonts(dateHour) + " " + timeFont.TimeFonts(dateMin));
                Thread.Sleep(700);

            }
        }

        public void SetLabelText(object text)
        {
            this.TimeLabel.Text = text.ToString();
        }

        public void SetLabelText1(object text)
        {
            this.TalkBox.Text = text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
            System.Environment.Exit(0);
            
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpAndDo upAndDo = new UpAndDo();
            upAndDo.ShowDialog();
        }
    }
}
