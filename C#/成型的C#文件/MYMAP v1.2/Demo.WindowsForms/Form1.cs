using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Demo.WindowsForms.CustomMarkers;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Reflection;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;
using CCWin;
using Demo.WindowsForms;

namespace Demo.WindowsForms.Forms
{
    public partial class Form1 : CCSkinMain
    {

        //串口变量初始化
        #region -- 串口变量 --
        private SerialPort comm = new SerialPort();
        private StringBuilder builder = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面。  
        private bool Listening = false;                     //是否没有执行完invoke相关操作
        private bool Closing_new = false;                   //是否正在关闭串口，执行Application.DoEvents，并阻止再次invoke
        private long received_count = 0;                    //接收计数  
        private long send_count = 0;                        //发送计数 
                                        
        byte[] print_data = new byte[257];        //serial接收数据相关
        int[] tmp = new int[50];

        byte Recive_State = 0;    //串口接收状态
        #endregion


        #region -- GMAP变量 --
        readonly GMapOverlay top = new GMapOverlay();
        internal readonly GMapOverlay objects = new GMapOverlay("objects");
        internal readonly GMapOverlay routes = new GMapOverlay("routes");
        internal readonly GMapOverlay polygons = new GMapOverlay("polygons");
        byte numcount = 0;
        double[] Lat_posion = new double[60];
        double[] Lng_posion = new double[60];

        GMapMarker currentMarker; // marker 标记
        GMapPolygon polygon;   // polygons  多边形
        GMapMarker currentTransport;
        #endregion

        SpeechSynthesizer SPEAK = null;

        UserChange userchange = new UserChange();
        Useradd useradd = new Useradd();
        Userdel userdel = new Userdel();

        double LAT_ERROR = 0;
        double LNG_ERROR = 0;      
        double Longitude_GPS; //当前精度
        double Latitude_GPS;
        float End_Point_Longitude;
        float End_Point_Latitude;
        UInt16 Nav_State;
        UInt16 Now_TARG_num;
        UInt16 Targ_point_num;

        /*****************************全局登录变量*******************************/
        public string Sigin_name="public     ";
        public bool Sigin_state = false;
        public int Sigin_level = 0;
        /***********************************************************************/


