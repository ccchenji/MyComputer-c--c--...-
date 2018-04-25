namespace 控制软件
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OpenClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBaudrate = new System.Windows.Forms.ComboBox();
            this.comboPortName = new System.Windows.Forms.ComboBox();
            this.Set = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.realdatatest = new System.Windows.Forms.CheckBox();
            this.SetAngle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RecDegtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OutModeSel = new System.Windows.Forms.ComboBox();
            this.RecBaseOutChk = new System.Windows.Forms.CheckBox();
            this.AGC_En_chk = new System.Windows.Forms.CheckBox();
            this.IFLoopChk = new System.Windows.Forms.CheckBox();
            this.LocalModeChk = new System.Windows.Forms.CheckBox();
            this.HSDAoutMode = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.AudioLpBkEn = new System.Windows.Forms.CheckBox();
            this.RefDisChk = new System.Windows.Forms.CheckBox();
            this.SUBCarriDisChk = new System.Windows.Forms.CheckBox();
            this.FM_dis_chk = new System.Windows.Forms.CheckBox();
            this.IF_Amp_Box = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.VolumeBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PhaseOffset = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RecvText = new System.Windows.Forms.RichTextBox();
            this.exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.Send_text = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.SignalFre = new System.Windows.Forms.TextBox();
            this.AMLoOffset = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LevDisplay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IF_AGC_Con = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderSentNo = new System.Windows.Forms.Label();
            this.StatsWordGotNo = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MyVor = new MyVR.UserControl1();
            this.PlaneTrack = new MyPlanTrack.UserControl1();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.Set.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpenClose);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBaudrate);
            this.groupBox1.Controls.Add(this.comboPortName);
            this.groupBox1.Location = new System.Drawing.Point(3, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(445, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "监控端口设置";
            // 
            // OpenClose
            // 
            this.OpenClose.Location = new System.Drawing.Point(361, 18);
            this.OpenClose.Margin = new System.Windows.Forms.Padding(4);
            this.OpenClose.Name = "OpenClose";
            this.OpenClose.Size = new System.Drawing.Size(61, 35);
            this.OpenClose.TabIndex = 2;
            this.OpenClose.Text = "打开";
            this.OpenClose.UseVisualStyleBackColor = true;
            this.OpenClose.Click += new System.EventHandler(this.openclose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "端口";
            // 
            // comboBaudrate
            // 
            this.comboBaudrate.FormattingEnabled = true;
            this.comboBaudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "38400",
            "4300",
            "5600",
            "115200"});
            this.comboBaudrate.Location = new System.Drawing.Point(239, 26);
            this.comboBaudrate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBaudrate.Name = "comboBaudrate";
            this.comboBaudrate.Size = new System.Drawing.Size(96, 23);
            this.comboBaudrate.TabIndex = 1;
            // 
            // comboPortName
            // 
            this.comboPortName.FormattingEnabled = true;
            this.comboPortName.Location = new System.Drawing.Point(67, 26);
            this.comboPortName.Margin = new System.Windows.Forms.Padding(4);
            this.comboPortName.Name = "comboPortName";
            this.comboPortName.Size = new System.Drawing.Size(72, 23);
            this.comboPortName.TabIndex = 0;
            // 
            // Set
            // 
            this.Set.Controls.Add(this.checkBox1);
            this.Set.Controls.Add(this.realdatatest);
            this.Set.Controls.Add(this.SetAngle);
            this.Set.Controls.Add(this.label8);
            this.Set.Controls.Add(this.RecDegtextBox);
            this.Set.Controls.Add(this.label5);
            this.Set.Controls.Add(this.OutModeSel);
            this.Set.Controls.Add(this.RecBaseOutChk);
            this.Set.Controls.Add(this.AGC_En_chk);
            this.Set.Controls.Add(this.IFLoopChk);
            this.Set.Controls.Add(this.LocalModeChk);
            this.Set.Controls.Add(this.HSDAoutMode);
            this.Set.Controls.Add(this.label17);
            this.Set.Controls.Add(this.AudioLpBkEn);
            this.Set.Controls.Add(this.RefDisChk);
            this.Set.Controls.Add(this.SUBCarriDisChk);
            this.Set.Controls.Add(this.FM_dis_chk);
            this.Set.Controls.Add(this.IF_Amp_Box);
            this.Set.Controls.Add(this.label15);
            this.Set.Controls.Add(this.VolumeBox);
            this.Set.Controls.Add(this.label13);
            this.Set.Controls.Add(this.PhaseOffset);
            this.Set.Controls.Add(this.label4);
            this.Set.Location = new System.Drawing.Point(3, 90);
            this.Set.Margin = new System.Windows.Forms.Padding(4);
            this.Set.Name = "Set";
            this.Set.Padding = new System.Windows.Forms.Padding(4);
            this.Set.Size = new System.Drawing.Size(445, 265);
            this.Set.TabIndex = 1;
            this.Set.TabStop = false;
            this.Set.Text = "工作模式设置";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 231);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 19);
            this.checkBox1.TabIndex = 59;
            this.checkBox1.Text = "工训测试";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // realdatatest
            // 
            this.realdatatest.AutoSize = true;
            this.realdatatest.Location = new System.Drawing.Point(128, 139);
            this.realdatatest.Margin = new System.Windows.Forms.Padding(4);
            this.realdatatest.Name = "realdatatest";
            this.realdatatest.Size = new System.Drawing.Size(119, 19);
            this.realdatatest.TabIndex = 50;
            this.realdatatest.Text = "实采数据测试";
            this.realdatatest.UseVisualStyleBackColor = true;
            this.realdatatest.CheckedChanged += new System.EventHandler(this.realdatatest_CheckedChanged);
            // 
            // SetAngle
            // 
            this.SetAngle.Location = new System.Drawing.Point(324, 85);
            this.SetAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetAngle.Name = "SetAngle";
            this.SetAngle.Size = new System.Drawing.Size(105, 25);
            this.SetAngle.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 57;
            this.label8.Text = "预设航道角";
            // 
            // RecDegtextBox
            // 
            this.RecDegtextBox.Enabled = false;
            this.RecDegtextBox.Location = new System.Drawing.Point(97, 85);
            this.RecDegtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RecDegtextBox.Name = "RecDegtextBox";
            this.RecDegtextBox.Size = new System.Drawing.Size(97, 25);
            this.RecDegtextBox.TabIndex = 56;
            this.RecDegtextBox.Text = "0";
            this.RecDegtextBox.TextChanged += new System.EventHandler(this.RecDegtextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 55;
            this.label5.Text = "测量角度";
            // 
            // OutModeSel
            // 
            this.OutModeSel.FormattingEnabled = true;
            this.OutModeSel.Items.AddRange(new object[] {
            "数据基带+副载波",
            "Hibert变换后",
            "鉴频输出滤波前后",
            "FM_cos  AM_cos"});
            this.OutModeSel.Location = new System.Drawing.Point(265, 166);
            this.OutModeSel.Margin = new System.Windows.Forms.Padding(4);
            this.OutModeSel.Name = "OutModeSel";
            this.OutModeSel.Size = new System.Drawing.Size(153, 23);
            this.OutModeSel.TabIndex = 54;
            this.OutModeSel.SelectedIndexChanged += new System.EventHandler(this.OutModeSel_SelectedIndexChanged);
            // 
            // RecBaseOutChk
            // 
            this.RecBaseOutChk.AutoSize = true;
            this.RecBaseOutChk.Location = new System.Drawing.Point(265, 139);
            this.RecBaseOutChk.Margin = new System.Windows.Forms.Padding(4);
            this.RecBaseOutChk.Name = "RecBaseOutChk";
            this.RecBaseOutChk.Size = new System.Drawing.Size(149, 19);
            this.RecBaseOutChk.TabIndex = 53;
            this.RecBaseOutChk.Text = "音频输出接收基带";
            this.RecBaseOutChk.UseVisualStyleBackColor = true;
            this.RecBaseOutChk.CheckedChanged += new System.EventHandler(this.RecBaseOutChk_CheckedChanged);
            // 
            // AGC_En_chk
            // 
            this.AGC_En_chk.AutoSize = true;
            this.AGC_En_chk.Location = new System.Drawing.Point(128, 200);
            this.AGC_En_chk.Margin = new System.Windows.Forms.Padding(4);
            this.AGC_En_chk.Name = "AGC_En_chk";
            this.AGC_En_chk.Size = new System.Drawing.Size(105, 19);
            this.AGC_En_chk.TabIndex = 52;
            this.AGC_En_chk.Text = "使用仿真IF";
            this.AGC_En_chk.UseVisualStyleBackColor = true;
            this.AGC_En_chk.CheckedChanged += new System.EventHandler(this.AGC_En_chk_CheckedChanged_1);
            // 
            // IFLoopChk
            // 
            this.IFLoopChk.AutoSize = true;
            this.IFLoopChk.Location = new System.Drawing.Point(128, 170);
            this.IFLoopChk.Margin = new System.Windows.Forms.Padding(4);
            this.IFLoopChk.Name = "IFLoopChk";
            this.IFLoopChk.Size = new System.Drawing.Size(119, 19);
            this.IFLoopChk.TabIndex = 51;
            this.IFLoopChk.Text = "中频环回测试";
            this.IFLoopChk.UseVisualStyleBackColor = true;
            this.IFLoopChk.CheckedChanged += new System.EventHandler(this.IFLoopChk_CheckedChanged);
            // 
            // LocalModeChk
            // 
            this.LocalModeChk.AutoSize = true;
            this.LocalModeChk.Enabled = false;
            this.LocalModeChk.Location = new System.Drawing.Point(265, 200);
            this.LocalModeChk.Margin = new System.Windows.Forms.Padding(4);
            this.LocalModeChk.Name = "LocalModeChk";
            this.LocalModeChk.Size = new System.Drawing.Size(89, 19);
            this.LocalModeChk.TabIndex = 50;
            this.LocalModeChk.Text = "本地模式";
            this.LocalModeChk.UseVisualStyleBackColor = true;
            // 
            // HSDAoutMode
            // 
            this.HSDAoutMode.FormattingEnabled = true;
            this.HSDAoutMode.Items.AddRange(new object[] {
            "IIR前",
            "IIR后",
            "AM调制"});
            this.HSDAoutMode.Location = new System.Drawing.Point(324, 15);
            this.HSDAoutMode.Margin = new System.Windows.Forms.Padding(4);
            this.HSDAoutMode.Name = "HSDAoutMode";
            this.HSDAoutMode.Size = new System.Drawing.Size(105, 23);
            this.HSDAoutMode.TabIndex = 46;
            this.HSDAoutMode.SelectedIndexChanged += new System.EventHandler(this.HSDAoutMode_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(229, 22);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 15);
            this.label17.TabIndex = 45;
            this.label17.Text = "高速DA输出";
            // 
            // AudioLpBkEn
            // 
            this.AudioLpBkEn.AutoSize = true;
            this.AudioLpBkEn.Location = new System.Drawing.Point(129, 139);
            this.AudioLpBkEn.Margin = new System.Windows.Forms.Padding(4);
            this.AudioLpBkEn.Name = "AudioLpBkEn";
            this.AudioLpBkEn.Size = new System.Drawing.Size(119, 19);
            this.AudioLpBkEn.TabIndex = 44;
            this.AudioLpBkEn.Text = "基带环回测试";
            this.AudioLpBkEn.UseVisualStyleBackColor = true;
            this.AudioLpBkEn.CheckedChanged += new System.EventHandler(this.AudioLpBkEn_CheckedChanged);
            // 
            // RefDisChk
            // 
            this.RefDisChk.AutoSize = true;
            this.RefDisChk.Location = new System.Drawing.Point(16, 200);
            this.RefDisChk.Margin = new System.Windows.Forms.Padding(4);
            this.RefDisChk.Name = "RefDisChk";
            this.RefDisChk.Size = new System.Drawing.Size(89, 19);
            this.RefDisChk.TabIndex = 42;
            this.RefDisChk.Text = "关闭参考";
            this.RefDisChk.UseVisualStyleBackColor = true;
            this.RefDisChk.CheckedChanged += new System.EventHandler(this.MSKEnChk_CheckedChanged);
            // 
            // SUBCarriDisChk
            // 
            this.SUBCarriDisChk.AutoSize = true;
            this.SUBCarriDisChk.Location = new System.Drawing.Point(13, 170);
            this.SUBCarriDisChk.Margin = new System.Windows.Forms.Padding(4);
            this.SUBCarriDisChk.Name = "SUBCarriDisChk";
            this.SUBCarriDisChk.Size = new System.Drawing.Size(104, 19);
            this.SUBCarriDisChk.TabIndex = 41;
            this.SUBCarriDisChk.Text = "关闭副载波";
            this.SUBCarriDisChk.UseVisualStyleBackColor = true;
            this.SUBCarriDisChk.CheckedChanged += new System.EventHandler(this.AMEnChk_CheckedChanged);
            // 
            // FM_dis_chk
            // 
            this.FM_dis_chk.AutoSize = true;
            this.FM_dis_chk.Location = new System.Drawing.Point(13, 139);
            this.FM_dis_chk.Margin = new System.Windows.Forms.Padding(4);
            this.FM_dis_chk.Name = "FM_dis_chk";
            this.FM_dis_chk.Size = new System.Drawing.Size(75, 19);
            this.FM_dis_chk.TabIndex = 40;
            this.FM_dis_chk.Text = "FM禁止";
            this.FM_dis_chk.UseVisualStyleBackColor = true;
            this.FM_dis_chk.CheckedChanged += new System.EventHandler(this.AGC_En_chk_CheckedChanged);
            // 
            // IF_Amp_Box
            // 
            this.IF_Amp_Box.FormattingEnabled = true;
            this.IF_Amp_Box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.IF_Amp_Box.Location = new System.Drawing.Point(97, 19);
            this.IF_Amp_Box.Margin = new System.Windows.Forms.Padding(4);
            this.IF_Amp_Box.Name = "IF_Amp_Box";
            this.IF_Amp_Box.Size = new System.Drawing.Size(97, 23);
            this.IF_Amp_Box.TabIndex = 39;
            this.IF_Amp_Box.SelectedIndexChanged += new System.EventHandler(this.IF_Amp_Box_SelectedIndexChanged);
            this.IF_Amp_Box.TextChanged += new System.EventHandler(this.IF_Amp_Box_TextChanged);
            this.IF_Amp_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IF_Amp_Box_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 22);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 38;
            this.label15.Text = "中频幅度";
            // 
            // VolumeBox
            // 
            this.VolumeBox.FormattingEnabled = true;
            this.VolumeBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.VolumeBox.Location = new System.Drawing.Point(324, 51);
            this.VolumeBox.Margin = new System.Windows.Forms.Padding(4);
            this.VolumeBox.Name = "VolumeBox";
            this.VolumeBox.Size = new System.Drawing.Size(105, 23);
            this.VolumeBox.TabIndex = 37;
            this.VolumeBox.SelectedIndexChanged += new System.EventHandler(this.VolumeBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(229, 55);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 36;
            this.label13.Text = "音量";
            // 
            // PhaseOffset
            // 
            this.PhaseOffset.FormattingEnabled = true;
            this.PhaseOffset.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254",
            "255",
            "256",
            "257",
            "258",
            "259",
            "260",
            "261",
            "262",
            "263",
            "264",
            "265",
            "266",
            "267",
            "268",
            "269",
            "270",
            "271",
            "272",
            "273",
            "274",
            "275",
            "276",
            "277",
            "278",
            "279",
            "280",
            "281",
            "282",
            "283",
            "284",
            "285",
            "286",
            "287",
            "288",
            "289",
            "290",
            "291",
            "292",
            "293",
            "294",
            "295",
            "296",
            "297",
            "298",
            "299",
            "300",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "309",
            "310",
            "311",
            "312",
            "313",
            "314",
            "315",
            "316",
            "317",
            "318",
            "319",
            "320",
            "321",
            "322",
            "323",
            "324",
            "325",
            "326",
            "327",
            "328",
            "329",
            "330",
            "331",
            "332",
            "333",
            "334",
            "335",
            "336",
            "337",
            "338",
            "339",
            "340",
            "341",
            "342",
            "343",
            "344",
            "345",
            "346",
            "347",
            "348",
            "349",
            "350",
            "351",
            "352",
            "353",
            "354",
            "355",
            "356",
            "357",
            "358",
            "359"});
            this.PhaseOffset.Location = new System.Drawing.Point(97, 51);
            this.PhaseOffset.Margin = new System.Windows.Forms.Padding(4);
            this.PhaseOffset.Name = "PhaseOffset";
            this.PhaseOffset.Size = new System.Drawing.Size(97, 23);
            this.PhaseOffset.TabIndex = 35;
            this.PhaseOffset.SelectedIndexChanged += new System.EventHandler(this.NoiseLev_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "飞机方位角";
            // 
            // RecvText
            // 
            this.RecvText.Location = new System.Drawing.Point(8, 32);
            this.RecvText.Margin = new System.Windows.Forms.Padding(4);
            this.RecvText.Name = "RecvText";
            this.RecvText.Size = new System.Drawing.Size(428, 29);
            this.RecvText.TabIndex = 15;
            this.RecvText.Text = "";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(621, 540);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(64, 65);
            this.exit.TabIndex = 3;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RecvText);
            this.groupBox4.Location = new System.Drawing.Point(3, 456);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(445, 70);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收状态（控制字+增益字+频率字+功率字）：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SendBtn);
            this.groupBox5.Controls.Add(this.Send_text);
            this.groupBox5.Location = new System.Drawing.Point(9, 549);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(243, 69);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "待发送指令";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(153, 20);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(80, 29);
            this.SendBtn.TabIndex = 51;
            this.SendBtn.Text = "发送";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.Send_Click_1);
            // 
            // Send_text
            // 
            this.Send_text.Location = new System.Drawing.Point(7, 19);
            this.Send_text.Margin = new System.Windows.Forms.Padding(4);
            this.Send_text.Multiline = true;
            this.Send_text.Name = "Send_text";
            this.Send_text.Size = new System.Drawing.Size(132, 29);
            this.Send_text.TabIndex = 13;
            this.Send_text.TextChanged += new System.EventHandler(this.Send_text_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.SignalFre);
            this.groupBox8.Controls.Add(this.AMLoOffset);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.LevDisplay);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.IF_AGC_Con);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Location = new System.Drawing.Point(3, 362);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(445, 86);
            this.groupBox8.TabIndex = 35;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "其他设置";
            // 
            // SignalFre
            // 
            this.SignalFre.Location = new System.Drawing.Point(101, 14);
            this.SignalFre.Margin = new System.Windows.Forms.Padding(4);
            this.SignalFre.Name = "SignalFre";
            this.SignalFre.Size = new System.Drawing.Size(128, 25);
            this.SignalFre.TabIndex = 46;
            this.SignalFre.Leave += new System.EventHandler(this.SignalFre_Leave);
            // 
            // AMLoOffset
            // 
            this.AMLoOffset.Location = new System.Drawing.Point(328, 16);
            this.AMLoOffset.Margin = new System.Windows.Forms.Padding(4);
            this.AMLoOffset.Name = "AMLoOffset";
            this.AMLoOffset.Size = new System.Drawing.Size(100, 25);
            this.AMLoOffset.TabIndex = 45;
            this.AMLoOffset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AMLoOffset_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "本振频偏";
            // 
            // LevDisplay
            // 
            this.LevDisplay.Location = new System.Drawing.Point(327, 49);
            this.LevDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.LevDisplay.Name = "LevDisplay";
            this.LevDisplay.ReadOnly = true;
            this.LevDisplay.Size = new System.Drawing.Size(101, 25);
            this.LevDisplay.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "信号强度";
            // 
            // IF_AGC_Con
            // 
            this.IF_AGC_Con.FormattingEnabled = true;
            this.IF_AGC_Con.Items.AddRange(new object[] {
            "01FF",
            "02FF",
            "03FF",
            "04FF",
            "05FF",
            "06FF",
            "07FF"});
            this.IF_AGC_Con.Location = new System.Drawing.Point(101, 50);
            this.IF_AGC_Con.Margin = new System.Windows.Forms.Padding(4);
            this.IF_AGC_Con.Name = "IF_AGC_Con";
            this.IF_AGC_Con.Size = new System.Drawing.Size(131, 23);
            this.IF_AGC_Con.TabIndex = 38;
            this.IF_AGC_Con.SelectedIndexChanged += new System.EventHandler(this.IF_AGC_Con_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 37;
            this.label16.Text = "中频增益";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "工作频率";
            // 
            // OrderSentNo
            // 
            this.OrderSentNo.Location = new System.Drawing.Point(260, 561);
            this.OrderSentNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderSentNo.Name = "OrderSentNo";
            this.OrderSentNo.Size = new System.Drawing.Size(124, 29);
            this.OrderSentNo.TabIndex = 62;
            this.OrderSentNo.Text = "已发送";
            // 
            // StatsWordGotNo
            // 
            this.StatsWordGotNo.AutoSize = true;
            this.StatsWordGotNo.Location = new System.Drawing.Point(260, 590);
            this.StatsWordGotNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatsWordGotNo.Name = "StatsWordGotNo";
            this.StatsWordGotNo.Size = new System.Drawing.Size(52, 15);
            this.StatsWordGotNo.TabIndex = 46;
            this.StatsWordGotNo.Text = "已收到";
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 540);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 65);
            this.button1.TabIndex = 49;
            this.button1.Text = "性能测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 15);
            this.label9.TabIndex = 59;
            this.label9.Text = "VOR表盘显示(向背台+航道偏离+警告旗)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(913, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 60;
            this.label10.Text = "飞机航迹仿真";
            // 
            // MyVor
            // 
            this.MyVor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MyVor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MyVor.BackgroundImage")));
            this.MyVor.IF_Amp = 0D;
            this.MyVor.Location = new System.Drawing.Point(455, 60);
            this.MyVor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyVor.Name = "MyVor";
            this.MyVor.reallAngel = 0D;
            this.MyVor.setAngle = 0D;
            this.MyVor.Size = new System.Drawing.Size(424, 389);
            this.MyVor.skewingDate = 1D;
            this.MyVor.TabIndex = 47;
            this.MyVor.tfDate = 1D;
            this.MyVor.Load += new System.EventHandler(this.MyVor_Load);
            // 
            // PlaneTrack
            // 
            this.PlaneTrack.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PlaneTrack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlaneTrack.BackgroundImage")));
            this.PlaneTrack.Location = new System.Drawing.Point(885, 59);
            this.PlaneTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlaneTrack.Name = "PlaneTrack";
            this.PlaneTrack.ReallAngle = 0D;
            this.PlaneTrack.SetAngle = 0D;
            this.PlaneTrack.SinAngle = 0;
            this.PlaneTrack.Size = new System.Drawing.Size(424, 389);
            this.PlaneTrack.TabIndex = 48;
            this.PlaneTrack.AutoSizeChanged += new System.EventHandler(this.PlaneTrack_AutoSizeChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(909, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 64;
            this.label11.Text = "正弦角度设置";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(899, 417);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 23);
            this.comboBox1.TabIndex = 65;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 616);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlaneTrack);
            this.Controls.Add(this.MyVor);
            this.Controls.Add(this.StatsWordGotNo);
            this.Controls.Add(this.OrderSentNo);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "DVOR接收机演示系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Set.ResumeLayout(false);
            this.Set.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBaudrate;
        private System.Windows.Forms.ComboBox comboPortName;
        private System.Windows.Forms.GroupBox Set;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OpenClose;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox RecvText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ComboBox IF_Amp_Box;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox VolumeBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox HSDAoutMode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox AudioLpBkEn;
        private System.Windows.Forms.CheckBox RefDisChk;
        private System.Windows.Forms.CheckBox SUBCarriDisChk;
        private System.Windows.Forms.CheckBox FM_dis_chk;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox IF_AGC_Con;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.CheckBox LocalModeChk;
        private System.Windows.Forms.TextBox LevDisplay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox IFLoopChk;
        private System.Windows.Forms.Label OrderSentNo;
        private System.Windows.Forms.Label StatsWordGotNo;
        private System.Windows.Forms.CheckBox AGC_En_chk;
        private System.Windows.Forms.ComboBox OutModeSel;
        private System.Windows.Forms.CheckBox RecBaseOutChk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AMLoOffset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SetAngle;
        private System.Windows.Forms.Timer timer4;
        private MyVR.UserControl1 MyVor;
        private MyPlanTrack.UserControl1 PlaneTrack;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox PhaseOffset;
        public System.Windows.Forms.TextBox RecDegtextBox;
        private System.Windows.Forms.CheckBox realdatatest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox SignalFre;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox Send_text;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

