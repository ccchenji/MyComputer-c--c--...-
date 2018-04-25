using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyMap
{
    [ComVisible(true)]
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
            webBrowser1.ObjectForScripting = this;
            label1.Text = "116.404";
            label2.Text = " 39.915";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("setLocation", new object[] {Convert.ToDouble(label1.Text), Convert.ToDouble(label2.Text) });
        }
        double x = 116.404;
        double y = 39.915;
        private void button1_Click(object sender, EventArgs e)
        {
            x += 0.1;
            y += 0.1;
            label1.Text = x.ToString();
            label2.Text = y.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled==true)
            {
                timer1.Enabled = false;
                button2.Text = "开始定位";
            }
            else
            {
                timer1.Enabled = true;
                button2.Text = "关闭定位";
            }
        } 
    }
}
