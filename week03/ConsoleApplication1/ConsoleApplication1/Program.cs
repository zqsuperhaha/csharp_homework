using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        private int a, b;
        private static readonly double d = 10;
        private const double c = 9;

        public Program(int a)
        {
            this.a = a;
        }
        public Program(int a,int b):this(3)
        {
           
       
            this.b = 300 +(int)c ;
            Console.WriteLine("c={0}",c);
        }
        static void Main(string[] args)
        {
            //readonly double c =9;
            const int m = 0;
            Program p = new Program(1,2);
            Console.Write("a="+p.a+"b="+p.b);
        }
    }
}
