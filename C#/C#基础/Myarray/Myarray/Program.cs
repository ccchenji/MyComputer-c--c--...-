using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Myarray
{
    class Program
    {
        static void Main(string[] args)
        {
            /**************一位数组的遍历和COPY**************/
            //int[] ages = new int[5];
            //int[] dest = new int[4];
            //ages[0] = 0;
            //ages[1] = 1;
            //ages[2] = 2;
            //ages[3] = 3;
            //ages[4] = 4;
            //Array.Copy(ages,0,dest,0,ages.Length-1);
            //foreach (int age in dest)
            //{
            //    Console.WriteLine(age);
            //}
            //Console.ReadKey();
            /***************二维数组的声明***************/
            //int[,] a = new int[3,5];
            //a[2, 0] = 1;
            //foreach(int age in a)
            //{
            //    Console.WriteLine(age);
            //}
            //Console.ReadKey();
            /****************交错数组的定义******************/
            int[][] t = new int[3][];
            t[0] = new int[2];
            t[1] = new int[4];
            t[2] = new int[3];
            t[0][1] = 1;
            Console.WriteLine(t[0][1]);
            Console.ReadKey();
        }
    }
}
