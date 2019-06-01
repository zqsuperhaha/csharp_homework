using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DB_connection01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 用户信息赋值
            string DataSource = @"(local)\YINN";
            string Catalog = "zqDB";
            string UserName = "zq";
            string Pwd = "zq123456";
            SqlDB zqsql = new SqlDB(DataSource,Catalog,UserName,Pwd);

            // 连接数据库
            zqsql.LinkDB();

            // 输出数据库相关信息
            Console.WriteLine("当前信息为:\n-----------------------------");
            Console.WriteLine("数据库服务器:"+DataSource+"\n数据库名称:"+Catalog+"\n登录用户名:"+UserName+"\n登录密码:"+Pwd);
            Console.WriteLine("-----------------------------");
            
            // 处理输出用户信息
            Console.WriteLine("开始读取用户信息：");
            zqsql.ReadUserInfo();
            Console.WriteLine("用户信息读取完成！");
            zqsql.SqlConClose();

            Console.ReadKey();
        }
    }
}
