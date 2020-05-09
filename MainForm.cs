using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TimeManager_CSharp;

namespace WindowsFormsApp1
{
    public partial class formsc : Form
    {
        public Form Form1;
        static int Number = 0;
        SynchronizationContext _syncContext = null;
        public formsc()
        {
            InitializeComponent();
            Form1 = this;
            _syncContext = SynchronizationContext.Current;
            
            
        }
        Thread thread1;
        public void Manager_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ChangeTimeThread));
            thread.IsBackground = true;
            thread.Start();

            thread1 = new Thread(new ThreadStart(ChangeTalkThread));
            thread1.IsBackground = true;
            thread1.Start();
        }

        public void ChangeTalkThread()
        {
            try {
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
                        Number = 1;
                        _syncContext.Post(SetLabelText, talk[i]);
                        Thread.Sleep(talkStay[i]);
                    }

                }
            } catch (Exception)
            {
                Number = 2;
                _syncContext.Post(SetLabelText, "");
               MessageBox.Show("使用了不匹配此版本的寄语配置文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Number = 3;
                _syncContext.Post(SetLabelText, "");
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

                Number = 0;
                _syncContext.Post(SetLabelText, timeFont.TimeFonts(dateHour) + ":" + timeFont.TimeFonts(dateMin));
                Thread.Sleep(700);
                Number = 0;
                _syncContext.Post(SetLabelText, timeFont.TimeFonts(dateHour) + " " + timeFont.TimeFonts(dateMin));
                Thread.Sleep(700);
            }
        }

        public void SetLabelText(object text)
        {
            if (Number == 0)
            {
                this.timeChange.Text = text.ToString();
            }
            else if (Number == 1)
            {
                this.Talk.Text = text.ToString();
            }
            else if (Number == 2)
            {
                this.TopMost = false;
            }
            else if (Number == 3)
            {
                this.TopMost = true;
            }

        }

        public void label2_Click(object sender, EventArgs e)
        { }

        public void timeChange_Click(object sender, EventArgs e)
        { }


        public void button3_Click(object sender, EventArgs e)
        {
            UpAndDo upAndDo = new UpAndDo();
            upAndDo.ShowDialog();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            AllScreen allScreen = new AllScreen();
            allScreen.Show();
            this.Hide();
        }
    }
}

