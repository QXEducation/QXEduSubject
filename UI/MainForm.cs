using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm(string UID)
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 学生意向调查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormStuInc().ShowDialog();
        }

        private void 学生注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormStuReg().ShowDialog();
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormRegList().ShowDialog();
        }

        private void 学生成绩单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormStuGreadin().ShowDialog();
        }

        private void 学生特点及建议ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormStuCharact().ShowDialog();
        }

        private void 教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormTeaInfo().ShowDialog();
        }

        private void 教师科目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormTeaSub().ShowDialog();
        }

        private void 科目录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSubjectInfo().ShowDialog();
        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormOPStuInfo().Show();
        }

        private void 缴费查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormOPstuReg().Show();
        }

        private void 上课情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormOPClass().Show();
        }

        private void 考试成果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormOPGread().Show();
        }

        private void 学生特点及分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormOPCharact().Show();
        }

        private void 教师信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormOPTeaInfo().Show();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormHelp().ShowDialog();
        }
    }
}
