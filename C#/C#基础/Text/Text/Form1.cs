using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=1;i<5;i++)
            {
                PictureBox p = new PictureBox();
                p.Name = i.ToString();
                p.Width = 10;
                p.Height = 10;
                p.Top = i * 20;
                p.Left = i * 20;
                p.Visible = true;
                p.BackColor = Color.Black;

                p.Click += new EventHandler(Picture_click);
                this.Controls.Add(p);
            }
        }

        void Picture_click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            if(p.BackColor==Color.Black)
            {
                p.BackColor = Color.Red;
            }
            else
            {
                p.BackColor = Color.Black;
            }

        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
