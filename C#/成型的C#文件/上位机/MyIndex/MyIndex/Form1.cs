using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
namespace MyIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool listening = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("4800");
            comboBox2.Items.Add("9600");
            comboBox2.Items.Add("115200");
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPortReceived);
        }

        //自动获取端口号
        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = SerialPort.GetPortNames();
            if (str.Length != 0)
            {
                comboBox1.Items.Clear();
                for (int i = 0; i < str.Length; i++)
                {
                    comboBox1.Items.Add(str[i]);
                }
                comboBox1.Text = str[0];
            }
            else
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("无可用端口！ ！", "错误");
            }
        }
        //接收事件处理函数
        private int receiveDate = 0;
        bool startReceive = false;
        int countDate = 0;
        byte[] constDate = new byte[5];
        float date = 0;
        public void serialPortReceived(object sender, SerialDataReceivedEventArgs e)
        {
            listening = true;//防止在接收数据时因关闭窗口而导致死机（一个标志位）
            receiveDate = serialPort1.BytesToRead;//获取缓存区的字节数
            byte[] randomDate = new byte[receiveDate];//建立一个数组保存缓存区的数据
            serialPort1.Read(randomDate, 0, receiveDate);//将数据读入数组
            for (int n = 0; n < receiveDate; n++)
            {
                if (randomDate[n] == 0X0B) //接收到包尾
                {
                    if (countDate == 5)//判断数据位数的准确性
                    {
                        float myDate = BitConverter.ToSingle(constDate, 0);//将数据转换成float
                        startReceive = false;//先关闭数据接收
                        Action dateReceiveHandler = () =>  //建立一个委托
                        {
                            if (constDate[4] == 0XA1)
                            {
                                textBox5.Text = myDate.ToString();
                            }
                            else if (constDate[4] == 0XA2)
                            {
                                textBox6.Text = myDate.ToString();
                                if (date!=float.Parse(textBox6.Text))
                                {
                                   date = float.Parse(textBox6.Text);
                                   userControl11.RealAngle = date;
                                   userControl12.RealAngle = date;
                                }
                            }
                            else if (constDate[4] == 0XA3)
                            {
                                textBox7.Text = myDate.ToString();
                            }
                            else if (constDate[4] == 0XA4)
                            {
                                textBox8.Text = myDate.ToString();
                            }
                        };
                        this.Invoke(dateReceiveHandler); //在一个线程调用另一个线程需使用委托
                        countDate = 0;
                    }
                    else if(countDate>5)//如果数据的位数不正确则重新开始接收
                    {
                        countDate = 0;
                        startReceive = false;
                    }
                }
                if (countDate < 5)//防止数据溢出
                {
                    if (startReceive == true)
                    {
                        constDate[countDate] = randomDate[n];
                        countDate++;
                    }
                }
                else if (countDate == 5)//接收错误重新开始接收
                {
                    countDate = 0;
                    startReceive = false;
                }
                if (randomDate[n] == 0X0A)//接收到包头
                {
                    startReceive = true;
                }
            }
            listening = false;
        }

        //打开串口
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = int.Parse(comboBox2.Text);
                serialPort1.Open();
                button2.Enabled = false;
                button3.Enabled = true;
            }
            catch
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("无可用端口！！", "错误");
            }
        }
        //关闭串口
        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                button2.Enabled = true;
                button3.Enabled = false;
                while (listening) Application.DoEvents();//等待事件的完成
                serialPort1.Close();
            }
        }
        //发送数据
        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                stringToByte(textBox1.Text);
                stringToByte(textBox2.Text);
                stringToByte(textBox3.Text);
                stringToByte(textBox4.Text);
                userControl11.SetAngle = float.Parse(textBox4.Text);
                userControl12.SetAngle = float.Parse(textBox4.Text);
                serialPort1.Write("\r\n");
            }
        }

        //字符转字节转换函数
        public void stringToByte(string str)
        {
            byte[] Byte = new byte[2];
            try
            {
                Int32 date = Int32.Parse(str);
                Byte[0] = (byte)(date >> 8);
                Byte[1] = (byte)(date);
                serialPort1.Write(Byte, 0, 2);
            }
            catch
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("不符合要求的字符", "错误");
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            while (listening) Application.DoEvents();//等待事件处理完成
            serialPort1.Close();//关闭串口
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)//中途改变波特率则
        {
            while (listening) Application.DoEvents();
            if (comboBox2.Text != "")
            {
                serialPort1.BaudRate = int.Parse(comboBox2.Text);
            }
        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
