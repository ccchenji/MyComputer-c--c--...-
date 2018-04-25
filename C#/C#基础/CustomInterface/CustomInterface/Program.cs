using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			Interface1 bark;
			bark = new Dog();
			bark.Bark();
			Console.ReadLine();
		}
	}
	public class Dog : Interface1
	{
		public void Bark()
		{
			Console.WriteLine("汪汪");
		}
	}
	public class Cat : Interface1
	{
		public void Bark()
		{
			Console.WriteLine("喵喵");
		}
		public void fight()
		{
			Console.WriteLine("爪子");
		}
	}
}
