using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_obj
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            object b = a; // 装箱
            Console.WriteLine("b={0},类型为:{1}",b,b.GetType());
            a = (int)b; // 拆箱
            Console.WriteLine("a= " + a);

        }
    }
}
