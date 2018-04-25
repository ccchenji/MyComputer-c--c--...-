using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            myColor c = myColor.Red;
            if (c==myColor.Red)
            {
                Console.WriteLine($"myColor is {c}");
            }
            Console.ReadKey();
        }
    }
    public enum myColor
    {
        Red=0,
        blue=1,
        Green=2
    }
    public struct myPoint
    {
        public int x;
        public int y;
        public myPoint(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
