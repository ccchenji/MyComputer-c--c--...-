using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
	class Program
	{
		static void Main(string[] args)
		{
			country Country = new country();
			provience Provience1 = new provience("A省");
			provience Provience2 = new provience("B省");
			Country.choice += new EventHandler(Provience1.recivemessage);
			Country.choice += new EventHandler(Provience2.recivemessage);
			Country.release("总统竞选在即");
			Console.ReadKey();
		}
	}
	public class country
	{
		public event EventHandler choice;
		public void release(string message)
		{

				//Console.WriteLine(message);
				choice(this,new EventArgs());
		}
	}
	public class provience 
	{
		string name;
		  public provience(string Name)
		{
			name = Name;
		}
		public void recivemessage(object s,EventArgs e)
		{
			Console.WriteLine(name + "收到");
		}
	}
}
