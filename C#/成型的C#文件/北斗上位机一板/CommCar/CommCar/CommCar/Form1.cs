using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.IO.Ports;
using MyTool;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
namespace CommCar
{
    public partial class Form1 : Form
    {
        private bool listening = false;//全局的监听
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            for (int i = 8000; i < 8100; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MyCompact.source = $"Data Source ={Application.StartupPath + "/MyData.sdf"}; encryption mode = platform default; Password = 123456;";
            //MyCompact.CreatTable("AllData","MainKey int primary key ,pooledData int,经度 float,纬度  float");
        }
        #region 搜索串口
        //
        //摘要：
        //    搜索串口
        private void searchPort_Click(object sender, EventArgs e)
        {
            string[] str = SerialPort.GetPortNames();
            if (str.Length != 0)
            {
                canUsePort.Items.Clear();
                for (int i = 0; i < str.Length; i++)
                {
                    canUsePort.Items.Add(str[i]);
                }
                canUsePort.Text = str[0];
            }
            else
            {
                MessageBox.Show("无可用端口！！", "错误");
            }
        }
        #endregion

        #region 打开串口
        //
        //摘要：
        //    打开串口
        private void openPort_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.BaudRate = int.Parse(baudRate.Text);
                serialPort1.PortName = canUsePort.Text;
                serialPort1.Open();
                openPort.Enabled = false;
                closePort.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 关闭串口
        //
        //摘要:
        //     关闭串口
        private void closePort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                openPort.Enabled = true;
                closePort.Enabled = false;
                while (listening) Application.DoEvents();
                serialPort1.Close();
            }
        }
        #endregion

        #region 窗口关闭事件
        //
        //摘要:
        //     窗口关闭事件
        //         串口关闭时等到消息队列中的所有消息处理完毕
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            while (listening) Application.DoEvents();
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            Application.Exit();
            //MyCompact.DeleteTable("AllData");
            //try
            //{
            //    MyCompact.DeleteTable("Num");
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        #endregion

        #region 波特率改变
        //
        //摘要:
        //     波特率中途改变,下位机波特率中途改变时下位机也得改
        private void baudRate_TextChanged(object sender, EventArgs e)
        {
            while (listening) Application.DoEvents();
            if (baudRate.Text != "")
            {
                serialPort1.BaudRate = int.Parse(baudRate.Text);
            }
        }
        #endregion

        #region 数据接收
        //
        //摘要:
        //     数据接收事件
        private Queue<byte> dataQueue = new Queue<byte>();//数据接收队列
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            listening = true;
            int length = serialPort1.BytesToRead;
            byte[] data = new byte[length];
            serialPort1.Read(data, 0, length);
            dataQueue.MyEnQueue(data);
            dealData();
            listening = false;
        }
        #endregion

        #region 数据处理与解码
        //
        //摘要:
        //     对发过来的数据进行处理,得到一个完整的数据包
        byte[] lenByte = new byte[200];
        int dataLength = 0;
        bool allbag = false;
        int lastNum = 0;
        int nowNum = 0;
        byte[] sendByte;
        Queue<byte[]> dataIsCar = new Queue<byte[]>();//完整的车子的数据包
        Queue<byte[]> dataIsBeacon = new Queue<byte[]>();//完整的信标的数据包
        private void dealData()
        {
            byte res = 0;
            while (dataQueue.Any())
            {
                if ((dataLength & 0X2000) != 0)//接收到包头
                {
                    if ((dataLength & 0x8000) == 0)//接收未完成
                    {
                        if ((dataLength & 0x4000) != 0)//接收到包尾
                        {
                            dataLength |= 0X8000;//接收完成
                        }
                        else
                        {
                            res = dataQueue.Dequeue();
                            if (res == 0XFE) allbag = true;
                            else if (allbag == true)
                            {
                                if (res == 0X01)
                                {
                                    dataLength |= 0X4000;
                                    allbag = false;
                                }
                                else
                                {
                                    allbag = false;
                                }
                            }
                            lenByte[dataLength & 0X1FFF] = res;
                            dataLength++;
                            if (dataLength > (199 + 0X6000)) dataLength = 0;//接收错误重新开始
                        }
                    }
                    else//接收完成
                    {
                        int middleLength = (dataLength & 0X1FFF) - 2;
                        //TODO:判断数据的完整性
                        byte[] vs = new byte[middleLength];
                        Array.Copy(lenByte, vs, middleLength);
                        DataIsAll dataIsAll = new DataIsAll(vs);
                        this.Invoke(new Action(() =>
                        {
                            textBox1.AppendText($"{dataIsAll.carAddress}"+"号车-->");
                            textBox1.AppendText($"经度:{dataIsAll.longitude}"+" ");
                            textBox1.AppendText($"纬度:{dataIsAll.latitude}" + " ");
                            textBox1.AppendText("\r\n");
                        }));
                        if (vs[18] == 0X01)
                        {
                            allCarNum[lastNum] = false;
                            sendByte = vs;
                            nowNum = (sendByte[0] << 8) + sendByte[1];
                            allCarNum[nowNum] = true;
                            lastNum = nowNum;
                        }
                        else if (vs[18] == 0X00)
                        {
                            dataIsBeacon.Enqueue(vs);
                        }
                        dataLength = 0;
                    }
                }
                else
                {
                    res = dataQueue.Dequeue();
                    if (res == 0X01) allbag = true;//接收到包头(0X01和0XFE)
                    else if (allbag == true)
                    {
                        if (res == 0XFE)
                        {
                            dataLength |= 0X2000;
                            allbag = false;
                        }
                        else
                        {
                            allbag = false;
                        }
                    }
                }
            }
        }
        #endregion
        /**********************************总端**************************************/
        #region 获取本机IP
        //
        //摘要:
        //     搜索本机IP
        private void SearchIP_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            IPHostEntry iPHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var i in iPHostEntry.AddressList)
            {
                if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    comboBox1.Items.Add(i.ToString());
                    comboBox1.Text = i.ToString();
                }
            }
        }
        #endregion

        #region 开启监听
        //
        //摘要:
        //     开启总端监听
        TcpListener[] tcpListener = new TcpListener[100];
        bool isListening = false;
        int listenerNum = 0;
        async private void OpenServe_Click(object sender, EventArgs e)
        {
            try
            {
                //建立监听实例
                tcpListener[listenerNum] = new TcpListener(IPAddress.Parse(comboBox1.Text), int.Parse(comboBox2.Text));
                tcpListener[listenerNum].Start();
                listenerNum++;
                textBox2.AppendText($"{comboBox2.Text + ":"}开始监听\r\n");
                isListening = true;
                await Task.Run(() =>
                {
                    ReceiveDataSon();
                });//开始异步监听
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 向子机发送数据
        bool[] allCarNum = new bool[100];//所有车子的编号
        private void ReceiveDataSon()
        {
            int thisPort = 7999 + listenerNum;
            while (isListening)
            {
                try
                {
                    TcpClient tcpClient = tcpListener[listenerNum - 1].AcceptTcpClient();//等待连接请求
                    Thread thread = new Thread(() =>
                    {
                        short carName = 0;//车的编号
                        NetworkStream networkStream = tcpClient.GetStream();
                        try
                        {
                            networkStream.Flush();
                            carName = carName.GetCarName(networkStream);
                            this.Invoke(new Action(() => { textBox2.AppendText($"{carName}号车连接成功\r\n"); }));
                            allCarNum[carName] = false;
                            while (isListening)//如果一直处于连接状态
                            {
                                if (allCarNum[carName] == true)//如果是自己的数据则发送
                                {
                                    //TODO:数据发送给子端口
                                    networkStream.Write(sendByte, 0, sendByte.Length);
                                    allCarNum[carName] = false;
                                }
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            tcpClient.Close();
                            networkStream.Close();
                            this.Invoke(new Action(() => { textBox2.AppendText($"{carName}号车断开连接\r\n"); }));
                        }
                    });
                    thread.IsBackground = true;
                    thread.Start();
                }
                catch
                {
                    this.Invoke(new Action(() =>
                    {
                        textBox2.AppendText($"{thisPort.ToString() + ":" + "关闭监听"}");
                        textBox2.AppendText("\r\n");
                    }));
                }
            }
        }
        #endregion

        #region 关闭TCP服务
        private void button1_Click(object sender, EventArgs e)
        {
            if (isListening == true)
            {
                isListening = false;

                for (int i = 0; i < listenerNum; i++)
                {
                    tcpListener[i].Stop();
                }
                textBox2.AppendText("所有端口结束监听\r\n");
                listenerNum = 0;
            }
        }
        #endregion
    }
    #region 扩展方法类
    //
    //摘要:
    //     一些类的扩展方法
    static class Util
    {
        public static void MyEnQueue(this Queue<byte> queue, byte[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                queue.Enqueue(data[i]);
            }
        }
        public static short GetCarName(this short name, NetworkStream networkStream)
        {
            byte[] vs = new byte[2];
            if ((vs[0] = (byte)networkStream.ReadByte()) > 0)
            {
                vs[1] = (byte)networkStream.ReadByte();
            }
            name = BitConverter.ToInt16(vs, 0);
            return name;
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
        }
    }
    #endregion
}