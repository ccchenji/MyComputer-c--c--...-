using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Nature
{
	class Program
	{
		static void Main(string[] args)
		{
			Person name = new Person();
			Person age = new Person();
			Person sex = new Person();
			//try
			//{
			//	age.Age = 130;
			//	Console.WriteLine(age.Age);
			//}
			//catch (ArgumentOutOfRangeException e)
			//{
			//	Console.WriteLine(e);
			//}
			//Console.ReadKey();
			Person.Sex = "chen";
			Console.WriteLine(Person.Sex);
			Console.ReadKey();
		}
	}

	public class Person
	{
		private string name = "chen";
		private int age;
		private static string sex;
		public string Name
		{
		//加private或去掉set代表只写
		get
			{
				return name;
			} 
		//加private或去掉set代表只读
		set
			{
				name = value;
			}
		}
		public int Age
		{
			get
			{
				return age;
			}
			 set
			{
				if(value<0||value>120)
				{
					throw (new ArgumentOutOfRangeException("AgeIntpropery",value,"年龄必须在0—120之间"));
				}
				age = value;
			}
		}

		public static string Sex
		{
			get
			{
				return sex;
			}
			set
			{
				sex = value;
			}
		}

	}
}
