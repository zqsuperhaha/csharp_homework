using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Note_Book
{
    public partial class MesBox : Form
    {
        internal Form1 form1_class = new Form1();

        public MesBox()
        {
            InitializeComponent();
        }

        internal void button1_Click(object sender, EventArgs e)  // 保存
        {
            form1_class.save_ok();
        }

        internal void button2_Click(object sender, EventArgs e)  // 不保存
        {
            if (form1_class.flag == 0)  //退出
            {
                form1_class.Close(); // 关闭主窗口
            }
            this.Close(); // 关闭本窗口
        }

        internal void button3_Click(object sender, EventArgs e)  // 取消
        {
            this.Close();
        }

        //// 关闭按钮按下
        //internal void MesBox_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    System.Environment.Exit(0);
        //}

        //internal void MesBox_Load(object sender, EventArgs e)
        //{
        //    this.FormClosing += new FormClosingEventHandler(MesBox_FormClosing);
        //}
    }
}
