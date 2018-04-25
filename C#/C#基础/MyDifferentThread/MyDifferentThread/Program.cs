using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyDifferentThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = Text();
            Console.WriteLine("运行结果{0}",task.Result);
            Console.ReadKey();
        }
       static async Task<int> Text()
        {
            Console.WriteLine("Run之前的线程ID{0}",Thread.CurrentThread.ManagedThreadId);
            int i = await Task.Run(new Func<int>(()=> { return add(1,2); }));
            return i;
        }
        static int add(int a,int b)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Run后的线程ID{0}",Thread.CurrentThread.ManagedThreadId);
            return a + b;
        }
    }
}
