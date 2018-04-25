using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
	class Program
	{
		static void Main(string[] args)
		{
			man Man = new man();
			woman Woman = new woman();
			Woman.voice();
			Console.ReadLine();
		}
	}
	public abstract class Person
	{
		private int[] intarray = new int[10];
		public virtual void voice()
		{
			
			Console.WriteLine("人开始发声"); 
		}
		public int this [int index]
		{
			get 
			{
				return intarray[index];
			}
			set
			{
				intarray[index] = value;
			}
		}
		protected internal virtual void height ()
		{
			Console.WriteLine("人的体重");
		}
	}
	class man :Person
	{
		private string sex = "man";
		public string Sex
		{
			get
			{
				return sex;
			} 
		}
		public sealed override void voice()
		{
			base.voice();
			Console.WriteLine("男人发粗犷的声音");
		}
	}
	class woman :Person
	{
		private string sex = "woman";
		public string Sex
		{
			get
			{
				return sex;
			}
		}
		public sealed override void voice()
		{
			base.voice();
			Console.WriteLine("女人发尖锐的声音");
		}
		protected internal override void height()
		{
			base.height();
		} 
	}
}
