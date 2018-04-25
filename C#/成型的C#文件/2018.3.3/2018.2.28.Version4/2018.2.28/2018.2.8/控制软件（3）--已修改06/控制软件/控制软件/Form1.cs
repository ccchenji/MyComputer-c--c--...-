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



namespace 控制软件
{
    /// <summary>
    /// timer1用于接收指令参数；
    /// port 为指令串口；port1为数据串口。
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //指令处理部分

        private SerialPort comm = new SerialPort();                    //定义端口
        private StringBuilder builder = new StringBuilder();
        /// ////////////////////////////////////////////
        
        public SerialPort comm1 = new SerialPort();            //定义新的串口
        private StringBuilder builder1 = new StringBuilder();  //C#中的一个类，一个可变的字符序列，类似StringBuffer  避免在事件处理方法中反复的创建，定义到外面。
       
        static string comName_command = "";
        static string comName_command1 = "";
        Boolean LocalModeEn = true;       
        private void Form1_Load(object sender, EventArgs e)   //设置端口基本信息 定时器
        {
           

             //初始化下拉串口名称列表框
            string[] ports = SerialPort.GetPortNames();        //获得端口号
            Array.Sort(ports);

            comboPortName.Items.AddRange(ports);       
           // comboPortName.SelectedIndex = comboPortName.Items.Count > 0 ? 0 : -1;            
            comboBaudrate.SelectedIndex = comboBaudrate.Items.IndexOf("38400");              //默认波特率38400
          
            //初始化SerialPort对象
            comm.NewLine = "\r\n";
            //事件注册
//            comm.DataReceived += comm_DataReceived;  //接收函数与系统串口类的接口，不可屏蔽
            
            //定时器设置
            timer1.Interval = 1000;   //状态刷新
            timer1.Stop();

            ////////////////////////////////////
           
            string[] ports1 = SerialPort.GetPortNames();  //定义数组，存储串口名称
            Array.Sort(ports1);                           //串口名称排序

            comName_command1 = File.ReadAllText("comname_command");  //读出文件中的端口号
            comboPortName.SelectedIndex = comboPortName.Items.IndexOf(comName_command1);    //显示端口

        }
        //控制用串口
        private void openclose_Click(object sender, EventArgs e)        // 串口开关
        {
            //根据当前串口对象，来判断操作
            if (comm.IsOpen)    //串口已打开
            {
                comm.Close();
                timer1.Stop();
            }
            else
            {   //串口已关闭
                comm.PortName = comboPortName.Text;
                comm.BaudRate = int.Parse(comboBaudrate.Text);
                try
                {
                    comm.Open();
                    timer1.Start();
                }
                catch (Exception ex)
                {
                    //捕获到异常信息，创建一个新的comm对象，之前的不能用了。
                    comm = new SerialPort();
                    //现实异常信息给客户。
                    MessageBox.Show(ex.Message);
                }
            }
            //设置按钮的状态
            OpenClose.Text = comm.IsOpen ? "关闭" : "打开";   //显示按键状态
            SignalFre.Enabled = comm.IsOpen;    //端口关闭时灰掉发送键或任何设置键
            PhaseOffset.Enabled = comm.IsOpen;
            SendBtn.Enabled = comm.IsOpen;
        }
    
