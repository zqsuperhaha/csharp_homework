using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            long startTime = DateTime.Now.Millisecond; // 获得当前时间的毫秒数
            for(int i = 0; i < 10000; i++)
            {
                s += i;
            }
            long endTime = DateTime.Now.Millisecond;
            long time = endTime - startTime;
            Console.WriteLine("string 消耗的时间为："+time);

            StringBuilder ss = new StringBuilder();
            startTime = DateTime.Now.Millisecond; // 获得当前时间的毫秒数
            for (int i = 0; i < 10000; i++)
            {
                ss.Append(i);
            }
            endTime = DateTime.Now.Millisecond;
            time = endTime - startTime;
            Console.WriteLine("StringBuilder 消耗的时间为：" + time);

            Console.ReadKey();

        }
    }
}
