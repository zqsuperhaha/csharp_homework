using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. char 值类型  string 特殊的引用类型
            char sex = '女';
            string name1 = "zqsuperhaha";
            string name2 = name1;
            Console.WriteLine("我叫{0},性别:{1},name1={2},name2={3}",name1,sex,name1,name2);
            name2 = "zq";
            Console.WriteLine("name1={0},name2={1}",name1, name2);

            //2. 将 string 与 类 做比较
            Test t1 = new Test();
            Test t2 = t1;
            t2.b = 100;
            Console.WriteLine("t1.a = {0},t1.b = {1}",t1.a,t1.b); //1,100
            Console.WriteLine("t2.a = {0},t2.b = {1}", t2.a, t2.b); //1,100

            //3. 类 中的 装箱、拆箱
            int a1 = 3;
            int a2;
            object b1 = a1;
            object b2 = b1;
            b2 = 4;
            a1 = (int)b1;
            a2 = (int)b2;
            Console.WriteLine("b1={0},b2={1},a1={2},a2={3}",b1,b2,a1,a2); //3,4,3,4 装箱、拆箱 实际上操作的是 值类型

            

            Console.ReadKey();

        }
    }
    class Test
    {
        internal int a = 1;
        internal int b = 2;
    }
}
