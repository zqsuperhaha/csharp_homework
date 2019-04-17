using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Color_transform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //textBox1.Width = 278; //这行不能加到这，因为没有使用new创建对象 实际上，在Designer里面的属性函数里面早就定义好了
            //就是这句 ：this.textBox1.Size = new System.Drawing.Size(278, 28);
            InitializeComponent();
            //textBox1.Width = 278; //加这也不行
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.FromArgb(255, 0, 0); //没有 textBox1.Text.ForeColor 这个属性，直接用 textBox1.ForeColor 就行
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the length is:"+textBox1.TextLength);
            textBox1.BackColor = Color.Green;
            //this.textBox1.Size = new System.Drawing.Size(textBox1.TextLength*7, 28);
            textBox1.Width = Convert.ToInt32(textBox1.TextLength * 6.7);
        }
    }
}
