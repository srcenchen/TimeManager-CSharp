using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1
{
    public partial class Manager : Form
    {


        static int Number = 0;
        SynchronizationContext _syncContext = null;
        public Manager()
        {
            InitializeComponent();
            _syncContext = SynchronizationContext.Current;
            
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ChangeTimeThread));
            thread.IsBackground = true;
            thread.Start();

            Thread thread1 = new Thread(new ThreadStart(ChangeTalkThread));
            thread1.IsBackground = true;
            thread1.Start();



        }

        private void ChangeTalkThread()
        {
            StreamReader sr = new StreamReader("./talk.json", Encoding.Default);
            String line = sr.ReadLine();
            JsonTextReader jsonTextReader = new JsonTextReader(new StringReader(line));
            JObject jObject = (JObject)JToken.ReadFrom(jsonTextReader);
            int NumberTalk = (int)jObject["hownumber"];
            String[] talk = new String[NumberTalk];
            for (int i = 0; i < NumberTalk; i++)
            {
                int i1 = i + 1;
                talk[i] = (String)jObject[i + 1 + "t"];
            }

            Number = 1;
            _syncContext.Post(SetLabelText, talk[1]);

            while (true)
            {
                for (int i = 0; i < NumberTalk; i++)
                {
                    Thread.Sleep(3000);
                    Number = 1;
                    _syncContext.Post(SetLabelText, talk[i]);
                }

            }
        }

        private void ChangeTimeThread()
        {
            while(true)
            {
                int dateHour = DateTime.Now.Hour;
                int dateMin = DateTime.Now.Minute;
                TimeFont timeFont = new TimeFont();

                Number = 0;
                _syncContext.Post(SetLabelText,timeFont.TimeFonts(dateHour) + ":" + timeFont.TimeFonts(dateMin));
                Thread.Sleep(700);
                Number = 0;
                _syncContext.Post(SetLabelText, timeFont.TimeFonts(dateHour) + " " + timeFont.TimeFonts(dateMin));
                Thread.Sleep(700);

            }
            /*
            String textjson = "{\"hownumber\" : \"3\",\"t1\" : \"昨天再好，走不回去，明天再难，也要抬脚继续\",\"t2\" : \"十年前，你周围的人会根据你父母的收入对待你。\",\"t3\" : \"十年后，你周围的人会根据你的收入对待你的父母\"}";
            RootObject rb = JsonConvert.DeserializeObject<RootObject>(textjson);
            _syncContext.Post(SetLabelText, rb.t1);
            Thread.Sleep(700);
            */

            
        }

        private void SetLabelText(object text)
        {
            if (Number == 0)
            {
                this.timeChange.Text = text.ToString();
            } else if (Number == 1)
            {
                this.Talk.Text = text.ToString();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timeChange_Click(object sender, EventArgs e)
        {

        }
    }
}

