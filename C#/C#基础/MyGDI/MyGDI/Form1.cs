using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MyGDI
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush br = new LinearGradientBrush(new PointF(0,0),new PointF(50,50),Color.Red ,Color.Yellow);
            g.DrawRectangle(new Pen(br),new Rectangle(50,50,50,50));
          //  g.FillRectangle(br,new Rectangle(50,50,50,50));
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
