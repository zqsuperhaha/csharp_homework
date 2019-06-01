using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsForms_1
{
    public partial class LoginForm : Form
    {
        private int _Flag; // 用户信息过期标志

        public LoginForm() //界面初始化
        {
            InitializeComponent();
        }

        // 连接数据库，获取数据
        private bool LinkSqlReadDate()
        {
            _Flag = 0;

            string sqlDate = ConfigurationManager.AppSettings["ConnectionString"];

            SqlConnection sqlcon = new SqlConnection();
            
            sqlcon.ConnectionString = sqlDate;
            try
            {
                sqlcon.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("数据库连接失败！请检查配置文件信息！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
            string sqlStr = "select * from student";

            SqlCommand sqlCmd = sqlcon.CreateCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = sqlStr;

            SqlDataReader sdr = sqlCmd.ExecuteReader(); // sdr 相当于 一行数据 的数组（一维）
            while (sdr.Read())  // 一行一行地读，直到没有数据为止
            {
                if (txt_UserName.Text == sdr[1].ToString() && txt_UserPwd.Text == sdr[2].ToString())
                {
                    if (sdr[4].Equals(false))
                    {
                        return true;
                    }
                    else
                    {
                        _Flag = 1;
                        return false;
                    }
                    
                }
            }
            sqlcon.Close();
            return false;
        }
        private void button1_Click(object sender, EventArgs e) //登录
        {
            if (LinkSqlReadDate())
            {
                MessageBox.Show(this,"用户名和密码验证通过，登录成功！","登录提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (_Flag == 1)
                {
                    MessageBox.Show(this, "用户信息已过期，请重新注册！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(this, "用户名和密码验证失败，请重新登录！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_UserName.Focus();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e) //取消
        {
            txt_UserName.Text = "";
            txt_UserPwd.Text = "";
            this.Close();
        }
        
        // 登录按钮--可用Enable
        private void txt_UserPwd_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = (txt_UserName.Text != "") && (txt_UserPwd.Text != "");
        }

        private void txt_UserPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // 按下Enter键，登录
            {
                button1_Click(button1, e);
            }
            else if (e.KeyChar == 27) //按下Eec键，取消
            {
                button2_Click(sender, e);
            }
        }

        private void txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) //按下Eec键，取消
            {
                button2_Click(sender, e);
            }

        }
    }
}
