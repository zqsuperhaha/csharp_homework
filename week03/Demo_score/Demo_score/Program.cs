using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_score
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = 78, csharp = 90, java = 63;
            double avgscore = (c + csharp + java) / 3;
            Console.WriteLine("------------------------------");
            Console.WriteLine("课程\tC\tC#\tJAVA");
            Console.WriteLine("成绩\t{0}\t{1}\t{2}",c,csharp,java);
            Console.WriteLine("------------------------------");
            Console.WriteLine("C#与JAVA的分数差为:{0}", Math.Abs(csharp-java));
            Console.WriteLine("三门课程的平均分为:"+avgscore+"\n");
           
        }
    }
}
