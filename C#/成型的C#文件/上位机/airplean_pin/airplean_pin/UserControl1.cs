using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace airplean_pin
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);   //消除界面更新时的闪烁
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
        private float setangle = 60f;
        private float realangle = 50f;
        public float SetAngle  //设置角度
        {
            get
            {
                return setangle;
            }
            set
            {
                setangle = value;
                OnSendDate();
            }
        }
        public float RealAngle
        {
            get
            {
                return realangle;
            }
            set
            {
                realangle = value;
                OnSendDate();
            }
        }
        public event EventHandler DateCnangeEvent;//定义事件
        public void OnSendDate()//发出事件
        {
            if (DateCnangeEvent != null)
            {
                DateCnangeEvent(this, new EventArgs());//触发事件
            }
        }
        public void DateCnange(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            Graphics gp = Graphics.FromImage(bmp);
            gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            drawPoint(gp);
            drawrect(gp);
            drawsetangle(gp);
            drawrealangle(gp);
            this.BackgroundImage = bmp;
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            Graphics gp = Graphics.FromImage(bmp);
            gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            drawPoint(gp);
            drawrect(gp);
            drawsetangle(gp);
            drawrealangle(gp);
            this.BackgroundImage = bmp;
            //DateCnangeEvent += new EventHandler(DateCnange);
        }
        private void drawPoint(Graphics gp) //画中心点
        {
            Pen p = new Pen(Color.Black, 1);
            int px = 295;
            gp.FillEllipse(new SolidBrush(Color.Black), new Rectangle(px, px, 10, 10));
        }
        private void drawrect(Graphics gp) //画中心点
        {
            Pen p = new Pen(Color.Red, 2);
            int tmpWidth = 20;
            int cx = 300;
            int cy = 300;
            int x_1 = cx - tmpWidth;
            int y_1 = cy;
            int x_2 = cx;
            int y_2 = cy - tmpWidth;
            int x_3 = cx;
            int y_3 = cy + tmpWidth;
            int x_4 = cx + tmpWidth;
            int y_4 = cy;
            gp.DrawLine(p, new Point(x_1, y_1), new Point(x_2, y_2));
            gp.DrawLine(p, new Point(x_1, y_1), new Point(x_3, y_3));
            gp.DrawLine(p, new Point(x_3, y_3), new Point(x_4, y_4));
            gp.DrawLine(p, new Point(x_4, y_4), new Point(x_2, y_2));
        }
        private void drawsetangle(Graphics gp) //画设定方位
        {
            Pen p = new Pen(Color.Green, 6);
            int cx = 300;
            int cy = 300;
            double rad = setangle * Math.PI / 180;
            double drad = 3 * Math.PI / 180;
            double drad1 = 8 * Math.PI / 180;
            if (setangle > 180) drad1 = -drad1;
            string str = setangle.ToString("目标方位0度");
            int ex = (int)(300 + (200) * Math.Cos(rad));
            int ey = (int)(300 - (200) * Math.Sin(rad));
            int ex1 = (int)(300 + (200 + 15) * Math.Cos(rad));
            int ey1 = (int)(300 - (200 + 15) * Math.Sin(rad));
            int ex2 = (int)(300 + (200) * Math.Cos(rad - drad));
            int ey2 = (int)(300 - (200) * Math.Sin(rad - drad));
            int ex3 = (int)(300 + (200) * Math.Cos(rad + drad));
            int ey3 = (int)(300 - (200) * Math.Sin(rad + drad));
            int ex4 = (int)(300 + (200) * Math.Cos(rad - drad1));
            int ey4 = (int)(300 - (200) * Math.Sin(rad - drad1));
            int ex5 = (int)(300 + (200) * Math.Cos(rad - Math.PI));
            int ey5 = (int)(300 - (200) * Math.Sin(rad - Math.PI));
            gp.DrawLine(new Pen (Color.Yellow,2), new Point(cx, cy), new Point(ex5, ey5));
            gp.DrawLine(p, new Point(cx, cy), new Point(ex, ey));
            Brush brushes = new SolidBrush(Color.Green);
            Point[] point = new Point[3];
            point[0] = new Point(ex1, ey1);
            point[1] = new Point(ex2, ey2);
            point[2] = new Point(ex3, ey3);
            gp.FillPolygon(brushes, point);
            gp.DrawString(str, new Font("宋体", 16), new SolidBrush(Color.Black), new PointF(ex4, ey4));
        }
        private void drawrealangle(Graphics gp) //画真实方位
        {
            Pen p = new Pen(Color.Blue, 4);
            int cx = 300;
            int cy = 300;
            int d = 50;
            double rad = (realangle - 180) * Math.PI / 180;
            double drad = 5 * Math.PI / 180;
            double drad1 = 12 * Math.PI / 180;
            double drad2 = 3 * Math.PI / 180;
            int ex = (int)(300 + (200) * Math.Cos(rad));
            int ey = (int)(300 - (200) * Math.Sin(rad));

            int ex1 = (int)(300 + (200 - 10 - d) * Math.Cos(rad));//负责飞机尾翼三角形
            int ey1 = (int)(300 - (200 - 10 - d) * Math.Sin(rad));
            int ex2 = (int)(300 + (200 - d) * Math.Cos(rad - drad));
            int ey2 = (int)(300 - (200 - d) * Math.Sin(rad - drad));
            int ex3 = (int)(300 + (200 - d) * Math.Cos(rad + drad));
            int ey3 = (int)(300 - (200 - d) * Math.Sin(rad + drad));

            int ex4 = (int)(300 + (200 - 20 - d) * Math.Cos(rad - drad1)); //机翼
            int ey4 = (int)(300 - (200 - 20 - d) * Math.Sin(rad - drad1));
            int ex6 = (int)(300 + (200 - 20 - d) * Math.Cos(rad + drad1));
            int ey6 = (int)(300 - (200 - 20 - d) * Math.Sin(rad + drad1));
            int ex7 = (int)(300 + (200 - 35 - d) * Math.Cos(rad - drad2));
            int ey7 = (int)(300 - (200 - 35 - d) * Math.Sin(rad - drad2));
            int ex8 = (int)(300 + (200 - 35 - d) * Math.Cos(rad + drad2));
            int ey8 = (int)(300 - (200 - 35 - d) * Math.Sin(rad + drad2));

            int ex5 = (int)(300 + (200 - 25 - d) * Math.Cos(rad)); //机身
            int ey5 = (int)(300 - (200 - 25 - d) * Math.Sin(rad));
            int ex9 = (int)(300 + (200 - 50 - d) * Math.Cos(rad)); //机头
            int ey9 = (int)(300 - (200 - 50 - d) * Math.Sin(rad));
            int ex10 = (int)(300 + (200 - 15 - d) * Math.Cos(rad));
            int ey10 = (int)(300 - (200 - 15 - d) * Math.Sin(rad));
            gp.DrawLine(p, new Point(cx, cy), new Point(ex, ey));
            gp.DrawLine(new Pen(Color.Black, 10), new Point(ex1, ey1), new Point(ex5, ey5));
            Brush brushes = new SolidBrush(Color.Black);
            Point[] point = new Point[3];
            point[0] = new Point(ex10, ey10);
            point[1] = new Point(ex2, ey2);
            point[2] = new Point(ex3, ey3);
            gp.FillPolygon(brushes, point);
            Point[] point1 = new Point[3];
            point1[0] = new Point(ex4, ey4);
            point1[1] = new Point(ex6, ey6);
            point1[2] = new Point(ex7, ey7);
            gp.FillPolygon(new SolidBrush(Color.Black), point1);
            Point[] point2 = new Point[3];
            point2[0] = new Point(ex7, ey7);
            point2[1] = new Point(ex8, ey8);
            point2[2] = new Point(ex6, ey6);
            gp.FillPolygon(brushes, point2);
            Point[] point3 = new Point[3];
            point3[0] = new Point(ex7, ey7);
            point3[1] = new Point(ex8, ey8);
            point3[2] = new Point(ex9, ey9);
            gp.FillPolygon(brushes, point3);

        }

    }
}
