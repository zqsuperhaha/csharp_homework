using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 新增内容
            if (comboBox1.Text != "")
            {
                comboBox1.Items.Add(comboBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 插入内容
            int i = comboBox1.SelectedIndex;
            if (i != 1)
                i = 0;
            if (comboBox1.Text != "")
            {
                comboBox1.Items.Insert(i,comboBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 删除输入的文本一样的item
            comboBox1.Items.Remove(comboBox1.Text);
            comboBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 删除选中行
            if (comboBox1.SelectedIndex != -1)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 清空整个列表
            comboBox1.Items.Clear();
        }

        // 三选一
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Simple
            comboBox1.DropDownStyle = ComboBoxStyle.Simple;
            comboBox1.Size = new Size(180, 100);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //DropDown
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //DropDownList
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 获取内容 (能不能多选呢？虽然没什么意义，在这里)
            textBox1.Clear();
            if (comboBox1.Text == "")
            {
                textBox1.AppendText("你以为我是 pig 吗?\r\n\r\n你还没选中嘞~");
            }
            else
            {
                textBox1.AppendText("选中的内容是："+comboBox1.Text);
            }
            
        }

       

    }
}
