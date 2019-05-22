using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ViewTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 选中的节点
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Text = treeView1.SelectedNode.Text + "(" + treeView1.SelectedNode.Level.ToString() + ")";
        }

        // 增加节点
        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode tn = treeView1.SelectedNode;

            if (tn != null)
            {
                tn.Nodes.Add(textBox2.Text);
            }
            else
            {
                treeView1.Nodes.Add(textBox2.Text);
            }
        }
        
        // 删除节点
        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
                treeView1.SelectedNode = null;
            }
            else
            {
                MessageBox.Show("你还没有选中节点哦~", "Warning:",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        // 清空节点
        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        // 展开节点
        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        // 收缩节点
        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

       
    }
}
