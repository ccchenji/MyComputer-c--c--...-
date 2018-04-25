using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyVR
{
    public partial class UserControl1 : UserControl
    {
        private double ReallAngle = 0;//真实角度
        private double SetAngle = 0;//设定角度
        private double TFDate = 1; //向背台的常数设定
        private double SkewingDate = 1;//偏移常数的设定
        private double if_Amp = 0;//中频幅度
        private event EventHandler ChangeAngle;//定义事件
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            AllDrawMessage(this, new EventArgs());
            ChangeAngle += new EventHandler(AllDrawMessage);//事件处理
        }
        private void SendReallAgnel()//事件的发出者
        {
            if (ChangeAngle != null)
            {
                ChangeAngle(this, new EventArgs());
            }
        }
        public double IF_Amp
        {
            get
            {
                return if_Amp;
            }
            set
            {
                if_Amp = value;
                SendReallAgnel();
            }
        }
        public double reallAngel  //设定真实角度的值
        {
            get
            {
                return ReallAngle;
            }
            set
            {
                ReallAngle = value;
                SendReallAgnel();
            }
        }
        public double setAngle//设定角度
        {
            get
            {
                return SetAngle;
            }
            set
            {
                SetAngle = value;
                SendReallAgnel();
            }
        }
        public double tfDate//向背台常数的设定
        {
            get
            {
                return TFDate;
            }
            set
            {
                TFDate = value;
                SendReallAgnel();
            }
        }
        public double skewingDate //偏移角度常数的设定
        {
            get
            {
                return SkewingDate;
            }
            set
            {
                SkewingDate = value;
                SendReallAgnel();
            }
        }
        private void AllDrawMessage(object s, EventArgs e)
        {
            label1.Text = "角度差：" + Math.Abs(SetAngle - ReallAngle).ToString();
            label2.Text = "R:" + ReallAngle.ToString();
            label3.Text = "S:" + SetAngle.ToString();
            Bitmap map = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(map);
            DrawRound(g);
            DrawRoundLine(g);
            DrawPointer(g);
            DrawSmallRound(g);
            DrawTF(g);
            MyFlag(g);
            this.BackgroundImage = map;
        }
        private int ChangeY(int Y)//Y轴坐标的坐标变换
        {
            Y = this.Height - Y;
            return Y;
        }
        private void DrawRound(Graphics g)//画大圆,以及虚线的圆,画小飞机，以及固定的指针
        {
            Pen Mypen = new Pen(Color.White, 1);
            Mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            Mypen.DashPattern = new float[] { 10f, 4f };
            //画实线的圆
            g.DrawEllipse(Pens.White, new Rectangle((this.Width - 240) / 2, (this.Height - 240) / 2, 240, 240));
            //画虚线的小圆
            g.DrawEllipse(Mypen, new Rectangle(this.Width / 2 - 60, this.Height / 2 - 60, 120, 120));
            //画小飞机
            g.DrawLine(new Pen(Color.Yellow, 3), this.Width / 2, this.Height / 2, this.Width / 2, this.Height / 2 - 8);
            g.DrawLine(new Pen(Color.Yellow, 4), this.Width / 2, this.Height / 2, this.Width / 2 - 12, this.Height / 2);
            g.DrawLine(new Pen(Color.Yellow, 4), this.Width / 2, this.Height / 2, this.Width / 2 + 12, this.Height / 2);
            g.DrawLine(new Pen(Color.Yellow, (float)2.5), this.Width / 2, this.Height / 2, this.Width / 2, this.Height / 2 + 14);
            g.DrawLine(new Pen(Color.Yellow, 4), this.Width / 2 - 5, this.Height / 2 + 10, this.Width / 2 + 6, this.Height / 2 + 10);
            //画固定的指针
            g.DrawLine(new Pen(Color.Yellow, 2), this.Width / 2, this.Height / 2 - 135, this.Width / 2, this.Height / 2 - 150);
            g.DrawLine(new Pen(Color.Red, 2), this.Width / 2, this.Height / 2 - 135, this.Width / 2 - 5, this.Height / 2 - 140);
            g.DrawLine(new Pen(Color.Red, 2), this.Width / 2, this.Height / 2 - 135, this.Width / 2 + 5, this.Height / 2 - 140);
        }
        private void DrawRoundLine(Graphics g)//画刻度，及数字
        {
            double Angle = 0;
            double ReallR = 0;//刻度的位置值
            double ReallN = 0;//数字的实际位置的值
            double ChangeAngle = 0;//将角度进行变换
            string Num = "0";//数字的实际值
            for (int i = 0; i < 72; i++)
            {
                //画刻度
                if (Angle % 90 == 0) ReallR = 130.0; else if (Angle % 6 == 0) ReallR = 126.0; else ReallR = 123.0;
                g.DrawLine(Pens.White, (float)(this.Width / 2 + 120.0 * Math.Sin((Angle - ReallAngle) * 3.14 / 180)), (float)(this.Height / 2 - 120.0 * Math.Cos((Angle - ReallAngle) * 3.14 / 180)),
             (float)(this.Width / 2 + ReallR * Math.Sin((Angle - ReallAngle) * 3.14 / 180)), (float)(this.Height / 2 - ReallR * Math.Cos((Angle - ReallAngle) * 3.14 / 180)));
                //画数字
                if (Angle % 6 == 0)
                {
                    //确定数字的值
                    if (Angle == 0) { Num = Angle.ToString() + "N"; }
                    else if (Angle > 0 && Angle < 180) { if (Angle == 90) Num = Angle.ToString() + "E"; else Num = Angle.ToString(); }
                    else if (Angle == 180) { Num = Angle.ToString() + "S"; }
                    else if (Angle > 180 && Angle < 270) { Num = Angle.ToString(); }
                    else if (Angle == 270) { Num = Angle.ToString() + "W"; }
                    else { Num = Angle.ToString(); }
                    //确定数字的位置做标
                    if (Angle - ReallAngle < 0) ChangeAngle = Angle - ReallAngle + 360; else ChangeAngle = Angle - ReallAngle;
                    if (ChangeAngle == 0 || ChangeAngle == 180) ReallN = 132.0;
                    else if (ChangeAngle > 0 && ChangeAngle < 180) ReallN = 130.0;
                    else if (ChangeAngle > 180 && ChangeAngle < 270) ReallN = 135.0;
                    else if (ChangeAngle == 270) ReallN = 147.0;
                    else ReallN = 142.0;
                    g.DrawString(Num, new Font("宋体", 9), new SolidBrush(Color.White),
             (float)(this.Width / 2 + ReallN * Math.Sin((Angle - ReallAngle) * 3.14 / 180)), (float)(this.Height / 2 - ReallN * Math.Cos((Angle - ReallAngle) * 3.14 / 180)));
                }
                Angle += 5;
            }
        }
        private void DrawPointer(Graphics g)//画指针
        {
            //画小指针
            Pen pen = new Pen(Color.SkyBlue, 2);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            pen.DashPattern = new float[] { 40f, 40f };
            g.DrawLine(pen, (float)(this.Width / 2 + 120 * Math.Sin((SetAngle - ReallAngle) * 3.14 / 180)), (float)(this.Height / 2 - 120 * Math.Cos((SetAngle - ReallAngle) * 3.14 / 180)),
                (float)(this.Width / 2 + 120 * Math.Sin((SetAngle - ReallAngle + 180) * 3.14 / 180)), (float)(this.Height / 2 - 120 * Math.Cos((SetAngle - ReallAngle + 180) * 3.14 / 180)));
        }
        private void DrawSmallRound(Graphics g)//画动态的小圆，以及指示
        {
            float a = (float)(60 * Math.Cos((SetAngle - ReallAngle) * 3.14 / 180));
            float b = (float)(60 * Math.Sin((SetAngle - ReallAngle) * 3.14 / 180));
            int c = 0;
            int length = 1;
            double Excursion = 0;
            Excursion = SkewingDate * Math.Sin((ReallAngle - SetAngle) * 3.14 / 180);
            g.DrawEllipse(Pens.White, new Rectangle((int)(this.Width / 2 + 55 * Math.Sin((SetAngle - ReallAngle - 90) * 3.14 / 180)), (int)(this.Height / 2 - 55 * Math.Cos((SetAngle - ReallAngle - 90) * 3.14 / 180)), 6, 6));//左一
            g.DrawEllipse(Pens.White, new Rectangle((int)(this.Width / 2 + 25 * Math.Sin((SetAngle - ReallAngle - 90) * 3.14 / 180)), (int)(this.Height / 2 - 25 * Math.Cos((SetAngle - ReallAngle - 90) * 3.14 / 180)), 6, 6));//左二
            g.DrawEllipse(Pens.White, new Rectangle((int)(this.Width / 2 + 55 * Math.Sin((SetAngle - ReallAngle + 90) * 3.14 / 180)), (int)(this.Height / 2 - 55 * Math.Cos((SetAngle - ReallAngle + 90) * 3.14 / 180)), 6, 6));//右一
            g.DrawEllipse(Pens.White, new Rectangle((int)(this.Width / 2 + 25 * Math.Sin((SetAngle - ReallAngle + 90) * 3.14 / 180)), (int)(this.Height / 2 - 25 * Math.Cos((SetAngle - ReallAngle + 90) * 3.14 / 180)), 6, 6));//右二
            if (Excursion > 0) c = -90; else c = 90;
            length = 5 * (int)Math.Abs(SetAngle - ReallAngle);
            if (length > 55) length = 55;
            if (length > 0)
            {
                g.DrawLine(new Pen(Color.SkyBlue, 2), (float)(this.Width / 2 + length * Math.Sin((SetAngle - ReallAngle + c) * 3.14 / 180)) + b, (float)(this.Height / 2 - length * Math.Cos((SetAngle - ReallAngle + c) * 3.14 / 180)) - a,
               (float)(this.Width / 2 + length * Math.Sin((SetAngle - ReallAngle + c) * 3.14 / 180)) - b, (float)(this.Height / 2 - length * Math.Cos((SetAngle - ReallAngle + c) * 3.14 / 180)) + a);
            }
        }
        private void DrawTF(Graphics g)//向背台飞行指示
        {
            double date = 0;
            date = TFDate * Math.Sin((ReallAngle - SetAngle - 90) * 3.14 / 180);
            Brush br1 = new SolidBrush(Color.GreenYellow);
            Brush br2 = new SolidBrush(Color.White);
            if (date > 0)
            {
                g.FillPolygon(br1, new Point[] { new Point(25, 5), new Point(14, 25), new Point(36, 25) });
                g.FillPolygon(br2, new Point[] { new Point(15, 28), new Point(35, 28), new Point(25, 48) });
            }
            if (date < 0)
            {
                g.FillPolygon(br2, new Point[] { new Point(25, 5), new Point(14, 25), new Point(36, 25) });
                g.FillPolygon(br1, new Point[] { new Point(15, 28), new Point(35, 28), new Point(25, 48) });
            }
            if (date == 0)
            {
                g.FillPolygon(br2, new Point[] { new Point(25, 5), new Point(14, 25), new Point(36, 25) });
                g.FillPolygon(br2, new Point[] { new Point(15, 28), new Point(35, 28), new Point(25, 48) });
            }
        }
        private void MyFlag(Graphics g)
        {
            Brush br1 = new SolidBrush(Color.GreenYellow);
            Brush br2 = new SolidBrush(Color.White);
            if (if_Amp != 0)
            {
                g.FillRectangle(br2, new Rectangle(260, 290, 50, 19));
            }
            else
            {
                g.FillRectangle(br1, new Rectangle(260, 290, 50, 19));
            }
            g.DrawString("ALERT", new Font("宋体", 11), new SolidBrush(Color.Red), new PointF(260, 290));
        }
    }
}
