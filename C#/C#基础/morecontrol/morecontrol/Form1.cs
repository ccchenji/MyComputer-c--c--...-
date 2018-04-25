using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace morecontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyPictureBox();
        }

        void MyPictureBox()
        {
            for(int i=0;i<4;i++)
            {
                PictureBox ptb = new PictureBox();
                ptb.BackColor = Color.Red;
                ptb.Width = 45;
                ptb.Height = 45;
                ptb.Top = 10 + i * 50;
                ptb.Left = 100;
                ptb.Visible = true;
                ptb.Click += new EventHandler(ptb_Click);
                this.Controls.Add(ptb);
            }
        }

        void ptb_Click (object sender ,EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            if(picture.BackColor==Color.Black)
            {
                picture.BackColor = Color.Red;
            }
            else
            {
                picture.BackColor = Color.Black;
            }
        }
    }
}
