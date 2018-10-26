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
using System.IO.Ports;
namespace MySystem
{
    public partial class Form1 : Form
    {
        const string dataPath = "Data Source=MySystem.sdf;Max Database Size=1024;encryption mode=platform default;Password=123456;";
        SerialPort mySerialPort = new SerialPort();//串口
        public delegate void MyEventHandler(bool flag);
        public event MyEventHandler serialOver;//串口转换完成事件
        bool listening = false;//用于串口监听
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = false;
            mySerialPort.DataReceived += receive_Data;
            serialOver += dealSerial;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }
        /// <summary>
        /// 新建表（按钮点击事件）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buildTable_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCeConnection conn = new SqlCeConnection(dataPath))
                {
                    conn.Open();
                    using (SqlCeCommand comm = new SqlCeCommand($"CREATE TABLE {nTableName.Text.ToString()} (姓名 nchar(20),学号 nchar(20),卡号 nchar(20) primary key,状态 bit)", conn))
                    {
                        comm.ExecuteNonQuery();
                    }
                    MessageBox.Show("创建成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 查询数据库中所有表的名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlCeConnection conn = new SqlCeConnection(dataPath))
            {
                conn.Open();
                DataTable data = conn.GetSchema("Tables");
                comboBox1.Items.Clear();
                foreach (DataRow row in data.Rows)
                {
                    string name = (string)row["TABLE_TYPE"];
                    if (name.Contains("TABLE"))
                    {
                        comboBox1.Items.Add(row["TABLE_NAME"].ToString());
                    }
                }
                if (comboBox1.Items.Count != 0) comboBox1.Text = comboBox1.Items[0].ToString();
            }
        }
        /// <summary>
        /// 删除表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (form2 == null || form2.TableName != comboBox1.Text)//form2窗口没有打开的话可以删除表
                {
                    using (SqlCeConnection conn = new SqlCeConnection(dataPath))
                    {
                        conn.Open();
                        using (SqlCeCommand comm = new SqlCeCommand($"DROP TABLE {comboBox1.Text}", conn))
                        {
                            comm.ExecuteNonQuery();
                        }
                        comboBox1.Items.Clear();
                        MessageBox.Show("删除成功");
                    }
                }
                else
                {
                    MessageBox.Show("表格正在被操作无法删除");
                }
            }
            catch
            {
                MessageBox.Show("此表不存在");
            }
        }
        Form2 form2;
        /// <summary>
        /// 编辑当前表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (form2 == null && comboBox1.Text != "")
            {
                form2 = new Form2(comboBox1.Text, dataPath);
                form2.Form2Closing += (send, ex) => { form2 = null; };
                form2.Show();
            }
        }
        /// <summary>
        /// 搜索串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            string[] str = SerialPort.GetPortNames();
            if (str.Length != 0)
            {
                comboBox3.Items.Clear();
                for (int i = 0; i < str.Length; i++)
                {
                    comboBox3.Items.Add(str[i]);
                }
                comboBox3.Text = str[0];
            }
            else
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("无可用端口！ ！", "错误");
            }
        }
        /// <summary>
        /// 打开串口事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                try
                {
                    mySerialPort.PortName = comboBox3.Text;
                    mySerialPort.BaudRate = int.Parse(comboBox2.Text);
                    mySerialPort.Open();
                    button5.Enabled = false;
                    button6.Enabled = true;
                    button3.Enabled = false;
                }
                catch
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    MessageBox.Show("无可用端口！！", "错误");
                }
            }
            else
            {
                MessageBox.Show("请先退出编辑框");
            }
        }
        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            if (mySerialPort.IsOpen)
            {
                while (listening) Application.DoEvents();//等待事件的完成
                mySerialPort.Close();
            }
            button3.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = false;
        }
        /// <summary>
        /// 串口接收事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        string num;//用于记录转换完成的学号
        private void receive_Data(object sender, SerialDataReceivedEventArgs e)
        {
            listening = true;
            int buffData = mySerialPort.BytesToRead;//得到缓存区的字节数
            char[] saveData = new char[buffData];
            mySerialPort.Read(saveData, 0, buffData);//将缓存区的数据全部取出来
            num = new string(saveData);//将数据转换为字符串
            sendFormSerial(radioButton1.Checked);//查询模式
            listening = false;
        }
        /// <summary>
        /// 用于串口转换完成发送消息
        /// </summary>
        void sendFormSerial(bool flag)
        {
            if (serialOver != null)
            {
                serialOver(flag);
            }
        }
        /// <summary>
        /// 串口转换完成进行数据处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dealSerial(bool flag)
        {
            Action action;
            if (flag)
            {
                action = () =>
                {
                    if (comboBox1.Text != "")
                    {
                        using (SqlCeConnection conn = new SqlCeConnection(dataPath))
                        {
                            conn.Open();
                            using (SqlCeCommand comm = new SqlCeCommand($"UPDATE {comboBox1.Text} SET 状态 =1 WHERE 卡号 = '{num}'", conn))
                            {
                                if (comm.ExecuteNonQuery() == 1)//执行sql语句
                                {
                                    textBox1.AppendText(":签到成功\n");
                                }
                                else
                                {
                                    textBox1.AppendText("查无此人\n");
                                }
                            }
                        }
                    }
                    else
                    {
                        textBox1.AppendText("无可查询表格!!!!\n");
                    }
                };
            }
            else
            {
                action = () => { textBox2.Text = num; };
            }
            // Action action = () => { textBox1.AppendText(num); };
            try
            {
                this.Invoke(action);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 注册卡号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != "" & textBox3.Text != "" & comboBox1.Text != "" & textBox4.Text != "")
                {
                    using (SqlCeConnection conn = new SqlCeConnection(dataPath))
                    {
                        conn.Open();
                        string Scomm = $"INSERT INTO {comboBox1.Text} VALUES ('{textBox3.Text}','{textBox4.Text}','{textBox2.Text}','{0}')";
                        using (SqlCeCommand comm = new SqlCeCommand(Scomm, conn))
                        {
                            comm.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("注册成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox4.Enabled = false;
            }
            else
            {
                groupBox4.Enabled = true;
            }
        }
    }
}