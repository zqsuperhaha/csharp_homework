using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_1
{
    public partial class LoginForm : Form
    {
        private string _UserName = "admin";
        private string _UserPwd = "123456";

        public LoginForm() //界面初始化
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e) //登录
        {
            string username = txt_UserName.Text;
            string userpwd = txt_UserPwd.Text;

            if ((username == _UserName) && (userpwd == _UserPwd))
            {
                MessageBox.Show(this,"用户名和密码验证通过，登录成功！","登录提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "用户名和密码验证失败，请重新登录！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_UserName.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e) //取消
        {
            txt_UserName.Text = "";
            txt_UserPwd.Text = "";
            this.Close();
        }
       
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
