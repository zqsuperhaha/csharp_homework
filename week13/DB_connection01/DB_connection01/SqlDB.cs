using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DB_connection01
{
    class SqlDB
    {
        // 用户信息
        private string _DataSource;
        private string _Catalog;
        private string _UserName;
        private string _Pwd;

        // 数据库连接 “桥梁”
        private SqlConnection _Sqlcon;

        // 用户信息安全化
        private string InitialConn(string DataSource, string Catalog, string UserName, string Pwd)
        {
            _DataSource = DataSource;
            _Catalog = Catalog;
            _UserName = UserName;
            _Pwd = Pwd;

            return "Data Source=" + DataSource + ";Initial Catalog=" + Catalog + ";Persist Security Info=True;User ID=" + UserName + ";Password=" + Pwd;
        }

        // 安全地初始化(用户信息、“桥梁”)
        public SqlDB(string DataSource, string Catalog, string UserName, string Pwd)  
        {
            _Sqlcon = new SqlConnection();
            _Sqlcon.ConnectionString = InitialConn(DataSource, Catalog, UserName, Pwd);
            
        }

        // 连接数据库
        public void LinkDB()
        {
            
            try
            {
                _Sqlcon.Open();
                if (_Sqlcon.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("数据库连接成功!!!");
                }
                else
                {
                    Console.WriteLine("数据库连接失败~！");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("数据库连接失败！" + e.Message);
                throw;
            }
        }

        // 关闭数据库
        public void SqlConClose()
        {
            _Sqlcon.Close();
        }

        // 读取用户信息
        public void ReadUserInfo()
        {
            string sqlStr = "select * from student";

            SqlCommand sqlCmd = _Sqlcon.CreateCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = sqlStr;

            SqlDataReader sdr = sqlCmd.ExecuteReader();

            // 输出用户属性
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            for (int i = 0; i < sdr.FieldCount; i++)
            {
                Console.Write("{0,-10}\t", sdr.GetName(i).Trim());
            }
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------");

            // 输出用户信息
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write("{0,-10}\t", sdr[i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }
    }
}
