using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBoxForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 新增内容 （尾部插入）
            if (richTextBox1.Text != "")
            {
                listBox1.Items.Add(richTextBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 插入内容 (在选中行的前面插入)
            int i = listBox1.SelectedIndex; // 获取当前行的标号
            if (i == -1)    // 没有选中行
            {
                i = 0;  // 插入到最顶端
            }
            if (richTextBox1.Text != "")
            {
                listBox1.Items.Insert(i, richTextBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 按文本内容删除项
            listBox1.Items.Remove(richTextBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 删除选中的行
            if (listBox1.SelectedIndex != -1)   // 如果选中了
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 清空列表
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 获取ListBox1的状态
            richTextBox2.Clear();

            richTextBox2.AppendText(string.Format("选中的项数量: {0}\r\n\n", listBox1.SelectedItems.Count));
            if (!checkBox1.Checked && listBox1.SelectedItems.Count > 0) 
            {
                richTextBox2.AppendText(string.Format("选中的项索引号: {0}\r\n", listBox1.SelectedIndex));
                richTextBox2.AppendText(string.Format("选中的项内容: {0}\r\n", listBox1.SelectedItem.ToString()));
            }
            else
            {
                foreach(string str in listBox1.SelectedItems)
                {
                    richTextBox2.AppendText(string.Format("选中的项索引号: {0}\r\n", listBox1.Items.IndexOf(str)));
                    richTextBox2.AppendText(string.Format("选中的项内容: {0}\r\n\n",str));
                }
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // 是否允许多选
            if (checkBox1.Checked)
            {
                listBox1.SelectionMode = SelectionMode.MultiSimple;
            }
            else
            {
                listBox1.SelectionMode = SelectionMode.One;
            }


        }

      
    }
}
