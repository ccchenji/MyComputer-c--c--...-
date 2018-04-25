using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEDCoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "";
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (player1.Map[j, i])
                        label2.Text += "1 ";
                    else
                        label2.Text += "0 ";
                }
                label2.Text += Environment.NewLine;
            }
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
