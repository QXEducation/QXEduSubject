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
    public partial class FormTeaSub : Form
    {
        //SPFT=SubjectPriceForTeacher
        public FormTeaSub()
        {
            InitializeComponent();
        }

        private void FormTeaSub_Load(object sender, EventArgs e)
        {
            Clear();
            Loading();
        }
        private void Clear()
        {
            txtTeaName.Clear();
            comTeaID.Items.Clear();
            txtTeaSex.Clear();
            txtTeaPhone.Clear();
            comGread1.SelectedIndex = -1;
            comGread2.Items.Clear();
            comSubID.Items.Clear();
            txtSubName.Clear();
            txtSPFT.Clear();
        }
        private void Loading()
        {
            labTeaName.Text = "教师姓名";
            labTeaID.Text = "教师编号";
            labTeaSex.Text = "教师性别";
            labTeaPhone.Text = "联系方式";
            labSubGread.Text = "教授年级";
            labSubID.Text = "课程编号";
            labSubName.Text = "课程名称";
            labSubPriForTea.Text = "课时费";
            btnClear.Text = "清空";
            btnInsert.Text = "录入";
            linTeaADD.Text = "添加教师";
            linTeaADD.Visible = false;
            DataTable DT = BLLDAL.GetGreadFromDB.getClassesDB();
            comGread1.Items.Clear();
            for(int i =0;i<DT.Rows.Count;i++)
            {
                comGread1.Items.Add(DT.Rows[i]["Classes"].ToString());
            }
        }

        private void comGread1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable DT = BLLDAL.GetGreadFromDB.getGreadDB(comGread1.Text);
            comGread2.Items.Clear();
            for(int i=0;i<DT.Rows.Count;i++)
            {
                comGread2.Items.Add(DT.Rows[i]["Gread"].ToString());
            }
        }

        private void comGread2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable DT = BLLDAL.RegStudents.getSubID(comGread1.Text + comGread2.Text);
            if (DT.Rows.Count != 0)
            {
                comSubID.Items.Clear();
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    comSubID.Items.Add(DT.Rows[i]["SubjectID"].ToString());
                }
                comSubID.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("请检查该年级下是否有课程", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comSubID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable DT = BLLDAL.RegStudents.getSubject(comSubID.Text);
            txtSubName.Text = DT.Rows[0]["SubjectName"].ToString();
        }

        private void txtTeaName_Leave(object sender, EventArgs e)
        {
            DataTable DT = BLLDAL.TeaSubject.getTeaCher(txtTeaName.Text);
            comTeaID.Items.Clear();
            if(DT.Rows.Count==0)
            {
                linTeaADD.Visible = true;
            }
            else
            {
                for(int i=0;i<DT.Rows.Count;i++)
                {
                    comTeaID.Items.Add(DT.Rows[i]["TeaID"].ToString());
                }
                comTeaID.SelectedIndex = 0;
            }
        }

        private void comTeaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable DT = BLLDAL.TeaSubject.getTeaInform(comTeaID.Text);
            txtTeaSex.Text = DT.Rows[0]["TeaSex"].ToString();
            txtTeaPhone.Text = DT.Rows[0]["TeaPhone"].ToString();
        }

        private void linTeaADD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormTeaInfo().ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtSPFT.Text != "")
            {
                if (BLLDAL.TeaSubject.check(comTeaID.Text, comSubID.Text))
                {
                    if (BLLDAL.TeaSubject.ifInsert(comTeaID.Text, comSubID.Text, txtSPFT.Text))
                    {
                        MessageBox.Show("添加成功");
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                }
                else
                {
                    MessageBox.Show("检测到重复科目");
                }
            }
            else
            {
                MessageBox.Show("请输入课时费");
            }
        }
    }
}
