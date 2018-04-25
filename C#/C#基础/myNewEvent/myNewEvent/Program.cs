using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public delegate void MessageHandler(object sender,SendMessage e);
public class SendMessage
{
    private string message;
    public SendMessage(string message)
    {
        this.message = message;
    }
    public string getMessgae
    {
        get
        {
            return message;
        }
        set
        {
            message = value;
        }
    }
}
namespace myNewEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Lihua = new Person("李华");
            Person Xiaoming = new Person("小明");
            Lihua.messageBeSended += Xiaoming.personGetMessage;
            Lihua.personSendMessage("朋友们我要结婚了");
            Console.ReadKey();
        }
    }
    public class Person
    {
        private string name;
        private string message;
        public event MessageHandler messageBeSended;
        public Person(string name)
        {
            this.name = name;
        }
        public string Name
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
        public string getMessage
        {
            get
            {
                return this.message;
            }
        }
        public void personSendMessage(string message)
        {
            this.message = message;
            if(messageBeSended!=null)
            {
                messageBeSended(this,new SendMessage(this.message));
            }
        }
        public void personGetMessage(object sender,SendMessage e)
        {
            Person friend = sender as Person;
            if(friend.name=="李华")
            {
                Console.WriteLine(e.getMessgae);
                Console.WriteLine("知道了");
            }
            else
            {
                Console.WriteLine("你是谁？");
            }
        }
    }
}

