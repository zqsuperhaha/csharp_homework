using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Data_Edit
{
    class MySQLCon
    {
        public SqlConnection sqlCon;

        // 连接数据库
        public bool LinkDB()
        {
            sqlCon.ConnectionString = "Data Source=(local)\\YINN;Initial Catalog=stDB;Persist Security Info=True;User ID=zq;Password=zq123456";

            sqlCon.Close();
            try
            {
                sqlCon.Open();
                return sqlCon.State == System.Data.ConnectionState.Open;
            }
            catch(Exception)
            {
                return false;
            }
        }
        
    }
}
