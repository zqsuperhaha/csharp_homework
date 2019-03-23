using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            // 字符串 比较
            string s1 = "abc";
            string s2 = "aBc";
            Console.WriteLine("s1==s2:{0}",s1==s2);
            Console.WriteLine("s1.Equals(s2):" + s1.Equals(s2));
            Console.WriteLine("s1.CompareTo(s2):" + s1.CompareTo(s2));
            Console.WriteLine("string.Compare(s1,s2):" + string.Compare(s1, s2)); // 对于 compare 分3种情况：s1==s2 =>0  s1>s2 =>-1  s1<s2 => 1 
            Console.WriteLine("s1.ToLower()==s2.ToLower():{0}" , s1.ToLower() == s2.ToLower());
            Console.WriteLine("s1.ToUpper() == s2.ToUpper():{0}" , s1.ToUpper() == s2.ToUpper());

            Console.ReadKey();

        }
    }
}
