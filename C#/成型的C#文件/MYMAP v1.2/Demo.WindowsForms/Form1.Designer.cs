namespace Demo.WindowsForms.Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainMap1 = new GMap.NET.WindowsForms.GMapControl();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.TextBOXZOOM = new CCWin.SkinControl.SkinLabel();
            this.trackBarZOOM = new CCWin.SkinControl.SkinTrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.lablel12 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.SAND_ALL = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.XiangMuList = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbin_show = new System.Windows.Forms.RichTextBox();
            this.hex_show = new System.Windows.Forms.CheckBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.skinTabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage4 = new CCWin.SkinControl.SkinTabPage();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.btnComOpen = new System.Windows.Forms.Button();
            this.cbComList = new System.Windows.Forms.ComboBox();
            this.cbBaudRateList = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Box_maplist = new System.Windows.Forms.ComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.reflash_time = new System.Windows.Forms.Timer(this.components);
            this.skinMenuStrip1 = new CCWin.SkinControl.SkinMenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PUTMARK = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LngCurrent = new System.Windows.Forms.TextBox();
            this.LatCurrent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.skinTabControl1.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZOOM)).BeginInit();
            this.skinTabPage2.SuspendLayout();
            this.skinTabPage4.SuspendLayout();
            this.skinMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMap1
            // 
            this.MainMap1.Bearing = 0F;
            this.MainMap1.CanDragMap = true;
            this.MainMap1.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap1.GrayScaleMode = false;
            this.MainMap1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap1.LevelsKeepInMemmory = 5;
            this.MainMap1.Location = new System.Drawing.Point(0, 0);
            this.MainMap1.MarkersEnabled = true;
            this.MainMap1.MaxZoom = 2;
            this.MainMap1.MinZoom = 2;
            this.MainMap1.MouseWheelZoomEnabled = true;
            this.MainMap1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap1.Name = "MainMap1";
            this.MainMap1.NegativeMode = false;
            this.MainMap1.PolygonsEnabled = true;
            this.MainMap1.RetryLoadTile = 0;
            this.MainMap1.RoutesEnabled = true;
            this.MainMap1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap1.ShowTileGridLines = false;
            this.MainMap1.Size = new System.Drawing.Size(799, 563);
            this.MainMap1.TabIndex = 0;
            this.MainMap1.Zoom = 0D;
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.Controls.Add(this.skinTabPage2);
            this.skinTabControl1.Controls.Add(this.skinTabPage3);
            this.skinTabControl1.Controls.Add(this.skinTabPage4);
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(4, 55);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 1;
            this.skinTabControl1.Size = new System.Drawing.Size(1188, 753);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 2;
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.skinTabPage1.BorderColor = System.Drawing.Color.Orange;
            this.skinTabPage1.Controls.Add(this.PUTMARK);
            this.skinTabPage1.Controls.Add(this.button3);
            this.skinTabPage1.Controls.Add(this.button1);
            this.skinTabPage1.Controls.Add(this.LngCurrent);
            this.skinTabPage1.Controls.Add(this.LatCurrent);
            this.skinTabPage1.Controls.Add(this.label3);
            this.skinTabPage1.Controls.Add(this.label2);
            this.skinTabPage1.Controls.Add(this.TextBOXZOOM);
            this.skinTabPage1.Controls.Add(this.trackBarZOOM);
            this.skinTabPage1.Controls.Add(this.label13);
            this.skinTabPage1.Controls.Add(this.lablel12);
            this.skinTabPage1.Controls.Add(this.checkedListBox1);
            this.skinTabPage1.Controls.Add(this.MainMap1);
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(1188, 717);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "实时监控";
            // 
            // TextBOXZOOM
            // 
            this.TextBOXZOOM.AutoSize = true;
            this.TextBOXZOOM.BackColor = System.Drawing.Color.Transparent;
            this.TextBOXZOOM.BorderColor = System.Drawing.Color.White;
            this.TextBOXZOOM.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBOXZOOM.Location = new System.Drawing.Point(784, 597);
            this.TextBOXZOOM.Name = "TextBOXZOOM";
            this.TextBOXZOOM.Size = new System.Drawing.Size(15, 17);
            this.TextBOXZOOM.TabIndex = 23;
            this.TextBOXZOOM.Text = "0";
            // 
            // trackBarZOOM
            // 
            this.trackBarZOOM.BackColor = System.Drawing.Color.Transparent;
            this.trackBarZOOM.Bar = null;
            this.trackBarZOOM.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Opacity;
            this.trackBarZOOM.Location = new System.Drawing.Point(3, 569);
            this.trackBarZOOM.Maximum = 20;
            this.trackBarZOOM.Minimum = 10;
            this.trackBarZOOM.Name = "trackBarZOOM";
            this.trackBarZOOM.Size = new System.Drawing.Size(796, 45);
            this.trackBarZOOM.TabIndex = 22;
            this.trackBarZOOM.Track = null;
            this.trackBarZOOM.Value = 10;
            this.trackBarZOOM.Scroll += new System.EventHandler(this.trackBarZOOM_Scroll_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(805, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 12);
            this.label13.TabIndex = 21;
            this.label13.Text = "请勾选需要显示的项目";
            // 
            // lablel12
            // 
            this.lablel12.AutoSize = true;
            this.lablel12.Location = new System.Drawing.Point(805, 44);
            this.lablel12.Name = "lablel12";
            this.lablel12.Size = new System.Drawing.Size(77, 12);
            this.lablel12.TabIndex = 18;
            this.lablel12.Text = "当前车辆位置";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(805, 63);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(285, 308);
            this.checkedListBox1.TabIndex = 17;
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.Transparent;
            this.skinTabPage2.BorderColor = System.Drawing.Color.DarkRed;
            this.skinTabPage2.Controls.Add(this.SAND_ALL);
            this.skinTabPage2.Controls.Add(this.button6);
            this.skinTabPage2.Controls.Add(this.button5);
            this.skinTabPage2.Controls.Add(this.button4);
            this.skinTabPage2.Controls.Add(this.XiangMuList);
            this.skinTabPage2.Controls.Add(this.button2);
            this.skinTabPage2.Controls.Add(this.checkBox1);
            this.skinTabPage2.Controls.Add(this.checkBox2);
            this.skinTabPage2.Controls.Add(this.richTextBox1);
            this.skinTabPage2.Controls.Add(this.label4);
            this.skinTabPage2.Controls.Add(this.cbin_show);
            this.skinTabPage2.Controls.Add(this.hex_show);
            this.skinTabPage2.Controls.Add(this.richTextBox2);
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(1188, 717);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "数据采集";
            // 
            // SAND_ALL
            // 
            this.SAND_ALL.Location = new System.Drawing.Point(714, 318);
            this.SAND_ALL.Name = "SAND_ALL";
            this.SAND_ALL.Size = new System.Drawing.Size(110, 65);
            this.SAND_ALL.TabIndex = 66;
            this.SAND_ALL.Text = "发送全部数据";
            this.SAND_ALL.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(843, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 23);
            this.button6.TabIndex = 65;
            this.button6.Text = "删除";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(843, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 23);
            this.button5.TabIndex = 64;
            this.button5.Text = "下移";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(843, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 23);
            this.button4.TabIndex = 63;
            this.button4.Text = "上移";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // XiangMuList
            // 
            this.XiangMuList.FormattingEnabled = true;
            this.XiangMuList.HorizontalScrollbar = true;
            this.XiangMuList.Location = new System.Drawing.Point(439, 36);
            this.XiangMuList.Name = "XiangMuList";
            this.XiangMuList.Size = new System.Drawing.Size(398, 276);
            this.XiangMuList.TabIndex = 62;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(248, 597);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "包含换行符";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 525);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 16);
            this.checkBox2.TabIndex = 41;
            this.checkBox2.Text = "十六进制发送";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 263);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(357, 198);
            this.richTextBox1.TabIndex = 47;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 45;
            this.label4.Text = "label4";
            // 
            // cbin_show
            // 
            this.cbin_show.Location = new System.Drawing.Point(13, 36);
            this.cbin_show.Name = "cbin_show";
            this.cbin_show.Size = new System.Drawing.Size(357, 220);
            this.cbin_show.TabIndex = 42;
            this.cbin_show.Text = "";
            // 
            // hex_show
            // 
            this.hex_show.AutoSize = true;
            this.hex_show.Location = new System.Drawing.Point(13, 10);
            this.hex_show.Name = "hex_show";
            this.hex_show.Size = new System.Drawing.Size(96, 16);
            this.hex_show.TabIndex = 40;
            this.hex_show.Text = "十六进制显示";
            this.hex_show.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(13, 467);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(347, 43);
            this.richTextBox2.TabIndex = 43;
            this.richTextBox2.Text = "";
            // 
            // skinTabPage3
            // 
            this.skinTabPage3.BackColor = System.Drawing.Color.Transparent;
            this.skinTabPage3.BorderColor = System.Drawing.Color.LawnGreen;
            this.skinTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage3.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage3.Name = "skinTabPage3";
            this.skinTabPage3.Size = new System.Drawing.Size(1188, 717);
            this.skinTabPage3.TabIndex = 2;
            this.skinTabPage3.TabItemImage = null;
            this.skinTabPage3.Text = "数据管理";
            // 
            // skinTabPage4
            // 
            this.skinTabPage4.BackColor = System.Drawing.Color.Transparent;
            this.skinTabPage4.BorderColor = System.Drawing.Color.SteelBlue;
            this.skinTabPage4.Controls.Add(this.skinLabel5);
            this.skinTabPage4.Controls.Add(this.btnComOpen);
            this.skinTabPage4.Controls.Add(this.cbComList);
            this.skinTabPage4.Controls.Add(this.cbBaudRateList);
            this.skinTabPage4.Controls.Add(this.label11);
            this.skinTabPage4.Controls.Add(this.label10);
            this.skinTabPage4.Controls.Add(this.label9);
            this.skinTabPage4.Controls.Add(this.label8);
            this.skinTabPage4.Controls.Add(this.label7);
            this.skinTabPage4.Controls.Add(this.label6);
            this.skinTabPage4.Controls.Add(this.label5);
            this.skinTabPage4.Controls.Add(this.label1);
            this.skinTabPage4.Controls.Add(this.Box_maplist);
            this.skinTabPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage4.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage4.Name = "skinTabPage4";
            this.skinTabPage4.Size = new System.Drawing.Size(1188, 717);
            this.skinTabPage4.TabIndex = 3;
            this.skinTabPage4.TabItemImage = null;
            this.skinTabPage4.Text = "程序设置";
            this.skinTabPage4.Click += new System.EventHandler(this.skinTabPage4_Click);
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(15, 71);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(56, 17);
            this.skinLabel5.TabIndex = 66;
            this.skinLabel5.Text = "串口设置";
            // 
            // btnComOpen
            // 
            this.btnComOpen.Location = new System.Drawing.Point(51, 161);
            this.btnComOpen.Name = "btnComOpen";
            this.btnComOpen.Size = new System.Drawing.Size(88, 24);
            this.btnComOpen.TabIndex = 65;
            this.btnComOpen.Text = "打开串口";
            this.btnComOpen.UseVisualStyleBackColor = true;
            this.btnComOpen.Click += new System.EventHandler(this.btnComOpen_Click);
            // 
            // cbComList
            // 
            this.cbComList.FormattingEnabled = true;
            this.cbComList.Location = new System.Drawing.Point(18, 127);
            this.cbComList.Name = "cbComList";
            this.cbComList.Size = new System.Drawing.Size(121, 20);
            this.cbComList.TabIndex = 64;
            // 
            // cbBaudRateList
            // 
            this.cbBaudRateList.FormattingEnabled = true;
            this.cbBaudRateList.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cbBaudRateList.Location = new System.Drawing.Point(18, 91);
            this.cbBaudRateList.Name = "cbBaudRateList";
            this.cbBaudRateList.Size = new System.Drawing.Size(121, 20);
            this.cbBaudRateList.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(837, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 62;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(837, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 61;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(837, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(837, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 59;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(837, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(837, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(837, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "label5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 55;
            this.label1.Text = "地图来源";
            // 
            // Box_maplist
            // 
            this.Box_maplist.FormattingEnabled = true;
            this.Box_maplist.Location = new System.Drawing.Point(16, 29);
            this.Box_maplist.Name = "Box_maplist";
            this.Box_maplist.Size = new System.Drawing.Size(123, 20);
            this.Box_maplist.TabIndex = 54;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(1027, 11);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(47, 17);
            this.skinLabel1.TabIndex = 3;
            this.skinLabel1.Text = "登录名:";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(1077, 11);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(43, 17);
            this.skinLabel2.TabIndex = 4;
            this.skinLabel2.Text = "public";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(1139, 11);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(35, 17);
            this.skinLabel3.TabIndex = 5;
            this.skinLabel3.Text = "级别:";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(1180, 11);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(15, 17);
            this.skinLabel4.TabIndex = 6;
            this.skinLabel4.Text = "0";
            // 
            // reflash_time
            // 
            this.reflash_time.Enabled = true;
            this.reflash_time.Tick += new System.EventHandler(this.reflash_time_Tick);
            // 
            // skinMenuStrip1
            // 
            this.skinMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip1.Back = System.Drawing.Color.White;
            this.skinMenuStrip1.BackRadius = 4;
            this.skinMenuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinMenuStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip1.BaseForeAnamorphosis = false;
            this.skinMenuStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseItemAnamorphosis = true;
            this.skinMenuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemBorderShow = true;
            this.skinMenuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemDown")));
            this.skinMenuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemMouse")));
            this.skinMenuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemRadius = 4;
            this.skinMenuStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.ItemAnamorphosis = true;
            this.skinMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemBorderShow = true;
            this.skinMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemRadius = 4;
            this.skinMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.人员ToolStripMenuItem});
            this.skinMenuStrip1.Location = new System.Drawing.Point(4, 28);
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Size = new System.Drawing.Size(1322, 25);
            this.skinMenuStrip1.SkinAllColor = true;
            this.skinMenuStrip1.TabIndex = 7;
            this.skinMenuStrip1.Text = "skinMenuStrip1";
            this.skinMenuStrip1.TitleAnamorphosis = true;
            this.skinMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip1.TitleRadius = 4;
            this.skinMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出登录ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            // 
            // 人员ToolStripMenuItem
            // 
            this.人员ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人员管理ToolStripMenuItem,
            this.车辆管理ToolStripMenuItem,
            this.管理员ToolStripMenuItem});
            this.人员ToolStripMenuItem.Name = "人员ToolStripMenuItem";
            this.人员ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.人员ToolStripMenuItem.Text = "登记管理";
            // 
            // 人员管理ToolStripMenuItem
            // 
            this.人员管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人员添加ToolStripMenuItem,
            this.人员删除ToolStripMenuItem,
            this.人员维护ToolStripMenuItem});
            this.人员管理ToolStripMenuItem.Name = "人员管理ToolStripMenuItem";
            this.人员管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.人员管理ToolStripMenuItem.Text = "人员管理";
            // 
            // 人员添加ToolStripMenuItem
            // 
            this.人员添加ToolStripMenuItem.Name = "人员添加ToolStripMenuItem";
            this.人员添加ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.人员添加ToolStripMenuItem.Text = "人员添加";
            // 
            // 人员删除ToolStripMenuItem
            // 
            this.人员删除ToolStripMenuItem.Name = "人员删除ToolStripMenuItem";
            this.人员删除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.人员删除ToolStripMenuItem.Text = "人员删除";
            // 
            // 人员维护ToolStripMenuItem
            // 
            this.人员维护ToolStripMenuItem.Name = "人员维护ToolStripMenuItem";
            this.人员维护ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.人员维护ToolStripMenuItem.Text = "人员维护";
            this.人员维护ToolStripMenuItem.Click += new System.EventHandler(this.人员维护ToolStripMenuItem_Click);
            // 
            // 车辆管理ToolStripMenuItem
            // 
            this.车辆管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.车辆添加ToolStripMenuItem,
            this.车辆删除ToolStripMenuItem,
            this.车辆维护ToolStripMenuItem});
            this.车辆管理ToolStripMenuItem.Name = "车辆管理ToolStripMenuItem";
            this.车辆管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.车辆管理ToolStripMenuItem.Text = "车辆管理";
            // 
            // 车辆添加ToolStripMenuItem
            // 
            this.车辆添加ToolStripMenuItem.Name = "车辆添加ToolStripMenuItem";
            this.车辆添加ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.车辆添加ToolStripMenuItem.Text = "车辆添加";
            // 
            // 车辆删除ToolStripMenuItem
            // 
            this.车辆删除ToolStripMenuItem.Name = "车辆删除ToolStripMenuItem";
            this.车辆删除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.车辆删除ToolStripMenuItem.Text = "车辆删除";
            // 
            // 车辆维护ToolStripMenuItem
            // 
            this.车辆维护ToolStripMenuItem.Name = "车辆维护ToolStripMenuItem";
            this.车辆维护ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.车辆维护ToolStripMenuItem.Text = "车辆维护";
            // 
            // 管理员ToolStripMenuItem
            // 
            this.管理员ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理员添加ToolStripMenuItem,
            this.管理员删除ToolStripMenuItem,
            this.管理员维护ToolStripMenuItem});
            this.管理员ToolStripMenuItem.Name = "管理员ToolStripMenuItem";
            this.管理员ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.管理员ToolStripMenuItem.Text = "管理员";
            // 
            // 管理员添加ToolStripMenuItem
            // 
            this.管理员添加ToolStripMenuItem.Name = "管理员添加ToolStripMenuItem";
            this.管理员添加ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.管理员添加ToolStripMenuItem.Text = "管理员添加";
            this.管理员添加ToolStripMenuItem.Click += new System.EventHandler(this.管理员添加ToolStripMenuItem_Click);
            // 
            // 管理员删除ToolStripMenuItem
            // 
            this.管理员删除ToolStripMenuItem.Name = "管理员删除ToolStripMenuItem";
            this.管理员删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.管理员删除ToolStripMenuItem.Text = "管理员删除";
            this.管理员删除ToolStripMenuItem.Click += new System.EventHandler(this.管理员删除ToolStripMenuItem_Click);
            // 
            // 管理员维护ToolStripMenuItem
            // 
            this.管理员维护ToolStripMenuItem.Name = "管理员维护ToolStripMenuItem";
            this.管理员维护ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.管理员维护ToolStripMenuItem.Text = "管理员维护";
            this.管理员维护ToolStripMenuItem.Click += new System.EventHandler(this.管理员维护ToolStripMenuItem_Click);
            // 
            // PUTMARK
            // 
            this.PUTMARK.Location = new System.Drawing.Point(838, 453);
            this.PUTMARK.Name = "PUTMARK";
            this.PUTMARK.Size = new System.Drawing.Size(80, 26);
            this.PUTMARK.TabIndex = 68;
            this.PUTMARK.Text = "标记";
            this.PUTMARK.UseVisualStyleBackColor = true;
            this.PUTMARK.Click += new System.EventHandler(this.PUTMARK_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(838, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 26);
            this.button3.TabIndex = 67;
            this.button3.Text = "button2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(934, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 31);
            this.button1.TabIndex = 66;
            this.button1.Text = "GO TO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LngCurrent
            // 
            this.LngCurrent.Location = new System.Drawing.Point(894, 424);
            this.LngCurrent.Name = "LngCurrent";
            this.LngCurrent.Size = new System.Drawing.Size(122, 21);
            this.LngCurrent.TabIndex = 65;
            // 
            // LatCurrent
            // 
            this.LatCurrent.Location = new System.Drawing.Point(894, 397);
            this.LatCurrent.Name = "LatCurrent";
            this.LatCurrent.Size = new System.Drawing.Size(122, 21);
            this.LatCurrent.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(816, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 63;
            this.label3.Text = "瞄点纬度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(816, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 62;
            this.label2.Text = "瞄点经度";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 791);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinTabControl1);
            this.Controls.Add(this.skinMenuStrip1);
            this.MainMenuStrip = this.skinMenuStrip1;
            this.MaximumSize = new System.Drawing.Size(1330, 791);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.skinTabControl1.ResumeLayout(false);
            this.skinTabPage1.ResumeLayout(false);
            this.skinTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZOOM)).EndInit();
            this.skinTabPage2.ResumeLayout(false);
            this.skinTabPage2.PerformLayout();
            this.skinTabPage4.ResumeLayout(false);
            this.skinTabPage4.PerformLayout();
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl MainMap1;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lablel12;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private System.Windows.Forms.Button SAND_ALL;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckedListBox XiangMuList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox cbin_show;
        private System.Windows.Forms.CheckBox hex_show;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private CCWin.SkinControl.SkinTabPage skinTabPage3;
        private CCWin.SkinControl.SkinTabPage skinTabPage4;
        private System.Windows.Forms.Button btnComOpen;
        private System.Windows.Forms.ComboBox cbComList;
        private System.Windows.Forms.ComboBox cbBaudRateList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Box_maplist;
        private CCWin.SkinControl.SkinTrackBar trackBarZOOM;
        private CCWin.SkinControl.SkinLabel TextBOXZOOM;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private System.Windows.Forms.Timer reflash_time;
        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员维护ToolStripMenuItem;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private System.Windows.Forms.Button PUTMARK;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LngCurrent;
        private System.Windows.Forms.TextBox LatCurrent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}