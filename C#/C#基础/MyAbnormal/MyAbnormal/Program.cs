using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAbnormal
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAdd test = new MyAdd();
            test.myAdd(200,200);
            Console.ReadKey();
        }
    }
    public class MyAdd
    {
        public void myAdd(byte a,byte b)
        {
            byte c = 0;
            try
            {
               checked { c = (byte)(a + b); };
                Console.WriteLine(c);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("越界");
                Console.WriteLine(e);
                Console.WriteLine(e.InnerException);
            }
        }
    }
}
