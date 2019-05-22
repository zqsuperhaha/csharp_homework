using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI_winform
{
    public partial class Form1 : Form
    {
        Form2 form2 = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        // 打开 窗口Form2
        private void my_File_Open_Click(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                form2 = new Form2();
                form2.Show();
            }
        }

        // 关闭 窗口Form2
        private void my_File_Close_Click(object sender, EventArgs e)
        {
            if (form2 != null)
            {
                form2.Close();
                form2 = null;
            }
 
        }
        // 当没有 Form2 的时候，关闭窗口菜单失效
        private void my_File_DropDownOpened(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                my_File_Close.Enabled = false;
            }
            else
            {
                my_File_Close.Enabled = true;
            }
        }

        // 退出
        private void my_File_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 新建窗口
        private void my_Win_New_Click(object sender, EventArgs e)
        {
            Form newform = new Form();
            newform.MdiParent = this;
            newform.Width = 450;
            newform.Text = string.Format("Mdi_" + this.MdiChildren.Count());
            newform.Show();
        }

        // 关闭窗口
        private void my_Win_Close_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        // 当没有子窗体的时候，关闭窗口菜单失效
        private void my_Win_DropDownOpened(object sender, EventArgs e)
        {
            my_Win_Close.Enabled = this.MdiChildren.Count() > 0;
        }

        // 水平平铺
        private void my_Win_Title_H_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        // 垂直平铺
        private void my_Win_Title_V_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        // 层叠窗口
        private void my_Win_Stack_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        // FormAbout
        private void 关于MDI窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormAbout()).ShowDialog();
        }

       

      

       


        

        

        
    }
}
