using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_math
{
	class Program
	{
		static void Main(string[] args)
		{
			Person name = new Person();
			Point sex = new Point();
			for(int i=1;i<6;i++)
			{
				name[i] = "HC" + i;
			}
			for(int i=1;i<6;i++)
			{
			Console.WriteLine(i+"号\t"+name[i]);
			}
			for(int i=1;i<6;i++)
			{
				string Name = "HC" + i;
				Console.WriteLine(Name+"\t"+name[Name]+"号");
			}
			Console.ReadLine();
		}
	}
	public class Person
	{
		private string name;
		private string [] sex = new string [6];
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
		~Person()
		{
			Console.WriteLine("析构函数被调用");
		}
		public Person ()
		{ 

		}
	 public string this [int index]
		{
			get
			{
				return sex[index];
			}
			set
			{
				sex[index] = value;
			}
		}
	  public uint this [string  name]
		{
			get
			{
				uint index = 1;
				while(sex[index]!=name && index<6)
				{
					index++;
				}
				return index;
			}
			set
			{
				
			}
		}
	}

	public struct Point
	{
		private int x;
		private int y;
		public Point(int x,int y)
		{
			this.x = x;
			this.y = y;
		}
	}
}
