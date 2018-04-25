using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace myDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Func<double,double> func=new Func<double, double>(person.getTest);
            Func<double, double> fund = new Func<double, double>(person.newTest);
            fund(12);
            func(12);
            Func<double, double> fune = new Func<double, double>(func + fund);
            fune(12);
            Console.ReadKey();
        }
    }
    class Person
    {
        double test = 12;
        public double getTest(double ji)
        {
            double chen = this.test / ji;
            Console.WriteLine(chen);
            return this.test;
        }
        public double newTest(double a)
        {
            double b = 12;
            b = b + a;
            Console.WriteLine(b);
            return b;   
        }
    }
}
