using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndClass
{
    class Program
    {
        //迭代算法求一个数的平方根
        public static double sqrt( double a)
        {
            double x = 1.0;
            do
            {
                Console.WriteLine(x + ", " + a / x);
                x = (x + a / x) / 2;
            } while (Math.Abs(x*x-a)/a>1e-6);
            Console.WriteLine(x);
            return x;
        }
        //用递归的方法算一个数阶乘
        public static int fun(int a)
        {
            Console.WriteLine(a);
            if (a==0||a==1)
            {
                return 1;
            }
            else
            {
                return fun(a-1)*a;
            }
        }
        //用递归的方法计算台阶问题
        public static int num(int a)
        {
            if (a == 0 || a == 1) return 1;
            else return num(a - 1) + num(a - 2);
        }
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(num(a));
            Console.Read();
        }
    }
}
