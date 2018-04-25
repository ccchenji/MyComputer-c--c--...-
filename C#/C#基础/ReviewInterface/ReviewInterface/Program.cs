using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReviewInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Me me = new Me();
            He he = new He();
            Use.UseSadPerson(he);
            Console.ReadKey();
        }
    }
    public class Me:HappyPerson
    {
        public void Eating()
        {
            Console.WriteLine("Eating");
        }
        public void Running()
        {
            Console.WriteLine("Running");
        }

        public void Smiling()
        {
            Console.WriteLine("Smiling");
        }

        public void Speaking()
        {
            Console.WriteLine("Speaking");
        }
    }
    public class He : SadPerson
    {
        public void Eating()
        {
            Console.WriteLine("Eating");
        }
        public void Running()
        {
            Console.WriteLine("Running");
        }

        public void Crying()
        {
            Console.WriteLine("Crying");
        }

        public void Speaking()
        {
            Console.WriteLine("Speaking");
        }
    }
    public class Use
    {
        public  static void UsePerson (Person a )
        {
            a.Running();
            a.Speaking();
            a.Eating();
        }
        public static void UseHappyPerson(HappyPerson a)
        {
            a.Smiling();
            a.Running();
            a.Speaking();
            a.Eating();
        }
        public static void UseSadPerson(SadPerson a)
        {
            a.Running();
            a.Speaking();
            a.Eating();
            a.Crying();
        }
    }
}