        public Form1()
        {
            InitializeComponent();


            #region //地图显示
            if (!GMapControl.IsDesignerHosted)
            {

                // set cache mode only if no internet avaible  检查一下是不是有网络连接
                if (!Stuff.PingNetwork("pingtest.com"))
                {
                    MainMap1.Manager.Mode = AccessMode.ServerAndCache;                   //使用模式 网络和离线
                                                                                         // MessageBox.Show("网络连接不可用, 正在使用离线模式", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // SPEAK.Speak("Network connection is available, use networking mode please wait for the program response");
                    //  SPEAK.Speak("网络连接可用, 正在使用联网模式 请等待程序响应");
                }

                // 地图设计        
                MainMap1.MapProvider = GMapProviders.OpenCycleMap;                      //地图供应商  google  
                MainMap1.Position = new PointLatLng(39.1311920962395, 117.352695465088);  //新建一个地图位置  中国民航大学的位置
                LatCurrent.Text = MainMap1.Position.Lat.ToString(CultureInfo.InvariantCulture);// 初始化当前点的坐标
                LngCurrent.Text = MainMap1.Position.Lng.ToString(CultureInfo.InvariantCulture);// 初始化当前点的坐标

                MainMap1.MinZoom = 1; MainMap1.MaxZoom = 18; MainMap1.Zoom = 14;  //初始化地图的放大系数
                trackBarZOOM.Value = (int)(MainMap1.Zoom); // get zoom  
                trackBarZOOM.Minimum = MainMap1.MinZoom;
                trackBarZOOM.Maximum = MainMap1.MaxZoom;
                TextBOXZOOM.Text = (MainMap1.Zoom - 14).ToString();   //lable坐标显示

                Box_maplist.ValueMember = "Name"; Box_maplist.DataSource = GMapProviders.List; //地图列表项目初始化
                Box_maplist.SelectedItem = MainMap1.MapProvider;                              //地图列表项目初始化

                //注册事件
                MainMap1.OnMapZoomChanged += new MapZoomChanged(MainMap_OnMapZoomChanged);      //地图滚轮放大事件
                MainMap1.OnPositionChanged += new PositionChanged(MainMap_OnPositionChanged);  //拖动地图事件
                MainMap1.OnMarkerClick += new MarkerClick(MainMap_OnMarkerClick);
                MainMap1.MouseDoubleClick += new MouseEventHandler(MainMap_MouseDoubleClick);
                routes.Routes.CollectionChanged += new GMap.NET.ObjectModel.NotifyCollectionChangedEventHandler(Routes_CollectionChanged);
                objects.Markers.CollectionChanged += new GMap.NET.ObjectModel.NotifyCollectionChangedEventHandler(Markers_CollectionChanged);


                MainMap1.Overlays.Add(routes);   // 叠加地图图层 add custom layers  
                MainMap1.Overlays.Add(polygons);
                MainMap1.Overlays.Add(objects);
                MainMap1.Overlays.Add(top);

            }
            #endregion


            // SPEAK_OUT.
            //   SPEAK_OUT.Start("HELLO!!");
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            this.DoubleBuffered = true;                              //使用双缓冲                         
            this.WindowState = FormWindowState.Normal;            //最大化
            cbBaudRateList.SelectedItem = cbBaudRateList.Items[6];   //波特率初始化
           // cbComList.SelectedItem = cbComList.Items[0];   //波特率初始化

            string[] ports = SerialPort.GetPortNames(); //读取现在能用的串口
            Array.Sort(ports);
            cbComList.Items.AddRange(ports);
            cbComList.SelectedIndex = cbComList.Items.Count > 0 ? 0 : -1;
            hex_show.Checked = true;  //十六进制显示
            //初始化SerialPort对象  
            comm.NewLine = "/r/n";
            comm.RtsEnable = false;//reset功能
            cbComList.Enabled = true;
            cbBaudRateList.Enabled = true;
            comm.DataReceived += comm_DataReceived;//添加事件注册


            this.CenterToParent();                 //居中显示
            dangqianweizhi();
        }






        public static void Voice_prompt(object data)
        {
            //Console.WriteLine("不带参数的线程函数");
            SpeechSynthesizer SPEAK1 = null;
            SPEAK1 = new SpeechSynthesizer();
            string datastr = data as string;
            SPEAK1.Speak( datastr);
        }
        #region -- 事件 --
        void MainMap_OnPositionChanged(PointLatLng point)
        {
           LatCurrent.Text = point.Lat.ToString(CultureInfo.InvariantCulture);
           LngCurrent.Text = point.Lng.ToString(CultureInfo.InvariantCulture);

        }
        // MapZoomChanged
        void MainMap_OnMapZoomChanged()
        {

            trackBarZOOM.Value = (int)(MainMap1.Zoom );
                TextBOXZOOM.Text = (MainMap1.Zoom-14).ToString();
            
        }


