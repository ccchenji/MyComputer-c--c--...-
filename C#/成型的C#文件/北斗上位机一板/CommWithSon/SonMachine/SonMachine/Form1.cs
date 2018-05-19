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
                try
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
                        this.Invoke(new Action(() => { textBox1.AppendText("和主机连接成功\r\n"); BreakLink.Enabled = true; }));
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
                        int size = 0;
                        while (tcpClient.Connected)
                        {
                            if ((size = networkStream.Read(vs, 0, vs.Length)) > 0)
                            {
                                DataIsAll dataIsAll = new DataIsAll(vs);
                                this.Invoke(new Action(() =>
                                {
                                    textBox1.AppendText($"{dataIsAll.carAddress}" + "号车-->");
                                    textBox1.AppendText($"经度:{dataIsAll.longitude}" + " ");
                                    textBox1.AppendText($"纬度{dataIsAll.latitude}" + " ");
                                    textBox1.AppendText("\r\n");
                                }));
                            }
                        }
                    }
                }
                catch
                {
                    this.Invoke(new Action(() => { textBox1.AppendText("与服务器断开连接\r\n"); }));
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
        private void SendDataToMain(NetworkStream networkStream, Int16 data)
        {
            byte[] da = new byte[2];
            networkStream.Write(da, 0, 2);
        }
        #endregion
    }
    #region 扩展方法类
    //
    //摘要:
    //     一些数据发送的扩展方法
    static class Util
    {
        public static void SendDataToMain(this short data, NetworkStream networkStream)
        {
            byte[] da = BitConverter.GetBytes(data);
            networkStream.Write(da, 0, da.Length);
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
