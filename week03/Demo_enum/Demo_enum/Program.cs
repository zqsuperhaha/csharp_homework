using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_enum
{
    class Program
    {
        public enum WEEK
        {
            Monday,
            Tuesday,
            Wednesday=5,
            Thursday,
            Friday,
            Saturday=10,
            Sunday
        }

        private WEEK _week;
        public WEEK Week
        {
            get { return _week; }
            set 
            {
                if (value == WEEK.Wednesday)
                {
                    _week = WEEK.Saturday;
                }
                else
                {
                    _week = value;
                }
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Week = WEEK.Monday;  // 赋值-1
            Console.WriteLine("今天是星期几？:"+p.Week);
            p.Week = WEEK.Wednesday; // 赋值-2
            Console.WriteLine("周末第一天是星期几？:{0},号码是：{1}",p.Week,(int)p.Week);

        }
    }
}
