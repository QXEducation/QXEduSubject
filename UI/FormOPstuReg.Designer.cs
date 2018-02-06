namespace UI
{
    partial class FormOPstuReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOPstuReg));
            this.labStuName = new System.Windows.Forms.Label();
            this.labStuID = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.comStuID = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuRegGread = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labStuName
            // 
            this.labStuName.AutoSize = true;
            this.labStuName.Location = new System.Drawing.Point(75, 23);
            this.labStuName.Name = "labStuName";
            this.labStuName.Size = new System.Drawing.Size(47, 12);
            this.labStuName.TabIndex = 0;
            this.labStuName.Text = "StuName";
            // 
            // labStuID
            // 
            this.labStuID.AutoSize = true;
            this.labStuID.Location = new System.Drawing.Point(75, 48);
            this.labStuID.Name = "labStuID";
            this.labStuID.Size = new System.Drawing.Size(35, 12);
            this.labStuID.TabIndex = 1;
            this.labStuID.Text = "StuID";
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(128, 20);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(121, 21);
            this.txtStuName.TabIndex = 2;
            this.txtStuName.Leave += new System.EventHandler(this.txtStuName_Leave);
            // 
            // comStuID
            // 
            this.comStuID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comStuID.FormattingEnabled = true;
            this.comStuID.Location = new System.Drawing.Point(128, 46);
            this.comStuID.Name = "comStuID";
            this.comStuID.Size = new System.Drawing.Size(121, 20);
            this.comStuID.TabIndex = 3;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(268, 43);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegID,
            this.StuID,
            this.StuRegGread,
            this.SubjectID,
            this.Price,
            this.PayFor});
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(519, 261);
            this.dataGridView1.TabIndex = 5;
            // 
            // RegID
            // 
            this.RegID.DataPropertyName = "RegID";
            this.RegID.HeaderText = "缴费编号";
            this.RegID.Name = "RegID";
            // 
            // StuID
            // 
            this.StuID.DataPropertyName = "StuId";
            this.StuID.HeaderText = "StuID";
            this.StuID.Name = "StuID";
            this.StuID.Visible = false;
            // 
            // StuRegGread
            // 
            this.StuRegGread.DataPropertyName = "StuRegGread";
            this.StuRegGread.HeaderText = "注册年级";
            this.StuRegGread.Name = "StuRegGread";
            // 
            // SubjectID
            // 
            this.SubjectID.DataPropertyName = "SubjectID";
            this.SubjectID.HeaderText = "课程编号";
            this.SubjectID.Name = "SubjectID";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "价格";
            this.Price.Name = "Price";
            // 
            // PayFor
            // 
            this.PayFor.DataPropertyName = "PayFor";
            this.PayFor.HeaderText = "支付方式";
            this.PayFor.Name = "PayFor";
            // 
            // FormOPstuReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 344);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.comStuID);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.labStuID);
            this.Controls.Add(this.labStuName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOPstuReg";
            this.Text = "缴费查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStuName;
        private System.Windows.Forms.Label labStuID;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.ComboBox comStuID;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuRegGread;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayFor;
    }
}