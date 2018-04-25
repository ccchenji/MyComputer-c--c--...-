using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Threading.Tasks;

namespace MyThread
{
    class Program
    {
        static int tickets = 100;
        static object Lock = new object();
        static void Main(string[] args)
        {
            Console.WriteLine("当前线程："+Thread.CurrentThread.ManagedThreadId);
            Action action = test;
            action();
            Console.WriteLine("当前线程：" + Thread.CurrentThread.ManagedThreadId);
            Console.Read();
        }
        private static void test()
        {
            Console.WriteLine("当前支线程:"+Thread.CurrentThread.ManagedThreadId);
        }
        private static void SaleTicketsThread1(object e)
        {
            CancellationToken token = (CancellationToken)e;
            while (true)
            {
                lock (Lock)
                {
                    if(token.IsCancellationRequested)
                    {
                        Console.WriteLine("线程1停止出票");
                        return;
                    }
                    Thread.Sleep(100);
                    if (tickets > 0)
                    {
                        Console.WriteLine("线程1出票" + tickets--);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        private static void SaleTicketThread2(object e)
        {
            CancellationToken token = (CancellationToken)e;
            while(true)
            {
                lock(Lock)
                {
                    if(token.IsCancellationRequested)
                    {
                        Console.WriteLine("线程2停止出票");
                        return;
                    }
                    Thread.Sleep(100);
                    if (tickets > 0)
                    {
                        Console.WriteLine("线程2出票" + tickets--);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
