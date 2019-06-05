using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Data_Edit
{
    class Students
    {
        private MySQLCon mySqlcon; // 连接数据库

        public string xh {get;set;}  // 学号
        public string xm {get;set;}  // 姓名
        public string xb {get;set;} // 性别
        public string nj {get;set;}  // 年级
        public string xy {get;set;}  // 学院
        public string zy {get;set;}  // 专业
        public string bj {get;set;}  // 班级
        public string dh {get;set;}  // 电话

        public Students()
        {
            // 连接数据库
            mySqlcon = new MySQLCon();
            mySqlcon.sqlCon = new SqlConnection();
            mySqlcon.LinkDB();
        }

        // 新增
        public int InsertData(string xh, string xm, string xb, string nj, string xy, string zy, string bj, string dh, out string error)
        {
            string sqlStr = string.Format("insert into student(学号,姓名,性别,年级,学院,专业,班级,电话) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", xh, xm, xb, nj, xy, zy, bj, dh);

            SqlCommand cmd = mySqlcon.sqlCon.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sqlStr;

            try
            {
                int i = cmd.ExecuteNonQuery();
                error = "";
                return i;
            }
            catch (Exception e)
            {
                error = e.Message;
                return -1;
            }

        }

        // 查询
        public bool FindData(string xh,out string error)
        {
            string sqlStr = string.Format("select * from student where 学号={0}", xh);

            SqlCommand cmd = mySqlcon.sqlCon.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sqlStr;

            xh = "";
            xm = "";
            xb = ""; 
            nj = "";
            xy = "";
            zy = "";
            bj = "";
            dh = "";

            try
            {
                SqlDataReader sdr = cmd.ExecuteReader(); // 不能读一些无效参数，如 sw123 等等
                while (sdr.Read())
                {
                    //xh = sdr["学号"].ToString(); 
                    xm = sdr["姓名"].ToString();
                    xb = sdr["性别"].ToString();
                    nj = sdr["年级"].ToString();
                    xy = sdr["学院"].ToString();
                    zy = sdr["专业"].ToString();
                    bj = sdr["班级"].ToString();
                    dh = sdr["电话"].ToString();
                }
                error = "";
                sdr.Close();
                return (xm != "");
            }
            catch(Exception e)
            {
                error = e.Message;
                return false;
            }
        }

        // 更新
        public int ReflashData(string xh, string xm, string xb, string nj, string xy, string zy, string bj, string dh, out string error)
        {
            string sqlStr = string.Format("update student set 姓名='{1}',性别='{2}',年级='{3}',学院='{4}',专业='{5}',班级='{6}',电话='{7}' where 学号='{0}'", xh, xm, xb, nj, xy, zy, bj, dh);

            SqlCommand cmd = mySqlcon.sqlCon.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sqlStr;

            try
            {
                int i = cmd.ExecuteNonQuery();
                error = "";
                return i;
            }
            catch (Exception e)
            {
                error = e.Message;
                return -1;
            }
        }

        // 删除
        public int DeleteData(string xh, out string error)
        {
            string sqlStr = string.Format("delete from student where 学号='{0}'", xh);
            SqlCommand cmd = mySqlcon.sqlCon.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sqlStr;
            try
            {
                int i = cmd.ExecuteNonQuery();
                error = "";
                return i;
            }
            catch (Exception e)
            {
                error = e.Message;
                return -1;
            }
        }
    }         
}             
              
              
              
              
              