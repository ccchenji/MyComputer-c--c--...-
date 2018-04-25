using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Timer
{
	public partial class Form1 : Form
	{
		int count;
		int time;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int i = 0;
			for(i=1;i<100;i++)
			{
				comboBox1.Items.Add(i.ToString()+" 秒");
			}
			comboBox1.Text = "1 秒";
			label3.Text = "1 秒";

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		  {
			  count++; //当前的秒数
			  label3.Text= (time-count).ToString() + " 秒";
			  progressBar1.Value = count;//设置进度条进度
			  if(count==time)
			{
			    timer1.Stop();//时间到了停止计时
				System.Media.SystemSounds.Asterisk.Play();//提示音
				MessageBox.Show("时间到了!","提示");//弹出这个对话框程序在此停止
				
			}
			
		  }

		private void button1_Click(object sender, EventArgs e)
		{
			 count = 0;
			 string str = comboBox1 .Text;
			 label3.Text = comboBox1.Text;
			time = Convert.ToInt32(str.Substring(0,2));
			 progressBar1.Maximum = time; //进度条的最大数值
			 timer1.Start(); //开启定时器
		}

		private void button2_Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}
	}
}
