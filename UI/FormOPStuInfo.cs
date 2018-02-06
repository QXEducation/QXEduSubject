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
    public partial class FormOPStuInfo : Form
    {
        public FormOPStuInfo()
        {
            InitializeComponent();
        }

        private void FormOPStuInfo_Load(object sender, EventArgs e)
        {
            Loading();

        }
        private void Clear()
        {
            txtStuName.Clear();
            comStuID.Items.Clear();
            txtStuSex.Clear();
            txtStuSchool.Clear();
            txtStuPhone.Clear();
            linReSelcet.Visible = true;
            linStuCharact.Visible = false;
            linUpdate.Visible = false;
            btnUpdate.Visible = false;
            btnClear.Visible = false;
            txtStuSchool.ReadOnly = true;
            txtStuSex.ReadOnly = true;
            txtStuPhone.ReadOnly = true;
        }
        private void Loading()
        {
            labStuName.Text = "学生姓名";
            labStuID.Text = "学生编号";
            labStuSex.Text = "学生性别";
            labStuSchool.Text = "学生学校";
            labStuPhone.Text = "联系方式";
            linStuCharact.Text = "学生特点及建议";
            linUpdate.Text = "修改学生信息";
            linReSelcet.Text = "重置查询";
            btnUpdate.Text = "写入修改";
            btnClear.Text = "撤销修改";
        }
        private void Selected()
        {
            DataTable DT = BLLDAL.RegStudents.getStudent(comStuID.Text);
            txtStuSex.Text = DT.Rows[0]["StuSex"].ToString();
            txtStuSchool.Text = DT.Rows[0]["StuSchool"].ToString();
            txtStuPhone.Text = DT.Rows[0]["StuPhone"].ToString();
            linStuCharact.Visible = true;
            linUpdate.Visible = true;
        }
        private void linUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtStuSex.ReadOnly = false;
            txtStuSchool.ReadOnly = false;
            txtStuPhone.ReadOnly = false;
            btnUpdate.Visible = true;
            btnClear.Visible = true;
            linReSelcet.Visible = false;
        }

        private void linReSelcet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
        }

        private void txtStuName_Leave(object sender, EventArgs e)
        {
            DataTable DT = BLLDAL.RegStudents.getStuID(txtStuName.Text);
            if(DT.Rows.Count==0)
            {
                MessageBox.Show("未查询到该姓名对应编号，请核对有无错字");
            }
            else
            {
                comStuID.Items.Clear();
               for(int i=0;i<DT.Rows.Count;i++)
                {
                    comStuID.Items.Add(DT.Rows[i]["StuID"].ToString());
                }
                comStuID.SelectedIndex = 0;
            }
        }

        private void comStuID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearSelcet();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool ifUpdate = BLLDAL.UpdateDB.UpdateStuDB(comStuID.Text, txtStuName.Text, txtStuSex.Text, txtStuSchool.Text, txtStuPhone.Text);
            if(ifUpdate)
            {
                MessageBox.Show("更新成功");
                ClearSelcet();

            }
            else
            {
                MessageBox.Show("更新失败");
            }
        }
        private void ClearSelcet()
        {
            Selected();
            txtStuSex.ReadOnly = true;
            txtStuSchool.ReadOnly = true;
            txtStuPhone.ReadOnly = true;
            btnUpdate.Visible = false;
            btnClear.Visible = false;
            linReSelcet.Visible = true;
        }

        private void linStuCharact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormOPCharact(comStuID.Text,txtStuName.Text).Show();
        }
    }
}
