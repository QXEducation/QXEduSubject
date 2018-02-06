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
    public partial class FormStuReg : Form
    {
        public FormStuReg()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            comStuSex.Text = "";
            txtStuID.Clear();
            txtStuInc.Clear();
            txtStuName.Clear();
            txtStuPhone.Clear();
            txtStuSchool.Clear();
            comStuSex.SelectedIndex = -1;

        }
        private void Loading()
        {
            labStuID.Text = "学生编号：";
            labStuInc.Text = "意愿编号：";
            labStuName.Text = "姓名：";
            labStuPhone.Text = "联系方式:";
            labStuSchool.Text = "学校：";
            labStuSex.Text = "性别：";
            btnClear.Text = "清空";
            btnInsert.Text = "注册";
        }

        private void FormStuReg_Load(object sender, EventArgs e)
        {
            Clear();
            Loading();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string StuInc;
            if (txtStuInc.Text == "")
                StuInc = "0";
            else
            {
                StuInc = txtStuInc.Text;
            }
            bool ifInsert=BLLDAL.RegStu.ifRegStu(txtStuID.Text, txtStuName.Text, comStuSex.Text, txtStuSchool.Text,txtStuPhone.Text, StuInc);
            if(ifInsert)
            {
                MessageBox.Show("录入成功");
                Clear();
            }
            else
            {
                MessageBox.Show("录入失败！", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkTxt()
        {
            if(txtStuID.Text==""||txtStuName.Text==""||txtStuPhone.Text==""||txtStuSchool.Text==""||comStuSex.Text=="")
            {
                MessageBox.Show("请检查是否留空", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInsert_MouseMove(object sender, MouseEventArgs e)
        {
            checkTxt();
        }
    }
}
