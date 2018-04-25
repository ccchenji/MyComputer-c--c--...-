using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dash_board_control
{
    public partial class UserControl1 : UserControl
    {
        private float setangle = 0f;
        private float realangle = 0f;   //实际角度数据接口
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
            drawFrame(gp);
            DrawRuling(gp);
            drawPoint(gp);
            DrawPin(gp);
            drawindex(gp);
            this.BackgroundImage = bmp;
        }
        public UserControl1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);   //消除界面更新时的闪烁
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            Graphics gp = Graphics.FromImage(bmp);
            gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            drawFrame(gp);
            DrawRuling(gp);
            drawPoint(gp);
            DrawPin(gp);
            drawindex(gp);
            this.BackgroundImage = bmp;
            DateCnangeEvent += new EventHandler(DateCnange);
        }
        private void drawFrame(Graphics gp)
        {
            int cerX = 250 / 2 + 25;   //进行坐标变换，此为原区域中心点坐标
            int cerY = 250 / 2 + 25;
            double  kd = 40 / Math.Sin(5 * Math.PI / 180);
            int drad = (int)(realangle - setangle);
            if (drad > 10) drad = 10;
            else if (drad < -10) drad = -10;
            int x = (int)(kd * Math.Sin(10 * Math.PI / 180));
            int x1 = (int)(kd * Math.Sin(drad * Math.PI / 180));
            Pen pen = new Pen(Color.White, 2);
            Rectangle rec = new Rectangle(30, 30, 240, 240);
            Rectangle rec1 = new Rectangle(cerX - x - 4, 146, 8, 8);
            Rectangle rec2 = new Rectangle(cerX - 30 - 4, 146, 8, 8);
            Rectangle rec3 = new Rectangle(cerX + 30 - 4, 146, 8, 8);
            Rectangle rec4 = new Rectangle(x - 4 + cerX, 146, 8, 8);
            gp.DrawEllipse(pen, rec);   //画仪表大圆
            gp.DrawEllipse(new Pen(Color.Purple, 2), rec1); //画仪表拉杆刻度圆
            gp.DrawEllipse(new Pen(Color.Purple, 2), rec2);
            gp.DrawEllipse(new Pen(Color.Purple, 2), rec3);
            gp.DrawEllipse(new Pen(Color.Purple, 2), rec4);
        }
        private void DrawRuling(Graphics gp)   //画刻度
        {
            int cerX = 250 / 2 + 25;   //进行坐标变换，此为原区域中心点坐标
            int cerY = 250 / 2 + 25;
            float start = 0;
            float sweepShot = 0;
            float angle = 0;
            int ex = 0;
            int ey = 0;
            Pen linePen = new Pen(Color.White, 1);
            float span = (float)(360 / 72);
            float sp = 0;
            float sp1 = 0;
            string str = sp.ToString("f0");
            if (realangle > 0 && realangle < 90)
            {
                start = 90 - realangle;
            }
            else if (realangle >= 90 && realangle <= 360)
            {
                start = 450 - realangle;
            }
            for (int i = 0; i < 72; i++)
            {
                angle = start + sweepShot;
                if (angle > 360)
                {
                    angle = angle - 360;
                }
                double rad = (start + sweepShot) / 180.0 * Math.PI;
                float radius = 240 / 2;
                int bx = (int)(cerX + radius * Math.Cos(rad));
                int by = (int)(cerY - radius * Math.Sin(rad));
                if ((sweepShot % 30 == 0) || (sweepShot==0))
                {
                    linePen.Width = 2;     //生成大刻度结束坐标
                    ex = (int)(cerX + (radius - 8) * Math.Cos(rad));
                    ey = (int)(cerY - (radius - 8) * Math.Sin(rad));
                    if (sp == 0)
                    {
                        str = sp.ToString("0N");
                    }
                    else if (sp == 90)
                    {
                        str = sp.ToString("0E");
                    }
                    else if (sp == 180)
                    {
                        str = sp.ToString("0S");
                    }
                    else if (sp == 270)
                    {
                        str = sp.ToString("0W");
                    }
                    else
                        str = sp.ToString("f0");                    //绘制刻度值
                    if (angle < 90 && angle >0)
                    {
                        gp.DrawString(str, new Font("宋体", 9), new SolidBrush(Color.White), new PointF(ex - 14, ey));
                    }
                    else if (angle > 90 && angle < 180)
                    {
                        gp.DrawString(str, new Font("宋体", 9), new SolidBrush(Color.White), new PointF(ex, ey));
                    }
                    else if (angle > 180 && angle < 270)
                    {
                        gp.DrawString(str, new Font("宋体", 9), new SolidBrush(Color.White), new PointF(ex + 2, ey - 10));
                    }
                    else if (angle > 270 && angle < 360)
                    {
                        gp.DrawString(str, new Font("宋体", 9), new SolidBrush(Color.White), new PointF(ex - 18, ey - 12));
                    }
                    else if (angle == 0)
                    {
                        gp.DrawString(str, new Font("宋体", 9), new SolidBrush(Color.White), new PointF(ex - 10, ey - 5));
                    }
                    else if (angle == 90)
                    {
                        gp.DrawString(str, new Font("宋体", 9), new SolidBrush(Color.White), new PointF(ex - 6, ey + 2));
                    }
                    else if (angle == 180)
                    {
                        gp.DrawString(str, new Font("宋体", 9), new SolidBrush(Color.White), new PointF(ex, ey - 5));
                    }
                    else if (angle == 270)
                    {
                        gp.DrawString(str, new Font("宋体", 9), new SolidBrush(Color.White), new PointF(ex - 7, ey - 12));
                    }

                }
                else
                {
                    linePen.Width = 1;    //小刻度结束坐标生成
                    ex = (int)(cerX + (radius - 5) * Math.Cos(rad));
                    ey = (int)(cerY - (radius - 5) * Math.Sin(rad));
                }
                gp.DrawLine(linePen, new Point(bx, by), new Point(ex, ey)); //绘制刻度线
                sp1 += span;
                sp = 360 - sp1;
                sweepShot += 5;
            }

        }
        private void drawPoint(Graphics gp) //画中心点
        {
            Pen p = new Pen(Color.White, 1);
            int tmpWidth = 6;
            int px = 250 / 2 + 25 - tmpWidth;
            gp.DrawEllipse(p, new Rectangle(px, px, 2 * tmpWidth, 2 * tmpWidth));
            gp.FillEllipse(new SolidBrush(Color.White), new Rectangle(px + 2, px + 2, 2 * tmpWidth - 4, 2 * tmpWidth - 4));
        }
        private void DrawPin(Graphics g) //画指针
        {
            int cer = 250 / 2 + 25;
            double rad = (90) * Math.PI / 180;
            double rad1 = 5 * Math.PI / 180;
            float R = 90;
            float dR = 15;
            int dx = (int)(cer + R * Math.Cos(rad));
            int dy = (int)(cer - R * Math.Sin(rad));
            int px = (int)(cer + (R - dR) * Math.Cos(rad - rad1));
            int py = (int)(cer - (R - dR) * Math.Sin(rad - rad1));
            int nx = (int)(cer + (R - dR) * Math.Cos(rad + rad1));
            int ny = (int)(cer - (R - dR) * Math.Sin(rad + rad1));
            Point[] point = new Point[3];
            point[0] = new Point(dx, dy);
            point[1] = new Point(px, py);
            point[2] = new Point(nx, ny);
            g.FillPolygon(new SolidBrush(Color.White), point);



        }

        private void drawindex(Graphics gp)   //画目标方位的标记
        {
            int cerX = 250 / 2 + 25;   //进行坐标变换，此为原区域中心点坐标
            int cerY = 250 / 2 + 25;
            float start = 0;
            float sweepShot = setangle;
            if (realangle >= 0 && realangle < 90)
            {
                start = 90 - realangle;
            }
            else if (realangle >= 90 && realangle <= 360)
            {
                start = 450 - realangle;
            }
            double rad = (start + sweepShot) / 180.0 * Math.PI;
            double rad1 = 5 / 180.0 * Math.PI;
            float radius = 240 / 2;
            int x_1 = (int)(cerX + radius * Math.Cos(rad));
            int y_1 = (int)(cerY - radius * Math.Sin(rad));
            int x_2 = (int)(cerX + (radius + 15) * Math.Cos(rad - rad1));
            int y_2 = (int)(cerY - (radius + 15) * Math.Sin(rad - rad1));
            int x_3 = (int)(cerX + (radius + 15) * Math.Cos(rad + rad1));
            int y_3 = (int)(cerY - (radius + 15) * Math.Sin(rad + rad1));
            Point[] point = new Point[3];
            point[0] = new Point(x_1, y_1);
            point[1] = new Point(x_2, y_2);
            point[2] = new Point(x_3, y_3);
            gp.FillPolygon(new SolidBrush(Color.Purple), point);
        }
    }
}
