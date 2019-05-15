using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left == -label1.Width)
            {
                label1.Left = splitContainer1.Panel2.Width;
            }
            label1.Left -= 3;
           
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void opening(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            splitContainer1.Panel2Collapsed = false;
        }

        private void closing_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            splitContainer1.Panel2Collapsed = true;
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            open.Enabled = !timer1.Enabled;
            close.Enabled = timer1.Enabled;
        }

    }
}
