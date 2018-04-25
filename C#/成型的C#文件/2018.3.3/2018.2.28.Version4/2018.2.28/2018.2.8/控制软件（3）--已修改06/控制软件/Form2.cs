using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System. Threading;

namespace 控制软件
{
    public partial class TestForm : Form
    {
        public static TestForm form2;//设置一个静态的Form2
      //  private event EventHandler DateChange; //事件委托数据刷新，控制tabpage1,2.
        /*
        private event EventHandler DateChange3; //事件委托数据刷新控制tabpage3.
        private event EventHandler DateChange4; //事件委托数据刷新控制tabpage4.
        */
        //public string RealAngle = "";  //定义变量真实角度=测量角度.
       // public string RealAngle = Form1 .form1 .RecDegtextBox .Text ;//将测量角度赋给真实角度     
        public string RealAngle;
        public string num = "10" ;//计算图表的纵坐标
        /*
        public static int datachangefla11 = 0;
        public static int datachangefla12 = 0;
        public static int datachangefla13 = 0;
        public static int datachangefla14 = 0;
        */
        public void SendMessage()
        { 
            /* 
            if (DateChange != null)
            {
                DateChange(this, new EventArgs());
            }
         
            if (DateChange3 != null)
            {
                DateChange3(this, new EventArgs());
            }
            if (DateChange4 != null)
            {
                DateChange4(this, new EventArgs());
            }
            */
        }
        public TestForm()
        {
            InitializeComponent();
            form2 = this;//将地址付给form2
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            timer1.Interval = int.Parse(textBox11.Text);//定时器1间隔设置为频率变化间隔。
            timer2.Interval = int.Parse(textBox18.Text); //定时器2间隔设置为角度变换间隔。
            timer1.Enabled = false;
            timer2.Enabled = false;
            
       
           textBox1.Text = "0";//测试频率为0.
           textBox2.Text = "0";//预设角度为0.
            RealAngle = Form1.form1.RecDegtextBox.Text;//此处的实际角度为form1中测量角度。
         //   DateChange += new EventHandler(Date_Change);
            /*
            DateChange3 += new EventHandler(Date_Change3); //控制tabpage3.
            DateChange4 += new EventHandler(Date_Change4);//控制tabpage4.
            */
        }
        private void Date_Change(object sender, EventArgs e)  //数据传递，将数据送到画图页面。//控制tabpage1,2.
        {

           // if (Form1.form1.SignalFre.Text != "") textBox1.Text = Form1.form1.SignalFre.Text;//若工作频率非空，则测试频率设置为工作频率。
          //  if (Form1.form1.PhaseOffset.Text != "") textBox2.Text = Form1.form1.PhaseOffset.Text;//若飞机方位角非空，则预设角度设置为飞机方位角。
            /*
            if (Form1.form1.RecDegtextBox.Text != "") RealAngle = Form1.form1.RecDegtextBox.Text;//若测量角度非空，则真实角度设置为测量角度。

            if (Form3.flag == true)//
            {
                //num = (int)(double.Parse(RealAngle) - double.Parse(textBox2.Text ));//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。
                num = 90;
                Form3.form3.SendMessage();//将角度误差送到form3，以便画图。
               
            }
           
            if (Form4.flag == true)//
            {
                num = (int)(double.Parse(RealAngle) - double.Parse(textBox13.Text));//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。
              
                Form4.form4.SendMessage();//将角度误差送到form4，以便画图。
              
            }
            
            if (Form5.flag == true)//
            {
                num = (int)(double.Parse(RealAngle) - double.Parse(textBox15.Text));//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。
               
                Form5.form5.SendMessage();//将角度误差送到form5，以便画图。
              
            }
            if (Form6.flag == true)//
            {
                num = (int)(double.Parse(RealAngle) - double.Parse(textBox20.Text));//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。
               
                Form6.form6.SendMessage();//将角度误差送到form6，以便画图。
            }
            */

        }
        /*
        private void Date_Change3(object sender, EventArgs e)  //数据传递，将数据送到画图页面。//控制tabpage3.
        {

            if (Form1.form1.SignalFre.Text != "") textBox1.Text = Form1.form1.SignalFre.Text;//若工作频率非空，则测试频率设置为工作频率。
            if (Form1.form1.PhaseOffset.Text != "") textBox2.Text = Form1.form1.PhaseOffset.Text;//若飞机方位角非空，则预设角度设置为飞机方位角。
            if (Form1.form1.RecDegtextBox.Text != "") RealAngle = Form1.form1.RecDegtextBox.Text;//若测量角度非空，则真实角度设置为测量角度。
          
           
            if (Form5.flag == true)//
            {
                num = (int)(double.Parse(RealAngle) - double.Parse(textBox2.Text));//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。

                Form5.form5.SendMessage();//将角度误差送到form5，以便画图。

            }
            if (Form4.flag == true)//
            {
                num = (int)(double.Parse(RealAngle) - double.Parse(textBox2.Text));//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。

                Form4.form4.SendMessage();//将角度误差送到form4，以便画图。

            }
            if (Form3.flag == true)//
            {
                num = (int)(double.Parse(RealAngle) - double.Parse(textBox2.Text));//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。
                Form3.form3.SendMessage();//将角度误差送到form3，以便画图。

            }
            if (Form6.flag == true)//
            {
                num = (int)(double.Parse(RealAngle) - double.Parse(textBox2.Text));//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。

                Form6.form6.SendMessage();//将角度误差送到form6，以便画图。
            }
        }
          */
       /*
        private void Date_Change4(object sender, EventArgs e)  //数据传递，将数据送到画图页面。//控制tabpage4.
        {
            Form1.form1.PhaseOffset.Text = textBox20.Text;//选中方位角设置为飞机方位角。
            if (Form1.form1.SignalFre.Text != "") textBox1.Text = Form1.form1.SignalFre.Text;//若工作频率非空，则测试频率设置为工作频率。
            //if (Form1.form1.PhaseOffset.Text != "") textBox2.Text = Form1.form1.PhaseOffset.Text;//若飞机方位角非空，则预设角度设置为飞机方位角。
            if (Form1.form1.RecDegtextBox.Text != "") RealAngle = Form1.form1.RecDegtextBox.Text;//若测量角度非空，则真实角度设置为测量角度。
            
            if (Form3.flag == true)//
            {
                num = (int)(double.Parse(RealAngle) - double.Parse(textBox2.Text));//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。
                Form3.form3.SendMessage();//将角度误差送到form3，以便画图。

            }
            if (Form4.flag == true)//
            {
                num = (int)(double.Parse(RealAngle) - double.Parse(textBox2.Text));//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。

                Form4.form4.SendMessage();//将角度误差送到form4，以便画图。

            }
            if (Form5.flag == true)//
            {
                num = (int)(double.Parse(RealAngle) - double.Parse(textBox2.Text));//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。

                Form5.form5.SendMessage();//将角度误差送到form5，以便画图。

            }
            if (Form6.flag == true)//
            {
                num = (int)(double.Parse(RealAngle) - double.Parse(textBox2.Text));//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。

                Form6.form6.SendMessage();//将角度误差送到form6，以便画图。
            }


        }
        */
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.form1.button1.Enabled = true;//form1性能测试按钮使能。
        }


