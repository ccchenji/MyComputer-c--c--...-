using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_CPU
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string Path = AppDomain.CurrentDomain.BaseDirectory + "ICON\\";
		float CpuVaule;
		private void timer1_Tick(object sender, EventArgs e)
		{
			notifyIconHandler();
		}
		private void notifyIconHandler()
		{
			CpuVaule = CPU.NextValue();
			label2.Text = CpuVaule.ToString() + "%";
			if (CpuVaule >= 100) CpuVaule = 100;
			Icon temp = new Icon(Path + "CPU" + ((int)(CpuVaule / 10)) * 10 + ".ico", 64, 64);
			notifyIcon1.Icon = temp;
		}
		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			 if(this.WindowState==System.Windows.Forms.FormWindowState.Minimized)
			{
				this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			}
			 else
			{
				this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CPU.MachineName = System.Net.Dns.GetHostName();
		    label3.Text = CPU.MachineName.ToString();
		}

		private void label4_MouseMove(object sender, MouseEventArgs e)
		{
			
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			label4.Text = e.X + "," + e.Y;
		}
	}
}
