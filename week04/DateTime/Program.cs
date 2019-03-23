using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("{0}", dt); // 2019 / 3 / 23 23:53:27
            Console.WriteLine("{0:d}", dt); // 2019/3/23
            Console.WriteLine("{0:D}", dt); // 2019年3月23日
            Console.WriteLine("{0:t}", dt); // 23:53
            Console.WriteLine("{0:T}", dt); // 23:53:05
            Console.WriteLine("{0:f}", dt); // 2019年3月23日 23:53
            Console.WriteLine("{0:F}", dt); // 2019年3月23日 23:53:05
            Console.WriteLine("{0:g}", dt); // 2019/3/23 23:53
            Console.WriteLine("{0:G}", dt); // 2019/3/23 23:53:05
            Console.WriteLine("{0:y}", dt); // 2019年3月
            Console.WriteLine("{0:Y}", dt); // 2019年3月
            Console.WriteLine("{0:m}", dt); // 3月23日
            Console.WriteLine("{0:M}", dt); // 3月23日

            Console.ReadKey();
        }
    }
}
