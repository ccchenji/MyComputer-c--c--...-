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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.AMLoOffset = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LevDisplay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IF_AGC_Con = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SignalFre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderSentNo = new System.Windows.Forms.Label();
            this.StatsWordGotNo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Errortest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Set.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpenClose);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBaudrate);
            this.groupBox1.Controls.Add(this.comboPortName);
            this.groupBox1.Location = new System.Drawing.Point(1253, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(501, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "监控端口设置";
            // 
            // OpenClose
            // 
            this.OpenClose.Location = new System.Drawing.Point(406, 21);
            this.OpenClose.Margin = new System.Windows.Forms.Padding(4);
            this.OpenClose.Name = "OpenClose";
            this.OpenClose.Size = new System.Drawing.Size(69, 42);
            this.OpenClose.TabIndex = 2;
            this.OpenClose.Text = "打开";
            this.OpenClose.UseVisualStyleBackColor = true;
            this.OpenClose.Click += new System.EventHandler(this.openclose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
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
            this.comboBaudrate.Location = new System.Drawing.Point(268, 32);
            this.comboBaudrate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBaudrate.Name = "comboBaudrate";
            this.comboBaudrate.Size = new System.Drawing.Size(108, 26);
            this.comboBaudrate.TabIndex = 1;
            // 
            // comboPortName
            // 
            this.comboPortName.FormattingEnabled = true;
            this.comboPortName.Location = new System.Drawing.Point(75, 32);
            this.comboPortName.Margin = new System.Windows.Forms.Padding(4);
            this.comboPortName.Name = "comboPortName";
            this.comboPortName.Size = new System.Drawing.Size(80, 26);
            this.comboPortName.TabIndex = 0;
            // 
            // Set
            // 
            this.Set.Controls.Add(this.textBox1);
            this.Set.Controls.Add(this.label9);
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
            this.Set.Location = new System.Drawing.Point(1253, 109);
            this.Set.Margin = new System.Windows.Forms.Padding(4);
            this.Set.Name = "Set";
            this.Set.Padding = new System.Windows.Forms.Padding(4);
            this.Set.Size = new System.Drawing.Size(501, 282);
            this.Set.TabIndex = 1;
            this.Set.TabStop = false;
            this.Set.Text = "工作模式设置";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 102);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 28);
            this.textBox1.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 57;
            this.label9.Text = "预设航道角";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // RecDegtextBox
            // 
            this.RecDegtextBox.Enabled = false;
            this.RecDegtextBox.Location = new System.Drawing.Point(110, 102);
            this.RecDegtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RecDegtextBox.Name = "RecDegtextBox";
            this.RecDegtextBox.Size = new System.Drawing.Size(109, 28);
            this.RecDegtextBox.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
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
            this.OutModeSel.Location = new System.Drawing.Point(298, 200);
            this.OutModeSel.Margin = new System.Windows.Forms.Padding(4);
            this.OutModeSel.Name = "OutModeSel";
            this.OutModeSel.Size = new System.Drawing.Size(172, 26);
            this.OutModeSel.TabIndex = 54;
            this.OutModeSel.SelectedIndexChanged += new System.EventHandler(this.OutModeSel_SelectedIndexChanged);
            // 
            // RecBaseOutChk
            // 
            this.RecBaseOutChk.AutoSize = true;
            this.RecBaseOutChk.Location = new System.Drawing.Point(298, 166);
            this.RecBaseOutChk.Margin = new System.Windows.Forms.Padding(4);
            this.RecBaseOutChk.Name = "RecBaseOutChk";
            this.RecBaseOutChk.Size = new System.Drawing.Size(178, 22);
            this.RecBaseOutChk.TabIndex = 53;
            this.RecBaseOutChk.Text = "音频输出接收基带";
            this.RecBaseOutChk.UseVisualStyleBackColor = true;
            this.RecBaseOutChk.CheckedChanged += new System.EventHandler(this.RecBaseOutChk_CheckedChanged);
            // 
            // AGC_En_chk
            // 
            this.AGC_En_chk.AutoSize = true;
            this.AGC_En_chk.Location = new System.Drawing.Point(144, 240);
            this.AGC_En_chk.Margin = new System.Windows.Forms.Padding(4);
            this.AGC_En_chk.Name = "AGC_En_chk";
            this.AGC_En_chk.Size = new System.Drawing.Size(124, 22);
            this.AGC_En_chk.TabIndex = 52;
            this.AGC_En_chk.Text = "使用仿真IF";
            this.AGC_En_chk.UseVisualStyleBackColor = true;
            this.AGC_En_chk.CheckedChanged += new System.EventHandler(this.AGC_En_chk_CheckedChanged_1);
            // 
            // IFLoopChk
            // 
            this.IFLoopChk.AutoSize = true;
            this.IFLoopChk.Location = new System.Drawing.Point(144, 204);
            this.IFLoopChk.Margin = new System.Windows.Forms.Padding(4);
            this.IFLoopChk.Name = "IFLoopChk";
            this.IFLoopChk.Size = new System.Drawing.Size(142, 22);
            this.IFLoopChk.TabIndex = 51;
            this.IFLoopChk.Text = "中频环回测试";
            this.IFLoopChk.UseVisualStyleBackColor = true;
            this.IFLoopChk.CheckedChanged += new System.EventHandler(this.IFLoopChk_CheckedChanged);
            // 
            // LocalModeChk
            // 
            this.LocalModeChk.AutoSize = true;
            this.LocalModeChk.Enabled = false;
            this.LocalModeChk.Location = new System.Drawing.Point(298, 240);
            this.LocalModeChk.Margin = new System.Windows.Forms.Padding(4);
            this.LocalModeChk.Name = "LocalModeChk";
            this.LocalModeChk.Size = new System.Drawing.Size(106, 22);
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
            this.HSDAoutMode.Location = new System.Drawing.Point(364, 18);
            this.HSDAoutMode.Margin = new System.Windows.Forms.Padding(4);
            this.HSDAoutMode.Name = "HSDAoutMode";
            this.HSDAoutMode.Size = new System.Drawing.Size(118, 26);
            this.HSDAoutMode.TabIndex = 46;
            this.HSDAoutMode.SelectedIndexChanged += new System.EventHandler(this.HSDAoutMode_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(258, 27);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 18);
            this.label17.TabIndex = 45;
            this.label17.Text = "高速DA输出";
            // 
            // AudioLpBkEn
            // 
            this.AudioLpBkEn.AutoSize = true;
            this.AudioLpBkEn.Location = new System.Drawing.Point(146, 166);
            this.AudioLpBkEn.Margin = new System.Windows.Forms.Padding(4);
            this.AudioLpBkEn.Name = "AudioLpBkEn";
            this.AudioLpBkEn.Size = new System.Drawing.Size(142, 22);
            this.AudioLpBkEn.TabIndex = 44;
            this.AudioLpBkEn.Text = "基带环回测试";
            this.AudioLpBkEn.UseVisualStyleBackColor = true;
            this.AudioLpBkEn.CheckedChanged += new System.EventHandler(this.AudioLpBkEn_CheckedChanged);
            // 
            // RefDisChk
            // 
            this.RefDisChk.AutoSize = true;
            this.RefDisChk.Location = new System.Drawing.Point(15, 240);
            this.RefDisChk.Margin = new System.Windows.Forms.Padding(4);
            this.RefDisChk.Name = "RefDisChk";
            this.RefDisChk.Size = new System.Drawing.Size(106, 22);
            this.RefDisChk.TabIndex = 42;
            this.RefDisChk.Text = "关闭参考";
            this.RefDisChk.UseVisualStyleBackColor = true;
            this.RefDisChk.CheckedChanged += new System.EventHandler(this.MSKEnChk_CheckedChanged);
            // 
            // SUBCarriDisChk
            // 
            this.SUBCarriDisChk.AutoSize = true;
            this.SUBCarriDisChk.Location = new System.Drawing.Point(15, 204);
            this.SUBCarriDisChk.Margin = new System.Windows.Forms.Padding(4);
            this.SUBCarriDisChk.Name = "SUBCarriDisChk";
            this.SUBCarriDisChk.Size = new System.Drawing.Size(124, 22);
            this.SUBCarriDisChk.TabIndex = 41;
            this.SUBCarriDisChk.Text = "关闭副载波";
            this.SUBCarriDisChk.UseVisualStyleBackColor = true;
            this.SUBCarriDisChk.CheckedChanged += new System.EventHandler(this.AMEnChk_CheckedChanged);
            // 
            // FM_dis_chk
            // 
            this.FM_dis_chk.AutoSize = true;
            this.FM_dis_chk.Location = new System.Drawing.Point(15, 166);
            this.FM_dis_chk.Margin = new System.Windows.Forms.Padding(4);
            this.FM_dis_chk.Name = "FM_dis_chk";
            this.FM_dis_chk.Size = new System.Drawing.Size(88, 22);
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
            this.IF_Amp_Box.Location = new System.Drawing.Point(110, 22);
            this.IF_Amp_Box.Margin = new System.Windows.Forms.Padding(4);
            this.IF_Amp_Box.Name = "IF_Amp_Box";
            this.IF_Amp_Box.Size = new System.Drawing.Size(109, 26);
            this.IF_Amp_Box.TabIndex = 39;
            this.IF_Amp_Box.SelectedIndexChanged += new System.EventHandler(this.IF_Amp_Box_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 27);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 18);
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
            this.VolumeBox.Location = new System.Drawing.Point(364, 62);
            this.VolumeBox.Margin = new System.Windows.Forms.Padding(4);
            this.VolumeBox.Name = "VolumeBox";
            this.VolumeBox.Size = new System.Drawing.Size(118, 26);
            this.VolumeBox.TabIndex = 37;
            this.VolumeBox.SelectedIndexChanged += new System.EventHandler(this.VolumeBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(258, 66);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 18);
            this.label13.TabIndex = 36;
            this.label13.Text = "音量";
            // 
            // PhaseOffset
            // 
            this.PhaseOffset.FormattingEnabled = true;
            this.PhaseOffset.Items.AddRange(new object[] {
            "0",
            "45",
            "90",
            "135",
            "180",
            "225",
            "270",
            "315"});
            this.PhaseOffset.Location = new System.Drawing.Point(110, 62);
            this.PhaseOffset.Margin = new System.Windows.Forms.Padding(4);
            this.PhaseOffset.Name = "PhaseOffset";
            this.PhaseOffset.Size = new System.Drawing.Size(109, 26);
            this.PhaseOffset.TabIndex = 35;
            this.PhaseOffset.SelectedIndexChanged += new System.EventHandler(this.NoiseLev_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "飞机方位角";
            // 
            // RecvText
            // 
            this.RecvText.Location = new System.Drawing.Point(8, 24);
            this.RecvText.Margin = new System.Windows.Forms.Padding(4);
            this.RecvText.Name = "RecvText";
            this.RecvText.Size = new System.Drawing.Size(481, 34);
            this.RecvText.TabIndex = 15;
            this.RecvText.Text = "";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1676, 609);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(72, 78);
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
            this.groupBox4.Location = new System.Drawing.Point(1253, 515);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(501, 84);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收状态（控制字+增益字+频率字+功率字）：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SendBtn);
            this.groupBox5.Controls.Add(this.Send_text);
            this.groupBox5.Location = new System.Drawing.Point(1253, 609);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(273, 82);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "待发送指令";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(172, 24);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(90, 34);
            this.SendBtn.TabIndex = 51;
            this.SendBtn.Text = "发送";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.Send_Click_1);
            // 
            // Send_text
            // 
            this.Send_text.Location = new System.Drawing.Point(8, 22);
            this.Send_text.Margin = new System.Windows.Forms.Padding(4);
            this.Send_text.Multiline = true;
            this.Send_text.Name = "Send_text";
            this.Send_text.Size = new System.Drawing.Size(148, 34);
            this.Send_text.TabIndex = 13;
            this.Send_text.TextChanged += new System.EventHandler(this.Send_text_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.AMLoOffset);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.LevDisplay);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.IF_AGC_Con);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.SignalFre);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Location = new System.Drawing.Point(1253, 400);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(501, 105);
            this.groupBox8.TabIndex = 35;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "其他设置";
            // 
            // AMLoOffset
            // 
            this.AMLoOffset.Location = new System.Drawing.Point(369, 20);
            this.AMLoOffset.Margin = new System.Windows.Forms.Padding(4);
            this.AMLoOffset.Name = "AMLoOffset";
            this.AMLoOffset.Size = new System.Drawing.Size(112, 28);
            this.AMLoOffset.TabIndex = 45;
            this.AMLoOffset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AMLoOffset_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "本振频偏";
            // 
            // LevDisplay
            // 
            this.LevDisplay.Location = new System.Drawing.Point(368, 58);
            this.LevDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.LevDisplay.Name = "LevDisplay";
            this.LevDisplay.ReadOnly = true;
            this.LevDisplay.Size = new System.Drawing.Size(114, 28);
            this.LevDisplay.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
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
            this.IF_AGC_Con.Location = new System.Drawing.Point(114, 60);
            this.IF_AGC_Con.Margin = new System.Windows.Forms.Padding(4);
            this.IF_AGC_Con.Name = "IF_AGC_Con";
            this.IF_AGC_Con.Size = new System.Drawing.Size(146, 26);
            this.IF_AGC_Con.TabIndex = 38;
            this.IF_AGC_Con.SelectedIndexChanged += new System.EventHandler(this.IF_AGC_Con_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 66);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 18);
            this.label16.TabIndex = 37;
            this.label16.Text = "中频增益";
            // 
            // SignalFre
            // 
            this.SignalFre.FormattingEnabled = true;
            this.SignalFre.Items.AddRange(new object[] {
            "112.1 BHVOR",
            "113.4 DJVOR",
            "118.2 TJTWR",
            "119.0 BJAPP2",
            "125.6 BJAPP1",
            "126.4 ATIS",
            "127.9 TJAPP",
            "131.45 ACARS",
            "1030.0 2ndRD",
            "1090.0 ADS-B"});
            this.SignalFre.Location = new System.Drawing.Point(114, 21);
            this.SignalFre.Margin = new System.Windows.Forms.Padding(4);
            this.SignalFre.Name = "SignalFre";
            this.SignalFre.Size = new System.Drawing.Size(146, 26);
            this.SignalFre.TabIndex = 36;
            this.SignalFre.SelectedIndexChanged += new System.EventHandler(this.SignalFre_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "工作频率";
            // 
            // OrderSentNo
            // 
            this.OrderSentNo.AutoSize = true;
            this.OrderSentNo.Location = new System.Drawing.Point(1535, 627);
            this.OrderSentNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderSentNo.Name = "OrderSentNo";
            this.OrderSentNo.Size = new System.Drawing.Size(62, 18);
            this.OrderSentNo.TabIndex = 45;
            this.OrderSentNo.Text = "已发出";
            // 
            // StatsWordGotNo
            // 
            this.StatsWordGotNo.AutoSize = true;
            this.StatsWordGotNo.Location = new System.Drawing.Point(1535, 659);
            this.StatsWordGotNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatsWordGotNo.Name = "StatsWordGotNo";
            this.StatsWordGotNo.Size = new System.Drawing.Size(62, 18);
            this.StatsWordGotNo.TabIndex = 46;
            this.StatsWordGotNo.Text = "已收到";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 49);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(323, 18);
            this.label12.TabIndex = 47;
            this.label12.Text = "VOR仪表显示(航道偏离+向背台+警告旗)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 482);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "航迹1",
            "航迹2",
            "航迹3"});
            this.comboBox3.Location = new System.Drawing.Point(519, 94);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(132, 26);
            this.comboBox3.TabIndex = 80;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(595, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(521, 466);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // Errortest
            // 
            this.Errortest.Location = new System.Drawing.Point(1605, 609);
            this.Errortest.Margin = new System.Windows.Forms.Padding(4);
            this.Errortest.Name = "Errortest";
            this.Errortest.Size = new System.Drawing.Size(60, 80);
            this.Errortest.TabIndex = 83;
            this.Errortest.Text = "性能测试";
            this.Errortest.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1118, 313);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 115);
            this.button1.TabIndex = 84;
            this.button1.Text = "右边有程序代码的不用修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(735, 73);
            this.button2.TabIndex = 85;
            this.button2.Text = "飞机动态航迹（可以选择3种航行路径，选择后自动链接右侧飞机方位角，实时变化和测量，设置开始按钮）";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 725);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Errortest);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.StatsWordGotNo);
            this.Controls.Add(this.OrderSentNo);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.ComboBox PhaseOffset;
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
        private System.Windows.Forms.ComboBox SignalFre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Send_text;
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
        private System.Windows.Forms.TextBox RecDegtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AMLoOffset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Errortest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

