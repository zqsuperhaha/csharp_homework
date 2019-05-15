namespace Note_Book
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.text_row = new System.Windows.Forms.ToolStripStatusLabel();
            this.text_col = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.my_newfile = new System.Windows.Forms.ToolStripMenuItem();
            this.my_openfile = new System.Windows.Forms.ToolStripMenuItem();
            this.my_save = new System.Windows.Forms.ToolStripMenuItem();
            this.my_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.my_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.my_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.my_edit_back = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.my_edit_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.my_edit_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.my_edit_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.my_edit_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.my_format = new System.Windows.Forms.ToolStripMenuItem();
            this.my_format_autoline = new System.Windows.Forms.ToolStripMenuItem();
            this.my_format_form = new System.Windows.Forms.ToolStripMenuItem();
            this.my_check_info = new System.Windows.Forms.ToolStripMenuItem();
            this.my_check_info_condition = new System.Windows.Forms.ToolStripMenuItem();
            this.my_help = new System.Windows.Forms.ToolStripMenuItem();
            this.my_help_info = new System.Windows.Forms.ToolStripMenuItem();
            this.my_help_zq = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.Text_EncodeType = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel1,
            this.text_row,
            this.text_col,
            this.Text_EncodeType});
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(950, 29);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(350, 24);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 24);
            // 
            // text_row
            // 
            this.text_row.AutoSize = false;
            this.text_row.Name = "text_row";
            this.text_row.Size = new System.Drawing.Size(65, 24);
            this.text_row.Text = "1 行";
            // 
            // text_col
            // 
            this.text_col.AutoSize = false;
            this.text_col.Name = "text_col";
            this.text_col.Size = new System.Drawing.Size(70, 24);
            this.text_col.Text = "1 列";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.my_edit,
            this.my_format,
            this.my_check_info,
            this.my_help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 32);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_newfile,
            this.my_openfile,
            this.my_save,
            this.my_saveas,
            this.toolStripMenuItem1,
            this.my_exit});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // my_newfile
            // 
            this.my_newfile.Name = "my_newfile";
            this.my_newfile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.my_newfile.Size = new System.Drawing.Size(224, 28);
            this.my_newfile.Text = "新建(&N)";
            this.my_newfile.Click += new System.EventHandler(this.my_newfile_Click);
            // 
            // my_openfile
            // 
            this.my_openfile.Name = "my_openfile";
            this.my_openfile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.my_openfile.Size = new System.Drawing.Size(224, 28);
            this.my_openfile.Text = "打开(&O)...";
            this.my_openfile.Click += new System.EventHandler(this.my_openfile_Click);
            // 
            // my_save
            // 
            this.my_save.Name = "my_save";
            this.my_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.my_save.Size = new System.Drawing.Size(224, 28);
            this.my_save.Text = "保存(&S)";
            this.my_save.Click += new System.EventHandler(this.my_save_Click);
            // 
            // my_saveas
            // 
            this.my_saveas.Name = "my_saveas";
            this.my_saveas.Size = new System.Drawing.Size(224, 28);
            this.my_saveas.Text = "另存为(&A)...";
            this.my_saveas.Click += new System.EventHandler(this.my_saveas_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // my_exit
            // 
            this.my_exit.Name = "my_exit";
            this.my_exit.Size = new System.Drawing.Size(224, 28);
            this.my_exit.Text = "退出(&X)";
            this.my_exit.Click += new System.EventHandler(this.my_exit_Click);
            // 
            // my_edit
            // 
            this.my_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_edit_back,
            this.toolStripMenuItem2,
            this.my_edit_cut,
            this.my_edit_copy,
            this.my_edit_paste,
            this.my_edit_cancel});
            this.my_edit.Name = "my_edit";
            this.my_edit.Size = new System.Drawing.Size(80, 28);
            this.my_edit.Text = "编辑(&E)";
            this.my_edit.DropDownOpened += new System.EventHandler(this.my_edit_DropDownOpened);
            // 
            // my_edit_back
            // 
            this.my_edit_back.Name = "my_edit_back";
            this.my_edit_back.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.my_edit_back.Size = new System.Drawing.Size(206, 28);
            this.my_edit_back.Text = "撤销(&U)";
            this.my_edit_back.Click += new System.EventHandler(this.my_edit_back_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 6);
            // 
            // my_edit_cut
            // 
            this.my_edit_cut.Name = "my_edit_cut";
            this.my_edit_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.my_edit_cut.Size = new System.Drawing.Size(206, 28);
            this.my_edit_cut.Text = "剪切(&X)";
            this.my_edit_cut.Click += new System.EventHandler(this.my_edit_cut_Click);
            // 
            // my_edit_copy
            // 
            this.my_edit_copy.Name = "my_edit_copy";
            this.my_edit_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.my_edit_copy.Size = new System.Drawing.Size(206, 28);
            this.my_edit_copy.Text = "复制(&C)";
            this.my_edit_copy.Click += new System.EventHandler(this.my_edit_copy_Click);
            // 
            // my_edit_paste
            // 
            this.my_edit_paste.Name = "my_edit_paste";
            this.my_edit_paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.my_edit_paste.Size = new System.Drawing.Size(206, 28);
            this.my_edit_paste.Text = "粘贴(&V)";
            this.my_edit_paste.Click += new System.EventHandler(this.my_edit_paste_Click);
            // 
            // my_edit_cancel
            // 
            this.my_edit_cancel.Name = "my_edit_cancel";
            this.my_edit_cancel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.my_edit_cancel.Size = new System.Drawing.Size(206, 28);
            this.my_edit_cancel.Text = "删除(&L)";
            this.my_edit_cancel.Click += new System.EventHandler(this.my_edit_cancel_Click);
            // 
            // my_format
            // 
            this.my_format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_format_autoline,
            this.my_format_form});
            this.my_format.Name = "my_format";
            this.my_format.Size = new System.Drawing.Size(85, 28);
            this.my_format.Text = "格式(&O)";
            // 
            // my_format_autoline
            // 
            this.my_format_autoline.Checked = true;
            this.my_format_autoline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.my_format_autoline.Name = "my_format_autoline";
            this.my_format_autoline.Size = new System.Drawing.Size(182, 28);
            this.my_format_autoline.Text = "自动换行(&W)";
            this.my_format_autoline.Click += new System.EventHandler(this.my_format_autoline_Click);
            // 
            // my_format_form
            // 
            this.my_format_form.Name = "my_format_form";
            this.my_format_form.Size = new System.Drawing.Size(182, 28);
            this.my_format_form.Text = "字体(&F)";
            this.my_format_form.Click += new System.EventHandler(this.my_format_form_Click);
            // 
            // my_check_info
            // 
            this.my_check_info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_check_info_condition});
            this.my_check_info.Name = "my_check_info";
            this.my_check_info.Size = new System.Drawing.Size(82, 28);
            this.my_check_info.Text = "查看(&V)";
            // 
            // my_check_info_condition
            // 
            this.my_check_info_condition.Checked = true;
            this.my_check_info_condition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.my_check_info_condition.Name = "my_check_info_condition";
            this.my_check_info_condition.Size = new System.Drawing.Size(156, 28);
            this.my_check_info_condition.Text = "状态栏(&S)";
            this.my_check_info_condition.Click += new System.EventHandler(this.my_check_info_condition_Click);
            // 
            // my_help
            // 
            this.my_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_help_info,
            this.my_help_zq});
            this.my_help.Name = "my_help";
            this.my_help.Size = new System.Drawing.Size(84, 28);
            this.my_help.Text = "帮助(&H)";
            // 
            // my_help_info
            // 
            this.my_help_info.Name = "my_help_info";
            this.my_help_info.Size = new System.Drawing.Size(221, 28);
            this.my_help_info.Text = "查看帮助(&H)";
            this.my_help_info.Click += new System.EventHandler(this.my_help_info_Click);
            // 
            // my_help_zq
            // 
            this.my_help_zq.Name = "my_help_zq";
            this.my_help_zq.Size = new System.Drawing.Size(221, 28);
            this.my_help_zq.Text = "关于ZQ记事本(&A)";
            this.my_help_zq.Click += new System.EventHandler(this.my_help_zq_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*.*";
            this.openFileDialog1.Multiselect = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*.*";
            this.saveFileDialog1.Title = "保存";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileName = "saveFileDialog2";
            this.saveFileDialog2.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*.*";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(950, 492);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "";
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // Text_EncodeType
            // 
            this.Text_EncodeType.Name = "Text_EncodeType";
            this.Text_EncodeType.Size = new System.Drawing.Size(150, 24);
            this.Text_EncodeType.Text = "Unicode (UTF-8)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 553);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZQ记事本";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel text_row;
        private System.Windows.Forms.ToolStripStatusLabel text_col;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem my_newfile;
        private System.Windows.Forms.ToolStripMenuItem my_openfile;
        private System.Windows.Forms.ToolStripMenuItem my_save;
        private System.Windows.Forms.ToolStripMenuItem my_saveas;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem my_exit;
        private System.Windows.Forms.ToolStripMenuItem my_edit;
        private System.Windows.Forms.ToolStripMenuItem my_edit_back;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem my_edit_cut;
        private System.Windows.Forms.ToolStripMenuItem my_edit_copy;
        private System.Windows.Forms.ToolStripMenuItem my_edit_paste;
        private System.Windows.Forms.ToolStripMenuItem my_edit_cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem my_format;
        private System.Windows.Forms.ToolStripMenuItem my_format_autoline;
        private System.Windows.Forms.ToolStripMenuItem my_format_form;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem my_check_info;
        private System.Windows.Forms.ToolStripMenuItem my_check_info_condition;
        private System.Windows.Forms.ToolStripMenuItem my_help;
        private System.Windows.Forms.ToolStripMenuItem my_help_info;
        private System.Windows.Forms.ToolStripMenuItem my_help_zq;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.ToolStripStatusLabel Text_EncodeType;
    }
}

