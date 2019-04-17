using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Font_Set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FontStyle fontstyle;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Font = new Font(textBox2.Text, Convert.ToSingle(textBox1.Text),fontstyle); //ToSingle --> 将数字文本（数字字符串）转单精度
            textBox3.Width = Convert.ToInt32(textBox1.Text) * textBox3.TextLength*2;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fontstyle = (FontStyle.Bold|FontStyle.Italic|FontStyle.Underline);
            if (!checkBox1.Checked)
                fontstyle -= FontStyle.Bold;
            if (!checkBox2.Checked)
                fontstyle -= FontStyle.Italic;
            if (!checkBox3.Checked)
                fontstyle -= FontStyle.Underline;

            textBox3.Font = new Font(textBox2.Text, Convert.ToSingle(textBox1.Text), fontstyle);
           
        }

    }
}