        //根据收到的状态字更新控件内容
        //10 控制字(24bit)
        //11 AGC_r[23:16],audio_amp[3:0],AGC_r[11:0]
        //12 Fre1 Fre2 Fre3 
        //13 00 Energy_o         int Noise0,Noise1, Noise2, Noise3;
        byte[] shift_buf = new byte[32];//声明一个缓冲数组收到的命令字4*4=16字节
        int shift_buf_rptr = 0;
        byte[] fifo_buf = new byte[16];//声明一个缓冲数组收到的命令字4*4=16字节
        byte[] fifo_buf_bak = new byte[16];//声明一个缓冲数组收到的命令字4*4=16字节
        int ptr_w = 0;
        Boolean StatasOkFlag = false;
        int StatusWordGotCnt = 0;
        private void timer1_Tick_1(object sender, EventArgs e)         //定时器(1s)函数 筛选出待显示信息
        {
            int n = comm.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据
            comm.Read(buf, 0, n);//读取缓冲数据
            //move data shift_buf: 0 is the oldest data
            int tmp_ptr;
            if (n > 32)
                return;
            for (tmp_ptr = 0; tmp_ptr < 32 - n; tmp_ptr++)   //n=4, put 4..31 to 0..27 
                shift_buf[tmp_ptr] = shift_buf[tmp_ptr + n];
            //received data put in shift_buf                
            for (int i = 0; i < n; i++)
                shift_buf[tmp_ptr++] = buf[i];       //put buf[0..3] to shift_buf[27..31]
            //get whole 4 order and put them in fifu_buf
            for (int i = 0; i < 16; i++)
            {
                if (((shift_buf[i] & 0xf0) == 0x80) && ((shift_buf[i + 4] & 0xf0) == 0x90) && ((shift_buf[i + 8] & 0xf0) == 0xa0) && ((shift_buf[i + 12] & 0xf0) == 0xb0))
                {
                    ptr_w = 0;
                    shift_buf_rptr = i;
                    StatasOkFlag = true;
                }
                else
                {
                    ptr_w++;
                    if (ptr_w >= 16) //防止越界
                        ptr_w = 0;
                }
                fifo_buf[ptr_w] = shift_buf[i];
            }
            //disp fifo_buf in RecvText
            for (int i = 0; i < 16; i++)            //
            {
                if (i == 0)
                    RecvText.Text = fifo_buf[i].ToString("X2") + " ";
                else
                    RecvText.Text += fifo_buf[i].ToString("X2") + " ";
            }
            //根据状态修改控件内容                      
            if (StatasOkFlag)
            {
                StatasOkFlag = false;
                StatusWordGotCnt++;
                StatsWordGotNo.Text = "已收到：" + StatusWordGotCnt.ToString();
                int a0=fifo_buf[0],a1 = fifo_buf[1], a2 = fifo_buf[2], a3 = fifo_buf[3];
                //B18：本地模式
                LocalModeChk.Checked = ((a1 & 0x04) == 0x04);
                if (LocalModeChk.Checked)
                {//本地模式，PC机不能发布命令对ACARS电台进行控制
                    for (int i = 0; i < 16; i++)
                        fifo_buf_bak[i] = fifo_buf[i];
                    fifo_buf_bak[0] = (byte)(fifo_buf_bak[0] & 0x0f);
                    fifo_buf_bak[1] = (byte)(fifo_buf_bak[1] & 0xfb);   //B18=0
                    fifo_buf_bak[4] = (byte)((fifo_buf_bak[4] & 0x0f)+(2<<4));   //B18=0
                }
                LocalModeEn = LocalModeChk.Checked;
                SendBtn.Enabled = !LocalModeEn;
                Send_text.Enabled = !LocalModeEn;
                IF_Amp_Box.Enabled = !LocalModeEn;
                PhaseOffset.Enabled = !LocalModeEn;
                HSDAoutMode.Enabled = !LocalModeEn;
                FM_dis_chk.Enabled = !LocalModeEn;
                SUBCarriDisChk.Enabled = !LocalModeEn;
                RefDisChk.Enabled = !LocalModeEn;
                AudioLpBkEn.Enabled = !LocalModeEn;
                VolumeBox.Enabled = !LocalModeEn;
                SignalFre.Enabled = !LocalModeEn;
                IF_AGC_Con.Enabled = !LocalModeEn;
                //B23~20: IF信号功率门限
                if (LocalModeEn)
                {
                    //B26~24: 设置音量
                    VolumeBox.Text = Convert.ToString((a0 & 0x07));     
                    //B23~20: 设置IF信号功率门限
                    IF_Amp_Box.Text = Convert.ToString((a1 & 0xf0) >> 4);
                    //B19：IF_AGC使能
                    AGC_En_chk.Checked = !((a1 & 0x08) == 0);
                    //B17：IF环回使能
                    IFLoopChk.Checked = !((a1 & 0x02) == 0);
                    //B16: 基带环回测试
                    AudioLpBkEn.Checked = !((a1 & 0x01) == 0);

                    //B15~7：相位偏移   缺省值为0  0~359°
                    PhaseOffset.Text = Convert.ToString(a2 * 2 + ((a3 & 0x80) >> 7));
                    //B56：00数据基带+副载波 01:副载波Hilbert变换后  10：鉴频输出+去直流后 11：FM_cos AM_cos
                    OutModeSel.SelectedIndex = (a3 & 0x60) >> 5;
                    //B4: 音频输出VOR接收时的信号
                    RecBaseOutChk.Checked = !((a3 & 0x10) == 0);
                    //B3：禁止对副载波进行FM调制
                    FM_dis_chk.Checked = !((a3 & 0x08) == 0);
                    //B2: 只输出30Hz参考信号
                    RefDisChk.Checked = !((a3 & 0x04) == 0);
                    //B1: 只输出副载波信号
                    SUBCarriDisChk.Checked = !((a3 & 0x02) == 0);

                    //高速DA输出模式
                    if (SUBCarriDisChk.Checked)
                        HSDAoutMode.SelectedIndex = 2;    //发射AM信号
                    else if ((a3 & 0x04) == 0)
                        HSDAoutMode.SelectedIndex = 0;    //测试：环回输出收到中频IIR前的信号
                    else
                        HSDAoutMode.SelectedIndex = 1;    //测试：环回输出收到中频IIR后的信号

                    //第4~7字节
                    //AM调制本振频偏AGC_r[27:12]
                    int fre_offset = (fifo_buf_bak[4] & 0x0f) * 4096 + fifo_buf_bak[5] * 16 + (fifo_buf_bak[6] >> 4);
                    if (fre_offset > 32767)
                        fre_offset = fre_offset - 65536;
                    float fre_offset_kHz =(float)( fre_offset * 80000.0 / 16777216.0);   //80000/2^24
                    AMLoOffset.Text = fre_offset_kHz.ToString("F3");
                    //B11~B0 AGC增益
                    byte tmp_d = (byte)(fifo_buf[6] & 0x0f);
                    IF_AGC_Con.Text = tmp_d.ToString("X2") + fifo_buf[7].ToString("X2");

                    //第8~11字节：工作频率
                    long fre = fifo_buf[9] * 65536 + fifo_buf[10] * 256 + fifo_buf[11];
                    SignalFre.Text = Convert.ToString(fre / 1000) + "." + Convert.ToString(fre % 1000);   //显示信号频率                       
                }//LocalModeEn
                //B12：9显示信号强度 {4'hb,15'h00,audio_amp[3:0],phase_out}
                int SignalLev = fifo_buf[14] >> 1;
                LevDisplay.Text = Convert.ToString(SignalLev);
                //B8:0 显示接收相位差 12 13 14 15
                int RecDeg;
                RecDeg=(fifo_buf[14] & 0x01)*256+fifo_buf[15];
                                if ( RecDeg > 255)
                                    RecDeg = RecDeg-512;
/*                                if (AudioLpBkEn.Checked)    //基带自环
                                    RecDeg =RecDeg + 96;
                                else
                                    RecDeg = RecDeg + 114;*/
//                  RecDeg = RecDeg + 5;
/*                if (RecDeg < 0)
                    RecDeg += 360;*/
                RecDegtextBox.Text = Convert.ToString(RecDeg);
            }//StatasOkFlag
    }

public void reflesh_command()   //刷新端口号
        {
            comName_command = comboPortName.SelectedItem.ToString();  //获取当前端口号
            if (comName_command1 != comName_command)               //若当前端口与文件中存储的端口不一致，即当端口号人为改变时，重写文件
            {
                if (comName_command != null)
                    File.Delete("comname_command");
                File.AppendAllText("comname_command", comName_command);  //写非空的端口号到文件
            }

        }

