using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace anglegusss
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int n=1;n<10000;n++)
            {
                int a = n;
                while (a != 1)
                {
                    Console.WriteLine(" " + a);
                    if (a % 2 == 1)
                    {
                        a = a * 3 + 1;
                    }
                    else
                    {
                        a /= 2;
                    }
                }
                Console.WriteLine(" " + a);
            }
            Console.ReadKey();

        }
    }
}
