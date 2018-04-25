using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Random random = new Random();
        Color getRandomColor()
        {
            return Color.FromArgb(
                random.Next(256),
                random.Next(256),
                random.Next(256));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int x = this.Width/2;
            int y = this.Height/2;
            for(int i=0;i<this.Height/2;i++)
            {
               g.DrawEllipse(new Pen(getRandomColor(),1),x-i,y-i,i*2,i*2);
            }
        }
    }
}
