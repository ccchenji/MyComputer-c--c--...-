using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = Application.StartupPath + "/map.html";
            Uri uri = new Uri(str);
            webBrowser1.Url = uri;
            webBrowser1.ObjectForScripting = TabPage.GetTabPageOfComponent(webBrowser1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "增加比例尺")
            {
                webBrowser1.Document.InvokeScript("Add");
                button1.Text = "删除比例尺";
            }
            else
            {
                webBrowser1.Document.InvokeScript("delete_control");
                button1.Text = "增加比例尺";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("setLocation", new object[] { 116.404, 39.915, "2.5" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                button2.Text = "开启跟随";
            }
            else
            {
                timer1.Enabled = true;
                button2.Text = "关闭跟随";
            }
        }
    }
}