        // click on some marker  我现在不知道这些功能
        void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (item is GMapMarkerRect)
                {
                    GeoCoderStatusCode status;
                    var pos = GMapProviders.GoogleMap.GetPlacemark(item.Position, out status);
                    if (status == GeoCoderStatusCode.G_GEO_SUCCESS && pos != null)
                    {
                        GMapMarkerRect v = item as GMapMarkerRect;
                        {
                            v.ToolTipText = pos.Value.Address;
                        }
                        MainMap1.Invalidate(false);
                    }
                }
                else
                {
                    if (item.Tag != null)
                    {
                        if (currentTransport != null)
                        {
                            currentTransport.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                            currentTransport = null;
                        }
                        currentTransport = item;
                        currentTransport.ToolTipMode = MarkerTooltipMode.Always;
                    }
                }
            }
        }

        void dangqianweizhi()
        {
            checkedListBox1.Items.Add("洒水车1  " + "当前点：A33"+"目标点：无" + "  编号：0001" );
            checkedListBox1.Items.Add("除冰车1  " + "当前点：A03" + "目标点：A0" + "  编号：0002");
            checkedListBox1.Items.Add("洒水车1  " + "当前点：B06" + "目标点：A3" + "  编号：0003");
        }
        // add demo circle
        void MainMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            /* var cc = new GMapMarkerCircle(MainMap1.FromLocalToLatLng(e.X, e.Y));
             objects.Markers.Add(cc);*/

            // set current marker
            currentMarker = new GMarkerGoogle(MainMap1.FromLocalToLatLng(e.X, e.Y), GMarkerGoogleType.arrow);

       

            Lat_posion[numcount] = currentMarker.Position.Lat;  //向数组添加目标点
            Lng_posion[numcount] = currentMarker.Position.Lng;

            PointLatLng p = new PointLatLng();
            PointLatLng p_last = new PointLatLng();

            if (numcount > 0)
            {
                


                p.Lat = Lat_posion[numcount];
                p.Lng = Lng_posion[numcount];

                p_last.Lat = Lat_posion[numcount - 1];
                p_last.Lng = Lng_posion[numcount - 1];

               DrawLineBetweenTwoPoint(p, p_last);

            }
            numcount++;

            //currentMarker.ToolTipText = numcount.ToString();
            //currentMarker.ToolTipMode = MarkerTooltipMode.Always;
            //top.Markers.Add(currentMarker);


            currentMarker = new GMarkerGoogle(p, GMarkerGoogleType.red_small);
            currentMarker.IsHitTestVisible = false;
            top.Markers.Add(currentMarker);


            XiangMuList.Items.Add("第"+ numcount.ToString()+"目标点"+"   J:"+ currentMarker.Position.Lat.ToString()+"   W:"+currentMarker.Position.Lng.ToString());


          
        }
    
        void Markers_CollectionChanged(object sender, GMap.NET.ObjectModel.NotifyCollectionChangedEventArgs e)
        {
            //textBoxMarkerCount.Text = objects.Markers.Count.ToString();
        }

        void Routes_CollectionChanged(object sender, GMap.NET.ObjectModel.NotifyCollectionChangedEventArgs e)
        {
            //textBoxrouteCount.Text = routes.Routes.Count.ToString();
        }
        private void TextBOXZOOM_TextChanged(object sender, EventArgs e)
        {
           
        }

       

        // 根据点找地图
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double lat = double.Parse(LatCurrent.Text, CultureInfo.InvariantCulture);
                double lng = double.Parse(LngCurrent.Text, CultureInfo.InvariantCulture);

                MainMap1.Position = new PointLatLng(lat, lng);
                MessageBox.Show("OK" );
            }
            catch (Exception ex)
            {
                MessageBox.Show("incorrect coordinate format: " + ex.Message);
            }
        }




       


        //画出两点直接的直线
        private void DrawLineBetweenTwoPoint(PointLatLng pointLatLng_S, PointLatLng pointLatLng_E)

        {

            List<PointLatLng> points = new List<PointLatLng>();

            points.Add(pointLatLng_S);

            points.Add(pointLatLng_E);

            GMapRoute r = new GMapRoute(points, "");

            r.Stroke = new Pen(Color.Green, 3);

            top.Routes.Add(r);

        }

        void RegeneratePolygon()
        {
            List<PointLatLng> polygonPoints = new List<PointLatLng>();

            foreach (GMapMarker m in objects.Markers)
            {
                if (m is GMapMarkerRect)
                {
                    m.Tag = polygonPoints.Count;
                    polygonPoints.Add(m.Position);
                }
            }

            if (polygon == null)
            {
                polygon = new GMapPolygon(polygonPoints, "polygon test");
                polygon.IsHitTestVisible = true;
                polygons.Polygons.Add(polygon);
            }
            else
            {
                polygon.Points.Clear();
                polygon.Points.AddRange(polygonPoints);

                if (polygons.Polygons.Count == 0)
                {
                    polygons.Polygons.Add(polygon);
                }
                else
                {
                    MainMap1.UpdatePolygonLocalPosition(polygon);
                }
            }
        }

        // add marker on current position
        private void button2_Click(object sender, EventArgs e)
        {
            GMarkerGoogle m = new GMarkerGoogle(currentMarker.Position, GMarkerGoogleType.green_pushpin);
            GMapMarkerRect mBorders = new GMapMarkerRect(currentMarker.Position);
            {
                mBorders.InnerMarker = m;
                if (polygon != null)
                {
                    mBorders.Tag = polygon.Points.Count;
                }
                mBorders.ToolTipMode = MarkerTooltipMode.Always;
            }

            Placemark? p = null;
            if (true)//checkBoxPlacemarkInfo.Checked
            {
                GeoCoderStatusCode status;
                var ret = GMapProviders.GoogleMap.GetPlacemark(currentMarker.Position, out status);
                if (status == GeoCoderStatusCode.G_GEO_SUCCESS && ret != null)
                {
                    p = ret;
                }
            }

            if (p != null)
            {
                mBorders.ToolTipText = p.Value.Address;
            }
            else
            {
                mBorders.ToolTipText = currentMarker.Position.ToString();
            }

            objects.Markers.Add(m);
            objects.Markers.Add(mBorders);

            RegeneratePolygon();
        }

        private void PUTMARK_Click(object sender, EventArgs e)
        {
            // set current marker
            currentMarker = new GMarkerGoogle(MainMap1.Position, GMarkerGoogleType.arrow);
            currentMarker.IsHitTestVisible = false;
            top.Markers.Add(currentMarker); 

        }
        #endregion

        /// <summary>
        /// 单击了项目清单里的某一项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XiangMuList_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("asdasd");
        }
        /// <summary>
        /// 单机编辑相按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>




        void mark()
        {
            PointLatLng p = new PointLatLng();
            if (Latitude_GPS != 0 && Longitude_GPS != 0)
            {
                p.Lat = Latitude_GPS;
                p.Lng = Longitude_GPS;

                currentMarker = new GMarkerGoogle(p, GMarkerGoogleType.red_small);
                currentMarker.IsHitTestVisible = false;
                top.Markers.Add(currentMarker);
            }

        }

        /******************************** serial 函数*********************************/
        /// <summary>
        /// 串口接收函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// //FE 0F A0 A0 03 01 00 00 00 00 00 00 00 00 00 00 00 FF          FE 10 A1 A1 03 01 00 00 00 00 00 00 00 00 00 00 00 00 FF 

        byte Zhenchangdu = 0;
        byte Yuanduankou = 0;
        byte Mudiduankou = 0;
        byte[] Yuandizhi= new byte[2];
        byte[] Latitude_str= new byte[11];
        byte[] longitude_str = new byte[12];

        string a;
        string b;
        void comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (Closing_new == true)
                return;
            try
            {
                Listening = true;////设置标记，说明我已经开始处理数据，   一会儿要使用系统UI的。
                int n = comm.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致   
                ///声明一个临时数组存储当前来的串口数据
                byte[] Received_bytes = new byte[n];
                byte[,] image = new byte[60, 80];


                comm.Read(Received_bytes, 0, n);//读取缓冲数据 
                received_count += n;//增加接收计数  
                if (received_count > 10000)
                {
                    this.Invoke((EventHandler)(delegate//因为要访问ui资源，所以需要使用invoke方式同步ui。  
                    {
                        cbin_show.Clear();
                    }));
                    received_count = 0;  //超过一定得值重新计数
                }
                builder.Clear();//清除字符串构造器的内容  
                this.Invoke((EventHandler)(delegate//因为要访问ui资源，所以需要使用invoke方式同步ui。  
                {
                    if (hex_show.Checked)//判断是否是显示为16禁止  
                        {
                        foreach (byte b in Received_bytes) //依次的拼接出16进制字符串  
                                builder.Append(b.ToString("X2") + " ");
                    }
                    else
                        builder.Append(Encoding.GetEncoding("GB2312").GetString(Received_bytes));//已经可以支持中文

                        this.cbin_show.AppendText(builder.ToString());//追加的形式添加到文本框末端，并滚动到最后。  
                        label3.Text = "已接收:" + received_count.ToString();//修改接收计数  
                    }));

                
                #region  //上位机数据采集
                for (int i = 0; i < n; i++)
                {
                    if (Recive_State == 7)
                    {
                        
                        this.Invoke((EventHandler)(delegate
                        {

                            a = Encoding.GetEncoding("GB2312").GetString(Latitude_str);
                            b = Encoding.GetEncoding("GB2312").GetString(longitude_str);
                            label5.Text = "Latitude_GPS:   " + a; 
                            label6.Text = "Longitude_GPS:  " + b;

                            try
                            {
                                double f1 = Convert.ToDouble(a); Latitude_GPS = f1/100.0;
                                double f2 = Convert.ToDouble(b); Longitude_GPS = f2/100.0;
                                label7.Text = "End_Point_Longitude: " + f1.ToString();
                                label8.Text = "End_Point_Latitude: " + f2.ToString();

                                
                            }
                            catch { }

                            PointLatLng p = new PointLatLng();
                            if (Latitude_GPS != 0 && Longitude_GPS != 0)
                            {
                                p.Lat = Latitude_GPS;
                                p.Lng = Longitude_GPS;

                                currentMarker = new GMarkerGoogle(p, GMarkerGoogleType.red_small);
                                currentMarker.IsHitTestVisible = false;
                                top.Markers.Add(currentMarker);
                            }



                        }));

                        
                        #endregion
                        Recive_State = 0;


                    }
                    if (Received_bytes[i] == 0xFE) Recive_State = 1;
                    else if (Recive_State == 1) { Zhenchangdu = Received_bytes[i]; Recive_State = 2; }
                    else if (Recive_State == 2) { Yuanduankou = Received_bytes[i]; Recive_State = 3; }
                    else if (Recive_State == 3 ) { Mudiduankou = Received_bytes[i]; Recive_State = 4; }
                    else if (Recive_State == 4) { Yuandizhi[0] = Received_bytes[i]; Recive_State = 5; }
                    else if (Recive_State == 5) { Yuandizhi[1] = Received_bytes[i]; Recive_State = 6; }
                    else if (Recive_State == 6)
                    {
                        try
                        {
                            switch (Mudiduankou)
                            {
                                case 0xA0:
                                    {
                                    
                                            Array.Copy(Received_bytes, i, Latitude_str, 0, 11);
                                    }
                                    break;
                                case 0xA1:
                                    {
                                   
                                            Array.Copy(Received_bytes, i, longitude_str, 0, 11);
                                    }
                                    break;
                           }
                        }
                        catch { }
                        Recive_State = 7;
                    }
                    
                }
            }
            finally
            {
                Listening = false;//我用完了，ui可以关闭串口了。
            }
        }
        /// <summary>
        /// 打开和关闭串口操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComOpen_Click(object sender, EventArgs e)
        {
            //根据当前串口对象，来判断操作  
            if (comm.IsOpen)
            {
                  Closing_new = true;
                while (Listening) Application.DoEvents();
                   comm.Close();//打开时点击，则关闭串口  
            }
            else
            {
                //没有串口的情况下
                if (cbComList.Text == "")
                {
                    MessageBox.Show("大哥，看看有没有串口啊!!!");
                    return;
                }
             
                //打开串口
                Closing_new = false;
                comm.PortName = cbComList.Text;
                comm.BaudRate = int.Parse(cbBaudRateList.Text);
                try
                {
                    comm.Open();
                }
                catch (Exception ex)
                {
                    comm = new SerialPort();//捕获到异常信息，创建一个新的comm对象，之前的不能用了。 
                    MessageBox.Show(ex.Message);//现实异常信息给客户。 
                }
            }

            string[] ports = SerialPort.GetPortNames(); //读取现在能用的串口
            Array.Sort(ports);
            cbComList.Items.Clear();
            cbComList.Refresh();
            cbComList.Items.AddRange(ports);
            cbComList.SelectedIndex = cbComList.Items.Count > 0 ? 0 : -1;

            btnComOpen.Text = comm.IsOpen ? "关闭端口" : "打开端口"; //设置按钮的状态  
            cbComList.Enabled = !comm.IsOpen;
            cbBaudRateList.Enabled = !comm.IsOpen;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //定义一个变量，记录发送了几个字节 
            if (!comm.IsOpen)
                return;
            int n = 0;
            //16进制发送  
            if (checkBox2.Checked)
            {
                n = Sand_hex();
            }
            else//ascii编码直接发送  
            {
                n = Sand_ASCII();
            }
            send_count += n;//累加发送字节数  
            label4.Text = "已发送:" + send_count.ToString();//更新界面  
        }

        /// <summary>
        /// 进行一次十六进制发送
        /// </summary>
        private int Sand_hex()
        {
            //我们不管规则了。如果写错了一些，我们允许的，只用正则得到有效的十六进制数  
            MatchCollection mc = Regex.Matches(richTextBox2.Text, @"(?i)[/da-f]{2}");
            List<byte> buf = new List<byte>();//填充到这个临时列表中  
                                              //依次添加到列表中  
            foreach (Match m in mc)
            {
                buf.Add(byte.Parse(m.Value));
            }
            //转换列表为数组后发送  
            comm.Write(buf.ToArray(), 0, buf.Count);
            //记录发送的字节数  
            return buf.Count;

        }
        /// <summary>
        /// 进行一次ASCII码发送
        /// </summary>
        /// <returns></returns>
        private int Sand_ASCII()
        {
            int n = 0;
            //包含换行符  
            if (checkBox1.Checked)
            {
                comm.Write(richTextBox2.Text + System.Environment.NewLine);
                n = richTextBox2.Text.Length + 2;
            }
            else//不包含换行符  
            {
                string a = richTextBox2.Text;
                string s = richTextBox2.Text;
                n = richTextBox2.Text.Length;
                if (a[n - 1] == '\n')
                    s = a.Substring(0, n - 1) + "\r\n";
                n = n + 1;
                comm.Write(s);
            }
            return n;
        }
        /******************************** serial 函数*********************************/

        int mark_data = 0;  //被选中的数据
        /// <summary>
        /// 对列表数据进行检查，不正常时进行提示
        /// </summary>
        /// <returns></returns>
        private Byte Check_data()
        {
            Byte check_right = 0;
            
            byte mark_error = 0;
            if (numcount < 2)  //判断一下数据是不是合适
            {
                if (numcount == 0)
                { MessageBox.Show("列表中没有数据项"); mark_error = 1; }
                else
                    if (mark_data == 0)
                { MessageBox.Show("列表中的数据项只有一向"); mark_error = 1; }

            }
            else
                for (Byte i = 0; i < numcount; i++)
                    if (XiangMuList.GetItemChecked(i))
                    {
                        if (check_right == 0)
                        {
                            check_right = 1;
                            mark_data = i;
                        }
                        else
                        {
                            MessageBox.Show("不能同时选中多项");
                            mark_error = 1;
                            check_right = 0;
                            mark_data = 0;
                        }
                    }

            if (check_right == 1)
            {
                MessageBox.Show("选中了第" + mark_data.ToString() + "项");
            }
            else
            if (mark_error == 0)
            {
                MessageBox.Show("没有选中的项目");
                mark_error = 1;
            }

            return mark_error;


        }
        /// <summary>
        /// 上移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            double lat_buff = 0;
            double lng_buff = 0;
            int con_buff = 0;
            if (Check_data() == 0)
            {
                if (mark_data == 0)
                {
                    MessageBox.Show("已经是第一个啦");
                }
                else
                {
                    lat_buff = Lat_posion[mark_data-1];
                    lng_buff = Lng_posion[mark_data-1];

                    Lat_posion[mark_data - 1] = Lat_posion[mark_data];
                    Lng_posion[mark_data - 1] = Lng_posion[mark_data];

                    Lat_posion[mark_data] = lat_buff;
                    Lng_posion[mark_data] = lng_buff;

                }
            }
            con_buff = XiangMuList.Items.Count;
            for (int i = XiangMuList.Items.Count - 1; i > -1; i--)
                XiangMuList.Items.RemoveAt(i);




            top.Markers.Clear();
            top.Routes.Clear();
            PointLatLng p = new PointLatLng();
            PointLatLng p_last = new PointLatLng();
            numcount = 0;
            for (int i = 0; i < con_buff; i++)
            {
                p.Lat = Lat_posion[i];
                p.Lng = Lng_posion[i];



                currentMarker = new GMarkerGoogle(p, GMarkerGoogleType.arrow);
                currentMarker.ToolTipText = (i+1).ToString();
                currentMarker.ToolTipMode = MarkerTooltipMode.Always;
                //currentMarker.IsHitTestVisible = false;
                top.Markers.Add(currentMarker);

                numcount++;
                if (i > 0)
                {
                    p_last.Lat = Lat_posion[i - 1];
                    p_last.Lng = Lng_posion[i - 1];
                    DrawLineBetweenTwoPoint(p, p_last);
                }
                XiangMuList.Items.Add("第" + numcount.ToString() + "目标点" + "   J:" + currentMarker.Position.Lat.ToString() + "   W:" + currentMarker.Position.Lng.ToString());
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            double lat_buff = 0;
            double lng_buff = 0;
            int con_buff = 0;
            if (Check_data() == 0)
            {
                if (mark_data == numcount-1)
                {
                    MessageBox.Show("已经是第一个啦");
                }
                else
                {
                    lat_buff = Lat_posion[mark_data + 1];
                    lng_buff = Lng_posion[mark_data + 1];

                    Lat_posion[mark_data + 1] = Lat_posion[mark_data];
                    Lng_posion[mark_data + 1] = Lng_posion[mark_data];

                    Lat_posion[mark_data] = lat_buff;
                    Lng_posion[mark_data] = lng_buff;

                }
            }
            con_buff = XiangMuList.Items.Count;
            for (int i = XiangMuList.Items.Count - 1; i > -1; i--)
                XiangMuList.Items.RemoveAt(i);




            top.Markers.Clear();
            top.Routes.Clear();
            PointLatLng p = new PointLatLng();
            PointLatLng p_last = new PointLatLng();
            numcount = 0;
            for (int i = 0; i < con_buff; i++)
            {
                p.Lat = Lat_posion[i];
                p.Lng = Lng_posion[i];



                currentMarker = new GMarkerGoogle(p, GMarkerGoogleType.arrow);
                currentMarker.ToolTipText = (i + 1).ToString();
                currentMarker.ToolTipMode = MarkerTooltipMode.Always;
                //currentMarker.IsHitTestVisible = false;
                top.Markers.Add(currentMarker);

                numcount++;
                if (i > 0)
                {
                    p_last.Lat = Lat_posion[i - 1];
                    p_last.Lng = Lng_posion[i - 1];
                    DrawLineBetweenTwoPoint(p, p_last);
                }
                XiangMuList.Items.Add("第" + numcount.ToString() + "目标点" + "   J:" + currentMarker.Position.Lat.ToString() + "   W:" + currentMarker.Position.Lng.ToString());
            }

        }

        /// <summary>
        /// 删除选中项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {

            if (Check_data() == 0)
            {
                for (int i = XiangMuList.Items.Count - 1; i > -1; i--)
                {
                    if (XiangMuList.GetItemChecked(i))
                    {
                        XiangMuList.Items.RemoveAt(i);
                        Lat_posion[i] = 9999;//清除的变量暂时标记一下
                        Lng_posion[i] = 9999;
                    }
                }

                Byte counta = 0;
                Byte con_aa = 0;
                for (int i = 0; i <= XiangMuList.Items.Count + 2; i++)
                {
                    if (Lat_posion[i] != 9999 && Lng_posion[i] != 9999)
                    {
                        Lat_posion[counta] = Lat_posion[i];
                        Lng_posion[counta] = Lng_posion[i];
                        counta++;
                    }

                }
                for (int i = 0; i < counta + 3; i++)
                {
                    if (Lat_posion[i] != 0)
                        con_aa++;
                }

                for (int i = XiangMuList.Items.Count - 1; i > -1; i--)
                    XiangMuList.Items.RemoveAt(i);





                numcount = 0;
                top.Markers.Clear();
                top.Routes.Clear();
                PointLatLng p = new PointLatLng();
                PointLatLng p_last = new PointLatLng();
                for (int i = 0; i < con_aa; i++)
                {
                    p.Lat = Lat_posion[i];
                    p.Lng = Lng_posion[i];



                    currentMarker = new GMarkerGoogle(p, GMarkerGoogleType.arrow);
                    currentMarker.ToolTipText = (i + 1).ToString();
                    currentMarker.ToolTipMode = MarkerTooltipMode.Always;
                    //currentMarker.IsHitTestVisible = false;
                    top.Markers.Add(currentMarker);

                    numcount++;
                    if (i > 0)
                    {
                        p_last.Lat = Lat_posion[i - 1];
                        p_last.Lng = Lng_posion[i - 1];
                        DrawLineBetweenTwoPoint(p, p_last);
                    }
                    XiangMuList.Items.Add("第" + numcount.ToString() + "目标点" + "   J:" + currentMarker.Position.Lat.ToString() + "   W:" + currentMarker.Position.Lng.ToString());
                }
            }
        }

        byte[] write_buff = new byte[128];

        private void SAND_ALL_Click(object sender, EventArgs e)
        {

            if (!comm.IsOpen)
            {
                MessageBox.Show("先打开串口");
                return; }

            int _cnt = 0;
            UInt16 I_temp;
            float F_temp;


            write_buff[_cnt++] = 0xFE;
            write_buff[_cnt++] = numcount;

            byte[] bb = BitConverter.GetBytes(0.0f);

            for (int i = 0; i < numcount; i++)
            {
               
                F_temp = (float)Lat_posion[i];

                bb = BitConverter.GetBytes(F_temp);
                write_buff[_cnt++] = bb[3];
                write_buff[_cnt++] = bb[2];
                write_buff[_cnt++] = bb[1];
                write_buff[_cnt++] = bb[0];
                //Longitude_GPS = BitConverter.ToSingle(bb, 0);
                F_temp = (float)Lng_posion[i];
                bb = BitConverter.GetBytes(F_temp);
                write_buff[_cnt++] = bb[3];
                write_buff[_cnt++] = bb[2];
                write_buff[_cnt++] = bb[1];
                write_buff[_cnt++] = bb[0];

                
            }
            write_buff[_cnt++] = 0xFF;
            comm.Write(write_buff, 0, _cnt);
            
        }

        private void trackBarZOOM_Scroll_1(object sender, EventArgs e)
        {
            MainMap1.Zoom = trackBarZOOM.Value;
        }



        public void all_reflash()
        {
            skinLabel2.Text = Sigin_name;                   //刷新登录名
            skinLabel4.Text = Sigin_level.ToString();       //刷新登录等级 
        }

        private void reflash_time_Tick(object sender, EventArgs e)
        {
            all_reflash();
        }

        private void 人员维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

         private void 管理员维护ToolStripMenuItem_Click(object sender, EventArgs e)
         {
            
            userchange.Show();
            userchange.BringToFront();       
         }

        private void 管理员添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            useradd.Show();
            useradd.BringToFront();
        }

        private void 管理员删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            userdel.Show();
            userdel.BringToFront();
        }

        private void skinTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void PUTMARK_Click_1(object sender, EventArgs e)
        {
            ///* var cc = new GMapMarkerCircle(MainMap1.FromLocalToLatLng(e.X, e.Y));
            //           objects.Markers.Add(cc);*/

            //// set current marker

            //try
            //{
            //    double lat = double.Parse(LatCurrent.Text, CultureInfo.InvariantCulture);
            //    double lng = double.Parse(LngCurrent.Text, CultureInfo.InvariantCulture);

            //    MainMap1.Position = new PointLatLng(lat, lng);
            //    MessageBox.Show("OK");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("incorrect coordinate format: " + ex.Message);
            //}


            //currentMarker = new GMarkerGoogle(MainMap1.FromLocalToLatLng(e.X, e.Y), GMarkerGoogleType.arrow);



            //Lat_posion[numcount] = currentMarker.Position.Lat;  //向数组添加目标点
            //Lng_posion[numcount] = currentMarker.Position.Lng;

            //PointLatLng p = new PointLatLng();
            //PointLatLng p_last = new PointLatLng();

            //if (numcount > 0)
            //{



            //    p.Lat = Lat_posion[numcount];
            //    p.Lng = Lng_posion[numcount];

            //    p_last.Lat = Lat_posion[numcount - 1];
            //    p_last.Lng = Lng_posion[numcount - 1];

            //    //  DrawLineBetweenTwoPoint(p, p_last);

            //}
            //numcount++;

            ////currentMarker.ToolTipText = numcount.ToString();
            //////currentMarker.ToolTipMode = MarkerTooltipMode.Always;
            //////top.Markers.Add(currentMarker);


            //currentMarker = new GMarkerGoogle(p, GMarkerGoogleType.red_small);
            //currentMarker.IsHitTestVisible = false;
            //top.Markers.Add(currentMarker);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
