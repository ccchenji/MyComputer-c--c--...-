using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyPlanTrack
{
    public partial class UserControl1 : UserControl
    {
        private double setAngle = 0;//设定角度
        private double reallAngle = 0;//真实角度
        private event EventHandler AngleChange;
        public bool Round = false;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("无飞行轨迹");
            comboBox1.Items.Add("按照圆形轨迹飞行");
            AllMap(this, new EventArgs());
            AngleChange += new EventHandler(AllMap);
        }
        public double SetAngle
        {
            get
            {
                return setAngle;
            }
            set
            {
                setAngle = value;
                SendMessage();
            }
        }
        public double ReallAngle
        {
            get
            {
                return reallAngle;
            }
            set
            {
                reallAngle = value;
                SendMessage();
            }
        }
        private void SendMessage()
        {
            if (AngleChange != null)
            {
                AngleChange(this, new EventArgs());
            }
        }
        private void AllMap(object sender, EventArgs e)
        {
            Bitmap map = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(map);
            DrawLine(g);
            DrawRectangle(g);
            DrawRound(g);
            DrawPlane(g);
            this.BackgroundImage = map;
        }
        private void DrawRound(Graphics g)//画一个虚线的圆
        {
            Pen pen = new Pen(Color.Black, 1);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            pen.DashPattern = new float[] { 10, 4 };
            g.DrawEllipse(pen, new Rectangle(this.Width / 2 - 60, this.Height / 2 - 60, 120, 120));
        }
        private void DrawPlane(Graphics g)//画整个飞机
        {
            PointF pointfEnd = (PointF)DrawDynamic(reallAngle - 28, 60);//飞机机尾坐标
            PointF pointfStart = (PointF)DrawDynamic(reallAngle, 60);//飞机机头坐标
            Pen pen1 = new Pen(Color.Blue, 3);
            Pen pen2 = new Pen(Color.Blue, 4);
            double angle = Math.Atan((pointfEnd.Y - pointfStart.Y) / (pointfEnd.X - pointfStart.X));//得到飞机飞行时与水平面的夹角
            PointF wingStart = new PointF((float)(pointfStart.X - (pointfStart.X - pointfEnd.X) * 0.28), (float)(pointfStart.Y - (pointfStart.Y - pointfEnd.Y) * 0.28));
            PointF wingEnd = new PointF((float)(pointfStart.X - (pointfStart.X - pointfEnd.X) * 0.8), (float)(pointfStart.Y - (pointfStart.Y - pointfEnd.Y) * 0.8));
            g.DrawLine(pen1, pointfStart, pointfEnd);
            g.DrawLine(pen2, DrawWingUp(wingStart, 15, angle), DrawWingDown(wingStart, 15, angle));
            g.DrawLine(pen2, DrawWingUp(wingEnd, 7, angle), DrawWingDown(wingEnd, 7, angle));
            g.DrawLine(Pens.Black,this.Width/2,this.Height/2,(pointfStart.X+pointfEnd.X)/2,(pointfStart.Y+pointfEnd.Y)/2);
        }
        private PointF DrawWingUp(PointF pointF, int length, double angle)//上机翼的坐标点
        {
            PointF point = new PointF((float)(pointF.X + length * Math.Sin(angle)), (float)(pointF.Y - length * Math.Cos(angle)));
            return point;
        }
        private PointF DrawWingDown(PointF pointF, int length, double angle)
        {
            PointF point = new PointF((float)(pointF.X - length * Math.Sin(angle)), (float)(pointF.Y + length * Math.Cos(angle)));
            return point;
        }
        private void DrawLine(Graphics g)//画线，及旁边的段线
        {
            Point PointCenter = new Point(this.Width / 2, this.Height / 2);//中心位置坐标
            Pen pen = new Pen(Color.Red, 2);
            Point[] point = { DrawSecondDynamic(DrawDynamic(setAngle, 80), setAngle, 16), DrawSecondDynamic(DrawDynamic(setAngle, 75), setAngle, 12), DrawSecondDynamic(DrawDynamic(setAngle, 75), setAngle, 20) };
            g.DrawLine(new Pen(Color.GreenYellow, 4), PointCenter, DrawDynamic(setAngle, 220));//画正向线
            g.DrawLine(new Pen(Color.CadetBlue, 4), PointCenter, DrawDynamic(setAngle + 180, 220));//画反向线
            g.DrawLine(pen, DrawSecondDynamic(DrawDynamic(setAngle, 50), setAngle, 16), DrawSecondDynamic(DrawDynamic(setAngle, 80), setAngle, 16));//画旁边的细线
            Brush brush = new SolidBrush(Color.Red);
            Brush brush1 = new SolidBrush(Color.Green);
            g.FillClosedCurve(brush, point);//画箭头
            if (setAngle >= 190 && setAngle <= 270) g.DrawString(setAngle.ToString(), new Font("宋体", 9), brush1, DrawSecondDynamic(DrawDynamic(setAngle, 80), setAngle, 40));
            else g.DrawString(setAngle.ToString(), new Font("宋体", 9), brush1, DrawSecondDynamic(DrawDynamic(setAngle, 80), setAngle, 29));
        }
        private void DrawRectangle(Graphics g)//画小矩形
        {
            int round = 10;
            Point PC = new Point(this.Width / 2, this.Height / 2);//中心位置坐标
            Point[] point ={new Point(PC.X-round*5/10,PC.Y-round),new Point(PC.X-round,PC.Y),new Point(PC.X-round*5/10,PC.Y+round),
            new Point(PC.X+round*5/10,PC.Y+round),new Point(PC.X+round,PC.Y),new Point(PC.X+round*5/10,PC.Y-round)};
            g.DrawRectangle(new Pen(Color.Red, 2), new Rectangle(this.Width / 2 - round, this.Height / 2 - round, round * 2, round * 2));
            g.DrawLines(new Pen(Color.Red, 2), point);
        }
        private Point DrawDynamic(double Angle, int round)//得到划线的终止坐标
        {
            Point point = new Point((int)(this.Width / 2 + round * Math.Sin(Angle * 3.14 / 180)),
                  (int)(this.Height / 2 - round * Math.Cos(Angle * 3.14 / 180)));
            return point;
        }
        private Point DrawSecondDynamic(Point Set, double Angle, int round)//得到旁边短线的坐标
        {
            Point point = new Point((int)(Set.X + round * Math.Cos(Angle * 3.14 / 180)),
                (int)(Set.Y + round * Math.Sin(Angle * 3.14 / 180)));
            return point;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.Text== "按照圆形轨迹飞行")
            {
                reallAngle += 5;
                SendMessage();
                Round = true;
            }
            else
            {
                Round = false;
            }
        }
    }
}
