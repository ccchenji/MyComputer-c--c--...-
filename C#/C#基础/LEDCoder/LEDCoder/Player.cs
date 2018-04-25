using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEDCoder
{
    public partial class Player : UserControl
    {
        public Player()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);//开启双缓冲
            this.SetStyle(ControlStyles.UserPaint, true);
            this.UpdateStyles();
            InitializeComponent();
        }
        public Point NowLocation { get => nowLocation; set => nowLocation = value; }
        public bool[,] Map { get => map; set => map = value; }
        public Point P { get => p; set => p = value; }

        bool bMouseDown = false;
        private bool[,] map = new bool[8, 8];
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            bMouseDown = true;
                NowLocation = new Point(P.X / 40, P.Y / 40);
                if (e.Button == MouseButtons.Left)
                    Map[P.X / 40, P.Y / 40] = true;
                else
                    Map[P.X / 40, P.Y / 40] = false;
                pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            bMouseDown = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            bMouseDown = false;
        }
        Rectangle rect;
        Point p;
        Point nowLocation;
        Size rectSize = new Size(38, 38);

        
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > 0 && e.X < 320 && e.Y > 0 && e.Y < 320)
                P = new Point(e.X, e.Y);
            if (bMouseDown && (NowLocation.X != P.X / 40 || NowLocation.Y != P.Y / 40))
            {
                NowLocation = new Point(P.X / 40, P.Y / 40);
                if (e.Button == MouseButtons.Left)
                    Map[P.X / 40, P.Y / 40] = true;
                else
                    Map[P.X / 40, P.Y / 40] = false;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    P = new Point(i * 40 + 1, j * 40 + 1);
                    rect = new Rectangle(P, rectSize);
                    if (Map[i, j])
                    {
                        e.Graphics.FillRectangle(Brushes.Red, rect);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(Brushes.Black, rect);
                    }
                }
            }
        }

        private void Player_Load(object sender, EventArgs e)
        {
            this.Size = new Size(326, 344);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
