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
        public formsc()
        {
            InitializeComponent();
            
        }
        public void Manager_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox();
            inputBox.ShowDialog();
        }

        private void NewTalkButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}

