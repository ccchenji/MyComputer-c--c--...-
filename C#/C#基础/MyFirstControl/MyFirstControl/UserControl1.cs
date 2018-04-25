using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFirstControl
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pictureBox1.BackColor==Color.Black)
            {
                pictureBox1.BackColor = Color.Red;
            }
            else
            {
                pictureBox1.BackColor = Color.Black;
            }
        }
    }
}
