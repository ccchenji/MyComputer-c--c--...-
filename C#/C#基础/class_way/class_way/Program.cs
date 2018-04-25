using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_way
{
	class Program
	{
		static void Main(string[] args)
		{
			Person print = new Person();
			print.Print("chen");
			Console.ReadLine();  
			print.Print(18);
			Console.ReadLine();
			print.Print("chen",18);
			Console.ReadLine();
			print.Print(18,"chen");
			Console.ReadLine();
		}
	}
	public class Person
	{
		 public void Print(string name)
		{
			Console.WriteLine(name);
		}
		public void Print(int age)
		{
			Console.WriteLine(age);
		}
		public void Print(string name,int age)
		{
			Console.WriteLine(name);
			Console.WriteLine(age);
		}
		public void Print(int age,string name)
		{
			Console.WriteLine(age);
			Console.WriteLine(name);
		}
	}
}
