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
    public partial class FormSubjectInfo : Form
    {
        public FormSubjectInfo()
        {
            InitializeComponent();
        }

        private void FormSubjectInfo_Load(object sender, EventArgs e)
        {
            Loading();
            ClearInLoad();
           

        }

        private void comGread1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comGread2.Items.Clear();
            comGread2.Text = "";
            DataTable GetGread = BLLDAL.GetGreadFromDB.getGreadDB(comGread1.SelectedItem.ToString());
            for (int i = 0; i < GetGread.Rows.Count; i++)
            {
                comGread2.Items.Add(GetGread.Rows[i]["Gread"].ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void Loading()
        {
            libSubID.Text = "课程编号";
            libSubName.Text = "课程名称";
            libSubGread.Text = "课程年级";
            libSubTime.Text = "课程时间";
            libSubPrice.Text = "课程价格";
            libIfPacked.Text = "是否为活动课程";
            IfPackedNo.Text = "否";
            IfPackedYes.Text = "是";
            btnInsert.Text = "注册课程";
            btnClear.Text = "清空";
            labSubText.Text = "课程介绍";
        }
        private void ClearInLoad()
        {
            comGread1.Items.Clear();
            comGread2.Items.Clear();
            DataTable GetGread = BLLDAL.GetGreadFromDB.getClassesDB();
            for (int i = 0; i < GetGread.Rows.Count; i++)
            {
                comGread1.Items.Add(GetGread.Rows[i]["Classes"].ToString());
            }
            txtSubName.Clear();
            comGread1.Text = "";
            comGread2.Items.Clear();
            txtTime.Clear();
            txtPrice.Clear();
            IfPackedNo.Checked = false;
            IfPackedYes.Checked = false;
            txtSubID.Clear();
            txtSubText.Clear();
        }
        private void Clear()
        {
            txtSubName.Clear();
            comGread1.Text = "";
            comGread2.Text = "";
            comGread2.Items.Clear();
            txtTime.Clear();
            txtPrice.Clear();
            IfPackedNo.Checked = false;
            IfPackedYes.Checked = false;
            txtSubID.Clear();
            txtSubText.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {


            try
            {
                string pack = "";
                if (IfPackedNo.Checked == true && IfPackedYes.Checked == false)
                    pack = "No";
                else if (IfPackedNo.Checked == false && IfPackedYes.Checked == true)
                    pack = "Yes";
                else
                    MessageBox.Show("请选择是否为活动课程！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                bool ifInsert = BLLDAL.InsertSubject.InsSub(txtSubID.Text, txtSubName.Text, comGread1.Text, comGread2.Text, txtTime.Text, txtPrice.Text, pack, txtSubText.Text);
                if (ifInsert)
                {
                    MessageBox.Show("添加成功");
                    Clear();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void CheckALL()
        {
            if(checkTxt())
            {
                if(checkChecked())
                {
                    if (checkCom())
                    {
                        //return true;
                    }
                    else
                    {
                        MessageBox.Show("请确认年级是否正确", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("请确认是否是活动课程", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请确认是否有项目未填写", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool checkTxt()
        {
            if(txtPrice.Text==""||txtSubID.Text==""||txtSubName.Text==""||txtSubText.Text==""||txtTime.Text=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool checkChecked()
        {
            if(IfPackedNo.Checked==false&&IfPackedYes.Checked==false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool checkCom()
        {
            if (comGread1.Text == "01小学" || comGread1.Text == "02初中" || comGread1.Text == "03高中")
            {
                if (comGread2.Text == "01一年级" || comGread2.Text == "02二年级" || comGread2.Text == "03三年级" || comGread2.Text == "04四年级" || comGread2.Text == "05五年级")
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        private void btnInsert_MouseMove(object sender, MouseEventArgs e)
        {
            CheckALL();
        }
    }
}
