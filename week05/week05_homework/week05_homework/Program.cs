using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace week05_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // 测试

            // 1. if...else if  switch...case
            First f = new First();
            f.IfElse();
            f.SwitchCase();

            // 2. 1-100 奇数和，偶数和
            Second s = new Second();
            s.OddEven();

            // 3. 九九乘法表
            Third t = new Third();
            t.JiuJiu();

            // 4.一维数组、二维数的定义、初始化、数组元素的赋值与取数
            Four fo = new Four();
            fo.Arrays();

            // 5.演示ArrayList的用法
            Five fi = new Five();
            fi.ArrayLists();

            // 6.演示HashTable的用法
            Six si = new Six();
            si.HaTa();

            Console.ReadKey();
        }
    }

    // 1. 由用户输入银行的英文简称，使用if ... else if 语句判断并输出银行的中文全称。
    class First
    {
        public void IfElse()
        {
            Console.Write("请输入银行的英文简称：");
            string bankName = Console.ReadLine();
            if (bankName == "ICBC")
            {
                Console.WriteLine("中国工商银行");
            }
            else if (bankName == "CBC")
            {
                Console.WriteLine("中国建设银行");
            }            
            else if (bankName == "ABC")
            {
                Console.WriteLine("中国农业银行");
            }
            else if (bankName == "BOC")
            {
                Console.WriteLine("中国银行");
            }
            else
            {
                Console.WriteLine("银行简称输入有误！");
            }

        }
        public void SwitchCase()
        {
            Console.Write("请输入银行的英文简称：");
            string bankName = Console.ReadLine();
            switch(bankName)
            {
                case "ICBC":
                    Console.WriteLine("中国工商银行");
                    break;
                case "CBC":
                    Console.WriteLine("中国建设银行");
                    break;
                case "ABC":
                    Console.WriteLine("中国农业银行");
                    break;
                case "BOC":
                    Console.WriteLine("中国银行");
                    break;
                default:
                    Console.WriteLine("银行简称输入有误！");
                    break;
            }

        }
    }

    // 2. 设计一个程序计算1~100之间的奇数和、偶数和。
    class Second
    {
        public void OddEven()
        {
            int odds = 0, evens = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds += i;
                }
                else
                {
                    evens += i;
                }
            }
            Console.WriteLine("1-100 奇数和为：{0},偶数和为：{1}",odds,evens);

        }
    }

    // 3. 设计一个程序打印一张九九选乘法表。
    class Third
    {
        public void JiuJiu()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}x{1}={2}\t",j,i,j*i);
                }
                Console.WriteLine();
            }
        }
    }

    // 4. 设计一程序，演示一维数组、二维数的定义、初始化、数组元素的赋值与取数。
    class Four
    {
        public void Arrays()
        {
            // 一维数组

            // 4种定义方式
            int[] a1 = { 1, 2, 3, 4, 5 };
            int[] a2 = new int[] { 1, 2, 3, 4, 5 };
            int[] a3 = new int[5]{1,2,3,4,5};
            Boolean[] a4 = new[] { true,false};
            // 声明+初始化
            double[] a5 = new double[3];
            a5[0] = 1.0;
            a5[1] = 3;
            a5[2] = 4;
            // 赋值
            a5[1] = 100;
            // 遍历
            for (int i = 0; i < a1.Length; i++)
            {
                Console.Write(i + "\t");
            }
            foreach (double i in a5)
            {
                Console.Write(i+"\t");
            }
            // 取数
            Console.WriteLine("a3的第二个元素为：{0}",a3[1]);

            // 二维数组

            // 4种定义方式
            int[,] b1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] b2 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            string[,] b3 = new string[2, 2] { { "hello", "hi" }, { "hahaha", "zq" } };

            int[][] b4 = new int[3][];
            b4[0] = new int[] { 1, 2 };
            b4[1] = new int[] { 3, 4, 5 };
            b4[2] = new int[4] { 6, 7, 8, 9 };

            // 长度
            Console.WriteLine("b1总长度为：" + b1.Length); // 6
            Console.WriteLine("b1行长度为：" + b1.GetLength(0)); // 2
            Console.WriteLine("b1列长度为：" +b1.GetLength(1)); // 3

            Console.WriteLine("b4行长度 b4.Length 为：" + b4.Length); //3
            Console.WriteLine("b4行长度 b4.GetLength(0) 为：" + b4.GetLength(0)); //3

            Console.WriteLine("b4行长度 b4[0].Length 为：" + b4[0].Length); //2
            Console.WriteLine("b4行长度 b4[1].Length 为：" + b4[1].Length); //3
             Console.WriteLine("b4行长度 b4[2].Length 为：" + b4[2].Length); //4
          
            Console.WriteLine("b4第一行列长度 b4[0].GetLength(0) 为：" + b4[0].GetLength(0)); //2
            Console.WriteLine("b4第二行列长度 b4[1].GetLength(0)) 为：" + b4[1].GetLength(0)); //3
            Console.WriteLine("b4第三行列长度 b4[2].GetLength(0)) 为：" + b4[2].GetLength(0)); //4

            // 遍历
            // 对于 int[,] 类型：
            // 1.
            int num = 0;
            foreach (int i in b1)
            {
                Console.Write(i+"\t");
                num++;
                if (num % b1.GetLength(1) == 0)
                {
                    Console.WriteLine();
                }
            }
            // 2.
            for (int i = 0; i < b1.GetLength(0);i++ )
            {
                for(int j=0;j<b1.GetLength(1);j++)
                {
                    Console.Write(b1[i,j]+"\t");
                }
                Console.WriteLine();
            }

            // 对于 int[][] 类型：
            // 1.
            foreach(int[] i in b4)
            {
                foreach (int j in i)
                {
                    Console.Write(j+"\t");
                }
                Console.WriteLine();
            }
            // 2. 
            for (int i = 0; i < b4.Length; i++)
            {
                for (int j = 0; j < b4[i].Length;j++ )
                {
                    Console.Write(b4[i][j] + "\t");
                    Console.Write("b4[{0}][{1}]={2}\t",i,j,i+j);
                }
                Console.WriteLine();
            }

        }
    }

    // 5. 设计一个程序，演示ArrayList的用法（定义、排序、增加、插入、删除、查找等）。
    class Five
    {
        public void ArrayLists()
        {
            ArrayList arr = new ArrayList(); 
            List<int> list = new List<int>();

            arr.Add(66);
            arr.Add(100);

            foreach (int i in arr)
            {
                Console.Write(i+"\t");
            }

            int[] a = new int[] { 1, 23, 4 };
            ArrayList aa = new ArrayList(a);

            Console.WriteLine("数组原始值为");
            foreach(int i in aa)
            {
                Console.Write(i + "\t");
            }

            // 增
            aa.Add(34);
            aa.Insert(1,200);
            // 删
            aa.Remove(200);
            aa.RemoveAt(0);
            // 查找
            int n = aa.IndexOf(34);
            Console.WriteLine("34标号为："+n);
            // 排序
            aa.Sort();
            aa.Reverse();

            Console.WriteLine("数组现在值为");
            foreach (int i in aa)
            {
                Console.Write(i + "\t");
            }
            

        }
    }

    // 6. 设计一个程序，演示HashTable的用法（Contains，ContainsKey，ContainsValue的用法）。
    class Six
    {
        public void HaTa()
        {
            Hashtable ht = new Hashtable();
            ht.Add("abc","lalala");
            ht.Add("zq",123);
            ht.Add(100,1);

            foreach(DictionaryEntry dic in ht)
            {
                Console.WriteLine(dic.Key+"\t"+dic.Value);
            }

            if (ht.Contains(123))
            {
                Console.WriteLine("ok,you find " + 123);
            }
            if (ht.ContainsKey("lalala"))
            {
                Console.WriteLine("ok,you find " + "lalala");
            }
            if (ht.ContainsValue(1))
            {
                Console.WriteLine("ok,you find " + 1);
            }
            
        }
    }
}
