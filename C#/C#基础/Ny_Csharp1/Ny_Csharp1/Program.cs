using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ny_Csharp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();
			try
			{
				person.Age = 130;
			}
			catch(ArgumentOutOfRangeException)
			{
				person.Age = 130;
			}
			Console.WriteLine(person.Age);
			Console.ReadLine();
		}
	}
	public class Person
	{
		private string name;
		private int age;
		public string Name
		{
			get
			{
				return name;
			}
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
					throw (new ArgumentOutOfRangeException("AgeIntPropery",value,"年龄必须在0-120之间"));
				}
				age = value;
			}
		}
	}
}
