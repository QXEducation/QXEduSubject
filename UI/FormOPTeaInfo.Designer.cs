namespace UI
{
    partial class FormOPTeaInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOPTeaInfo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeaUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeaSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeaPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeaComes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTNS = new System.Windows.Forms.Button();
            this.txtTeaName = new System.Windows.Forms.TextBox();
            this.labTeaName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comTeaCome = new System.Windows.Forms.ComboBox();
            this.btnTCSelect = new System.Windows.Forms.Button();
            this.labTeaCome = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSelcetAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeaID,
            this.TeaUS,
            this.TeaName,
            this.TeaSex,
            this.TeaPhone,
            this.TeaComes});
            this.dataGridView1.Location = new System.Drawing.Point(62, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(543, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // TeaID
            // 
            this.TeaID.DataPropertyName = "TeaID";
            this.TeaID.HeaderText = "教师编号";
            this.TeaID.Name = "TeaID";
            // 
            // TeaUS
            // 
            this.TeaUS.DataPropertyName = "TeaUs";
            this.TeaUS.HeaderText = "校内教师";
            this.TeaUS.Name = "TeaUS";
            this.TeaUS.Visible = false;
            // 
            // TeaName
            // 
            this.TeaName.DataPropertyName = "TeaName";
            this.TeaName.HeaderText = "教师姓名";
            this.TeaName.Name = "TeaName";
            // 
            // TeaSex
            // 
            this.TeaSex.DataPropertyName = "TeaSex";
            this.TeaSex.HeaderText = "教师性别";
            this.TeaSex.Name = "TeaSex";
            // 
            // TeaPhone
            // 
            this.TeaPhone.DataPropertyName = "TeaPhone";
            this.TeaPhone.HeaderText = "联系方式";
            this.TeaPhone.Name = "TeaPhone";
            // 
            // TeaComes
            // 
            this.TeaComes.DataPropertyName = "TeaComes";
            this.TeaComes.HeaderText = "教师来源";
            this.TeaComes.Name = "TeaComes";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(62, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 74);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTNS);
            this.tabPage1.Controls.Add(this.txtTeaName);
            this.tabPage1.Controls.Add(this.labTeaName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 48);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTNS
            // 
            this.btnTNS.Location = new System.Drawing.Point(190, 6);
            this.btnTNS.Name = "btnTNS";
            this.btnTNS.Size = new System.Drawing.Size(75, 23);
            this.btnTNS.TabIndex = 2;
            this.btnTNS.Text = "Select";
            this.btnTNS.UseVisualStyleBackColor = true;
            this.btnTNS.Click += new System.EventHandler(this.btnTNS_Click);
            // 
            // txtTeaName
            // 
            this.txtTeaName.Location = new System.Drawing.Point(72, 7);
            this.txtTeaName.Name = "txtTeaName";
            this.txtTeaName.Size = new System.Drawing.Size(100, 21);
            this.txtTeaName.TabIndex = 1;
            // 
            // labTeaName
            // 
            this.labTeaName.AutoSize = true;
            this.labTeaName.Location = new System.Drawing.Point(7, 11);
            this.labTeaName.Name = "labTeaName";
            this.labTeaName.Size = new System.Drawing.Size(47, 12);
            this.labTeaName.TabIndex = 0;
            this.labTeaName.Text = "TeaName";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comTeaCome);
            this.tabPage2.Controls.Add(this.btnTCSelect);
            this.tabPage2.Controls.Add(this.labTeaCome);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(535, 48);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comTeaCome
            // 
            this.comTeaCome.FormattingEnabled = true;
            this.comTeaCome.Location = new System.Drawing.Point(60, 9);
            this.comTeaCome.Name = "comTeaCome";
            this.comTeaCome.Size = new System.Drawing.Size(121, 20);
            this.comTeaCome.TabIndex = 3;
            // 
            // btnTCSelect
            // 
            this.btnTCSelect.Location = new System.Drawing.Point(187, 7);
            this.btnTCSelect.Name = "btnTCSelect";
            this.btnTCSelect.Size = new System.Drawing.Size(75, 23);
            this.btnTCSelect.TabIndex = 2;
            this.btnTCSelect.Text = "Select";
            this.btnTCSelect.UseVisualStyleBackColor = true;
            this.btnTCSelect.Click += new System.EventHandler(this.btnTCSelect_Click);
            // 
            // labTeaCome
            // 
            this.labTeaCome.AutoSize = true;
            this.labTeaCome.Location = new System.Drawing.Point(7, 11);
            this.labTeaCome.Name = "labTeaCome";
            this.labTeaCome.Size = new System.Drawing.Size(47, 12);
            this.labTeaCome.TabIndex = 0;
            this.labTeaCome.Text = "TeaCome";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSelcetAll);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(535, 48);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSelcetAll
            // 
            this.btnSelcetAll.Location = new System.Drawing.Point(84, 6);
            this.btnSelcetAll.Name = "btnSelcetAll";
            this.btnSelcetAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelcetAll.TabIndex = 0;
            this.btnSelcetAll.Text = "Select";
            this.btnSelcetAll.UseVisualStyleBackColor = true;
            this.btnSelcetAll.Click += new System.EventHandler(this.btnSelcetAll_Click);
            // 
            // FormOPTeaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 453);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOPTeaInfo";
            this.Text = "教师信息";
            this.Load += new System.EventHandler(this.FormOPTeaInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnTNS;
        private System.Windows.Forms.TextBox txtTeaName;
        private System.Windows.Forms.Label labTeaName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnTCSelect;
        private System.Windows.Forms.Label labTeaCome;
        private System.Windows.Forms.ComboBox comTeaCome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaComes;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSelcetAll;
    }
}