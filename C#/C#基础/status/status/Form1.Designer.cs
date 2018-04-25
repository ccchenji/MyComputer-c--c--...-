namespace status
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cpuCounter = new System.Diagnostics.PerformanceCounter();
            this.cpuIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RAMCounter = new System.Diagnostics.PerformanceCounter();
            this.RAMIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.DiskReadCounter = new System.Diagnostics.PerformanceCounter();
            this.DiskWriteCounter = new System.Diagnostics.PerformanceCounter();
            this.DiskIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.netReceiveCounter1 = new System.Diagnostics.PerformanceCounter();
            this.label1 = new System.Windows.Forms.Label();
            this.netReceiveCounter2 = new System.Diagnostics.PerformanceCounter();
            this.netSendCounter1 = new System.Diagnostics.PerformanceCounter();
            this.netSendCounter2 = new System.Diagnostics.PerformanceCounter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cpuCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAMCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiskReadCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiskWriteCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netReceiveCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netReceiveCounter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netSendCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netSendCounter2)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuCounter
            // 
            this.cpuCounter.CategoryName = "Processor Information";
            this.cpuCounter.CounterName = "% Processor Utility";
            this.cpuCounter.InstanceName = "_Total";
            this.cpuCounter.MachineName = "DESKTOP-Q898JJ0";
            // 
            // cpuIcon
            // 
            this.cpuIcon.Text = "notifyIcon1";
            this.cpuIcon.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RAMCounter
            // 
            this.RAMCounter.CategoryName = "Memory";
            this.RAMCounter.CounterName = "% Committed Bytes In Use";
            this.RAMCounter.MachineName = "DESKTOP-Q898JJ0";
            // 
            // RAMIcon
            // 
            this.RAMIcon.Text = "notifyIcon1";
            this.RAMIcon.Visible = true;
            // 
            // DiskReadCounter
            // 
            this.DiskReadCounter.CategoryName = "LogicalDisk";
            this.DiskReadCounter.CounterName = "Disk Read Bytes/sec";
            this.DiskReadCounter.InstanceName = "_Total";
            this.DiskReadCounter.MachineName = "DESKTOP-Q898JJ0";
            // 
            // DiskWriteCounter
            // 
            this.DiskWriteCounter.CategoryName = "LogicalDisk";
            this.DiskWriteCounter.CounterName = "Disk Write Bytes/sec";
            this.DiskWriteCounter.InstanceName = "_Total";
            this.DiskWriteCounter.MachineName = "DESKTOP-Q898JJ0";
            // 
            // DiskIcon
            // 
            this.DiskIcon.Text = "notifyIcon1";
            this.DiskIcon.Visible = true;
            // 
            // netReceiveCounter1
            // 
            this.netReceiveCounter1.CategoryName = "Network Interface";
            this.netReceiveCounter1.CounterName = "Bytes Received/sec";
            this.netReceiveCounter1.InstanceName = "Intel[R] Dual Band Wireless-AC 3165";
            this.netReceiveCounter1.MachineName = "DESKTOP-Q898JJ0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // netReceiveCounter2
            // 
            this.netReceiveCounter2.CategoryName = "Network Interface";
            this.netReceiveCounter2.CounterName = "Bytes Received/sec";
            this.netReceiveCounter2.InstanceName = "Intel[R] Dual Band Wireless-AC 3165";
            this.netReceiveCounter2.MachineName = "DESKTOP-Q898JJ0";
            // 
            // netSendCounter1
            // 
            this.netSendCounter1.CategoryName = "Network Interface";
            this.netSendCounter1.CounterName = "Bytes Sent/sec";
            this.netSendCounter1.InstanceName = "Intel[R] Dual Band Wireless-AC 3165";
            this.netSendCounter1.MachineName = "DESKTOP-Q898JJ0";
            // 
            // netSendCounter2
            // 
            this.netSendCounter2.CategoryName = "Network Interface";
            this.netSendCounter2.CounterName = "Bytes Sent/sec";
            this.netSendCounter2.InstanceName = "Intel[R] Dual Band Wireless-AC 3165";
            this.netSendCounter2.MachineName = "DESKTOP-Q898JJ0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAMCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiskReadCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiskWriteCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netReceiveCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netReceiveCounter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netSendCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netSendCounter2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter cpuCounter;
        private System.Windows.Forms.NotifyIcon cpuIcon;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter RAMCounter;
        private System.Windows.Forms.NotifyIcon RAMIcon;
        private System.Diagnostics.PerformanceCounter DiskReadCounter;
        private System.Diagnostics.PerformanceCounter DiskWriteCounter;
        private System.Windows.Forms.NotifyIcon DiskIcon;
        private System.Diagnostics.PerformanceCounter netReceiveCounter1;
        private System.Windows.Forms.Label label1;
        private System.Diagnostics.PerformanceCounter netReceiveCounter2;
        private System.Diagnostics.PerformanceCounter netSendCounter1;
        private System.Diagnostics.PerformanceCounter netSendCounter2;
        private System.Windows.Forms.Label label2;
    }
}

