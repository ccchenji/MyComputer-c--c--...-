using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_grammer
{
	class Program
	{
		static void Main(string[] args)
		{
			Temperature Temp = new Temperature();
			try
			{
				Temp.ShowTemp();
			}
			catch(TempIsZeroException e)
			{
				Console.WriteLine("TempIsZeroException : {0}",e);
			}
			Console.ReadKey();
		}
	}
	public class Temperature
	{
		int temperature = 0;
		public void ShowTemp()
		{
		   if(temperature==0)
			{
				throw (new TempIsZeroException("Zero Temperature found"));
			}
			else
			{
				Console.WriteLine("Temperature: {0}", temperature);
			}
		}
	}

	public class TempIsZeroException : ApplicationException
	{
		public TempIsZeroException(string message) : base(message)
		{

		}
	}
}