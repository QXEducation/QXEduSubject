using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace UI
{
    public partial class FormRegList : Form
    {
        public FormRegList()
        {
            InitializeComponent();
        }
        public void Clear()
        {

            txtRegId.Clear();
            txtStuName.Clear();
            comStuID.Items.Clear();
            comStuID.DropDownStyle = ComboBoxStyle.DropDownList;
            txtStuSex.Clear();
            txtStuSex.ReadOnly = true;
            txtStuSchool.Clear();
            txtStuSchool.ReadOnly = true;
            comGread1.SelectedIndex = -1;
            comGread2.Items.Clear();
            comSubID.Items.Clear();
            comSubID.SelectedIndex = -1;
            txtSubName.Clear();
            txtSubPrice.Clear();
            txtPrice.Clear();
            comPayFor.SelectedIndex = -1;
            btnInsert.Visible = false;
            btnReIn.Visible = false;
            linDisAdd.Visible = false;
            linlabStuAdd.Visible = true;
        }
        private void Loading()
        {
            labRegId.Text = "缴费编号";
            labStuName.Text = "学生姓名";
            labStuID.Text = "学生编号";
            labStuSchool.Text = "学校";
            labStuSex.Text = "性别";
            labStuRegGread.Text = "注册学年";
            labSubID.Text = "科目编号";
            labSubName.Text = "科目名称";
            labSubPrice.Text = "科目价格";
            labPrice.Text = "支付价格";
            labPayFor.Text = "支付方式";
            btnInsert.Text = "缴费";
            btnReIn.Text = "录入并缴费";
            btnClear.Text = "清空";
            linlabStuAdd.Text = "进入学生注册模式";
            linDisAdd.Text = "取消学生注册模式";
            DataTable DT = BLLDAL.GetGreadFromDB.getClassesDB();
            comGread2.Items.Clear();
            for(int i=0;i<DT.Rows.Count;i++)
            {
                comGread1.Items.Add(DT.Rows[i]["Classes"].ToString());
            }
        }

        private void txtStuName_Leave(object sender, EventArgs e)
        {
            int count= BLLDAL.RegStudents.getRegIDDT();
            if (count == -1)
            {
                MessageBox.Show("数据库连接错误，请检查数据库", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtRegId.Text = count.ToString();
                DataTable DT = BLLDAL.RegStudents.getStuID(txtStuName.Text);
                if (DT.Rows.Count != 0)
                {
                    btnInsert.Visible = true;
                    comStuID.Items.Clear();
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        comStuID.Items.Add(DT.Rows[i]["StuID"].ToString());
                    }
                    comStuID.SelectedIndex = 0;
                }
                else
                {
                    Rein();
                }
            }
        }

        private void FormRegList_Load(object sender, EventArgs e)
        {
            Clear();
            Loading();
        }

        private void linlabStuAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rein();
        }

        private void comSubID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable DT = BLLDAL.RegStudents.getSubject(comSubID.Text);
            txtSubName.Text = DT.Rows[0]["SubjectName"].ToString();
            txtSubPrice.Text = DT.Rows[0]["SubjectPrice"].ToString();
            txtPrice.Text = txtSubPrice.Text;
        }

        private void comGread2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Gread = comGread1.Text + comGread2.Text;
            DataTable DT = BLLDAL.RegStudents.getSubID(Gread);
            comSubID.Items.Clear();
            for(int i =0;i<DT.Rows.Count;i++)
            {
                comSubID.Items.Add(DT.Rows[i]["SubjectID"].ToString());
            }
            comSubID.SelectedIndex = 0;
        }
        private void Rein()
        {
            comStuID.DropDownStyle = ComboBoxStyle.DropDown;
            txtStuSex.ReadOnly = false;
            txtStuSchool.ReadOnly = false;
            btnInsert.Visible = false;
            btnReIn.Visible = true;
            linDisAdd.Visible = true;
            linlabStuAdd.Visible = false;
        }

        private void comGread1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable DT = BLLDAL.GetGreadFromDB.getGreadDB(comGread1.Text);
            comGread2.Items.Clear();
            for (int i = 0; i < DT.Rows.Count; i++)
                comGread2.Items.Add(DT.Rows[i]["Gread"].ToString());
        }

        private void comStuID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable DT = BLLDAL.RegStudents.getStudent(comStuID.Text);
            if (DT.Rows.Count != 0)
            {
                txtStuSchool.Text = DT.Rows[0]["StuSchool"].ToString();
                txtStuSex.Text = DT.Rows[0]["StuSex"].ToString();
                btnInsert.Visible = true;
                btnReIn.Visible = false;
            }
            else
            {
                Rein();
            }
        }

        private void linDisAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comStuID.Items.Count == 0)
            {
                MessageBox.Show("退出学生注册模式失败,请核对学生姓名或清空填写", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                comStuID.DropDownStyle = ComboBoxStyle.DropDownList;
                txtStuSex.ReadOnly = true;
                txtStuSchool.ReadOnly = true;
                linDisAdd.Visible = false;
                linlabStuAdd.Visible = true;
                btnReIn.Visible = false;
                btnInsert.Visible = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool isInsert = BLLDAL.RegStudents.Insert(txtRegId.Text, comStuID.Text, comGread1.Text + comGread2.Text, comSubID.Text, txtPrice.Text, comPayFor.Text);
            if(isInsert)
            {
                MessageBox.Show("添加成功");
                Clear();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void btnReIn_Click(object sender, EventArgs e)
        {
            bool isInsert = BLLDAL.RegStudents.ReInsert(comStuID.Text, txtStuName.Text, txtStuSex.Text, txtStuSchool.Text, null, txtRegId.Text, comGread1.Text + comGread2.Text, comSubID.Text, txtPrice.Text, comPayFor.Text);
            if(isInsert)
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
