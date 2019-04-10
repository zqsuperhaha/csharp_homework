using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Struct_project
{
    class Class1
    {
        public string _Sex;
        private string Sex // 这个成员变量非常可怜，因为它的存在就是作为一个与外界的通道（接口），是为与自己“同名”的私有变量服务的
        {
            set { _Sex = value; }
            get { return _Sex; }
        }
        public static void Main()
        {
            Class1 c = new Class1();
            c.Sex = "女";
            Console.WriteLine(c.Sex);
        }
    }

}
