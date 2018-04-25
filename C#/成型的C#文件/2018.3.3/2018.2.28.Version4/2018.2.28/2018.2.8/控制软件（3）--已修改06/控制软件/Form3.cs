using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace 控制软件
{
    public partial class Form3 : Form
    {
        public static Form3 form3;
        public static bool flag = false;
        public int testNum = 0;//测试次数
        public int testnum = 0;//储存测试次数
        public int xorigin = 0;
      private event EventHandler DateChange;  //事件委托，实现数据刷新.
        private delegate void MySeries(Series series, string a, string b);  //委托.
        private event MySeries Draw;//定义画表的一个事件
        private Series series;
        public string RealAngle;
        public string num = "10";
        public Form3()
        {
            InitializeComponent();
            form3 = this;
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
        private void Form3_Load(object sender, EventArgs e)
        {
            SendMessage();
            Form1.form1.PhaseOffset.Text = TestForm.form2.textBox2.Text;//控制参量画图
            Form1.form1.SignalFre.Text = TestForm.form2.textBox1.Text;
            int a;
            string a1, a2, a3;
            a = (int)((double.Parse(Form1.form1.SignalFre.Text)) * 1000);
            a1 = (a % 256).ToString("X2");//变量定义冲突!!
            a = a / 256;
            a2 = (a % 256).ToString("X2");
            a = a / 256;
            a3 = (a % 256).ToString("X2");
            Form1.form1.Send_text.Text = "10 " + a3 + " " + a2 + " " + a1;
            series = new Series("测角精度");  //角度差对象。

            DateChange += new EventHandler(MyDateChange);//数据更新标志位.MyDateChange为空.
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
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.form2.Mytest.Enabled = true;//page1中测试按钮使能.
            timer1.Enabled = false;
            flag = false;
        }

        private void timer1_Tick(object sender, EventArgs e)  //定时器函数，计算图表纵坐标。
        {
            if (testNum > 0)  //测试次数>=0.
            {
                xorigin += 1;
                if (Form1.form1.RecDegtextBox.Text != "")
                    RealAngle = Form1.form1.RecDegtextBox.Text;//若测量角度非空，则真实角度设置为测量角度。
                else RealAngle = "0";
                if (Form3.flag == true)//
                {

                    num = Math.Abs(int.Parse(RealAngle) - int.Parse(TestForm.form2.textBox2.Text)).ToString();//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。

                }
                SendDrawMessage(series, xorigin.ToString(),num.ToString());
                testNum -= 1;
            }
            else
            {
                timer1.Enabled = false;
                button1.Enabled = true;//获取数据结束，画表完成，使能保存按钮。
            }
        }

        private void button1_Click(object sender, EventArgs e)//保存图表按钮。
        {
            SaveFileDialog open = new SaveFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                chart1.SaveImage(open.FileName, ChartImageFormat.Bmp);//保存图片
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
