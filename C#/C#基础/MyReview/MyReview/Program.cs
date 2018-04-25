using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程ID:"+Thread.CurrentThread.ManagedThreadId);
            test();
            Console.WriteLine("主线程运行到此");
            Console.Read();
        }
        private async static void test()
        {
            Console.WriteLine("test线程ID:" + Thread.CurrentThread.ManagedThreadId);
            await est1();
            Console.WriteLine("test线程ID:" + Thread.CurrentThread.ManagedThreadId);
        }
        private static Task est1()
        {
            return Task.Run(()=> {
                Console.WriteLine("est1线程ID:" + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10000);
                Console.WriteLine("est1线程完成");
            });
        }
    }
}
