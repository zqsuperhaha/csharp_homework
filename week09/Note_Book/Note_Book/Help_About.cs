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
    public partial class Help_About : Form
    {
        public Help_About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // 确认
        {
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.Links[0].LinkData = linkLabel2.Text;
            System.Diagnostics.Process.Start(linkLabel2.Text);
            linkLabel2.LinkVisited = true;
        }
        
        
    }
}
