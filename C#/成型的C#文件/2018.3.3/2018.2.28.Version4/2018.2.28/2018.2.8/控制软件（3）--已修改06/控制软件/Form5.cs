using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace 控制软件
{
    public partial class Form5 : Form
    {
        public static Form5 form5;
        public static bool flag = false;
        public int testNum = 0;//测试次数
        public int testnum = 0;//储存测试次数
        public double xorigin;//x轴起始点
        public double xinterval;//x轴间隔
        public double x_end;//x轴终点
        private event EventHandler DateChange;  //事件委托，实现数据刷新.
        private delegate void MySeries(Series series, string a, string b);  //委托.
        private event MySeries Draw;//定义画表的一个事件
        private Series series;
        public string RealAngle;
        public string num = "10";//计算图表的纵坐标
        private double  Sum_0 = 0,x=0;
        private int Sum_1 = 0;
        public int testnum_1 = 0;
        private UInt32 flag1 = 0;
        public Form5()
        {
            InitializeComponent();
            form5 = this;
        }
        public void SendMessage()//从form2获得图表纵坐标数据。
        {
            if (DateChange != null)
            {
                DateChange(this, new EventArgs()); //更新数据。
            }
        }
        private void SendDrawMessage(Series series, string a, string b)//获得画图数据
        {
            if (Draw != null)
            {
                Draw(series, a, b); //画图。
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            SendMessage();
            Form1.form1.PhaseOffset.Text = TestForm.form2.textBox15.Text;//控制参量画图
            Form1.form1.SignalFre.Text = Convert.ToString(xorigin);
            series = new Series("接收机带宽");  //角度差对象。
            DateChange += new EventHandler(MyDateChange);//数据更新标志位.
            Draw += new MySeries(MyDrawLine);  //不停的描点划线。
            button1.Enabled = false;  //表未画好前灰掉保存按钮。
        }

        private void MyDateChange(object sender, EventArgs e)
        {

        }

        private void MyDrawLine(Series series, string a, string b)//画图格式设置。
        {
            chart1.Series.Clear();//清空。
            series.ChartType = SeriesChartType.Line;//类型，线型。
            series.Points.AddXY(double.Parse(a), double.Parse(b));//画点。
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;//X轴.
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;//Y轴.
            chart1.Series.Add(series);//描点连线.
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.form2.Mytest.Enabled = true;//page1中测试按钮使能.
            timer1.Enabled = false;
            flag = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog open = new SaveFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                chart1.SaveImage(open.FileName, ChartImageFormat.Bmp);//保存图片
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a;
            string a1, a2, a3;
            if (testNum >=0)  //测试次数>=0.
            {
                if (Form1.form1.RecDegtextBox.Text != "")
                    RealAngle = Form1.form1.RecDegtextBox.Text;//若测量角度非空，则真实角度设置为测量角度。
                else
                    RealAngle = "0";
                if (flag1 == 0)
                {
                    num = Math.Abs(int.Parse(RealAngle) - int.Parse(TestForm.form2.textBox15.Text)).ToString();
                    SendDrawMessage(series, xorigin.ToString(), num.ToString());//获取一定量的数据。
                }
                flag1++;
                if (testnum_1 > 0)
                {
                    Sum_0 = Sum_0 + Math.Pow((int.Parse(RealAngle) - int.Parse(TestForm.form2.textBox15.Text)), 2);
                    testnum_1 -= 1;
                }
                else 
                {
                    testnum_1 = int.Parse(TestForm.form2.testNum.Text);
                    xorigin = xorigin + xinterval;
                    Form1.form1.SignalFre.Text = Convert.ToString(xorigin);

                    a = (int)((double.Parse(Form1.form1.SignalFre.Text)) * 1000);
                    a1 = (a % 256).ToString("X2");//变量定义冲突!!
                    a = a / 256;
                    a2 = (a % 256).ToString("X2");
                    a = a / 256;
                    a3 = (a % 256).ToString("X2");
                    Form1.form1.Send_text.Text = "10 " + a3 + " " + a2 + " " + a1;

                    Sum_1 = (int)(Math.Sqrt(Sum_0/testnum_1));
                    if (Form5.flag == true)
                    {
                        num = Math.Abs(int.Parse(RealAngle) - int.Parse(TestForm.form2.textBox15.Text)).ToString();//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。
                    }
                    Sum_0 = 0;
                    SendDrawMessage(series, xorigin.ToString(), Sum_1.ToString());//获取一定量的数据。
                } 
                testNum -=1;
 
            }
            else
            {
                num = Math.Abs(int.Parse(RealAngle) - int.Parse(TestForm.form2.textBox15.Text)).ToString();
                SendDrawMessage(series, x_end.ToString(), num.ToString());//获取一定量的数据。
                timer1.Enabled = false;
                button1.Enabled = true;//获取数据结束，画表完成，使能保存按钮。
            }
        }

    }
}
