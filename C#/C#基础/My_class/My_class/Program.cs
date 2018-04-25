using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_class
{
	class Program
	{
		static void Main(string[] args)
		{ 
			Person.a = 12;
			Console.WriteLine(Person.a);
			Console.ReadKey();
		}
	}
	  class chen 
	{
		private int a;
		private int b;
		private int c;
        public void Get_a(int a)
		{
			this.a = a;
		}
		public void Get_b(int b)
		{
			this.b = b;
		}
		public void Get_c(int c)
		{
			this.c = c;
		}
		public int Take_abc()
		{
			return this.a*this.b*this.c;
		}
		public static chen operator +(chen chen1, chen chen2)
		{
			chen chen3 = new chen();
			chen3.a = chen1.a + chen2.a;
			chen3.b = chen1.b + chen2.b;
			chen3.c = chen1.c + chen2.c;
			return chen3;
		}
	}
	public class Person
	{
		public static int a = 2;
		public int b=1;
		public const int c = 12;
		public readonly int d;
	    public void Get_a()
		{

		}
	}
}
