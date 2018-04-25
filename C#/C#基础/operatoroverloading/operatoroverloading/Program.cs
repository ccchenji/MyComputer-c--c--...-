using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatoroverloading
{
	 class box
	{
		private double Height;//高度
		private double Breadth;//宽度
		private double Length;//长度

		public double getVolume()
		{
			return Height * Breadth * Length;
		}
		public void setHeight(double Hei)
		{
			Height = Hei;
		}
		public void setLength(double Len)
		{
			Length = Len;
		}
		public void setBreadth(double Bre)
		{
			Breadth = Bre;
		}
		//重载运算符把两个BOX类相加
		public static box operator +(box a, box b)
		{
			box newbox = new box();
			newbox.Length = a.Length + b.Length;
			newbox.Height = a.Height + b.Height;
			newbox.Breadth = a.Breadth + b.Breadth;
			return newbox;
		}
		public static box operator ++(box a)
		{
			box newbox = new box();
			newbox.Height = a.Height++;
			newbox.Length = a.Length++;
			newbox.Breadth = a.Breadth++;
			return newbox;
		}

        public static box operator -(box a)
        {
            box b = new box();
            b.Height = -a.Height;
            b.Length = -a.Length;
            b.Breadth = -a.Breadth;
            return b;
        }

	}
	class Program
	{
		static void Main(string[] args)
		{
			int[] arry = new int[] { 0,1,2,3,4,5,6};
			double volume = 0.0;

			box box1 = new box();
			box box2 = new box();
			box box3 = new box();
			box1.setHeight(2.0);
			box1.setLength(3.0);
			box1.setBreadth(4.0);


			box2.setBreadth(5.0);
			box2.setHeight(6.0);
			box2.setLength(7.0);


		    //盒子一的体积
			volume = box1.getVolume();
			Console.WriteLine("box1的体积： {0}",volume);

			//盒子二的体积

			volume = box2.getVolume();
			Console.WriteLine("box2的体积： {0}",volume);

            box3 = -box1;
			volume = box3.getVolume();

			Console.WriteLine("box3的体积： {0}",volume);

			foreach (int element in arry)
			{
				Console.WriteLine(element);
			}

			Console.ReadLine();

		}
	}
}
