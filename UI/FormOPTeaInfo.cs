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
    public partial class FormOPTeaInfo : Form
    {
        public FormOPTeaInfo()
        {
            InitializeComponent();
        }

        private void FormOPTeaInfo_Load(object sender, EventArgs e)
        {
            loading();
        }
        private void loading()
        {
            labTeaName.Text = "教师姓名";
            btnTNS.Text = "查询";
            tabPage1.Text = "姓名查询";
            tabPage2.Text = "来源查询";
            tabPage3.Text = "全部查询";
            labTeaCome.Text = "教师来源";
            btnTCSelect.Text = "查询";
            btnSelcetAll.Text = "查询";

            DataTable DT = BLLDAL.GetGreadFromDB.getTeaComes();
            comTeaCome.Items.Clear();
            for (int i=0;i<DT.Rows.Count;i++)
            {
                comTeaCome.Items.Add(DT.Rows[i]["TeaComes"].ToString());
                comTeaCome.SelectedIndex = -1;
            }
        }

        private void btnTNS_Click(object sender, EventArgs e)
        {
            DataTable DT = BLLDAL.UpdateDB.getSelectTeacherName(txtTeaName.Text);
            dataGridView1.DataSource = DT;
            dataGridView1.Update();

        }

        private void btnTCSelect_Click(object sender, EventArgs e)
        {
            DataTable DT = BLLDAL.UpdateDB.getSelectTeacherCome(comTeaCome.Text);
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
        }

        private void btnSelcetAll_Click(object sender, EventArgs e)
        {
            DataTable DT = BLLDAL.UpdateDB.getSelectALL();
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
        }
    }
}
