namespace UI
{
    partial class FormStuCharact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStuCharact));
            this.labStuName = new System.Windows.Forms.Label();
            this.labStuID = new System.Windows.Forms.Label();
            this.labStuSex = new System.Windows.Forms.Label();
            this.labStuSchool = new System.Windows.Forms.Label();
            this.labStuPhone = new System.Windows.Forms.Label();
            this.labStuCharact = new System.Windows.Forms.Label();
            this.labTeaInform = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.comStuID = new System.Windows.Forms.ComboBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuSex = new System.Windows.Forms.TextBox();
            this.txtStuSchool = new System.Windows.Forms.TextBox();
            this.txtStuPhone = new System.Windows.Forms.TextBox();
            this.txtStuCharact = new System.Windows.Forms.TextBox();
            this.txtTeaInform = new System.Windows.Forms.TextBox();
            this.btnTmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labStuName
            // 
            this.labStuName.AutoSize = true;
            this.labStuName.Location = new System.Drawing.Point(63, 42);
            this.labStuName.Name = "labStuName";
            this.labStuName.Size = new System.Drawing.Size(47, 12);
            this.labStuName.TabIndex = 0;
            this.labStuName.Text = "StuName";
            // 
            // labStuID
            // 
            this.labStuID.AutoSize = true;
            this.labStuID.Location = new System.Drawing.Point(63, 69);
            this.labStuID.Name = "labStuID";
            this.labStuID.Size = new System.Drawing.Size(35, 12);
            this.labStuID.TabIndex = 0;
            this.labStuID.Text = "StuID";
            // 
            // labStuSex
            // 
            this.labStuSex.AutoSize = true;
            this.labStuSex.Location = new System.Drawing.Point(63, 96);
            this.labStuSex.Name = "labStuSex";
            this.labStuSex.Size = new System.Drawing.Size(41, 12);
            this.labStuSex.TabIndex = 0;
            this.labStuSex.Text = "StuSex";
            // 
            // labStuSchool
            // 
            this.labStuSchool.AutoSize = true;
            this.labStuSchool.Location = new System.Drawing.Point(63, 124);
            this.labStuSchool.Name = "labStuSchool";
            this.labStuSchool.Size = new System.Drawing.Size(59, 12);
            this.labStuSchool.TabIndex = 0;
            this.labStuSchool.Text = "StuSchool";
            // 
            // labStuPhone
            // 
            this.labStuPhone.AutoSize = true;
            this.labStuPhone.Location = new System.Drawing.Point(63, 151);
            this.labStuPhone.Name = "labStuPhone";
            this.labStuPhone.Size = new System.Drawing.Size(53, 12);
            this.labStuPhone.TabIndex = 0;
            this.labStuPhone.Text = "StuPhone";
            // 
            // labStuCharact
            // 
            this.labStuCharact.AutoSize = true;
            this.labStuCharact.Location = new System.Drawing.Point(63, 179);
            this.labStuCharact.Name = "labStuCharact";
            this.labStuCharact.Size = new System.Drawing.Size(65, 12);
            this.labStuCharact.TabIndex = 0;
            this.labStuCharact.Text = "StuCharact";
            // 
            // labTeaInform
            // 
            this.labTeaInform.AutoSize = true;
            this.labTeaInform.Location = new System.Drawing.Point(63, 269);
            this.labTeaInform.Name = "labTeaInform";
            this.labTeaInform.Size = new System.Drawing.Size(59, 12);
            this.labTeaInform.TabIndex = 0;
            this.labTeaInform.Text = "TeaInform";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(120, 375);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(306, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comStuID
            // 
            this.comStuID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comStuID.FormattingEnabled = true;
            this.comStuID.Location = new System.Drawing.Point(154, 66);
            this.comStuID.Name = "comStuID";
            this.comStuID.Size = new System.Drawing.Size(158, 20);
            this.comStuID.TabIndex = 2;
            this.comStuID.SelectedIndexChanged += new System.EventHandler(this.comStuID_SelectedIndexChanged);
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(154, 39);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(158, 21);
            this.txtStuName.TabIndex = 1;
            this.txtStuName.TextChanged += new System.EventHandler(this.txtStuName_TextChanged);
            this.txtStuName.Leave += new System.EventHandler(this.txtStuName_Leave);
            // 
            // txtStuSex
            // 
            this.txtStuSex.Location = new System.Drawing.Point(154, 93);
            this.txtStuSex.Name = "txtStuSex";
            this.txtStuSex.ReadOnly = true;
            this.txtStuSex.Size = new System.Drawing.Size(158, 21);
            this.txtStuSex.TabIndex = 0;
            this.txtStuSex.TabStop = false;
            // 
            // txtStuSchool
            // 
            this.txtStuSchool.Location = new System.Drawing.Point(154, 121);
            this.txtStuSchool.Name = "txtStuSchool";
            this.txtStuSchool.ReadOnly = true;
            this.txtStuSchool.Size = new System.Drawing.Size(158, 21);
            this.txtStuSchool.TabIndex = 0;
            this.txtStuSchool.TabStop = false;
            // 
            // txtStuPhone
            // 
            this.txtStuPhone.Location = new System.Drawing.Point(154, 148);
            this.txtStuPhone.Name = "txtStuPhone";
            this.txtStuPhone.ReadOnly = true;
            this.txtStuPhone.Size = new System.Drawing.Size(158, 21);
            this.txtStuPhone.TabIndex = 0;
            this.txtStuPhone.TabStop = false;
            // 
            // txtStuCharact
            // 
            this.txtStuCharact.Location = new System.Drawing.Point(154, 176);
            this.txtStuCharact.Multiline = true;
            this.txtStuCharact.Name = "txtStuCharact";
            this.txtStuCharact.Size = new System.Drawing.Size(239, 84);
            this.txtStuCharact.TabIndex = 3;
            // 
            // txtTeaInform
            // 
            this.txtTeaInform.Location = new System.Drawing.Point(154, 266);
            this.txtTeaInform.Multiline = true;
            this.txtTeaInform.Name = "txtTeaInform";
            this.txtTeaInform.Size = new System.Drawing.Size(239, 84);
            this.txtTeaInform.TabIndex = 4;
            // 
            // btnTmp
            // 
            this.btnTmp.Location = new System.Drawing.Point(318, 63);
            this.btnTmp.Name = "btnTmp";
            this.btnTmp.Size = new System.Drawing.Size(75, 23);
            this.btnTmp.TabIndex = 0;
            this.btnTmp.Text = "Don\'t selcet ?Insert!";
            this.btnTmp.UseVisualStyleBackColor = true;
            this.btnTmp.Visible = false;
            this.btnTmp.Click += new System.EventHandler(this.btnTmp_Click);
            // 
            // FormStuCharact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 471);
            this.Controls.Add(this.btnTmp);
            this.Controls.Add(this.txtTeaInform);
            this.Controls.Add(this.txtStuCharact);
            this.Controls.Add(this.txtStuPhone);
            this.Controls.Add(this.txtStuSchool);
            this.Controls.Add(this.txtStuSex);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.comStuID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.labTeaInform);
            this.Controls.Add(this.labStuCharact);
            this.Controls.Add(this.labStuPhone);
            this.Controls.Add(this.labStuSchool);
            this.Controls.Add(this.labStuSex);
            this.Controls.Add(this.labStuID);
            this.Controls.Add(this.labStuName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStuCharact";
            this.Text = "学生特点分析";
            this.Load += new System.EventHandler(this.FormStuCharact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStuName;
        private System.Windows.Forms.Label labStuID;
        private System.Windows.Forms.Label labStuSex;
        private System.Windows.Forms.Label labStuSchool;
        private System.Windows.Forms.Label labStuPhone;
        private System.Windows.Forms.Label labStuCharact;
        private System.Windows.Forms.Label labTeaInform;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox comStuID;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuSex;
        private System.Windows.Forms.TextBox txtStuSchool;
        private System.Windows.Forms.TextBox txtStuPhone;
        private System.Windows.Forms.TextBox txtStuCharact;
        private System.Windows.Forms.TextBox txtTeaInform;
        private System.Windows.Forms.Button btnTmp;
    }
}