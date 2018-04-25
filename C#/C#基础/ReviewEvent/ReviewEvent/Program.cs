using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewEvent
{
    public delegate void MyDelegate(string a);
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = new DateTime();
            Console.WriteLine(DateTime.Now);
            Console.ReadKey();
        }
    }
    public class Person
    {
        public event MyDelegate NameChangeEvent;
        public void OnNameChange()
        {
            if(NameChangeEvent != null)
            {
                NameChangeEvent("新名字:"+name);
            }
        }
        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        public string Name
        {
           get
            {
                return name;
            }
            set
            {
                name = value;
                NameChangeEvent += new MyDelegate(NameChange);
                OnNameChange();
            }
        }
        private void NameChange(string name)
        {
            Console.WriteLine(name);
            Console.WriteLine("事件调用成功");
        }
    }
}
