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
    public partial class FormTeaInfo : Form
    {
        public FormTeaInfo()
        {
            InitializeComponent();
        }

        private void FormTeaInfo_Load(object sender, EventArgs e)
        {
            Clear();
            Loading();
        }
        private void Clear()
        {
            txtTeaID.Clear();
            txtTeaName.Clear();
            txtTeaPhone.Clear();
            txtTeaSex.Clear();
            txtTmp.Clear();
        }
        private void Loading()
        {
            labTeaID.Text = "教师编号：";
            labTeaName.Text = "教师姓名：";
            labTeaPhone.Text = "联系方式：";
            labTeaSex.Text = "性别：";
            labTmp.Text = "教师来源";
            btnInsert.Text = "录入";
            btnClear.Text = "清空";
            labTmp.Visible = true;
            txtTmp.Visible = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool ifInsert = BLL_DAL.TeaInsert.InsTea(txtTeaID.Text, txtTeaName.Text, txtTeaSex.Text, txtTeaPhone.Text, "1", txtTmp.Text);
            if(ifInsert)
            {
                MessageBox.Show("添加成功");
                Clear();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }
    }
}
