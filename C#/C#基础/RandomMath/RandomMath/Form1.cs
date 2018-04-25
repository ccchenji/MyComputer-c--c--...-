using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomMath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int a, b;
        string op;
        int result;
        private void btnNew_Click(object sender, EventArgs e)
        {
            a = random.Next(9) + 1;
            b = random.Next(9) + 1;
            int c = 0;
            c = random.Next(3);
            switch (c)
            { 
                case 0:op = "+";result = a + b;break;
                case 1:op = "-";result = a - b;break;
                case 2:op = "*";result = a * b;break;
            }
            label1.Text = a.ToString();
            label2.Text = op;
            label3.Text = b.ToString();
            txtAnswer.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Nothing";
            label2.Text = "Nothing";
            label3.Text = "Nothing";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            string answer = txtAnswer.Text;
            if(answer !="")
            {
                double d = double.Parse(answer);
                string disp = "" + a + op + b + "=" + answer + " ";
                if (d == result)
                {
                    disp += "^_^";
                }
                else
                {
                    disp += "/../";
                }
                listBox1.Items.Add(disp);
            }

        }
    }
}
