using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mynature
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Student();
            Person s1 = new Student();
            Student s2 = new Student();
            p1.Name = "chen";
            p1.Sex = "man";
            p1.Age = "19";
            s2.Name = "ji";
            //s2 = p1 as Student;//s2.Name 为NULL
            //s2 = p1;  //编译出错
            p1 = s2;//可以使用
            //s2 = (Student)p1;  //编译会通过，但会出现未经处理的异常
            Console.WriteLine(p1.Name);
            Console.ReadKey();
        }
    }
    class Person
    {
      public string Name { set; get; }
      public string Age { set; get; }
      public string Sex { set; get; }
    }
    class Student :Person
    {
        public string Class { set; get; }
    }
}
