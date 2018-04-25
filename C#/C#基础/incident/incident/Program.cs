using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incident
{
	class Program
	{
		static void Main(string[] args)
		{
            Bridegroom bridegroom = new Bridegroom();
            Friend friend1 = new Friend("小明");
            Friend friend2 = new Friend("小华");
            Friend friend3 = new Friend("小李");
            bridegroom.MarryEvent += new Bridegroom.MarryHandler(friend1.sendmessage);
            bridegroom.MarryEvent += new Bridegroom.MarryHandler(friend2.sendmessage);
            bridegroom.MarryEvent += new Bridegroom.MarryHandler(friend3.sendmessage);
            bridegroom.OnMarriagecoming("朋友们我结婚了，到时候一定要来");
            Console.ReadKey();
        }
       
	}
	public class Bridegroom
	{
		public delegate void MarryHandler(string msg);
		public event MarryHandler MarryEvent;
		public void OnMarriagecoming (string msg)
		{
			  if(MarryEvent!=null)
			{
				MarryEvent(msg);
			}
		}
	}
	public class Friend
	{
		public string Name; 
		public Friend(string name)
		{
			Name = name;
		}
		public void sendmessage(string mssage)
		{
			Console.WriteLine(mssage);
			Console.WriteLine(this.Name+"收到了，到时候准时参加");
		}
	}

	public class  text
	{
		public string Name;
		public text(string name)
		{
			Name = name;
		}
		 public void Write()
		{
			Console.WriteLine("Yes");
		}
	}
	public class text2 :text
	{
		 public text2 (string name) : base (name)
		{
			 
		}
	    public void Write2()
		{
			Console.WriteLine("No");
		}
	}
}
