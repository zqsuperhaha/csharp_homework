using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Data_Edit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 新增
        private void button1_Click(object sender, EventArgs e)
        {
            Students student1 = new Students();
            student1.xh = textBox1.Text;
            student1.xm = textBox2.Text;
            student1.xb = textBox3.Text;
            student1.nj = textBox4.Text;
            student1.xy = textBox5.Text;
            student1.zy = textBox6.Text;
            student1.bj = textBox7.Text;
            student1.dh = textBox8.Text;
            string error = "";
            if (student1.xh == "" || student1.xm == "" || student1.xb == "" || student1.nj == "" || student1.xy == "" || student1.zy == "" || student1.bj == "")
            {
                MessageBox.Show("请将数据补全!");
                textBox1.Focus();
            }
            else
            {
                int i = student1.InsertData(student1.xh, student1.xm, student1.xb, student1.nj, student1.xy, student1.zy, student1.bj, student1.dh, out error);
                if (i > 0)
                {
                    MessageBox.Show(string.Format("新增数据成功！！！新增了{0}条数据", i));
                }
                else
                {
                    MessageBox.Show("新增数据失败！~" + error);
                }
            }

        }

        // 查询
        Students student2 = new Students(); // 被查询到的学生
        private void button3_Click(object sender, EventArgs e)
        {
            student2.xh = textBox9.Text;
            string error = "";
            if (student2.FindData(student2.xh, out error))
            {
                textBox1.Text = student2.xh;
                textBox2.Text = student2.xm;
                textBox3.Text = student2.xb;
                textBox4.Text = student2.nj;
                textBox5.Text = student2.xy;
                textBox6.Text = student2.zy;
                textBox7.Text = student2.bj;
                textBox8.Text = student2.dh;
            }
            else
            {
                MessageBox.Show("没有查询到此人~" + error);
            }
           

        }

        // 清空
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "男";
            textBox4.Text = "2019";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

            textBox1.Focus();
        }

        // 更新
        private void button4_Click(object sender, EventArgs e)
        {
            student2.xh = textBox1.Text;
            student2.xm = textBox2.Text;
            student2.xb = textBox3.Text;
            student2.nj = textBox4.Text;
            student2.xy = textBox5.Text;
            student2.zy = textBox6.Text;
            student2.bj = textBox7.Text;
            student2.dh = textBox8.Text;
            string error = "";
            if (student2.xh == "" || student2.xm == "" || student2.xb == "" || student2.nj == "" || student2.xy == "" || student2.zy == "" || student2.bj == "")
            {
                MessageBox.Show("请将数据补全!");
                textBox1.Focus();
            }
            else
            {
                int i = student2.ReflashData(student2.xh, student2.xm, student2.xb, student2.nj, student2.xy, student2.zy, student2.bj, student2.dh, out error);
                if (i > 0)
                {
                    MessageBox.Show(string.Format("更新数据成功！！！更新了{0}条数据", i));
                }
                else
                {
                    MessageBox.Show("更新数据失败！~" + error);
                }
            }
        }

        // 删除
        private void button5_Click(object sender, EventArgs e)
        {
            string error = "";

            int i = student2.ReflashData(student2.xh, student2.xm, student2.xb, student2.nj, student2.xy, student2.zy, student2.bj, student2.dh, out error);
            if (i > 0)
            {
                MessageBox.Show(string.Format("删除数据成功！！！删除了{0}条数据", i));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "男";
                textBox4.Text = "2019";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";

                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("删除数据失败！~" + error);
            }
        }

        
    }
}
