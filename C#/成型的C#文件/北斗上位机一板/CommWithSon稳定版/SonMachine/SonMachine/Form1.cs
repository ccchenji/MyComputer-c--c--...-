using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SonMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 8000; i < 8100; i++)
            {
                PortName.Items.Add(i.ToString());
            }
            for (int i = 1; i < 200; i++)
            {
                carName.Items.Add(i.ToString());
            }
            IpName.Text = "10.8.64.245";
            radioButton1.Checked = false;
            radioButton2.Checked = true;
            radioButton3.Checked = false;
            radioButton4.Checked = true;
        }
        #region 连接到主机
        //
        //摘要:
        //     客户端连接到主机
        NetworkStream networkStream = null;
        TcpClient tcpClient = null;
        async private void ConnectWithMain_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                tcpClient = new TcpClient();
                string carText = "";
                string IpNameText = "";
                string PortNameText = "";
                Int16 car = 0;
                this.Invoke(new Action(() =>
                {
                    try
                    {
                        IpNameText = IpName.Text;
                        PortNameText = PortName.Text;
                        carText = carName.Text;//得到车子的编号
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }));
                try
                {
                    car = Int16.Parse(carText);
                    IPAddress iPAddress = IPAddress.Parse(IpNameText);
                    int Port = int.Parse(PortNameText);
                    this.Invoke(new Action(() => { textBox1.AppendText("连接中......\r\n"); ConnectWithMain.Enabled = false; }));
                    tcpClient.Connect(iPAddress, Port);
                    this.Invoke(new Action(() => { textBox1.AppendText("和主机连接成功\r\n"); BreakLink.Enabled = true; button1.Enabled = true; }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Invoke(new Action(() => { textBox1.AppendText("连接失败!!!!!\r\n"); ConnectWithMain.Enabled = true; }));
                }
                if (tcpClient.Connected)
                {
                    networkStream = tcpClient.GetStream();
                    car.SendDataToMain(networkStream);
                    byte[] vs = new byte[100];
                    //数据接收
                    Task.Run(() =>
                    {
                        while (tcpClient.Connected)
                        {
                            GetMessageFromMain(networkStream, vs);
                        }
                    });
                    //数据发送
                    Task.Run(() =>
                    {
                        while (tcpClient.Connected)
                        {
                            if (noSend == true)
                            {
                                SendDataToMain(networkStream, allSendData);
                                noSend = false;
                            }
                        }
                    });
                }
            });
        }
        #endregion

        #region 关闭与服务器连接
        //
        //摘要:
        //     关闭与服务器连接
        private void BreakLink_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcpClient != null)
                {
                    tcpClient.Close();
                    if (networkStream != null)
                    {
                        networkStream.Close();
                    }
                    BreakLink.Enabled = false;
                    ConnectWithMain.Enabled = true;
                    button1.Enabled = false;
                    noSend = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 向主机发送信息 
        //
        //摘要:向主机发送信息
        //    
        private void SendDataToMain(NetworkStream networkStream, byte[] data)
        {
            try
            {
                networkStream.Write(data, 0, data.Length);
                this.Invoke(new Action(() => { textBox2.AppendText("发送成功\r\n"); }));
            }
            catch
            {
                this.Invoke(new Action(() => { textBox2.AppendText("无法向主机发送信息\r\n"); }));
            }
        }
        #endregion

        #region 获得主机发送的信息
        //
        //摘要:
        //     获得从主机发送的数据
        private void GetMessageFromMain(NetworkStream networkStream, byte[] vs)
        {
            try
            {
                if ((networkStream.Read(vs, 0, vs.Length)) > 0)
                {
                    DataIsAll dataIsAll = new DataIsAll(vs);
                    if (dataIsAll.modeIorII == 0X00)//模式1
                    {
                        this.Invoke(new Action(() =>
                        {
                            textBox1.AppendText($"{dataIsAll.carAddress}" + "号车-->");
                            textBox1.AppendText($"经度:{dataIsAll.longitude}" + " ");
                            textBox1.AppendText($"纬度{dataIsAll.latitude}" + " ");
                            textBox1.AppendText($"距离信标的距离{dataIsAll.destination1}" + "米");
                            textBox1.AppendText("\r\n");
                        }));
                    }
                    else if(dataIsAll.modeIorII==0X01)
                    {
                        this.Invoke(new Action(() =>
                        {
                            textBox1.AppendText($"{dataIsAll.carAddress}" + "号车-->");
                            textBox1.AppendText($"经度:{dataIsAll.longitude}" + " ");
                            textBox1.AppendText($"纬度{dataIsAll.latitude}" + "\r\n");
                            textBox1.AppendText($"距离信标1的距离{dataIsAll.destination1}" + "米"+"\r\n");
                            textBox1.AppendText($"距离信标2的距离{dataIsAll.destination2}" + "米"+"\r\n");
                            textBox1.AppendText($"距离信标3的距离{dataIsAll.destination3}" + "米"+"\r\n");
                            textBox1.AppendText($"距离信标4的距离{dataIsAll.destination4}" + "米"+"\r\n");
                        }));
                    }
                }
            }
            catch
            {
                this.Invoke(new Action(() => { textBox1.AppendText("断开与服务器的连接"); }));
            }
        }
        #endregion

        #region 发送事件
        //
        //摘要:按钮触发,并向主机发送数据
        //
        bool noSend = false;
        byte[] allSendData = new byte[30];
        private void button1_Click(object sender, EventArgs e)
        {
            byte[] data;
            allSendData[0] = 0X02;
            allSendData[1] = 0XFD;
            try
            {
                data = carName.Text.ChangeToByteShort();
                allSendData[2] = data[1];
                allSendData[3] = data[0];
                data = latitude.Text.ChangeToByteDouble();
                Array.Copy(data, 0, allSendData, 4, 8);
                data = longitude.Text.ChangeToByteDouble();
                Array.Copy(data, 0, allSendData, 12, 8);
                if (radioButton3.Checked)
                {
                    allSendData[20] = 0X01;
                }
                else
                {
                    allSendData[20] = 0X00;
                }
                if (radioButton1.Checked)
                {
                    allSendData[21] = 0X01;
                }
                else
                {
                    allSendData[21] = 0X00;
                }
                allSendData[28] = 0XFD;
                allSendData[29] = 0X02;
                for (int i = 0; i < 30; i++)
                {
                    textBox2.AppendText(allSendData[i].ToString("X") + " ");
                }
                textBox2.AppendText("\r\n");
                if (noSend == false)
                {
                    noSend = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
    #region 扩展方法类
    //
    //摘要:
    //     一些数据发送的扩展方法
    static class Util
    {
        //将车子编号发给总端
        public static void SendDataToMain(this short data, NetworkStream networkStream)
        {
            byte[] da = BitConverter.GetBytes(data);
            networkStream.Write(da, 0, da.Length);
        }
        //将字符串转换成字节数组(Double型)
        public static byte[] ChangeToByteDouble(this string sData)
        {
            double data = double.Parse(sData);
            byte[] vs = BitConverter.GetBytes(data);
            return vs;
        }
        //将字符转换成字节数组(short型)
        public static byte[] ChangeToByteShort(this string sData)
        {
            short data = short.Parse(sData);
            byte[] vs = BitConverter.GetBytes(data);
            return vs;
        }
    }
    #endregion

    #region 数据类
    //
    //摘要:
    //     此处为一个完整的数据
    class DataIsAll
    {
        private byte[] allData;
        public int carAddress { get; set; }//当前编号(车子或者信标)
        public double longitude { get; set; }//当前的经度信息
        public double latitude { get; set; }//当前的纬度信息
        public byte myTab { get; set; }//用于判断是车子还是信标
        public double destination1 { get; set; }//获得当前车子距离信标的距离
        public double destination2 { get; set; }//获得当前车子距离信标的距离
        public double destination3 { get; set; }//获得当前车子距离信标的距离
        public double destination4 { get; set; }//获得当前车子距离信标的距离
        public short modeIorII { get; set; }
        public DataIsAll(byte[] allData)//构造函数
        {
            this.allData = allData;
            dealData();
        }
        private void dealData()
        {
            carAddress = (allData[0] << 8) + allData[1];
            latitude = BitConverter.ToDouble(allData, 2);//当前坐标的纬度信息
            longitude = BitConverter.ToDouble(allData, 10);//当前坐标的经度信息
            myTab = allData[18];//用于判断车子或者信标
            modeIorII = allData[58];//判断模式         
            destination1 = BitConverter.ToDouble(allData, 26);
            destination2 = BitConverter.ToDouble(allData, 34);
            destination3 = BitConverter.ToDouble(allData, 42);
            destination4 = BitConverter.ToDouble(allData, 50);
        }
    }
    #endregion
}
