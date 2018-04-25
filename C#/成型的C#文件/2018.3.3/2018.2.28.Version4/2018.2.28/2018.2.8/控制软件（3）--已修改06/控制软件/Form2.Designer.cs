namespace 控制软件
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.testButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.testNum = new System.Windows.Forms.TextBox();
            this.testCycle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearDate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.飞机方位角 = new System.Windows.Forms.TabPage();
            this.azimuth = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.接收机带宽 = new System.Windows.Forms.TabPage();
            this.BandwidthTest = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.测角精度 = new System.Windows.Forms.TabPage();
            this.Mytest = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.飞机方位角.SuspendLayout();
            this.接收机带宽.SuspendLayout();
            this.测角精度.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.testButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.testNum);
            this.groupBox1.Controls.Add(this.testCycle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(357, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试选项";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(273, 44);
            this.testButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(59, 55);
            this.testButton.TabIndex = 6;
            this.testButton.Text = "自动测试";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "次";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "ms";
            // 
            // testNum
            // 
            this.testNum.Location = new System.Drawing.Point(124, 80);
            this.testNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testNum.Name = "testNum";
            this.testNum.Size = new System.Drawing.Size(100, 25);
            this.testNum.TabIndex = 3;
            this.testNum.Text = "10";
            // 
            // testCycle
            // 
            this.testCycle.Location = new System.Drawing.Point(124, 34);
            this.testCycle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testCycle.Name = "testCycle";
            this.testCycle.Size = new System.Drawing.Size(100, 25);
            this.testCycle.TabIndex = 2;
            this.testCycle.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "测试次数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "测试周期";
            // 
            // clearDate
            // 
            this.clearDate.Location = new System.Drawing.Point(1171, 646);
            this.clearDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearDate.Name = "clearDate";
            this.clearDate.Size = new System.Drawing.Size(93, 51);
            this.clearDate.TabIndex = 2;
            this.clearDate.Text = "清楚数据";
            this.clearDate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Location = new System.Drawing.Point(983, 74);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(493, 132);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送数据";
            this.groupBox2.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(5, 22);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(481, 103);
            this.textBox5.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Location = new System.Drawing.Point(983, 255);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(493, 386);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收数据";
            this.groupBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(5, 24);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(481, 356);
            this.textBox4.TabIndex = 0;
            // 
            // 飞机方位角
            // 
            this.飞机方位角.Controls.Add(this.azimuth);
            this.飞机方位角.Controls.Add(this.label28);
            this.飞机方位角.Controls.Add(this.label29);
            this.飞机方位角.Controls.Add(this.label30);
            this.飞机方位角.Controls.Add(this.textBox16);
            this.飞机方位角.Controls.Add(this.textBox17);
            this.飞机方位角.Controls.Add(this.textBox18);
            this.飞机方位角.Controls.Add(this.textBox19);
            this.飞机方位角.Controls.Add(this.textBox20);
            this.飞机方位角.Controls.Add(this.label31);
            this.飞机方位角.Controls.Add(this.label33);
            this.飞机方位角.Controls.Add(this.label35);
            this.飞机方位角.Controls.Add(this.label36);
            this.飞机方位角.Controls.Add(this.label37);
            this.飞机方位角.Controls.Add(this.label38);
            this.飞机方位角.Location = new System.Drawing.Point(4, 25);
            this.飞机方位角.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.飞机方位角.Name = "飞机方位角";
            this.飞机方位角.Size = new System.Drawing.Size(355, 303);
            this.飞机方位角.TabIndex = 3;
            this.飞机方位角.Text = "测角范围";
            this.飞机方位角.UseVisualStyleBackColor = true;
            this.飞机方位角.Click += new System.EventHandler(this.飞机方位角_Click);
            // 
            // azimuth
            // 
            this.azimuth.Location = new System.Drawing.Point(149, 201);
            this.azimuth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.azimuth.Name = "azimuth";
            this.azimuth.Size = new System.Drawing.Size(100, 29);
            this.azimuth.TabIndex = 85;
            this.azimuth.Text = "方位角测试";
            this.azimuth.UseVisualStyleBackColor = true;
            this.azimuth.Click += new System.EventHandler(this.azimuth_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(52, 102);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 15);
            this.label28.TabIndex = 84;
            this.label28.Text = "测试功率";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(263, 75);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(31, 15);
            this.label29.TabIndex = 83;
            this.label29.Text = "MHz";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(271, 104);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(31, 15);
            this.label30.TabIndex = 82;
            this.label30.Text = "dBm";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(203, 100);
            this.textBox16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(57, 25);
            this.textBox16.TabIndex = 81;
            this.textBox16.Text = "-40";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(204, 71);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(53, 25);
            this.textBox17.TabIndex = 77;
            this.textBox17.Text = "112.1";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(209, 159);
            this.textBox18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(48, 25);
            this.textBox18.TabIndex = 75;
            this.textBox18.Text = "1";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(204, 130);
            this.textBox19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(53, 25);
            this.textBox19.TabIndex = 71;
            this.textBox19.Text = "359";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(135, 130);
            this.textBox20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(49, 25);
            this.textBox20.TabIndex = 72;
            this.textBox20.Text = "1";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(263, 168);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(22, 15);
            this.label31.TabIndex = 80;
            this.label31.Text = "度";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(265, 136);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(22, 15);
            this.label33.TabIndex = 79;
            this.label33.Text = "度";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(52, 75);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(67, 15);
            this.label35.TabIndex = 78;
            this.label35.Text = "测试频率";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(52, 138);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(67, 15);
            this.label36.TabIndex = 76;
            this.label36.Text = "角度范围";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(52, 168);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(67, 15);
            this.label37.TabIndex = 74;
            this.label37.Text = "角度间隔";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(183, 140);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(25, 25);
            this.label38.TabIndex = 73;
            this.label38.Text = "~";
            // 
            // 接收机带宽
            // 
            this.接收机带宽.Controls.Add(this.BandwidthTest);
            this.接收机带宽.Controls.Add(this.label32);
            this.接收机带宽.Controls.Add(this.label25);
            this.接收机带宽.Controls.Add(this.textBox15);
            this.接收机带宽.Controls.Add(this.textBox10);
            this.接收机带宽.Controls.Add(this.textBox11);
            this.接收机带宽.Controls.Add(this.textBox12);
            this.接收机带宽.Controls.Add(this.textBox14);
            this.接收机带宽.Controls.Add(this.label17);
            this.接收机带宽.Controls.Add(this.label22);
            this.接收机带宽.Controls.Add(this.label21);
            this.接收机带宽.Controls.Add(this.label18);
            this.接收机带宽.Controls.Add(this.label19);
            this.接收机带宽.Controls.Add(this.label23);
            this.接收机带宽.Controls.Add(this.label24);
            this.接收机带宽.Location = new System.Drawing.Point(4, 25);
            this.接收机带宽.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.接收机带宽.Name = "接收机带宽";
            this.接收机带宽.Size = new System.Drawing.Size(355, 303);
            this.接收机带宽.TabIndex = 2;
            this.接收机带宽.Text = "接收机带宽";
            this.接收机带宽.UseVisualStyleBackColor = true;
            this.接收机带宽.Click += new System.EventHandler(this.接收机带宽_Click);
            // 
            // BandwidthTest
            // 
            this.BandwidthTest.Location = new System.Drawing.Point(161, 204);
            this.BandwidthTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BandwidthTest.Name = "BandwidthTest";
            this.BandwidthTest.Size = new System.Drawing.Size(100, 29);
            this.BandwidthTest.TabIndex = 69;
            this.BandwidthTest.Text = "带宽测试";
            this.BandwidthTest.UseVisualStyleBackColor = true;
            this.BandwidthTest.Click += new System.EventHandler(this.BandwidthTest_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(273, 100);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(22, 15);
            this.label32.TabIndex = 68;
            this.label32.Text = "度";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(267, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 15);
            this.label25.TabIndex = 65;
            this.label25.Text = "dBm";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(205, 96);
            this.textBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(57, 25);
            this.textBox15.TabIndex = 67;
            this.textBox15.Text = "0";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(207, 68);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(53, 25);
            this.textBox10.TabIndex = 61;
            this.textBox10.Text = "-40";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(212, 155);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(48, 25);
            this.textBox11.TabIndex = 59;
            this.textBox11.Text = "0.05";
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(207, 126);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(53, 25);
            this.textBox12.TabIndex = 55;
            this.textBox12.Text = "117.9";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(137, 126);
            this.textBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(49, 25);
            this.textBox14.TabIndex = 56;
            this.textBox14.Text = "112.1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(55, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 15);
            this.label17.TabIndex = 66;
            this.label17.Text = "飞机方位角";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(265, 164);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 15);
            this.label22.TabIndex = 64;
            this.label22.Text = "MHz";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(268, 132);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 15);
            this.label21.TabIndex = 63;
            this.label21.Text = "MHz";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(55, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 62;
            this.label18.Text = "测试功率";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(55, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 15);
            this.label19.TabIndex = 60;
            this.label19.Text = "频率范围";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(55, 164);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 15);
            this.label23.TabIndex = 58;
            this.label23.Text = "频率间隔";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(185, 136);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 25);
            this.label24.TabIndex = 57;
            this.label24.Text = "~";
            // 
            // 测角精度
            // 
            this.测角精度.Controls.Add(this.Mytest);
            this.测角精度.Controls.Add(this.label10);
            this.测角精度.Controls.Add(this.label9);
            this.测角精度.Controls.Add(this.label8);
            this.测角精度.Controls.Add(this.textBox3);
            this.测角精度.Controls.Add(this.textBox2);
            this.测角精度.Controls.Add(this.textBox1);
            this.测角精度.Controls.Add(this.label7);
            this.测角精度.Controls.Add(this.label6);
            this.测角精度.Controls.Add(this.label5);
            this.测角精度.Location = new System.Drawing.Point(4, 25);
            this.测角精度.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.测角精度.Name = "测角精度";
            this.测角精度.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.测角精度.Size = new System.Drawing.Size(355, 303);
            this.测角精度.TabIndex = 0;
            this.测角精度.Text = "测角精度";
            this.测角精度.UseVisualStyleBackColor = true;
            this.测角精度.Click += new System.EventHandler(this.测角精度_Click);
            this.测角精度.MouseClick += new System.Windows.Forms.MouseEventHandler(this.测角精度_MouseClick);
            // 
            // Mytest
            // 
            this.Mytest.Location = new System.Drawing.Point(145, 238);
            this.Mytest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mytest.Name = "Mytest";
            this.Mytest.Size = new System.Drawing.Size(147, 41);
            this.Mytest.TabIndex = 9;
            this.Mytest.Text = "测试";
            this.Mytest.UseVisualStyleBackColor = true;
            this.Mytest.Click += new System.EventHandler(this.Mytest_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(240, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "dBm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(240, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(240, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "MHz";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 175);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "-40";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 112);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "0";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "112.1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "测试功率";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "预设角度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "测试频率";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.测角精度);
            this.tabControl1.Controls.Add(this.接收机带宽);
            this.tabControl1.Controls.Add(this.飞机方位角);
            this.tabControl1.Location = new System.Drawing.Point(9, 176);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(363, 332);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 518);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clearDate);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestForm";
            this.Text = "关键技术指标测试";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.飞机方位角.ResumeLayout(false);
            this.飞机方位角.PerformLayout();
            this.接收机带宽.ResumeLayout(false);
            this.接收机带宽.PerformLayout();
            this.测角精度.ResumeLayout(false);
            this.测角精度.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TextBox testNum;
        public System.Windows.Forms.TextBox testCycle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabPage 飞机方位角;
        private System.Windows.Forms.Button azimuth;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox16;
        public System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TabPage 接收机带宽;
        private System.Windows.Forms.Button BandwidthTest;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox10;
        public System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        public System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.TabPage 测角精度;
        public System.Windows.Forms.Button Mytest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TextBox textBox19;
    }
}