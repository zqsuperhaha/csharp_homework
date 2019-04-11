using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms2
{
    public partial class Form1 : Form
    {
        private int _a;
        private int _b;

        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(sender,e);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "输入答案吧!";
 
            Random r = new Random();
            _a = r.Next(1, 10);
            _b = r.Next(1, 10);
            if(_a>=_b)
            {
                label2.Text = Convert.ToString(_a) + " - " + Convert.ToString(_b) + " =";
            }
            else
            {
                label2.Text = Convert.ToString(_a) + " + " + Convert.ToString(_b) + " =";
            }
            textBox1.Focus();
            
        }
       

        private void button3_Click(object sender, EventArgs e)
        {           
                string c =textBox1.Text;
                //bool answer=true;

                if (_a >= _b)
                {
                    if (c !=Convert.ToString(_a - _b))
                    {
                        label4.Text = "你答错了，加油！";
                        textBox1.Focus();
                    }
                    else
                    {
                        label4.Text = "你答对了，真棒！";
                    }

                }
                else
                {
                    if (c!= Convert.ToString(_a + _b))
                    {
                        label4.Text = "你答错了，加油！";
                        textBox1.Focus();
                    }
                    else
                    {
                        label4.Text = "你答对了，真棒！";
                    }
                }

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = textBox1.Text != "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                button3_Click(button3,e);
            }
           
        }

    }
}
