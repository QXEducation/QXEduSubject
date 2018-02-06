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
    public partial class FormOPCharact : Form
    {
        bool Insert = false;
        public FormOPCharact()
        {
            InitializeComponent();
        }
        public FormOPCharact(string StuIDd,string StuNames)
        {
            InitializeComponent();
            //StuIDin = StuIDd;
            //StuName = StuNames;
            txtStuName.Text = StuNames;
            comStuID.Items.Add(StuIDd);
            comStuID.SelectedIndex = 0;
        }

        private void FormOPCharact_Load(object sender, EventArgs e)
        {
        //  clear();
            Loading();
        }
        private void clear()
        {
            txtStuName.Clear();
            txtStuSchool.Clear();
            txtStuSex.Clear();
            txtStuCharact.Clear();
            txtTeaInform.Clear();
            comStuID.Items.Clear();
            comStuID.SelectedIndex = -1;
            //linUpdate.Visible = false;
            btnUpdate.Visible = false;
            btnClear.Visible = false;
            linReSelcet.Visible = true;
        }
        private void Loading()
        {
            labStuName.Text = "学生姓名";
            labStuId.Text = "学生编号";
            labStuSchool.Text = "学校";
            labStuSex.Text = "性别";
            labStuCharaact.Text = "学生特点";
            labTeaInform.Text = "教师建议";
            linReSelcet.Text = "重置查询";
            linUpdate.Text = "修改数据";
            btnUpdate.Text = "更新数据";
            btnClear.Text = "撤销更新";
            ReClear();
            
        }

        private void linReSelcet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clear();
        }

        private void linUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linUpdate.Visible = false;
            txtStuCharact.ReadOnly =false;
            txtTeaInform.ReadOnly = false;
            btnUpdate.Visible = true;
            btnClear.Visible = true;
            linReSelcet.Visible = false;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ReClear();
            Selected();
        }

        private void txtStuName_Leave(object sender, EventArgs e)
        {
            DataTable DT = BLLDAL.RegStudents.getStuID(txtStuName.Text);
            if (DT.Rows.Count != 0)
            {
                comStuID.Items.Clear();
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    comStuID.Items.Add(DT.Rows[i]["StuID"]);
                }
                comStuID.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("未查询到该姓名对应编号，请核对有无错字");
            }
        }

        private void comStuID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected();
        }

        private void ReClear()
        {
            txtStuCharact.ReadOnly = true;
            txtTeaInform.ReadOnly = true;
            //linUpdate.Visible = false;
            btnUpdate.Visible = false;
            btnClear.Visible = false;
            linReSelcet.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(Insert)
            {
                bool ifInsert=BLLDAL.InsertStuCharact.ifInsert(comStuID.Text, txtStuCharact.Text, txtTeaInform.Text);
                if(ifInsert)
                {
                    MessageBox.Show("录入成功");
                    Selected();
                    ReClear();
                }
                else
                {
                    MessageBox.Show("录入失败");
                }
            }
            else
            {
                bool ifInsert = BLLDAL.UpdateDB.UpdateChaDB(comStuID.Text, txtStuCharact.Text, txtTeaInform.Text);
                if(ifInsert)
                {
                    MessageBox.Show("更新成功");
                    Selected();
                    ReClear();
                }
                else
                {
                    MessageBox.Show("更新失败");
                }
            }
        }

        private void Selected()
        {
            linUpdate.Visible = true;
            DataTable DTInform = BLLDAL.RegStudents.getStudent(comStuID.Text);
            DataTable DTChara = BLLDAL.InsertStuCharact.getChaDT(comStuID.Text);
            txtStuSex.Text = DTInform.Rows[0]["StuSex"].ToString();
            txtStuSchool.Text = DTInform.Rows[0]["StuSchool"].ToString();
            if (DTChara.Rows.Count != 0)
            {
                txtStuCharact.Text = DTChara.Rows[0]["StuCharact"].ToString();
                txtTeaInform.Text = DTChara.Rows[0]["TeaInform"].ToString();
                Insert = false;
            }
            else
            {
                txtStuCharact.Text = "";
                txtTeaInform.Text = "";
                Insert = true;
            }
        }
    }
}