        //远程控制模式下下，设置ACARS电台的工作模式及参数
        int OrderSentCnt=0;
        private void Send_Click_1(object sender, EventArgs e)
        {
            string in_str = Send_text.Text;
            MatchCollection mc = Regex.Matches(in_str, @"(?i)[\da-f]{2}");
            List<byte> buf = new List<byte>();//填充到这个临时列表中
            //依次添加到列表中
            foreach (Match m in mc)
            {
                // buf.Add(byte.Parse(m.Value));
                buf.Add(byte.Parse(Convert.ToInt32(m.Value, 16).ToString()));

            }
            //转换列表为数组后发送
            comm.Write(buf.ToArray(), 0, buf.Count);
            OrderSentCnt++;
            OrderSentNo.Text = "已发送：" + OrderSentCnt.ToString();
        }
        //改变高速DA输出模式
        //B7：AM发射使能
        //B2：选择DA输出   0：IIR前   1：IIR后
        private void HSDAoutMode_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        //准备发送一个字符串 函数   设置参数时使用
        public void send_str(int OrderFlag)          
        {
            Send_text.Text = "";
            for (int i = 0; i < 4; i++)
                Send_text.Text += fifo_buf_bak[i + OrderFlag*4].ToString("X2") + " ";
        }
        //改变ACARS电台工作频率: 字节1为频率设置命令字，后3个字节为频率字（单位kHz）
        private void SignalFre_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (SignalFre.SelectedIndex)
            {
                case 0: Send_text.Text = "01 01 B5 80"; break;  //112.1 Tjanjin Airport VOR
                case 1: Send_text.Text = "01 01 BA F8"; break;  //113.4 东丽湖VOR
                case 2: Send_text.Text = "01 01 CD B8"; break;  //118.2 TJTWR
                case 3: Send_text.Text = "01 01 D0 D8 "; break; //119.0 BJAPP2
                case 4: Send_text.Text = "01 01 EA A0 "; break; //125.6 BJAPP1
                case 5: Send_text.Text = "01 01 ED C0 "; break; //126.4 ATIS
                case 6: Send_text.Text = "01 01 F3 9C"; break;  //127.9 TJAPP
                case 7: Send_text.Text = "01 02 01 7A"; break;  //131.45 ACARS
                case 8: Send_text.Text = "01 0F B7 70"; break;  //1030MHz 二次雷达发射 
                case 9: Send_text.Text = "01 10 A1 D0"; break;  //1090MHz 二次雷达接收
                default: Send_text.Text = "01 02 01 7A "; break;//131.45 ACARS
            }
        }
        //B26~24：音量控制   缺省值5
        private void VolumeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tmp_dat = Convert.ToByte(VolumeBox.Text, 10) & 0x07;
            fifo_buf_bak[0] = (byte)((fifo_buf_bak[0] & 0xf8) + tmp_dat);
            send_str(0);
        }

        //B23~20: 设置IF信号功率门限
        private void IF_Amp_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tmp_dat= Convert.ToByte(IF_Amp_Box.Text) << 4;
            fifo_buf_bak[1] = (byte)((fifo_buf_bak[1] & 0x0f) + tmp_dat);//Convert.ToInt32(m.Value, 16)
            send_str(0);
        }

        //B19：IF_AGC使能
        private void AGC_En_chk_CheckedChanged_1(object sender, EventArgs e)
        {
            if (AGC_En_chk.Checked)
                fifo_buf_bak[1] = (byte)(fifo_buf_bak[1] | 0x08);
            else
                fifo_buf_bak[1] = (byte)(fifo_buf_bak[1] & 0xf7);
            send_str(0);
        }
        //B17 中频环回使能
        private void IFLoopChk_CheckedChanged(object sender, EventArgs e)
        {
            if (IFLoopChk.Checked)
                fifo_buf_bak[1] = (byte)(fifo_buf_bak[1] | 0x02);
            else
                fifo_buf_bak[1] = (byte)(fifo_buf_bak[1] & 0xfd);
            send_str(0);
        }
        //B16：基带环回测试
        private void AudioLpBkEn_CheckedChanged(object sender, EventArgs e)
        {
            if (AudioLpBkEn.Checked)
                fifo_buf_bak[1] = (byte)(fifo_buf_bak[1] | 0x01);
            else
                fifo_buf_bak[1] = (byte)(fifo_buf_bak[1] & 0xfe);
            send_str(0);
        }
        //B15~7: 可变相位角度（0~360度）
        private void NoiseLev_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dat;
            dat = (int)(Convert.ToDecimal(PhaseOffset.Text));
            fifo_buf_bak[2] =(byte)(dat>>1);
            if((dat%1)==1)
                fifo_buf_bak[3] |= 0x80;
            send_str(0);
        }

        //B65：00数据基带+副载波 01:副载波Hilbert变换后  10：鉴频输出+去直流后 11：FM_cos AM_cos
        private void OutModeSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            fifo_buf_bak[3] &= 0x9f;
            fifo_buf_bak[3] |= (byte)(OutModeSel.SelectedIndex<<5);
            send_str(0);
        }
        //B4: 音频输出VOR接收时的信号
        private void RecBaseOutChk_CheckedChanged(object sender, EventArgs e)
        {
            if (RecBaseOutChk.Checked)
                fifo_buf_bak[3] = (byte)(fifo_buf_bak[3] | 0x10);
            else
                fifo_buf_bak[3] = (byte)(fifo_buf_bak[3] & 0xef);
            send_str(0);
        }
        //B3：禁止对副载波进行FM调制
        private void AGC_En_chk_CheckedChanged(object sender, EventArgs e)
        {
            if(FM_dis_chk.Checked)
                fifo_buf_bak[3] = (byte)(fifo_buf_bak[3] | 0x08);
            else
                fifo_buf_bak[3] = (byte)(fifo_buf_bak[3] & 0xf7);
            send_str(0);
        }
        //B2：只输出30Hz参考信号
        private void AMEnChk_CheckedChanged(object sender, EventArgs e)
        {
            if (SUBCarriDisChk.Checked)
            {
                fifo_buf_bak[3] = (byte)(fifo_buf_bak[3] | 0x04);
                if (RefDisChk.Checked)
                    RefDisChk.Checked = false;
            }
            else
                fifo_buf_bak[3] = (byte)(fifo_buf_bak[3] & 0xfb);
            send_str(0);
        }
        //B1：只输出副载波信号
        private void MSKEnChk_CheckedChanged(object sender, EventArgs e)
        {
            if (RefDisChk.Checked)
            {
                fifo_buf_bak[3] = (byte)(fifo_buf_bak[3] | 0x02);
                if (SUBCarriDisChk.Checked)
                    SUBCarriDisChk.Checked = false;
            }
            else
                fifo_buf_bak[3] = (byte)(fifo_buf_bak[3] & 0xfd);
            send_str(0);
        }



        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //4 5 6 7
        //02设置R820T中频增益（低12位）（发送给430单片机，转发给FPGA）
        private void IF_AGC_Con_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tmp1 = Convert.ToInt16(IF_AGC_Con.Text, 16);
            fifo_buf_bak[6] = (byte)((fifo_buf_bak[6] & 0xf0) + (tmp1 >> 8));
            fifo_buf_bak[7] = (byte)((tmp1 & 0xff));
            send_str(1);
        }
        //02设置AM调制本振频偏（高16位）（发送给FPGA）
        private void AMLoOffset_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                double tmp_f = Convert.ToDouble(AMLoOffset.Text);
                int tmp1 = (int)(tmp_f * 16777216 / 80000);
                if (tmp1 > 32767)
                    tmp1 = 32767;
                if (tmp1 < -32767)
                    tmp1 = -32767;
                if (tmp1 < 0)
                    tmp1 = tmp1 + 65536;
                fifo_buf_bak[4] = (byte)(0x20 + (tmp1 >> 12));
                fifo_buf_bak[5] = (byte)((tmp1 >> 4));
                byte tmp2 = (byte)((tmp1 & 0x0f)<<4);
                byte tmp3 = (byte)(fifo_buf_bak[6] & 0x0f);
                fifo_buf_bak[6] = (byte)(tmp3 + tmp2);
                send_str(1);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Send_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    } 
}
