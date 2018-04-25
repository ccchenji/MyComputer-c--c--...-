using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace MyAttribute
{
    class Program
    {
        [Conditional("OK")]
         public static void show()
        {
            Console.WriteLine("chen");
        }
        static void Main(string[] args)
        {
            DateTime chen = new DateTime();
            DateTime ji = new DateTime(2016,12,3,8,5,20);
            TimeSpan xue = new TimeSpan();
            chen = DateTime.Now;
            xue = chen - ji;
            MyAttribute attrs =(MyAttribute) MyAttribute.GetCustomAttribute(typeof(Person),typeof(MyAttribute));
            Console.WriteLine(attrs.Name);
            Console.WriteLine(typeof(Program));
            Console.WriteLine(xue.Hours);
            Console.ReadKey();
        }
    }
    class MyAttribute : System.Attribute
    {
        private string name;
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
        public MyAttribute(string name)
        {
            this.name = name;
        }
    }
    [MyAttribute("chen")]
    class Person
    {
        string name;
        int a = 0;
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
        public void test()
        {
             
        }
    }
}
