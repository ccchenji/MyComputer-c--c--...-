using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;
using System.Net;

namespace MyThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请先输入下载地址！");
                return;
            }
            textBox2.Text = "下载中.....";
            await task(textBox2.Text.Trim());
        }
        public Task task(string ur1)
        {
            return Task.Run(()=> { DownLoadFileSync(ur1); });
        }
        public void DownLoadFileSync(string url)
        {
            int BufferSize = 2048;
            byte[] BufferRead = new byte[BufferSize];
            string SavePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\dotNetFx 35setup.exe";
            FileStream fileStream = null;
            HttpWebResponse myWebResponse = null;
            if (File.Exists(SavePath))
            {
                File.Delete(SavePath);
            }
            fileStream = new FileStream(SavePath, FileMode.OpenOrCreate);
            try
            {
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
                if (myWebRequest != null)
                {
                    myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                    Stream responseStream = myWebResponse.GetResponseStream();
                    int readSize = responseStream.Read(BufferRead, 0, BufferSize);
                    while (readSize > 0)
                    {
                        fileStream.Write(BufferRead, 0, readSize);
                    }
                    textBox2.Text = "文件下载完成，文件大小wei：" + fileStream.Length + "下载路径为:" + SavePath;
                }
            }
            catch (Exception e)
            {
                Action action = () => { textBox2.Text = "下载过程发生异常，异常信息为：" + e.Message; };
                this.Invoke(action);
            }
            finally
            {
                if (myWebResponse != null)
                {
                    myWebResponse.Close();
                }
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }
    }
}
