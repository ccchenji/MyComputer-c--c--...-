using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_performance
{
	public partial class Form1 : Form
	{
		Form2 stup = new Form2();
		public  Form1 main;
		public string chen;
		public Form1()
		{
			main = this;
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label1.Text = CPU.NextValue().ToString();
			chen = label1.Text;
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			stup.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			   label2.Text = stup.str;
		}
	}
}
