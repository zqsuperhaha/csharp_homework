using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Struct_project
{

    class Program
    {
        public struct StructStudent
        {
            public string Name; // 没get,set方法或为private--(私有成员变量)字段
            private int _Age; // 如果是 private ,就里外都不能赋值，那么只能通过 new 实例化来赋值（构造函数）
            public int Age 
            {
                set { _Age = value; }
                get { return _Age; }
            }

            public string Sex;

            public void SayHi()
            {
                Console.WriteLine("hello!" + Name + ",your age is:" + Age + ",your sex is:" + Sex);
            }

            public StructStudent(string name, int age, string sex) // 结构的构造函数
            {
                Name = name;
                _Age = age;
                this.Sex = sex;
            }
        }
        private bool _ok;
        public bool Ok
        {
            set
            {
                if (value == false)
                {
                    _ok = true;
                }
            }
            get { return _ok; }
        }
        public StructStudent stu3;

        static void Main(string[] args)
        {
            StructStudent stu1 = new StructStudent(); // 这样就像一个普通变量的声明，如果要初始化，就需要赋值，而对于这个struct类型，赋值就需要整体赋值
            //stu1.Name = "zq";
            //stu1.Age = 10000;
            //stu1.Sex = "女";
            stu1.SayHi();

            //StructStudent stu2 = new StructStudent("Edward",0,"man");
            //stu2.Name = "zqhahaha";
            //stu2.SayHi();

            StructStudent stu4 = new StructStudent();
            stu4.SayHi(); // Age(int) 默认值为 0 ，Name(string) 默认值为 ""

            Program p = new Program();
            p.stu3.Age = 50000;
            p.stu3.SayHi();

            p.Ok = false;
            Console.WriteLine(p.Ok);

            Console.ReadKey();
        }
    }

}
