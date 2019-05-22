namespace MDI_winform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.my_File = new System.Windows.Forms.ToolStripMenuItem();
            this.my_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.my_File_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.my_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.my_Win = new System.Windows.Forms.ToolStripMenuItem();
            this.my_Win_New = new System.Windows.Forms.ToolStripMenuItem();
            this.my_Win_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.my_Win_Title = new System.Windows.Forms.ToolStripMenuItem();
            this.my_Win_Stack = new System.Windows.Forms.ToolStripMenuItem();
            this.my_Win_Title_H = new System.Windows.Forms.ToolStripMenuItem();
            this.my_Win_Title_V = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于MDI窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_File,
            this.my_Win,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // my_File
            // 
            this.my_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_File_Open,
            this.my_File_Close,
            this.my_File_Exit});
            this.my_File.Name = "my_File";
            this.my_File.Size = new System.Drawing.Size(80, 28);
            this.my_File.Text = "文件(&F)";
            this.my_File.DropDownOpened += new System.EventHandler(this.my_File_DropDownOpened);
            // 
            // my_File_Open
            // 
            this.my_File_Open.Name = "my_File_Open";
            this.my_File_Open.Size = new System.Drawing.Size(232, 28);
            this.my_File_Open.Text = "打开Form2窗口(&o)";
            this.my_File_Open.Click += new System.EventHandler(this.my_File_Open_Click);
            // 
            // my_File_Close
            // 
            this.my_File_Close.Name = "my_File_Close";
            this.my_File_Close.Size = new System.Drawing.Size(232, 28);
            this.my_File_Close.Text = "关闭Form2窗口(&C)";
            this.my_File_Close.Click += new System.EventHandler(this.my_File_Close_Click);
            // 
            // my_File_Exit
            // 
            this.my_File_Exit.Name = "my_File_Exit";
            this.my_File_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.my_File_Exit.Size = new System.Drawing.Size(232, 28);
            this.my_File_Exit.Text = "退出(&X)";
            this.my_File_Exit.Click += new System.EventHandler(this.my_File_Exit_Click);
            // 
            // my_Win
            // 
            this.my_Win.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_Win_New,
            this.my_Win_Close,
            this.toolStripMenuItem1,
            this.my_Win_Title,
            this.my_Win_Stack});
            this.my_Win.Name = "my_Win";
            this.my_Win.Size = new System.Drawing.Size(88, 28);
            this.my_Win.Text = "窗口(&W)";
            this.my_Win.DropDownOpened += new System.EventHandler(this.my_Win_DropDownOpened);
            // 
            // my_Win_New
            // 
            this.my_Win_New.Name = "my_Win_New";
            this.my_Win_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.my_Win_New.Size = new System.Drawing.Size(248, 28);
            this.my_Win_New.Text = "新建窗口(&N)";
            this.my_Win_New.Click += new System.EventHandler(this.my_Win_New_Click);
            // 
            // my_Win_Close
            // 
            this.my_Win_Close.Name = "my_Win_Close";
            this.my_Win_Close.Size = new System.Drawing.Size(179, 28);
            this.my_Win_Close.Text = "关闭窗口(&D)";
            this.my_Win_Close.Click += new System.EventHandler(this.my_Win_Close_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 6);
            // 
            // my_Win_Title
            // 
            this.my_Win_Title.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_Win_Title_H,
            this.my_Win_Title_V});
            this.my_Win_Title.Name = "my_Win_Title";
            this.my_Win_Title.Size = new System.Drawing.Size(179, 28);
            this.my_Win_Title.Text = "平铺窗口(&T)";
            // 
            // my_Win_Stack
            // 
            this.my_Win_Stack.Name = "my_Win_Stack";
            this.my_Win_Stack.Size = new System.Drawing.Size(248, 28);
            this.my_Win_Stack.Text = "层叠窗口(&S)";
            this.my_Win_Stack.Click += new System.EventHandler(this.my_Win_Stack_Click);
            // 
            // my_Win_Title_H
            // 
            this.my_Win_Title_H.Name = "my_Win_Title_H";
            this.my_Win_Title_H.Size = new System.Drawing.Size(178, 28);
            this.my_Win_Title_H.Text = "水平平铺(&H)";
            this.my_Win_Title_H.Click += new System.EventHandler(this.my_Win_Title_H_Click);
            // 
            // my_Win_Title_V
            // 
            this.my_Win_Title_V.Name = "my_Win_Title_V";
            this.my_Win_Title_V.Size = new System.Drawing.Size(178, 28);
            this.my_Win_Title_V.Text = "垂直平铺(&V)";
            this.my_Win_Title_V.Click += new System.EventHandler(this.my_Win_Title_V_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于MDI窗体ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(83, 28);
            this.帮助ToolStripMenuItem.Text = "帮助(&A)";
            // 
            // 关于MDI窗体ToolStripMenuItem
            // 
            this.关于MDI窗体ToolStripMenuItem.Name = "关于MDI窗体ToolStripMenuItem";
            this.关于MDI窗体ToolStripMenuItem.Size = new System.Drawing.Size(189, 28);
            this.关于MDI窗体ToolStripMenuItem.Text = "关于MDI窗体";
            this.关于MDI窗体ToolStripMenuItem.Click += new System.EventHandler(this.关于MDI窗体ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 542);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MDI_winform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem my_File;
        private System.Windows.Forms.ToolStripMenuItem my_File_Open;
        private System.Windows.Forms.ToolStripMenuItem my_File_Close;
        private System.Windows.Forms.ToolStripMenuItem my_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem my_Win;
        private System.Windows.Forms.ToolStripMenuItem my_Win_New;
        private System.Windows.Forms.ToolStripMenuItem my_Win_Close;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem my_Win_Title;
        private System.Windows.Forms.ToolStripMenuItem my_Win_Title_H;
        private System.Windows.Forms.ToolStripMenuItem my_Win_Title_V;
        private System.Windows.Forms.ToolStripMenuItem my_Win_Stack;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于MDI窗体ToolStripMenuItem;
    }
}