        private void testButton_Click(object sender, EventArgs e)//自动测试按钮（测试周期、测试次数）。准备四个图表界面，传递数据。
        {

            //使能四个选项卡测试按钮
            Mytest.Enabled = true;
            BandwidthTest.Enabled = true;
            azimuth.Enabled = true;
            switch(tabControl1.SelectedIndex)
            {
                case 0: Form3.flag = true; Form5.flag = false; Form6.flag = false; break;
                case 1: Form5.flag = false; Form5.flag = true; Form6.flag = false; break;
                case 2: Form6.flag = false;Form5.flag = false; Form6.flag = true; break;

                default: Form3.flag = true; Form5.flag = false; Form6.flag = false; break;
            }
                
            //form3图形设置
           // Form3.flag = true;  //准备form3.
            Form3.form3 = new Form3();
          //  RealAngle = "0";
            try
            {
                Form3.form3.testNum = int.Parse(testNum.Text); //传递到测试次数。
              //  Form3.form3.testnum = int.Parse(testNum.Text);//传递到存储测试次数.
                testButton.Enabled = false;  //点击后灰掉按钮，防止误操作。
            }
            catch
            {
                MessageBox.Show("不符合要求的字符");
            }


            //form5图形设置
          //  Form5.flag = true;  //准备form5.
            Form5.form5 = new Form5();
          //  RealAngle = "0";
            try
            {
                Form5.form5.testNum = (int)((double.Parse(textBox12.Text) - double.Parse(textBox14.Text)) / double.Parse(textBox11.Text)) * int.Parse(testNum.Text); //传递到测试次数。
                Form5.form5.testnum_1 = int.Parse(testNum.Text);
                Form5.form5.xorigin = double.Parse(textBox14.Text);//功率范围起始点为x轴起始点。
                Form5.form5.x_end = double.Parse(textBox12.Text);//功率范围起始点为x轴终点。
                Form5.form5.xinterval = double.Parse(textBox11.Text);//功率间隔为x轴间隔。
                testButton.Enabled = false;  //点击后灰掉按钮，防止误操作。
            }
            catch
            {
                MessageBox.Show("不符合要求的字符");
            }
            //form6图形设置
           // Form6.flag = true;  //准备form6.
            Form6.form6 = new Form6();
           // RealAngle = "0";
            try
            {
                Form6.form6.testNum = (int)((double.Parse(textBox19.Text) - double.Parse(textBox20.Text)) / double.Parse(textBox18.Text))+1; //传递到测试次数。
                Form6.form6.testnum_1 = int.Parse(testNum.Text);
                Form6.form6.xorigin = double.Parse(textBox20.Text);//角度范围起始点为x轴起始点。
                Form6.form6.xend = double.Parse(textBox12.Text);//角度范围起始点为x轴终点。
                Form6.form6.xinterval = double.Parse(textBox18.Text);//角度间隔为x轴间隔。
                testButton.Enabled = false;  //点击后灰掉按钮，防止误操作。
            }
            catch
            {
                MessageBox.Show("不符合要求的字符");
            }

            //**********************************************
            //if (Form1.form1.RecDegtextBox.Text != "")
            //    RealAngle = Form1.form1.RecDegtextBox.Text;//若测量角度非空，则真实角度设置为测量角度。
            //else RealAngle = "0";

            //if (Form3.flag == true)//
            //{ 
            //    num = Math.Abs(int.Parse(RealAngle) - int.Parse(textBox2.Text)).ToString();//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。
            //}

            //if (Form4.flag == true)//
            //{
            //    num = Math.Abs(int.Parse(RealAngle) - int.Parse(textBox13.Text)).ToString();//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。
            //}

            //if (Form5.flag == true)//
            //{
            //    num = Math.Abs(int.Parse(RealAngle) - int.Parse(textBox15.Text)).ToString();//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。
            //}

            //if (Form6.flag == true)//
            //{
            //   // num  = (int.Parse(RealAngle) - int.Parse(textBox20.Text)).ToString ();//真实角度-预设角度=角度误差(num)。本质是测量角度-预设角度=角度误差。
            //    //num = (int.Parse(RealAngle) -Form3 .form3.xorigin).ToString();
            //    //Form6.form6.SendMessage();//将角度误差送到form6，以便画图。
            //}
            

        }
           

