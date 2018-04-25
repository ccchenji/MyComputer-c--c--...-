using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Friends friends = new Friends();
            foreach(object f in friends)
            {
               if(f is Friend)
                {
                    Friend a = f as Friend;
                    Console.WriteLine(a.Name);
                }
            }
            Console.Read();
        }
    }
    public class text
    {

    }
    public class Friend:text
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public Friend(string name)
        {
            this.name = name;
        }
    }
    public class Friends:System.Collections.IEnumerable
    {
        private object[] name;
        public Friends()
        {
            name = new object[] { new Friend("张三"),new chen("李四") };
        }
        public System.Collections.IEnumerator GetEnumerator()//实现迭代器
        {
            for (int index = 0; index < name.Length; index++)
            {
                yield return name[index];
            }
        }
    }
    public class chen: text
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public chen(string name)
        {
            this.name = name;
        }
    }
}
