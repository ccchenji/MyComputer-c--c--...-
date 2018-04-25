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
    public partial class Form6 : Form
    {
        public static Form6 form6;
        public static bool flag = false;
        public int testNum = 0;//测试次数
        public int testnum = 0;//储存测试次数
        public double xorigin;//x轴起始点
        public double xend;//x轴终点
        public double y_axis;
        public int testnum_1 = 0;
        public double xinterval;//x轴间隔
        private event EventHandler DateChange;  //事件委托，实现数据刷新.
        private delegate void MySeries(Series series, string a, string b);  //委托.
        private event MySeries Draw;//定义画表的一个事件
        private Series series;
        public string RealAngle;
        public string num = "10";//计算图表的纵坐标
        private UInt32 flag1 = 0;
        private UInt32 flag2 = 0;
        private double Sum_0 = 0, x = 0;
        private double lastdata = 0, prodata = 0,data=0;
        private int Sum_1 = 0;
        public Form6()
        {
            InitializeComponent();
            form6 = this;
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
        private void Form6_Load(object sender, EventArgs e)
        {
            SendMessage();
            Form1.form1.SignalFre.Text = TestForm.form2.textBox17.Text;
            Form1.form1.PhaseOffset.Text = Convert.ToString(xorigin);
            series = new Series("飞机方位角");  //角度差对象。
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

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
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
            prodata =lastdata ;
            lastdata =data;
            if (Form1.form1.RecDegtextBox.Text != "")
            {
                RealAngle = Form1.form1.RecDegtextBox.Text;//若测量角度非空，则真实角度设置为测量角度。
                data = double.Parse(RealAngle);
            }
            else
                RealAngle = "0";
           
            //if (flag1 == 0)
            //{
            //    num = Math.Abs(int.Parse(RealAngle) - int.Parse(TestForm.form2.textBox19.Text)).ToString();
            //    SendDrawMessage(series, xorigin.ToString(), num.ToString());//获取一定量的数据。
            //}
            //flag1++;
            if ((lastdata == prodata) && (double.Parse(RealAngle) == lastdata)&&(testNum >0)) 
            {
                num = Math.Abs(int.Parse(RealAngle) - (int)(xorigin)).ToString();
                SendDrawMessage(series, xorigin.ToString(), num.ToString());
                xorigin = xorigin + xinterval;
                Form1.form1.PhaseOffset.Text = Convert.ToString(xorigin);
                testNum--;
            }
            else if (testNum == 0)
            {
                //num = Math.Abs(int.Parse(RealAngle) - (int)(xorigin)).ToString();
                //SendDrawMessage(series, xend.ToString(), num.ToString());//获取一定量的数据。
                timer1.Enabled = false;
                button1.Enabled = true;//获取数据结束，画表完成，使能保存按钮。 }            
            
            }
            //if (testnum_1 > 0)
            //{
            //    Sum_0 = Sum_0 + Math.Pow((int.Parse(RealAngle) - int.Parse(TestForm.form2.textBox19.Text)), 2);
            //    testnum_1 -= 1;
            //}
            //else
            //{
            //    flag2++;
            //    testnum_1 = int.Parse(TestForm.form2.testNum.Text);
            //    Sum_1 = (int)(Math.Sqrt(Sum_0 / testnum_1));
            //    if (Form6.flag == true)
            //    {
            //        num = Math.Abs(int.Parse(RealAngle) - int.Parse(TestForm.form2.textBox19.Text)).ToString();//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。
            //    }
            //    Sum_0 = 0;
            //    if (flag2 >= 5)
            //    {
            //        SendDrawMessage(series, xorigin.ToString(), Sum_1.ToString());//获取一定量的数据。
            //        xorigin = xorigin + xinterval;
            //        Form1.form1.PhaseOffset.Text = Convert.ToString(xorigin);
            //        flag2 = 0;
            //    }

            //}

            //testNum = testNum-1;

            //}
            //else
            //{
            //if (xorigin == xend)
            //{
            //    num = Math.Abs(int.Parse(RealAngle) - int.Parse(TestForm.form2.textBox19.Text)).ToString();
            //    SendDrawMessage(series, xend.ToString(), num.ToString());//获取一定量的数据。
            //    timer1.Enabled = false;
            //    button1.Enabled = true;//获取数据结束，画表完成，使能保存按钮。 }

            //    //}
            //}

        }
    }
}
