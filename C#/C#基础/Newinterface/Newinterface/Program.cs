using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Newinterface
{
    class Program
    {
            static void m1(Runner r)
            {
                r.run();
            }
            static void m2(swimmer s)
            {
                s.swim();
            }
            static void m3(Animal a)
            {
                a.eat();
            }
            static void m4(Person p)
            {
                p.Speak();
            }
        static void Main(string[] args)
        {
            Person p = new Person();
            Fly f = new Fly();
            m1(f);
            m2(p);
            m3(p);
            m4(p);
            Runner a = new Person();
            a.run();
            Console.ReadKey();
        }
    }
    interface Runner
    {
        void run();
    }
    interface swimmer
    {
        void swim();
    }
   abstract public class Animal
    {
        public abstract void eat();
    }
    class Person : Animal,Runner, swimmer
    {
        public void run()
        {
            Console.WriteLine("run");
        }
        public void swim()
        {
            Console.WriteLine("swim");
        }
        public override void eat()
        {
            Console.WriteLine("eat");
        }
        public void Speak()
        {
            Console.WriteLine("Speak");
        }
    }
    class Fly : Animal, Runner, swimmer
    {
        public void run()
        {
            Console.WriteLine("run1");
        }
        public void swim()
        {
            Console.WriteLine("swim1");
        }
        public override void eat()
        {
            Console.WriteLine("eat1");
        }
        public void Speak()
        {
            Console.WriteLine("Speak1");
        }
    }
}
