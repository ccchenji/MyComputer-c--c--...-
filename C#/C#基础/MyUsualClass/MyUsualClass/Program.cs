using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyUsualClass
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder chen = new StringBuilder("xuan");
            StringBuilder ji = new StringBuilder();
            chen = chen.Replace(chen.ToString(),"ji");
            Console.WriteLine(chen);
            Console.ReadKey();
        }
    }
}
