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
    public partial class FormStuCharact : Form
    {
        DataTable IDdt;
        public FormStuCharact()
        {
            InitializeComponent();
        }

        private void txtStuName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtStuName_Leave(object sender, EventArgs e)
        {
            IDdt = BLLDAL.InsertStuCharact.getComDT(txtStuName.Text);
            if (IDdt.Rows.Count == 0)
            {
               // btnTmp.Visible = true;
                MessageBox.Show("未查询到学生信息，请检查姓名是否错误，或添加学生信息！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < IDdt.Rows.Count; i++)
                {
                    comStuID.Items.Add(IDdt.Rows[i]["StuID"].ToString());
                }
                comStuID.SelectedIndex = 0;
            }
        }

        private void comStuID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStuSex.Text = IDdt.Rows[comStuID.SelectedIndex]["StuSex"].ToString();
            txtStuSchool.Text = IDdt.Rows[comStuID.SelectedIndex]["StuSchool"].ToString();
            txtStuPhone.Text = IDdt.Rows[comStuID.SelectedIndex]["StuPhone"].ToString();

            DataTable ChaDT = BLLDAL.InsertStuCharact.getChaDT(comStuID.SelectedItem.ToString());
            if(ChaDT.Rows.Count!=0)
            {
                txtStuCharact.Text = ChaDT.Rows[0]["StuCharact"].ToString();
                txtTeaInform.Text = ChaDT.Rows[0]["TeaInform"].ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtStuName.Clear();
            comStuID.Items.Clear();
            txtStuSex.Clear();
            txtStuSchool.Clear();
            txtStuPhone.Clear();
            txtStuCharact.Clear();
            txtTeaInform.Clear();
            btnTmp.Visible = false;
        }
        private void Loading()
        {
            labStuID.Text = "学生编号";
            labStuName.Text = "学生姓名";
            labStuSex.Text = "学生性别";
            labStuSchool.Text = "学校";
            labStuPhone.Text = "学生联系方式";
            labStuCharact.Text = "学生特点";
            labTeaInform.Text = "教师建议";
            btnInsert.Text = "录入";
            btnClear.Text = "清空";
            btnTmp.Text = "添加学生信息";
            btnTmp.Visible = false;
        }

        private void FormStuCharact_Load(object sender, EventArgs e)
        {
            Loading();
            Clear();
        }

        private void btnTmp_Click(object sender, EventArgs e)
        {
           //窗口跳转，暂未添加

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool ifInsert = BLLDAL.InsertStuCharact.ifInsert(comStuID.SelectedItem.ToString(), txtStuCharact.Text.ToString(), txtTeaInform.Text);
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
