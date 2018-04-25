using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace MyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer();
            Console.WriteLine("hhahah");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.Read();
        }
        static void Writer()
        {
            Task task1 = task();
        }
        static Task task()
        {
            return Task.Factory.StartNew(() =>
            {
                string filePath = @"C:\Users\ccchenji\Desktop\name\test.txt";
                using (FileStream fileStream = File.Open(filePath, FileMode.OpenOrCreate))
                {
                    string msg = "cccccccccccc";
                    StreamWriter streamWriter = new StreamWriter(fileStream);
                    streamWriter.Write(msg);
                    streamWriter.Close();
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                }
                for(int i=0;i<10;i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
            });
        }
    }
}
