using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArrageGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int N = 4; //按钮的行，列数
        Button[,] Buttons = new Button[N,N];
        private void Form1_Load(object sender, EventArgs e)
        {
            //产生所有的按钮
            GenerateAllButtons();
        }
        //按键点击事件处理
        private void button1_Click(object sender, EventArgs e)
        {
            //打乱顺序
            Shuffle();
        }
        void GenerateAllButtons()
        {
            int x0 = 50, y0 = 20, w = 45, d = 50;
            for(int r=0; r<N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    int num = r * N + c;
                    Button btn = new Button();
                    btn.Text = (num + 1).ToString();
                    btn.Top = y0 + r * d;
                    btn.Left = x0 + c * d;
                    btn.Width = w;
                    btn.Height = w;
                    btn.Visible = true;
                    btn.Tag = num;//这个数字用来表示它所在行列的位置

                    //注册事件
                    btn.Click += new EventHandler(Btn_click);
                    Buttons[r, c] = btn;
                    this.Controls.Add(btn);
                }
            }
            Buttons[N - 1, N - 1].Visible = false;
        }
        //打乱顺序
        void Shuffle()
        {
            Random random = new Random();
            for(int i=0;i<100;i++)
            {
                int a = random.Next(N);
                int b = random.Next(N);
                int c = random.Next(N);
                int d = random.Next(N);
                swap(Buttons[a,b],Buttons[c,d]);
            }
        }
        //交换两个按钮
        void swap(Button btna, Button btnb)
        {
            string t = btna.Text;
            btna.Text = btnb.Text;
            btnb.Text = t;
            bool v = btna.Visible;
            btna.Visible = btnb.Visible;
            btnb.Visible = v;
        }
        //按键处理函数
        void Btn_click(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            Button blank = FindHideButton();
            if(IsNeighbor(btn,blank))
            {
                swap(btn,blank);
                blank.Focus();
            }
            if(ResultIsOk())
            {
                MessageBox.Show("OK");
            }
        }
        //查找隐藏按钮
        Button FindHideButton()
        {
            for(int i=0; i<N; i++)
            {
              for(int j=0;j<N;j++)
                {
                    if(!Buttons[i,j].Visible)
                    {
                        return Buttons[i,j];
                    }
                }
            }
            return null;
        }
    //判断是否相邻
     bool IsNeighbor(Button btna,Button btnb)
        {
            int a =(int)btna.Tag;
            int b = (int)btnb.Tag;
            int r1 = a / N, c1 = a % N;
            int r2 = b / N, c2 = b % N;
            if(r1==r2&&(c1==c2-1||c1==c2+1)||c1==c2&&(r1==r2-1||r1==r2+1))
            {
                return true;
            }
            return false;
        }
        //判断是否完成
        bool ResultIsOk()
        {
            for(int r=0; r<N; r++)
            {
                for(int c=0; c<N; c++)
                {
                    if(Buttons[r,c].Text!=(r * N + c + 1).ToString())
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
