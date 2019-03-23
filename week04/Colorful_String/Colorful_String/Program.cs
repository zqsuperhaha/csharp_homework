using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colorful_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // 字符串 操作
            string str = "我喜欢吃冰淇淋";
            Console.WriteLine(str);
            // 1.增
            string s1 = str.Insert(4,"超级大的");
            Console.WriteLine(s1);

        }
    }
}
