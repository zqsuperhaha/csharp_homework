using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Data02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.TodayDate.ToString("yyyy-MM-dd");
            textBox2.Text = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            textBox3.Text = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(numericUpDown1.Value);
            if (num > 0)
            {
                monthCalendar1.MaxSelectionCount = num;
            }
            else
            {
                MessageBox.Show("嘿，你不能弄那么小！！！","错误!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                numericUpDown1.Value = 1;
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
