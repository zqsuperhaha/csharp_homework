using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DataBase_Connection
{
    public partial class Form1 : Form
    {
        private SqlConnection _Sqlcon;

        public Form1()
        {
            InitializeComponent();
            textBox_config.Text = "";
        }

        // button1 显示
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "";
        }
        // button3 显示
        private void textBox_config_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = textBox_config.Text != "";
        }

        // 开始连接数据库 -- 1
        private void button1_Click(object sender, EventArgs e)
        {
            string coninfo = @"Data Source=" + textBox1.Text + ";Initial Catalog=" + textBox3.Text + ";Persist Security Info=True;User ID=" + textBox2.Text + ";Password=" + textBox4.Text;
            linkDB(coninfo);
        }

        private void linkDB(string coninfo)
        {
            _Sqlcon = new SqlConnection();
            _Sqlcon.ConnectionString = coninfo;

            try
            {
                _Sqlcon.Close();
                _Sqlcon.Open();
                if (_Sqlcon.State == System.Data.ConnectionState.Open)
                {
                    toolStripStatusLabel1.Text = "数据库连接成功!!!";
                    button2.Enabled = true;
                    button4.Enabled = true;
                    //button2.Focus();
                }
            }
            catch (Exception e)
            {
                toolStripStatusLabel1.Text = "数据库连接失败!~";
                MessageBox.Show(string.Format("数据库连接失败!~{0}", e.Message), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 断开连接数据库 -- 1
        private void button2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "数据库已断开连接~~~";
            button2.Enabled = false;
            button4.Enabled = false;
            button1.Focus();
            _Sqlcon.Close();
        }

        // 开始连接数据库 -- 2
        private void button5_Click(object sender, EventArgs e)
        {
            //textBox_config.Text = ConfigurationManager.AppSettings["ConnectionString"];
            textBox_config.Text = ConfigurationManager.ConnectionStrings["ZQconn"].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            linkDB(textBox_config.Text);
        }

        // 断开连接数据库 -- 2
        private void button4_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "数据库已断开连接~~~";
            button4.Enabled = false;
            button2.Enabled = false;
            button3.Focus();
            _Sqlcon.Close();
        }

      

       

       

     
      

      
       


    }
}
