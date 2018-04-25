using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic n = new System.Dynamic.ExpandoObject();
            n.Name = "chen";
            n.Age = 12;
            n.add = (Func<int>)(()=> { int x = 1;return x + 1; });
            Console.WriteLine(n.Name);
            Console.WriteLine(n.Age);
            int i = n.add();
            Console.WriteLine(i);
            Console.Read();
        }
        private static void LinqQuery(List<int> collection)
        {
            var queruResult = from item in collection
                              where item % 2 == 0
                              select item;
            foreach (var item in queruResult)
            {
                Console.WriteLine(item);
            }
        }
        private static void test(int x, int y = 0, string name = "chen")
        {
            Console.WriteLine("x={0},y={1},name={2}", x, y, name);
        }
    }
}