       private void Mytest_Click(object sender, EventArgs e) //测角精度，测试按钮，调出form3  
       {
           
           if (Form3.flag == true)  //已经准备好开启form3
            {
                try
                {
                    if (int.Parse(testCycle.Text) > 0)
                    {
                        Form3.form3.timer1.Enabled = true; //form3定时器使能。
                        Form3.form3.timer1.Interval = int.Parse(testCycle.Text); //form3定时器间隔为测试周期，每周期采一个点，画图。
                    }
                    Form3.form3.Show();  //显示form3.
                    Mytest.Enabled = false; //尚未准备好未点击自动测试按钮，灰掉测试按钮
                }
                catch
                {
                    MessageBox.Show("不符合要求的字符");
                }
            }
            testButton.Enabled = true; //使能自动测试按钮.
            BandwidthTest.Enabled = false;
            azimuth.Enabled = false;
        }

        private void BandwidthTest_Click(object sender, EventArgs e)//带宽测试，测试按钮，调出form5
        {
            if (Form5.flag == true)  //已经准备好开启form3
            {
                try
                {
                    if (int.Parse(testCycle.Text) > 0)
                    {
                        Form5.form5.timer1.Enabled = true; //form3定时器使能。
                        Form5.form5.timer1.Interval = int.Parse(testCycle.Text); //form3定时器间隔为测试周期，每周期采一个点，画图。
                    }
                    Form5.form5.Show();  //显示form5.
                    BandwidthTest.Enabled = false; //尚未准备好未点击自动测试按钮，灰掉测试按钮
                }
                catch
                {
                    MessageBox.Show("不符合要求的字符");
                }
            }
            testButton.Enabled = true; //使能自动测试按钮.     
            Mytest.Enabled = true;
            azimuth.Enabled = false;
        }

