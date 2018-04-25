using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
	class Program
	{
		public delegate void transmit(int first, int second);
		public delegate void Greet(string name);
		static void Main(string[] args)
		{
            byte[] c = new byte[3];
            int a = 0;
            string b = "45";
            a =(int) Convert.ToDecimal(b);
            c[0] = (byte)(a >> 1);
            Console.WriteLine(c[0]);
            Console.Read();
		}
		private static void judge(transmit d)
		{
			d(1, 2);
		}
		public static void Greeted(string name, Greet callback)
		{
			callback(name);
		}
	}
	public class add_num
	{
		public void Add(int first,int second)
		{
			int sum = first + second;
			Console.WriteLine(sum);
		}
	}
	public class Greeting
	{
		  public void ChineseGreet(string name)
		{
			Console.WriteLine("你好 "+name);
		}
		public void AmericanGreet(string name)
		{
			Console.WriteLine("Hello "+name);
		}
	}

}
