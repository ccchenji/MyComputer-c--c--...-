using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyThreadReview
{
    class Program
    {
        private int num = 100;
        static object i = new object();
        private static int tickets = 100;
        static void Main(string[] args)
        {
            CancellationTokenSource token = new CancellationTokenSource();
            Task task = new Task(() => { SaleTicketThread1(token.Token); });
            Task task1 = new Task(() => { SaleTicketThread2(token.Token); });
            task.Start();
            task1.Start();
            Thread.Sleep(1000);
            Console.Read();
        }
        private static void SaleTicketThread1(object e)
        {
            while (true)
            {
                CancellationToken token = (CancellationToken)e;
                if(token.IsCancellationRequested)
                {
                    break;
                }
                lock (i)
                {
                    if (tickets > 0)
                    {
                        Console.WriteLine("线程1出票:" + tickets--);
                        Thread.Sleep(100);
                    }
                    else
                    {
                        Console.WriteLine("票买完了");
                        return;
                    }
                }
            }
        }
        private static void SaleTicketThread2(object e)
        {
            while (true)
            {
                CancellationToken token = (CancellationToken)e;
                if (token.IsCancellationRequested)
                {
                    break;
                }
                lock (i)
                {
                    if (tickets > 0)
                    {
                        Console.WriteLine("线程2出票:" + tickets--);
                        Thread.Sleep(100);
                    }
                    else
                    {
                        Console.WriteLine("票买完了");
                        return;
                    }
                }
            }
        }
        private static void MyThread(object e, int num)
        {
            CancellationToken token = (CancellationToken)e;
            Console.WriteLine("计数开始");
            for (int i = 0; i < num; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("计数终止");
                    return;
                }
                else
                {
                    Console.WriteLine("当前值:{0}", i);
                    Thread.Sleep(100);
                }
            }
        }
    }
}