        private void azimuth_Click(object sender, EventArgs e)//方位角测试，测试按钮，调出form6
        {
            if (Form6.flag == true)  //已经准备好开启form3
            {
                try
                {
                    if (int.Parse(testCycle.Text) > 0)
                    {
                        Form6.form6.timer1.Enabled = true; //form3定时器使能。
                        Form6.form6.timer1.Interval = int.Parse(testCycle.Text); //form3定时器间隔为测试周期，每周期采一个点，画图。
                    }
                    Form6.form6.Show();  //显示form4.
                    azimuth.Enabled = false; //尚未准备好未点击自动测试按钮，灰掉测试按钮
                }
                catch
                {
                    MessageBox.Show("不符合要求的字符");
                }
            }
            testButton.Enabled = true; //使能自动测试按钮.
        
            Mytest.Enabled = true;
            BandwidthTest.Enabled = false;
          
        }

     
//控制频率在一定范围内以一定间隔改变的时钟.
      
//控制角度在一定范围内以一定间隔改变的时钟。
      

        private void 测角精度_Click(object sender, EventArgs e)//测角精度选项卡
        {
            //横轴为测试次数，纵轴为角度误差。
            //显示频率，角度，功率
         
          //  Form1.form1.SignalFre.Text = textBox14.Text;//选中频率设置为工作频率。
            //Form1.form1.PhaseOffset.Text = textBox20.Text;//选中方位角设置为飞机方位角。
            /*
            datachangefla11 = 1;
            datachangefla12 = 0;
            datachangefla13 = 0;
            datachangefla14 = 0;
          */
        }

        private void 灵敏度_Click(object sender, EventArgs e)//灵敏度选项卡
        {
            //横轴为功率变化，纵轴为角度误差，每个功率测一个点。
            //设置功率
            //显示频率，角度、功率
           
            /*
         datachangefla11 = 0;
         datachangefla12 = 1;
         datachangefla13 = 0;
         datachangefla14 = 0;*/
        }

        private void 接收机带宽_Click(object sender, EventArgs e)//接收机带宽选项卡
        {
            //横轴为频率点，纵轴为角度误差，每个频率测一个点
            //设置频率
            //显示功率、角度
           
            //Form1.form1.SignalFre.Text  = textBox14.Text;//选中频率设置为工作频率。
            /*
            datachangefla11 = 0;
            datachangefla12 = 0;
            datachangefla13 = 1;
            datachangefla14 = 0;
            */
        }

        private void 飞机方位角_Click(object sender, EventArgs e)//飞机方位角选项卡
        {
            //横轴为角度，纵轴为角度误差。每个角度测一个点。
            //设置角度
            //显示频率、功率
          
           // Form1.form1.PhaseOffset.Text = textBox20.Text;//选中方位角设置为飞机方位角。
           
            /*
            datachangefla11 = 0;
            datachangefla12 = 0;
            datachangefla13 = 1;
            datachangefla14 = 0;
            */
        }
        
        //
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void 灵敏度_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void 测角精度_MouseClick(object sender, MouseEventArgs e)
       {
           
       }
    }
}


