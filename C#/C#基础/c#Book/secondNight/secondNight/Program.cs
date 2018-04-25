using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace secondNight
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * //c#中的插值字符串，比+高效的多，用+来连接字符串可能占用大量的内存
             * string first = "123";
             * string second = "45";
             * Console.WriteLine($"chen{second}");
             * Console.ReadKey();
            */

            /*
             * //c#中的double与float是可与取余的
             * double first = 12.3;
             * double second = first % 2;
             * Console.WriteLine(second);
             * Console.ReadKey();
            */

            /*
             * //c#中int,long,decimal,类型是不能除以0的会报错。然而double,float可以表示无穷大的值
             * double first = 5.0;
             * double second = 0.0;
             * if(first/second==4.0/0.0)
             * {
             *  Console.WriteLine(first / second);
             * }
             * Console.ReadKey();
            */

            /*
             * //c#中0.0/0.0等于NaN,这是唯一的 
             * double first = 0.0;
             * double second = 0.0;
             * Console.WriteLine(first/second);
             * Console.ReadKey();
            */

            /*
             * //c#中的var声明的变量必须得赋初值，c#根据处置来判断变量的类型.
             * var chen = "string";
             * Console.WriteLine(chen);
             * Console.ReadKey();
            */
        }
    }
}
