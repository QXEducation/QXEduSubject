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
    public partial class FormOPstuReg : Form
    {
        public FormOPstuReg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = BLLDAL.DBConn.getDT("select * from StudentRegList");
            //dataGridView1.Update();
            DataTable DT = BLLDAL.UpdateDB.getStuReg(comStuID.Text);
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
        }

        private void txtStuName_Leave(object sender, EventArgs e)
        {
            DataTable DT = BLLDAL.RegStudents.getStuID(txtStuName.Text);
            comStuID.Items.Clear();
            for(int i=0;i<DT.Rows.Count;i++)
            {
                comStuID.Items.Add(DT.Rows[i]["StuID"].ToString());
            }
            comStuID.SelectedIndex = 0;
        }
    }
}
