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
	public partial class Form2 : Form
	{
		public string str;
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			str = label1.Text;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label1.Text = Form1.main.chen;
		}
	}
}
