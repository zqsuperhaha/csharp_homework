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
            string s1 = str.Insert(4,"超级大的"); // 在4标号位置添加
            Console.WriteLine(s1);
            string s2 = str.Insert(str.Length, "超级大的"); // 在尾部添加
            Console.WriteLine(s2);
            str  += "超级大的"; // 在尾部添加
            Console.WriteLine(str);
            string s3 = str + "超级大的"; // 在头部添加
            Console.WriteLine(s3);

            // 2.删
            string s4 = str.Remove(1,2);
            Console.WriteLine(s4);
            string s5 = str.Remove(3); // 从3位置开始全删了
            Console.WriteLine(s5);
            Console.WriteLine(str); // 原字符串不变

            // 3.改
            string s6 = str.Replace("喜欢","不喜欢"); // 替换字符串   不喜欢 替换 喜欢
            Console.WriteLine(s6);
            Console.WriteLine(str);
            int a = 10000;
            Console.WriteLine(a.ToString().Replace('1','2'));

            string s7 = str.Substring(1,str.Length-1); // 截取字符串  从1位置开始，截取str.Length-1个
            Console.WriteLine(s7);

            string S = "hahaha"; 
            string SS = "哈哈哈";
            string SSS = "哈哈haha";
            string S1 = S.PadLeft(7,'【'); // 补全字符串   不足7位就在左边用'【'补全，小于或等于就不补（因为满了，但不报错，保持原样输出）
            string S2 = SS.PadLeft(4, '【');
            string S3 = SSS.PadRight(8, '【');
            Console.WriteLine(S.Length+" "+SS.Length+" "+SSS.Length);  // 6 3 6
            Console.WriteLine(S1);  // 对于字符串里面的中文和英文：中文每个字算一个长度单位，英文每个字母算一个长度单位
            Console.WriteLine(S2);
            Console.WriteLine(S3);

            str = "zqsuperhaha@qq.com";
            int i = str.IndexOf("@"); // '@'、"@" 都行
            Console.WriteLine(str.Substring(0,i)); // 从0开始，截取11（i）个 --> zqsuperhaha

            string str1 = null;
            string str2 = "";
            string str3 = string.Empty;

            // 判断 字符串 是否为空 的几种方法:
            if (str1 == null || str2 == "" || str3 == string.Empty)
            {
                Console.WriteLine("str1 =:" + str1 + "ok");
                Console.WriteLine("str2 =:" + str2 + "ok");
                Console.WriteLine("str3 =:" + str3 + "ok");
                //输出结果：
                //str1 =:ok
                //str2 =:ok
                //str3 =:ok  看来，空的结果也是什么也没有~
                Console.WriteLine("str1==str2:{0}",str1==str2);
                Console.WriteLine("str2==str3:{0}", str2 == str3);
                Console.WriteLine("str1==str3:{0}", str1 == str3);
                //输出结果：
                //str1 == str2:False
                //str2 == str3:True
                //str1 == str3:False

            }
            if (string.IsNullOrEmpty(str1)) { }
            if (str2.Length == 0) { }
            if (str2.Equals(string.Empty)) { }

            // 分割字符串
            string Seven_deadly_sins = "Pride,Envy,Anger,Sloth,Greed,Gluttony,Lust"; // 俗称“七大罪”！
            string[] sdsList = Seven_deadly_sins.Split(',');
            foreach (string s in sdsList)
            {
                Console.WriteLine(s);
            }
            // 拼接字符串
            string laststring = string.Join("o",sdsList);
            Console.WriteLine(laststring);



            Console.ReadKey();


        }
    }
}
