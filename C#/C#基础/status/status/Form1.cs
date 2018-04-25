using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace status
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string localPath = AppDomain.CurrentDomain.BaseDirectory + "Icons\\Light Icons\\";
        PerformanceCounterCategory netCategory = new PerformanceCounterCategory("Network Interface");
        int netAdapterCount;
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] instanceNames;
            instanceNames = netCategory.GetInstanceNames();
            netAdapterCount = instanceNames.Length;
            netReceiveCounter1.InstanceName = instanceNames[2];
            netSendCounter1.InstanceName = instanceNames[2];
            label2.Text = null;
            for (int i = 0; i < netAdapterCount; i++)
            {
                label2.Text += instanceNames[i]+Environment.NewLine;
            }
            if (netAdapterCount >= 2)
            {
                netReceiveCounter2.InstanceName = instanceNames[1];
                netSendCounter2.InstanceName = instanceNames[1];
            }
        }
        float cpuValue, ramValue, DiskReadValue, DiskWriteValue, diskEdge = 0.1f, netReceivedValue, netSendValue;

        private void timer1_Tick(object sender, EventArgs e)
        {
            cpuHandler();
            ramHandler();
            DiskHandler();
            netHandler();
        }
        void cpuHandler()
        {
            cpuValue = cpuCounter.NextValue();
            cpuIcon.Text = "CPU:" + cpuValue.ToString("0.0#") + "%";
            if (cpuValue >= 100) cpuValue = 100;
            Icon temp = new Icon(localPath + "CPU" + ((int)(cpuValue / 10)) * 10 + ".ico", 64, 64);
            cpuIcon.Icon = temp;
        }
        void ramHandler()
        {
            ramValue = RAMCounter.NextValue();
            RAMIcon.Text = "RAM:" + ramValue.ToString("0.0#") + "%";
            Icon temp = new Icon(localPath + "Memory" + ((int)(ramValue / 10)) * 10 + ".ico", 64, 64);
            RAMIcon.Icon = temp;
        }
        void DiskHandler()
        {
            DiskReadValue = DiskReadCounter.NextValue() / 1024 / 1024;
            DiskWriteValue = DiskWriteCounter.NextValue() / 1024 / 1024;
            Icon temp;
            if (DiskReadValue > diskEdge && DiskWriteValue > diskEdge)
                temp = new Icon(localPath + "HDBoth.ico");
            else if (DiskReadValue > diskEdge && DiskWriteValue < diskEdge)
                temp = new Icon(localPath + "HDRead.ico");
            else if (DiskReadValue < diskEdge && DiskWriteValue > diskEdge)
                temp = new Icon(localPath + "HDWrite.ico");
            else
                temp = new Icon(localPath + "HDOff.ico");
            DiskIcon.Icon = temp;
            DiskIcon.Text = "Read:" + DiskReadValue.ToString("0.00#") + "MB/s" + Environment.NewLine + "Write:" + DiskWriteValue.ToString("0.00#") + "MB/s";
        }
        void netHandler()
        {
            netReceivedValue = netReceiveCounter1.NextValue() / 1024;
            netSendValue = netSendCounter1.NextValue() / 1024;
            if (netAdapterCount >= 2)
            {
                netReceivedValue += netReceiveCounter2.NextValue() / 1024;
                netSendValue += netSendCounter2.NextValue() / 1024;
            }
            label1.Text = "Received:" + netReceivedValue.ToString("0.0#") + "KB/s"+Environment.NewLine+"Send:"+netSendValue.ToString("0.0#")+"KB/s";
        }
    }
}
