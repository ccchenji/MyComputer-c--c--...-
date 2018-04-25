using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Threading.Tasks;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.IO;

using System.Media;
namespace 控制软件
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private SerialPort compost = new SerialPort();                    //定义端口
        private StringBuilder builderp = new StringBuilder();


        public SerialPort comrecv = new SerialPort();            //定义新的串口
        private StringBuilder builderr = new StringBuilder(); //C#中的一个类，一个可变的字符序列，类似StringBuffer  避免在事件处理方法中反复的创建，定义到外面。
       
        static string comNamepost = "";              //写配置文件所需全局变量
        static string comNamepost1 = "";
        static string comNamerecv = "";
        static string comNamerecv1 = "";

        private void test_Load(object sender, EventArgs e)
        {
            /////////////////////////发送端口
            string[] portsp = SerialPort.GetPortNames();        //获得端口号
            Array.Sort(portsp);

            ComGiv.Items.AddRange(portsp);           //加载端口号
            // comboPortName.SelectedIndex = comboPortName.Items.Count > 0 ? 0 : -1;     //默认端口号       
            BaudGiv.SelectedIndex = BaudGiv.Items.IndexOf("38400");              //默认波特率38400

            compost.NewLine = "\r\n";
           // compost.DataReceived += compost_DataReceived;  //接收函数与系统串口类的接口，不可屏蔽

            ////////////////////////////////////////接收端口
            string[] portsr = SerialPort.GetPortNames();  //定义数组，存储串口名称
            Array.Sort(portsr);                           //串口名称排序

            ComGet.Items.AddRange(portsr);        //加载端口号
            // DatCom.SelectedIndex = DatCom.Items.Count > 0 ? 0 : -1;        //默认端口号 
            BaudGet.SelectedIndex = BaudGet.Items.IndexOf("38400");          // 缺省38400

            comrecv.NewLine = "\r\n";                      //定义换行
            comrecv.DataReceived += comrecv_DataReceived;  //接收函数与系统串口类的接口，不可屏蔽

            /////////////端口号配置文件
            comNamepost1 = File.ReadAllText("testpost");  //读出文件中的端口号
            ComGiv.SelectedIndex = ComGiv.Items.IndexOf(comNamepost1);    //显示端口

            comNamerecv1 = File.ReadAllText("testrecv");  //读出文件中的端口号
            ComGet.SelectedIndex = ComGet.Items.IndexOf(comNamerecv1);    //显示端口

           
        }

        private void openoffpost()        // 串口开关 发送端口
        {
            //根据当前串口对象，来判断操作
            if (compost.IsOpen)
            {
                //打开时点击，则关闭串口
                compost.Close();
            }
            else
            {
                //关闭时点击，则设置好端口，波特率后打开
                compost.PortName = ComGiv.Text;
                compost.BaudRate = int.Parse(BaudGiv.Text);
                try
                {
                    compost.Open();
                }
                catch (Exception ex)
                {
                    //捕获到异常信息，创建一个新的comm对象，之前的不能用了。
                    compost = new SerialPort();
                    //现实异常信息给客户。
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void openoffrecv()        // 串口开关 接收端口
        {
            //根据当前串口对象，来判断操作
            if (comrecv.IsOpen)
            {
                //打开时点击，则关闭串口
                comrecv.Close();
            }
            else
            {
                //关闭时点击，则设置好端口，波特率后打开
                comrecv.PortName = ComGet.Text;
                comrecv.BaudRate = int.Parse(BaudGet.Text);
                try
                {
                    comrecv.Open();
                }
                catch (Exception ex)
                {
                    //捕获到异常信息，创建一个新的comm对象，之前的不能用了。
                    comrecv = new SerialPort();
                    //现实异常信息给客户。
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Send(string str)    //发送函数  发送端口
        {
            int n = 0;
            MatchCollection mc = Regex.Matches(str, @"(?i)[\da-f]{2}");
            List<byte> buf = new List<byte>();//填充到这个临时列表中
            //依次添加到列表中
            foreach (Match m in mc)
            {
                // buf.Add(byte.Parse(m.Value));
                buf.Add(byte.Parse(Convert.ToInt32(m.Value, 16).ToString()));

            }
            //转换列表为数组后发送
            compost.Write(buf.ToArray(), 0, buf.Count);

            n = buf.Count;
        }

        private void comrecv_DataReceived(object sender, EventArgs e)    //接收函数  接收端口
        {
           
            int n = comrecv.BytesToRead;    //先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
            byte[] buf = new byte[n];    //声明一个临时数组存储当前来的串口数据
            // received_count += n;       //增加接收计数
            comrecv.Read(buf, 0, n);       //读取缓冲数据

            builderr.Clear();            //清除字符串构造器的内容
            //因为要访问ui资源，所以需要使用invoke方式同步ui。
            this.Invoke((EventHandler)(delegate
            {
               
                // builder1.Append(Encoding.ASCII.GetString(buf));
                foreach (byte b in buf)
                {
                    builderr.Append(b.ToString("X2")+" ");
                }
                this.TestRecv.AppendText(builderr.ToString());

            }));
            
        }


        public string str_bit(string testPost)            //字符串转二进制函数
        {
            byte[] data = Encoding.Unicode.GetBytes(testPost);
            StringBuilder result = new StringBuilder(data.Length * 8);

            foreach (byte b in data)
            {
                result.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }
            return result.ToString();
        }

        public string bit_str(string testRecv)     //二进制转字符串函数
        {
            System.Text.RegularExpressions.CaptureCollection cs =
                System.Text.RegularExpressions.Regex.Match(testRecv, @"([01]{8})+").Groups[1].Captures;
            byte[] data = new byte[cs.Count];
            for (int i = 0; i < cs.Count; i++)
            {
                data[i] = Convert.ToByte(cs[i].Value, 2);
            }
            return Encoding.Unicode.GetString(data, 0, data.Length);
        }
        
        private void StartTest_Click(object sender, EventArgs e)
        {
            openoffpost();  //开发送端口
            openoffrecv();  //开接收端口
            StartTest.Text = compost.IsOpen ? "端口已打开" : "端口已关闭";   //显示按键状态
           
        }
        string postbit,recvbit;
        private void button1_Click(object sender, EventArgs e)  //误比特率测试
        { 
            Send(TestPost.Text);
            postbit = str_bit(TestPost.Text);
            
            recvbit=bit_str(TestRecv.Text);

            string strend = recvbit.Replace(postbit, "");
            ErrorNum.Text ="误比特率"+ (strend.Length/postbit.Length).ToString();
            //比较文件，计算误比特率


        }

        private void Exit_Click(object sender, EventArgs e)
        {
           // player.Stop();
            this.Close();
        }

        private void ComGiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            refleshpost();
        }

        public void refleshpost()   //刷新端口号
        {
            comNamepost = ComGiv.SelectedItem.ToString();  //获取当前端口号
            if (comNamepost1 != comNamepost)               //若当前端口与文件中存储的端口不一致，即当端口号人为改变时，重写文件
            {
                if (comNamepost != null)
                    File.Delete("testpost");
                File.AppendAllText("testpost", comNamepost);  //写非空的端口号到文件
            }
        }

        private void ComGet_SelectedIndexChanged(object sender, EventArgs e)   //刷新
        {
            refleshrecv();
        }

        public void refleshrecv()   //刷新端口号
        {
            comNamerecv = ComGet.SelectedItem.ToString();  //获取当前端口号
            if (comNamerecv1 != comNamerecv)               //若当前端口与文件中存储的端口不一致，即当端口号人为改变时，重写文件
            {
                if (comNamerecv != null)
                    File.Delete("testrecv");
                File.AppendAllText("testrecv", comNamerecv);  //写非空的端口号到文件
            }

        }

      
        public int chartonum(string str)
        {
            byte[] array = System.Text.Encoding.ASCII.GetBytes(str); //数组array为对应的ASCII数组 
            int asciicode = (int)(array[0]);
            return asciicode;

        }
        
        public char str_to_chr(string in_str)   //功能：把两位的十六进制字符串转换为相应16进制数表示的ASCII字符。
        {
            if (Convert.ToInt32(in_str, 16) > 0x7f)
            {
                int num = Convert.ToInt32(in_str, 16) & 0x7f;   //将字符转换为数字并去掉校验位。

                char chr = (char)(num);
                return chr;
            }
            else
            {
                return (char)Convert.ToInt32(in_str, 16);
            }

        }
        
        public string acars_trans(string in_str)   //将16进制的acars报文译码
        {
            int i = 0;
            char strchr;
            string firstr = "", s = "";
            firstr = remove_nul(in_str);//输入字符串去除空格符
            string[] midstr = new string[firstr.Length / 2];
            int j = 0;
            for (i = 0; i < firstr.Length / 2; i++)
            {
                midstr[i] = firstr.Substring(j, 2);   //提取两个长度的字符串
                strchr = str_to_chr(midstr[i]);   //转换成字符
                s += strchr.ToString();                           //连成完整字符串
                j += 2;
            }
            s = filter(s);
            return s;
        }

        public string remove_nul(string in_str)  //去除字符串中的空格符
        {
            int i;
            string out_str = "";

            for (i = 0; i < in_str.Length; i++)
            {
                if (in_str.Substring(i, 1) != " ")
                {
                    out_str += in_str.Substring(i, 1);
                }
            }
            return out_str;
        }

        public string filter(string in_str)
        {
            int a = in_str.Length;
            char[] strin = in_str.ToCharArray();
            int[] num = new int[a];

            int i;

            string s = strin[0].ToString();

            for (i = 0; i < a; i++)
            {

                num[i] = (int)strin[i];

                if ((num[i] > 0x2C) && (num[i] < 0x7B))
                {
                    s += strin[i].ToString();
                }
                else { s += " "; }

            }

            return s;
        } 
        
         int reportnum = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (TestRecv.Text.Contains("7F 52") && TestRecv.Text.Contains("AB 2A 16 16"))
            {
                string begain_str, over_str;
                begain_str = "AB 2A 16 16";   //帧头
                over_str = "7F 52";      //帧尾
                int str_start, str_end;
                string acarsreport;
                // string s1;
                str_start = TestRecv.Text.IndexOf(begain_str);  //帧头位置
                str_end = TestRecv.Text.IndexOf(over_str);      //帧尾位置
                acarsreport = TestRecv.Text.Substring(str_start, str_end - str_start + over_str.Length);   //完整的一帧数据

                // resultOfRecv.Text += acarsreport;                                   //显示一帧数据                              
                resultDat.Text += DateTime.Now.ToString("hh:mm:ss") + acars_trans(acarsreport).Remove(0, 3);    //显示字符

                TestRecv.Text = TestRecv.Text.Remove(0, str_end + over_str.Length);  //改变要处理的字符串
                resultDat.Text += "\r\n";
                reportnum++;
                Ps.Text = ((1000-reportnum)/1000).ToString();

            }
            else
            {
                ;
            }

           
        }


        static string pathUse;
        
        private void MSKTest_Click(object sender, EventArgs e)   //测试按钮
        {
            timer1.Interval = 50;
            timer1.Start();
           
           
        }

        private void button2_Click(object sender, EventArgs e)  //音频发送按钮
        {
            OpenFileDialog path = new OpenFileDialog();
            path.ShowDialog();
            string pathStr = Convert.ToString(path);
            pathUse = pathStr.Substring(56);

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = pathUse;
            player.Load();
            player.Play();
           
        }
    }
}
