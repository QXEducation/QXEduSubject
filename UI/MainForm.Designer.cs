namespace UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生意向调查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.学生成绩单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生特点及建议ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师科目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.科目录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缴费查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上课情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考试成果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生特点及分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.学生录入ToolStripMenuItem,
            this.教师录入ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出系统ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // 学生录入ToolStripMenuItem
            // 
            this.学生录入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生意向调查ToolStripMenuItem,
            this.学生注册ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.学生成绩单ToolStripMenuItem,
            this.学生特点及建议ToolStripMenuItem});
            this.学生录入ToolStripMenuItem.Name = "学生录入ToolStripMenuItem";
            this.学生录入ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学生录入ToolStripMenuItem.Text = "学生录入";
            // 
            // 学生意向调查ToolStripMenuItem
            // 
            this.学生意向调查ToolStripMenuItem.Name = "学生意向调查ToolStripMenuItem";
            this.学生意向调查ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.学生意向调查ToolStripMenuItem.Text = "学生意向调查";
            this.学生意向调查ToolStripMenuItem.Click += new System.EventHandler(this.学生意向调查ToolStripMenuItem_Click);
            // 
            // 学生注册ToolStripMenuItem
            // 
            this.学生注册ToolStripMenuItem.Name = "学生注册ToolStripMenuItem";
            this.学生注册ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.学生注册ToolStripMenuItem.Text = "学生注册";
            this.学生注册ToolStripMenuItem.Click += new System.EventHandler(this.学生注册ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem1.Text = "学生缴费登记";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 6);
            // 
            // 学生成绩单ToolStripMenuItem
            // 
            this.学生成绩单ToolStripMenuItem.Enabled = false;
            this.学生成绩单ToolStripMenuItem.Name = "学生成绩单ToolStripMenuItem";
            this.学生成绩单ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.学生成绩单ToolStripMenuItem.Text = "学生成绩单";
            this.学生成绩单ToolStripMenuItem.Click += new System.EventHandler(this.学生成绩单ToolStripMenuItem_Click);
            // 
            // 学生特点及建议ToolStripMenuItem
            // 
            this.学生特点及建议ToolStripMenuItem.Name = "学生特点及建议ToolStripMenuItem";
            this.学生特点及建议ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.学生特点及建议ToolStripMenuItem.Text = "学生特点及建议";
            this.学生特点及建议ToolStripMenuItem.Click += new System.EventHandler(this.学生特点及建议ToolStripMenuItem_Click);
            // 
            // 教师录入ToolStripMenuItem
            // 
            this.教师录入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.教师信息ToolStripMenuItem,
            this.教师科目ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.科目录入ToolStripMenuItem});
            this.教师录入ToolStripMenuItem.Name = "教师录入ToolStripMenuItem";
            this.教师录入ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.教师录入ToolStripMenuItem.Text = "教学信息录入";
            // 
            // 教师信息ToolStripMenuItem
            // 
            this.教师信息ToolStripMenuItem.Name = "教师信息ToolStripMenuItem";
            this.教师信息ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.教师信息ToolStripMenuItem.Text = "教师信息";
            this.教师信息ToolStripMenuItem.Click += new System.EventHandler(this.教师信息ToolStripMenuItem_Click);
            // 
            // 教师科目ToolStripMenuItem
            // 
            this.教师科目ToolStripMenuItem.Name = "教师科目ToolStripMenuItem";
            this.教师科目ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.教师科目ToolStripMenuItem.Text = "教师课时费";
            this.教师科目ToolStripMenuItem.Click += new System.EventHandler(this.教师科目ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 6);
            // 
            // 科目录入ToolStripMenuItem
            // 
            this.科目录入ToolStripMenuItem.Name = "科目录入ToolStripMenuItem";
            this.科目录入ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.科目录入ToolStripMenuItem.Text = "科目录入";
            this.科目录入ToolStripMenuItem.Click += new System.EventHandler(this.科目录入ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生信息ToolStripMenuItem,
            this.缴费查询ToolStripMenuItem,
            this.上课情况ToolStripMenuItem,
            this.考试成果ToolStripMenuItem,
            this.学生特点及分析ToolStripMenuItem,
            this.教师信息ToolStripMenuItem1});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 学生信息ToolStripMenuItem
            // 
            this.学生信息ToolStripMenuItem.Name = "学生信息ToolStripMenuItem";
            this.学生信息ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.学生信息ToolStripMenuItem.Text = "学生信息";
            this.学生信息ToolStripMenuItem.Click += new System.EventHandler(this.学生信息ToolStripMenuItem_Click);
            // 
            // 缴费查询ToolStripMenuItem
            // 
            this.缴费查询ToolStripMenuItem.Name = "缴费查询ToolStripMenuItem";
            this.缴费查询ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.缴费查询ToolStripMenuItem.Text = "缴费查询";
            this.缴费查询ToolStripMenuItem.Click += new System.EventHandler(this.缴费查询ToolStripMenuItem_Click);
            // 
            // 上课情况ToolStripMenuItem
            // 
            this.上课情况ToolStripMenuItem.Enabled = false;
            this.上课情况ToolStripMenuItem.Name = "上课情况ToolStripMenuItem";
            this.上课情况ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.上课情况ToolStripMenuItem.Text = "上课情况";
            this.上课情况ToolStripMenuItem.Click += new System.EventHandler(this.上课情况ToolStripMenuItem_Click);
            // 
            // 考试成果ToolStripMenuItem
            // 
            this.考试成果ToolStripMenuItem.Enabled = false;
            this.考试成果ToolStripMenuItem.Name = "考试成果ToolStripMenuItem";
            this.考试成果ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.考试成果ToolStripMenuItem.Text = "考试成果";
            this.考试成果ToolStripMenuItem.Click += new System.EventHandler(this.考试成果ToolStripMenuItem_Click);
            // 
            // 学生特点及分析ToolStripMenuItem
            // 
            this.学生特点及分析ToolStripMenuItem.Name = "学生特点及分析ToolStripMenuItem";
            this.学生特点及分析ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.学生特点及分析ToolStripMenuItem.Text = "学生特点及分析";
            this.学生特点及分析ToolStripMenuItem.Click += new System.EventHandler(this.学生特点及分析ToolStripMenuItem_Click);
            // 
            // 教师信息ToolStripMenuItem1
            // 
            this.教师信息ToolStripMenuItem1.Name = "教师信息ToolStripMenuItem1";
            this.教师信息ToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.教师信息ToolStripMenuItem1.Text = "教师信息";
            this.教师信息ToolStripMenuItem1.Click += new System.EventHandler(this.教师信息ToolStripMenuItem1_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.帮助ToolStripMenuItem.Text = "版本信息";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(65, 308);
            this.treeView1.TabIndex = 2;
            this.treeView1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "勤学教育信息管理系统-offline";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生意向调查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 学生成绩单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生特点及建议ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师科目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 科目录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缴费查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上课情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考试成果ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生特点及分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师信息ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TreeView treeView1;
    }
}