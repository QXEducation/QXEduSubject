namespace UI
{
    partial class FormStuReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStuReg));
            this.labStuID = new System.Windows.Forms.Label();
            this.labStuName = new System.Windows.Forms.Label();
            this.labStuSex = new System.Windows.Forms.Label();
            this.labStuSchool = new System.Windows.Forms.Label();
            this.labStuPhone = new System.Windows.Forms.Label();
            this.labStuInc = new System.Windows.Forms.Label();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuSchool = new System.Windows.Forms.TextBox();
            this.txtStuPhone = new System.Windows.Forms.TextBox();
            this.txtStuInc = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.comStuSex = new System.Windows.Forms.ComboBox();
            this.comSchool = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labStuID
            // 
            this.labStuID.AutoSize = true;
            this.labStuID.Location = new System.Drawing.Point(99, 62);
            this.labStuID.Name = "labStuID";
            this.labStuID.Size = new System.Drawing.Size(35, 12);
            this.labStuID.TabIndex = 0;
            this.labStuID.Text = "StuID";
            // 
            // labStuName
            // 
            this.labStuName.AutoSize = true;
            this.labStuName.Location = new System.Drawing.Point(99, 93);
            this.labStuName.Name = "labStuName";
            this.labStuName.Size = new System.Drawing.Size(47, 12);
            this.labStuName.TabIndex = 1;
            this.labStuName.Text = "StuName";
            // 
            // labStuSex
            // 
            this.labStuSex.AutoSize = true;
            this.labStuSex.Location = new System.Drawing.Point(99, 124);
            this.labStuSex.Name = "labStuSex";
            this.labStuSex.Size = new System.Drawing.Size(41, 12);
            this.labStuSex.TabIndex = 2;
            this.labStuSex.Text = "StuSex";
            // 
            // labStuSchool
            // 
            this.labStuSchool.AutoSize = true;
            this.labStuSchool.Location = new System.Drawing.Point(99, 155);
            this.labStuSchool.Name = "labStuSchool";
            this.labStuSchool.Size = new System.Drawing.Size(59, 12);
            this.labStuSchool.TabIndex = 3;
            this.labStuSchool.Text = "StuSchool";
            // 
            // labStuPhone
            // 
            this.labStuPhone.AutoSize = true;
            this.labStuPhone.Location = new System.Drawing.Point(99, 186);
            this.labStuPhone.Name = "labStuPhone";
            this.labStuPhone.Size = new System.Drawing.Size(53, 12);
            this.labStuPhone.TabIndex = 4;
            this.labStuPhone.Text = "StuPhone";
            // 
            // labStuInc
            // 
            this.labStuInc.AutoSize = true;
            this.labStuInc.Location = new System.Drawing.Point(99, 217);
            this.labStuInc.Name = "labStuInc";
            this.labStuInc.Size = new System.Drawing.Size(41, 12);
            this.labStuInc.TabIndex = 5;
            this.labStuInc.Text = "StuInc";
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(191, 59);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(100, 21);
            this.txtStuID.TabIndex = 6;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(191, 90);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 21);
            this.txtStuName.TabIndex = 7;
            // 
            // txtStuSchool
            // 
            this.txtStuSchool.Location = new System.Drawing.Point(191, 152);
            this.txtStuSchool.Name = "txtStuSchool";
            this.txtStuSchool.Size = new System.Drawing.Size(100, 21);
            this.txtStuSchool.TabIndex = 9;
            // 
            // txtStuPhone
            // 
            this.txtStuPhone.Location = new System.Drawing.Point(191, 183);
            this.txtStuPhone.Name = "txtStuPhone";
            this.txtStuPhone.Size = new System.Drawing.Size(100, 21);
            this.txtStuPhone.TabIndex = 10;
            // 
            // txtStuInc
            // 
            this.txtStuInc.Location = new System.Drawing.Point(191, 214);
            this.txtStuInc.Name = "txtStuInc";
            this.txtStuInc.Size = new System.Drawing.Size(100, 21);
            this.txtStuInc.TabIndex = 11;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(101, 267);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            this.btnInsert.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnInsert_MouseMove);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(216, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comStuSex
            // 
            this.comStuSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comStuSex.FormattingEnabled = true;
            this.comStuSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comStuSex.Location = new System.Drawing.Point(191, 121);
            this.comStuSex.Name = "comStuSex";
            this.comStuSex.Size = new System.Drawing.Size(100, 20);
            this.comStuSex.TabIndex = 14;
            // 
            // comSchool
            // 
            this.comSchool.FormattingEnabled = true;
            this.comSchool.Location = new System.Drawing.Point(297, 152);
            this.comSchool.Name = "comSchool";
            this.comSchool.Size = new System.Drawing.Size(121, 20);
            this.comSchool.TabIndex = 15;
            this.comSchool.Visible = false;
            // 
            // FormStuReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 393);
            this.Controls.Add(this.comSchool);
            this.Controls.Add(this.comStuSex);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtStuInc);
            this.Controls.Add(this.txtStuPhone);
            this.Controls.Add(this.txtStuSchool);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtStuID);
            this.Controls.Add(this.labStuInc);
            this.Controls.Add(this.labStuPhone);
            this.Controls.Add(this.labStuSchool);
            this.Controls.Add(this.labStuSex);
            this.Controls.Add(this.labStuName);
            this.Controls.Add(this.labStuID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStuReg";
            this.Text = "学生信息注册";
            this.Load += new System.EventHandler(this.FormStuReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStuID;
        private System.Windows.Forms.Label labStuName;
        private System.Windows.Forms.Label labStuSex;
        private System.Windows.Forms.Label labStuSchool;
        private System.Windows.Forms.Label labStuPhone;
        private System.Windows.Forms.Label labStuInc;
        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuSchool;
        private System.Windows.Forms.TextBox txtStuPhone;
        private System.Windows.Forms.TextBox txtStuInc;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox comStuSex;
        private System.Windows.Forms.ComboBox comSchool;
    }
}