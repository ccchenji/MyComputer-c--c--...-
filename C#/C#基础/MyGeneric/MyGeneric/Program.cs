using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        private static T max<T>(T a, T b)where T:IComparable<T>
        {
           if(a.CompareTo(b)>0)
            {
                return a;
            }
            return b;
        }
    }
}
