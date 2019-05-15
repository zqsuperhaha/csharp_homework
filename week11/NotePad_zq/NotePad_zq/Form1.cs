using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotePad_zq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 创建页
        private TabPage createPage()
        {
            TabPage tp = new TabPage();
           // TextBox text = new TextBox();
            int x = tabControl1.TabPages.Count + 1;
            tp.Text = "Page(" + x.ToString() + ")";
            tp.UseVisualStyleBackColor = true;

            TextBox tx = new TextBox();
            tx.Multiline = true;
            tx.Dock = DockStyle.Fill;
            tp.Controls.Add(tx);

            tp.ImageIndex = 2;
            return tp;

        }
        // 增加新的一页
        private void button1_Click(object sender, EventArgs e)
        {
            TabPage tp = createPage();
            tabControl1.TabPages.Add(tp);
            tabControl1.SelectedTab = tp;
            
        }

        // 插入新的一页
        private void button2_Click(object sender, EventArgs e)
        {
            TabPage tp = createPage();
            int index = tabControl1.SelectedIndex;
            tabControl1.TabPages.Insert(index, tp);
        }

        // 删除当前页(方法1)
        private void button3_Click(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            tabControl1.TabPages.RemoveAt(index);
            if (index < tabControl1.TabPages.Count - 1)
            {
                tabControl1.SelectedIndex = index;
                // 这里为什么不是 index+1 ? 难道 index 可以获取时刻索引？(实时更新)
                // 不不不，每删除一个，tabControl1会自动更新索引，比如删除的是 索引5，索引6那一页就会向前推，变成索引5
                // 就像列表list.remove()一样,删除了就像前推~
            }
            else
            {
                tabControl1.SelectedIndex = index - 1;
            }
        }

        // 删除当前页(方法2)
        private void button4_Click(object sender, EventArgs e)
        {
            TabPage tp = tabControl1.SelectedTab;
            int index = tabControl1.SelectedIndex;
            tabControl1.TabPages.Remove(tp);
            if (index < tabControl1.TabPages.Count - 1)
            {
                //tabControl1.SelectedIndexChanged(tabControl1.TabPages.IndexOf(tp));
                tabControl1.SelectTab(index);
                //tabControl1.SelectedIndex = index;
            }
            else
            {
                tabControl1.SelectedIndex = index - 1;
            }
        }
        


       

    }
}
