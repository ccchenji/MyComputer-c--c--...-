using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoolArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 100;
            bool[] a = new bool[N+1];
            for (int i = 2; i <=N; i++) a[i] = true;
            for(int i = 2;i <N; i++)
            {
                for(int j=i*2;j<=N;j+=i)
                {
                    if(a[i]) a[j] = false;
                }
            }
            for(int i=2; i<=N; i++)
            {
                if(a[i])
                {
                    Console.WriteLine( i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
