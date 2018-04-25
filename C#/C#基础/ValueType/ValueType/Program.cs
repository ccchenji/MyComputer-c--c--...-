using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            float date = 123.4f;
            byte[] myByte = BitConverter.GetBytes(date);
            byte[] text = new byte[5];
            Array.Copy(myByte,0,text,0,4);
            text[4] = 1;
            float myDate = BitConverter.ToSingle(text, 0);
            Console.Write(myDate);
            Console.ReadKey();
        }
    }
    class Person
    {
        public string name { get { return name; } }
        public string sex { get { return "sex" + sex; }  }
        public string age { get { return "age" + age; }  }
    }
    class Student : Person
    {
        public string Class { get {return  "Class" + Class; }  }
    }
}
