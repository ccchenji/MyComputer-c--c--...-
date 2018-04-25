using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public delegate void marryHanderler(Object sender, marryMessageArgs e);
public class  marryMessageArgs
{
   private string message;
   public marryMessageArgs(string message)
    {
        this.message = message;
    }
   public string messageGet
    {
        get
        {
            return this.message;
        }
        set
        {
            this.message = value;
        }
    }
}
namespace myEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            LiHua lihua = new LiHua("李华");
            XiaoMing xiaoming = new XiaoMing();
            lihua.messageSend += (sender, e) => { Console.WriteLine(e.messageGet);Console.WriteLine($"好的"); };
            lihua.messageBeSended();
            Console.ReadKey();
        }
    }
    public class LiHua
    {
        private string name;
        public event marryHanderler messageSend;
        public string  Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public  LiHua(string name)
        {
            this.name = name;
        }
        public void messageBeSended()
        {
            if(messageSend!=null)
            {
                messageSend(this,new marryMessageArgs("朋友们我结婚了，到时候一定要来"));
            }
        }
    }
    public class XiaoMing
    {
        public  void receiveMessage(object sender, marryMessageArgs e)
        {
            LiHua lihua =sender as LiHua;
            Console.WriteLine(e.messageGet);
            Console.WriteLine("好的"+lihua.Name+"一定到");
        }
    }
}
