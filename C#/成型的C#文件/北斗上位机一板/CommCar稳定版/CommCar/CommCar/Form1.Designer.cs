namespace CommCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.beaconLatitude4 = new System.Windows.Forms.TextBox();
            this.beaconLongitude4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.beaconLatitude3 = new System.Windows.Forms.TextBox();
            this.beaconLongitude3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.beaconText4 = new System.Windows.Forms.TextBox();
            this.beaconText3 = new System.Windows.Forms.TextBox();
            this.beaconText2 = new System.Windows.Forms.TextBox();
            this.beaconLatitude2 = new System.Windows.Forms.TextBox();
            this.beaconLongitude2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.beaconText1 = new System.Windows.Forms.TextBox();
            this.beaconLatitude1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.beaconLongitude1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OpenServe = new System.Windows.Forms.Button();
            this.SearchIP = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closePort = new System.Windows.Forms.Button();
            this.openPort = new System.Windows.Forms.Button();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.canUsePort = new System.Windows.Forms.ComboBox();
            this.searchPort = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1036, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "信标坐标显示";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.beaconLatitude4);
            this.groupBox3.Controls.Add(this.beaconLongitude4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.beaconLatitude3);
            this.groupBox3.Controls.Add(this.beaconLongitude3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.beaconText4);
            this.groupBox3.Controls.Add(this.beaconText3);
            this.groupBox3.Controls.Add(this.beaconText2);
            this.groupBox3.Controls.Add(this.beaconLatitude2);
            this.groupBox3.Controls.Add(this.beaconLongitude2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.beaconText1);
            this.groupBox3.Controls.Add(this.beaconLatitude1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.beaconLongitude1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1024, 435);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "信标数据数据采集";
            // 
            // beaconLatitude4
            // 
            this.beaconLatitude4.Location = new System.Drawing.Point(857, 62);
            this.beaconLatitude4.Name = "beaconLatitude4";
            this.beaconLatitude4.Size = new System.Drawing.Size(143, 25);
            this.beaconLatitude4.TabIndex = 20;
            // 
            // beaconLongitude4
            // 
            this.beaconLongitude4.Location = new System.Drawing.Point(857, 27);
            this.beaconLongitude4.Name = "beaconLongitude4";
            this.beaconLongitude4.Size = new System.Drawing.Size(143, 25);
            this.beaconLongitude4.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(756, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "信标4纬度";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(756, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "信标4经度";
            // 
            // beaconLatitude3
            // 
            this.beaconLatitude3.Location = new System.Drawing.Point(607, 61);
            this.beaconLatitude3.Name = "beaconLatitude3";
            this.beaconLatitude3.Size = new System.Drawing.Size(143, 25);
            this.beaconLatitude3.TabIndex = 16;
            // 
            // beaconLongitude3
            // 
            this.beaconLongitude3.Location = new System.Drawing.Point(607, 27);
            this.beaconLongitude3.Name = "beaconLongitude3";
            this.beaconLongitude3.Size = new System.Drawing.Size(143, 25);
            this.beaconLongitude3.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(506, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "信标3纬度";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(506, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "信标3经度";
            // 
            // beaconText4
            // 
            this.beaconText4.Location = new System.Drawing.Point(756, 93);
            this.beaconText4.Multiline = true;
            this.beaconText4.Name = "beaconText4";
            this.beaconText4.Size = new System.Drawing.Size(244, 336);
            this.beaconText4.TabIndex = 12;
            // 
            // beaconText3
            // 
            this.beaconText3.Location = new System.Drawing.Point(506, 93);
            this.beaconText3.Multiline = true;
            this.beaconText3.Name = "beaconText3";
            this.beaconText3.Size = new System.Drawing.Size(244, 336);
            this.beaconText3.TabIndex = 11;
            // 
            // beaconText2
            // 
            this.beaconText2.Location = new System.Drawing.Point(256, 93);
            this.beaconText2.Multiline = true;
            this.beaconText2.Name = "beaconText2";
            this.beaconText2.Size = new System.Drawing.Size(244, 336);
            this.beaconText2.TabIndex = 10;
            // 
            // beaconLatitude2
            // 
            this.beaconLatitude2.Location = new System.Drawing.Point(357, 62);
            this.beaconLatitude2.Name = "beaconLatitude2";
            this.beaconLatitude2.Size = new System.Drawing.Size(143, 25);
            this.beaconLatitude2.TabIndex = 9;
            // 
            // beaconLongitude2
            // 
            this.beaconLongitude2.Location = new System.Drawing.Point(357, 27);
            this.beaconLongitude2.Name = "beaconLongitude2";
            this.beaconLongitude2.Size = new System.Drawing.Size(143, 25);
            this.beaconLongitude2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(256, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "信标2纬度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(256, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "信标2经度";
            // 
            // beaconText1
            // 
            this.beaconText1.Location = new System.Drawing.Point(6, 93);
            this.beaconText1.Multiline = true;
            this.beaconText1.Name = "beaconText1";
            this.beaconText1.Size = new System.Drawing.Size(244, 336);
            this.beaconText1.TabIndex = 4;
            // 
            // beaconLatitude1
            // 
            this.beaconLatitude1.Location = new System.Drawing.Point(107, 62);
            this.beaconLatitude1.Name = "beaconLatitude1";
            this.beaconLatitude1.Size = new System.Drawing.Size(143, 25);
            this.beaconLatitude1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "信标1纬度";
            // 
            // beaconLongitude1
            // 
            this.beaconLongitude1.Location = new System.Drawing.Point(107, 27);
            this.beaconLongitude1.Name = "beaconLongitude1";
            this.beaconLongitude1.Size = new System.Drawing.Size(143, 25);
            this.beaconLongitude1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "信标1经度";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("新宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1036, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "串口配置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton2);
            this.groupBox6.Controls.Add(this.radioButton1);
            this.groupBox6.Location = new System.Drawing.Point(13, 385);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1020, 56);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "比赛模式选择";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(117, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "模式2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 23);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "模式1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Location = new System.Drawing.Point(13, 195);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(596, 190);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "tcp数据显示";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(584, 157);
            this.textBox2.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(7, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(602, 183);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "串口数据显示";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(590, 149);
            this.textBox1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.OpenServe);
            this.groupBox2.Controls.Add(this.SearchIP);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(615, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 190);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "服务器配置";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "关闭服务";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenServe
            // 
            this.OpenServe.Location = new System.Drawing.Point(162, 117);
            this.OpenServe.Name = "OpenServe";
            this.OpenServe.Size = new System.Drawing.Size(104, 50);
            this.OpenServe.TabIndex = 5;
            this.OpenServe.Text = "启动服务";
            this.OpenServe.UseVisualStyleBackColor = true;
            this.OpenServe.Click += new System.EventHandler(this.OpenServe_Click);
            // 
            // SearchIP
            // 
            this.SearchIP.Location = new System.Drawing.Point(23, 119);
            this.SearchIP.Name = "SearchIP";
            this.SearchIP.Size = new System.Drawing.Size(104, 48);
            this.SearchIP.TabIndex = 4;
            this.SearchIP.Text = "搜索IP";
            this.SearchIP.UseVisualStyleBackColor = true;
            this.SearchIP.Click += new System.EventHandler(this.SearchIP_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(130, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 26);
            this.comboBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Port:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(19, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.closePort);
            this.groupBox1.Controls.Add(this.openPort);
            this.groupBox1.Controls.Add(this.baudRate);
            this.groupBox1.Controls.Add(this.canUsePort);
            this.groupBox1.Controls.Add(this.searchPort);
            this.groupBox1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(615, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "端口";
            // 
            // closePort
            // 
            this.closePort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.closePort.Enabled = false;
            this.closePort.ForeColor = System.Drawing.Color.Black;
            this.closePort.Location = new System.Drawing.Point(277, 113);
            this.closePort.Name = "closePort";
            this.closePort.Size = new System.Drawing.Size(104, 54);
            this.closePort.TabIndex = 6;
            this.closePort.Text = "关闭串口";
            this.closePort.UseVisualStyleBackColor = false;
            this.closePort.Click += new System.EventHandler(this.closePort_Click);
            // 
            // openPort
            // 
            this.openPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.openPort.ForeColor = System.Drawing.Color.Black;
            this.openPort.Location = new System.Drawing.Point(147, 113);
            this.openPort.Name = "openPort";
            this.openPort.Size = new System.Drawing.Size(104, 54);
            this.openPort.TabIndex = 5;
            this.openPort.Text = "打开串口";
            this.openPort.UseVisualStyleBackColor = false;
            this.openPort.Click += new System.EventHandler(this.openPort_Click);
            // 
            // baudRate
            // 
            this.baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.baudRate.Location = new System.Drawing.Point(130, 71);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(121, 23);
            this.baudRate.TabIndex = 4;
            this.baudRate.TextChanged += new System.EventHandler(this.baudRate_TextChanged);
            // 
            // canUsePort
            // 
            this.canUsePort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.canUsePort.FormattingEnabled = true;
            this.canUsePort.Location = new System.Drawing.Point(130, 35);
            this.canUsePort.Name = "canUsePort";
            this.canUsePort.Size = new System.Drawing.Size(121, 23);
            this.canUsePort.TabIndex = 1;
            // 
            // searchPort
            // 
            this.searchPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchPort.ForeColor = System.Drawing.Color.Black;
            this.searchPort.Location = new System.Drawing.Point(23, 113);
            this.searchPort.Name = "searchPort";
            this.searchPort.Size = new System.Drawing.Size(104, 54);
            this.searchPort.TabIndex = 0;
            this.searchPort.Text = "搜索串口";
            this.searchPort.UseVisualStyleBackColor = false;
            this.searchPort.Click += new System.EventHandler(this.searchPort_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1044, 476);
            this.tabControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 494);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "北斗上位机  中国民航大学505实验室";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox beaconText4;
        private System.Windows.Forms.TextBox beaconText3;
        private System.Windows.Forms.TextBox beaconText2;
        private System.Windows.Forms.TextBox beaconLatitude2;
        private System.Windows.Forms.TextBox beaconLongitude2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox beaconText1;
        private System.Windows.Forms.TextBox beaconLatitude1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox beaconLongitude1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OpenServe;
        private System.Windows.Forms.Button SearchIP;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closePort;
        private System.Windows.Forms.Button openPort;
        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.ComboBox canUsePort;
        private System.Windows.Forms.Button searchPort;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox beaconLatitude4;
        private System.Windows.Forms.TextBox beaconLongitude4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox beaconLatitude3;
        private System.Windows.Forms.TextBox beaconLongitude3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

