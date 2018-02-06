using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class FormStuInc : Form
    {
        public FormStuInc()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtIncID.Clear();
            txtStuInc.Clear();
            txtStuName.Clear();
            txtStuPhone.Clear();
            txtStuSchool.Clear();
            txtStuSex.Clear();
        }
        private void Loading()
        {
            labIncID.Text = "意愿编号：";
            labInclination.Text = "学生意愿：";
            labStuName.Text = "姓名：";
            labStuPhone.Text = "联系方式：";
            labStuSchool.Text = "学校：";
            labStuSex.Text = "性别:";
            btnClear.Text = "清空";
            btnInsert.Text = "录入";
        }

        private void FormStuInc_Load(object sender, EventArgs e)
        {
            Clear();
            Loading();
        }

        private void btnInsert_MouseMove(object sender, MouseEventArgs e)
        {
            Check();
        }
        private void Check()
        {
            if(txtIncID.Text==""||txtStuInc.Text==""||txtStuName.Text==""||txtStuPhone.Text==""||txtStuSchool.Text==""||txtStuSex.Text=="")
            {
                MessageBox.Show("请检查是否留空", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool isInsert = BLLDAL.StuInc.ifInsert(txtIncID.Text, txtStuName.Text, txtStuSex.Text, txtStuSchool.Text, txtStuPhone.Text, txtStuInc.Text);
            if(isInsert)
            {
                MessageBox.Show("录入成功");
                Clear();
            }
            else
            {
                MessageBox.Show("录入失败！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
