using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_Communicate
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int i = 0;
			for(i=1;i<21;i++)
			{
				comboBox1.Items.Add("COM"+i.ToString());
			}
			comboBox1.Text = "COM1";
			comboBox2.Text = "4800";
			serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived);
		} 
		private void port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			 if(!radioButton3.Checked) //接收的是字符 
			{
				string str = serialPort1.ReadExisting();//字符串方式读取
				textBox2.AppendText(str);
			}
			else //接收的是数值
			{
				byte date;
				date =(byte)serialPort1.ReadByte();
				string str = date.ToString("X").ToUpper();
				textBox2.AppendText("0X"+ (str.Length==1 ? "0" +str : str) + " ");
			} 
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				serialPort1.PortName = textBox2.Text; 
				serialPort1.BaudRate =Convert.ToInt32(comboBox2.Text,10);
				serialPort1.Open();
				button1.Enabled = false;
				button2.Enabled = true;
			}
			catch 
			{
				System.Media.SystemSounds.Asterisk.Play();
				MessageBox.Show("端口错误，请检查端口！！","错误");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			button1.Enabled = true;
			button2.Enabled = false;
			if(serialPort1.IsOpen)
			{
				serialPort1.Close();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			byte[] buffer = new byte[1];
			if(serialPort1.IsOpen)
			{
				if (textBox2.Text!=" ")
				{
                     if(!radioButton1.Checked)//如果发送模式是字符
					{
						try
						{
							serialPort1.WriteLine(textBox1.Text);//写数据
						}
						catch
						{
							System.Media.SystemSounds.Asterisk.Play();
							if(serialPort1.IsOpen)
							{
								button1.Enabled = true;
								button2.Enabled = false;
								serialPort1.Close();
							}
							MessageBox.Show("端口错误，请检查端口！！","错误");
						}
					}
					 else
					{
					     
					}
				}
			}
		}
	}
}
