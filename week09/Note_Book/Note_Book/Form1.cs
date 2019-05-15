using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Note_Book
{
    public partial class Form1 : Form
    {
        private string _FileName = "";
        private string _Texts = "";
        private int flag = 1;  // 0--取消--什么都不干  1--不保存或保存，干点什么
        private Encoding _FileEncode = Encoding.UTF8;   // 系统默认编码为：UTF8
        
        //internal MesBox mesbox;

        public Form1()  // 界面初始化
        {
            InitializeComponent();
        }

        internal void textBox1_KeyUp(object sender, KeyEventArgs e)  // 获得当前行号、列号
        {
            int index = textBox1.GetFirstCharIndexOfCurrentLine();  // 得到该行第一个字符的引索（位置）
            int row = textBox1.GetLineFromCharIndex(index) + 1; // 获得该行的行号
            int col = textBox1.SelectionStart - index + 1; // 获得该行光标所在位置 - 第一个字符的位置 +1 = 获得该行列号

            text_row.Text = row + " 行";
            text_col.Text = col + " 列";
            //Text_EncodeType.Text = _FileEncode.EncodingName;
        }

        internal void my_newfile_Click(object sender, EventArgs e) // 新建
        {

            if (textBox1.Text != _Texts)
            {
                check_again();
            }
            if (flag == 1)
            {
                textBox1.Clear();
                this.Text = "新建文本文档";
                _FileName = "";
                textBox1.Focus();
                _Texts = textBox1.Text; // 存好当前文本，看看后面有没有改动
            }
            flag = 1;
        }

        internal void my_openfile_Click(object sender, EventArgs e) // 打开
        {
            if (textBox1.Text != _Texts)
            {
                check_again();
            }
            if (flag == 1)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // 读取打开文件的数据流
                    _FileName = openFileDialog1.FileName;
                    _FileEncode = TextEncodingType.GetType(_FileName);
                    System.IO.StreamReader sr = new System.IO.StreamReader(_FileName,_FileEncode);
                    textBox1.Text = sr.ReadToEnd();
                    _Texts = textBox1.Text; // 存好当前文本，看看后面有没有改动
                    sr.Close();
                    Text_EncodeType.Text = _FileEncode.EncodingName; // 显示编码种类
                    _FileName = openFileDialog1.FileName;
                    this.Text = _FileName;
                }
            }
            flag = 1;
        }

        internal void SaveFile(string fileName)  // 保存--公共
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName,false,_FileEncode);   // 如果覆盖文件，那么文件内容会变，文件名不会变
            sw.WriteLine(textBox1.Text);
            _Texts = textBox1.Text; // 存好当前文本，看看后面有没有改动
            sw.Flush();
            sw.Close();
            this.Text = fileName;

        }
        internal void save_ok()  // 保存--复用
        {
            if (_FileName == "")    // 如果是 初始文件 或 新建文件 那么要弹出保存对话框
            {
                saveFileDialog1.FileName = this.Text;   // 弹出保存对话框
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)    // 如果点击确定，即保存到当前目录（或选中目录）
                {
                    _FileName = saveFileDialog1.FileName;
                    SaveFile(_FileName);
                }
            }
            else                   // 如果不是，那么直接保存
            {
                SaveFile(_FileName);
            }
        }
        internal void my_save_Click(object sender, EventArgs e) // 保存
        {
            save_ok();
        }

        internal void my_saveas_Click(object sender, EventArgs e) // 另存为 
        {
            saveFileDialog2.FileName = this.Text;
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)    
            {
                _FileName = saveFileDialog2.FileName;
                SaveFile(_FileName);
            }
        }

        internal void my_exit_Click(object sender, EventArgs e)  // 退出
        {
            if (textBox1.Text != _Texts)
            {
                check_again();
            }
            if (flag == 1)
            {
                System.Environment.Exit(0); // 成功啦！用这句而不用 this.Close(); 就可以一步退出窗口，而不是两步
            }
        }

        internal void Form1_FormClosing(object sender, FormClosingEventArgs e)   // 关闭窗口按钮
        {
            if (textBox1.Text != _Texts)
            {
                check_again();
            }

            if (flag == 0)
            {
                e.Cancel = true;    // 保留窗体~
            }
            else
            {
                System.Environment.Exit(0);
            }
            //my_exit.Checked = true;
            //my_exit_Click(sender,e);
        }

        //internal void Form1_Load(object sender, EventArgs e)
        //{
        //    this.FormClosing -= new FormClosingEventHandler(Form1_FormClosing);
        //}

        internal void check_again()   // 再次询问~
        {
            DialogResult ms = MessageBox.Show("请问是否要保存当前文档？", "提示", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

            if (ms == DialogResult.Yes)  // 要保存
            {
                save_ok();
            }
            else if(ms == DialogResult.Cancel)
            {
                flag = 0;   // 取消
            }
           
            //mesbox = new MesBox();
            //mesbox.Show();
        }

        internal void my_edit_DropDownOpened(object sender, EventArgs e) // 编辑菜单
        {
            my_edit_back.Enabled = textBox1.CanUndo;
            my_edit_copy.Enabled = textBox1.SelectionLength > 0;
            my_edit_cut.Enabled = my_edit_copy.Enabled;
            my_edit_paste.Enabled = Clipboard.ContainsText();
            my_edit_cancel.Enabled = my_edit_copy.Enabled;
        }

        private void my_edit_back_Click(object sender, EventArgs e) // 撤销
        {
            textBox1.Undo();
        }
        private void my_edit_cut_Click(object sender, EventArgs e)   // 剪切
        {
            Clipboard.SetDataObject(textBox1.SelectedText); // 将选中内容复制到剪切板
            textBox1.SelectedText = "";
        }
        private void my_edit_copy_Click(object sender, EventArgs e)  // 复制
        {
            Clipboard.SetDataObject(textBox1.SelectedText); // 将选中内容复制到剪切板
        }
        private void my_edit_paste_Click(object sender, EventArgs e)  //粘贴
        {
            textBox1.Paste();
        }
        private void my_edit_cancel_Click(object sender, EventArgs e)   //删除
        {
            textBox1.SelectedText = ""; // 删除选中的文本
        }

        internal void my_format_autoline_Click(object sender, EventArgs e)   // 自动换行
        {
            my_format_autoline.Checked = !my_format_autoline.Checked;
            textBox1.WordWrap = my_format_autoline.Checked;
        }

        internal void my_format_form_Click(object sender, EventArgs e) // 字体设置
        {
            fontDialog1.Font = textBox1.Font;
            fontDialog1.ShowColor = true; //此处为关键，是否在字体对话框中显示颜色
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.SelectionFont = fontDialog1.Font;
                //textBox1.SelectionColor = colorDialog1.Color; // 这个还需要 colorDialog1 颜色对话框哦~
                textBox1.SelectionColor = fontDialog1.Color;
            }
             //&& colorDialog1.ShowDialog() == DialogResult.OK  // 对应颜色对话框

        }

        internal void my_check_info_condition_Click(object sender, EventArgs e)  // 状态栏
        {
            my_check_info_condition.Checked = !my_check_info_condition.Checked;
            statusStrip1.Visible = my_check_info_condition.Checked;
        }

        private void my_help_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你真的需要帮助吗？ZQ记事本用起来可是 so easy 啊~", "帮助", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // 以对话框的形式显示
        private void my_help_zq_Click(object sender, EventArgs e)
        {
            //string date = "今天是："+DateTime.Now.ToLongDateString().ToString();
            //if("2019年4月27日" == date)
            //{
            //    date += "\n  祝你生日快乐哦~";
            //}
            //MessageBox.Show(date,"关于ZQ记事本", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            (new Help_About()).ShowDialog(); // 显示对话框
            // 可以拆分成:
            //Help_About ha = new Help_About();
            //ha.ShowDialog();

            //(new Help_About()).Show(); // 这样写，就会造成 不点确定也没关系，会被其他页面挡住，就会造成可能有多个这种小窗口出现，重重叠叠~
        }


        //private void my_edit_back_Click(object sender, EventArgs e)
        //{
        //    my_edit_back.Enabled = textBox1.CanUndo;
        //}
    }
}
