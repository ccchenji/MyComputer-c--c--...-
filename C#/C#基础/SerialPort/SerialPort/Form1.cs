using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPort
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string str;
			int i = 0;
			for (i = 0; i < 256; i++)
			{
				str = i.ToString("x").ToUpper();
				if (str.Length == 1)
				{
					str = str + "0";
				}
				comboBox1.Items.Add("0X" + str);
			}
			comboBox1.Text = "0X00";//下拉菜单的初始化
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string date = comboBox1.Text.Substring(2, 2);
			byte[] buffer = new byte[1];
			buffer[0] = Convert.ToByte(date, 16);
			try
			{
				serialPort1.Open();
				serialPort1.Write(buffer, 0, 1);
				serialPort1.Close();
			}
			catch
			{
				if (serialPort1.IsOpen)
				{
					serialPort1.Close();
				}
				System.Media.SystemSounds.Asterisk.Play();
				MessageBox.Show("端口错误！!", "错误");
			}
		}
	}
}
				

