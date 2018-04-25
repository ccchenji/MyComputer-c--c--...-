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
    public partial class Form4 : Form
    {
        public static Form4 form4;
        public static bool flag = false;
        public int testNum = 0;//测试次数
        public int testnum = 0;//储存测试次数
        public double  xorigin;//x轴起始点
      //  public double  xinterval;//x轴间隔
        private event EventHandler DateChange;  //事件委托，实现数据刷新.
        private delegate void MySeries(Series series, string a, string b);  //委托.
        private event MySeries Draw;//定义画表的一个事件
        private Series series;
        public string RealAngle;
        public string num = "10";
        public Form4()
        {
            InitializeComponent();
            form4 = this;
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

        private void Form4_Load(object sender, EventArgs e)
        {
            SendMessage();
            Form1.form1.PhaseOffset.Text = TestForm.form2.textBox13.Text;//控制参量画图
            Form1.form1.SignalFre.Text = TestForm.form2.textBox9.Text;

            series = new Series("灵敏度");  //角度差对象。
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

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestForm.form2.Mytest.Enabled = true;//page1中测试按钮使能.
            timer1.Enabled = false;
            flag = false;
        }

      

        private void button1_Click(object sender, EventArgs e)  //保存按钮
        {
            SaveFileDialog open = new SaveFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                chart1.SaveImage(open.FileName, ChartImageFormat.Bmp);//保存图片
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (testNum >= 0)  //测试次数>=0.
            {
                if (Form1.form1.RecDegtextBox.Text != "")
                    RealAngle = Form1.form1.RecDegtextBox.Text;//若测量角度非空，则真实角度设置为测量角度。
                else 
                    RealAngle = "0";
                if (Form4.flag == true)//
                {
                    num = Math.Abs(int.Parse(RealAngle) - int.Parse(TestForm.form2.textBox13.Text)).ToString();//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。
                }
                xorigin +=1;
                SendDrawMessage(series, xorigin.ToString(),num);//获取一定量的数据。              
                testNum -=1;

            }
            else
            {
                timer1.Enabled = false;
                button1.Enabled = true;//获取数据结束，画表完成，使能保存按钮。
            }
        }





    }
}
