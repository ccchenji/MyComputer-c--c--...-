using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_interface
{
	class Program
	{
		static void Main(string[] args)
		{
            IChineseGreeting chinese = new Speaker();
			chinese.SayHello();
			Console.ReadKey();
		}
	}
	public class Speaker : IAmericanGreeting, IChineseGreeting
	{
		void IAmericanGreeting.SayHello()
		{
			Console.WriteLine("HELLO");
		}
		void IChineseGreeting.SayHello()
		{
			Console.WriteLine("你好");
		}
	}
}
