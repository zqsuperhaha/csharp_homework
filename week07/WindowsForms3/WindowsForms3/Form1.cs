using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms3
{
    public partial class Form1 : Form
    {
        private int _Num;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // 开始出数
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
            Random r = new Random();
            _Num = r.Next(1,100);          
        }

        private void button3_Click(object sender, EventArgs e)  // 显示答案
        {
            textBox2.Text = Convert.ToString(_Num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            if (num == _Num)
            {
                label3.Text = "正确！";
            }
            else if (num < _Num)
            {
                label3.Text = "小了！";
                textBox1.Focus();
            }
            else
            {
                label3.Text = "大了！";
                textBox1.Focus();
            }
        }

        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == '\r')
        //    {
        //        button2_Click(button2, e);
        //    }
        //}

        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e) ----这样不能退出，why???
        //{
        //    if (e.KeyChar == 27)
        //    {
        //        button4_Click(sender, e);
        //    }
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

    }
}
