using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Threading;

namespace Map
{
    public partial class Form2 : Form
    {
        public static Form2 form2;
        private delegate void MyEventHandler(double x, double y, double pm2);
        private event MyEventHandler DataChange;
        public Form2()
        {
            InitializeComponent();
            form2 = this;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            string str = Application.StartupPath + "/map.html";
            Uri uri = new Uri(str);
            webBrowser1.Url = uri;
            webBrowser1.ObjectForScripting = groupBox1;
            DataChange += RedrawMap;
        }
        public void SendMessage(double x, double y, double pm)
        {
            if (DataChange != null)
            {
                DataChange(x, y, pm);
            }
        }
        private void RedrawMap(double x, double y, double pm2)
        {
            webBrowser1.Document.InvokeScript("setLocation", new object[] { x, y ,pm2});
            webBrowser1.Document.InvokeScript("Add");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("changeUp");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("changeDown");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if(Form1.timer.Enabled ==true)
            {
                Form1.timer.Enabled = false;
                button3.Text = "开启跟随";
            }
           else
            {
                Form1.timer.Enabled = true;
                button3.Text = "关闭跟随";
            }
        }
    }
}
