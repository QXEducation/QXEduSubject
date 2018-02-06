namespace UI
{
    partial class FormOPCharact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOPCharact));
            this.labStuName = new System.Windows.Forms.Label();
            this.labStuId = new System.Windows.Forms.Label();
            this.labStuSex = new System.Windows.Forms.Label();
            this.labStuSchool = new System.Windows.Forms.Label();
            this.labStuCharaact = new System.Windows.Forms.Label();
            this.labTeaInform = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.comStuID = new System.Windows.Forms.ComboBox();
            this.txtStuSex = new System.Windows.Forms.TextBox();
            this.txtStuSchool = new System.Windows.Forms.TextBox();
            this.txtStuCharact = new System.Windows.Forms.TextBox();
            this.txtTeaInform = new System.Windows.Forms.TextBox();
            this.linReSelcet = new System.Windows.Forms.LinkLabel();
            this.linUpdate = new System.Windows.Forms.LinkLabel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labStuName
            // 
            this.labStuName.AutoSize = true;
            this.labStuName.Location = new System.Drawing.Point(26, 32);
            this.labStuName.Name = "labStuName";
            this.labStuName.Size = new System.Drawing.Size(47, 12);
            this.labStuName.TabIndex = 0;
            this.labStuName.Text = "StuName";
            // 
            // labStuId
            // 
            this.labStuId.AutoSize = true;
            this.labStuId.Location = new System.Drawing.Point(26, 67);
            this.labStuId.Name = "labStuId";
            this.labStuId.Size = new System.Drawing.Size(35, 12);
            this.labStuId.TabIndex = 1;
            this.labStuId.Text = "StuId";
            // 
            // labStuSex
            // 
            this.labStuSex.AutoSize = true;
            this.labStuSex.Location = new System.Drawing.Point(26, 102);
            this.labStuSex.Name = "labStuSex";
            this.labStuSex.Size = new System.Drawing.Size(41, 12);
            this.labStuSex.TabIndex = 2;
            this.labStuSex.Text = "StuSex";
            // 
            // labStuSchool
            // 
            this.labStuSchool.AutoSize = true;
            this.labStuSchool.Location = new System.Drawing.Point(26, 137);
            this.labStuSchool.Name = "labStuSchool";
            this.labStuSchool.Size = new System.Drawing.Size(59, 12);
            this.labStuSchool.TabIndex = 3;
            this.labStuSchool.Text = "StuSchool";
            // 
            // labStuCharaact
            // 
            this.labStuCharaact.AutoSize = true;
            this.labStuCharaact.Location = new System.Drawing.Point(26, 172);
            this.labStuCharaact.Name = "labStuCharaact";
            this.labStuCharaact.Size = new System.Drawing.Size(65, 12);
            this.labStuCharaact.TabIndex = 4;
            this.labStuCharaact.Text = "StuCharact";
            // 
            // labTeaInform
            // 
            this.labTeaInform.AutoSize = true;
            this.labTeaInform.Location = new System.Drawing.Point(26, 268);
            this.labTeaInform.Name = "labTeaInform";
            this.labTeaInform.Size = new System.Drawing.Size(59, 12);
            this.labTeaInform.TabIndex = 5;
            this.labTeaInform.Text = "TeaInform";
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(91, 29);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(182, 21);
            this.txtStuName.TabIndex = 6;
            this.txtStuName.Leave += new System.EventHandler(this.txtStuName_Leave);
            // 
            // comStuID
            // 
            this.comStuID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comStuID.FormattingEnabled = true;
            this.comStuID.Location = new System.Drawing.Point(91, 64);
            this.comStuID.Name = "comStuID";
            this.comStuID.Size = new System.Drawing.Size(182, 20);
            this.comStuID.TabIndex = 7;
            this.comStuID.SelectedIndexChanged += new System.EventHandler(this.comStuID_SelectedIndexChanged);
            // 
            // txtStuSex
            // 
            this.txtStuSex.Location = new System.Drawing.Point(91, 99);
            this.txtStuSex.Name = "txtStuSex";
            this.txtStuSex.ReadOnly = true;
            this.txtStuSex.Size = new System.Drawing.Size(182, 21);
            this.txtStuSex.TabIndex = 8;
            // 
            // txtStuSchool
            // 
            this.txtStuSchool.Location = new System.Drawing.Point(91, 134);
            this.txtStuSchool.Name = "txtStuSchool";
            this.txtStuSchool.ReadOnly = true;
            this.txtStuSchool.Size = new System.Drawing.Size(182, 21);
            this.txtStuSchool.TabIndex = 9;
            // 
            // txtStuCharact
            // 
            this.txtStuCharact.Location = new System.Drawing.Point(91, 172);
            this.txtStuCharact.Multiline = true;
            this.txtStuCharact.Name = "txtStuCharact";
            this.txtStuCharact.ReadOnly = true;
            this.txtStuCharact.Size = new System.Drawing.Size(260, 87);
            this.txtStuCharact.TabIndex = 10;
            // 
            // txtTeaInform
            // 
            this.txtTeaInform.Location = new System.Drawing.Point(91, 265);
            this.txtTeaInform.Multiline = true;
            this.txtTeaInform.Name = "txtTeaInform";
            this.txtTeaInform.ReadOnly = true;
            this.txtTeaInform.Size = new System.Drawing.Size(260, 87);
            this.txtTeaInform.TabIndex = 11;
            // 
            // linReSelcet
            // 
            this.linReSelcet.AutoSize = true;
            this.linReSelcet.Location = new System.Drawing.Point(286, 67);
            this.linReSelcet.Name = "linReSelcet";
            this.linReSelcet.Size = new System.Drawing.Size(53, 12);
            this.linReSelcet.TabIndex = 12;
            this.linReSelcet.TabStop = true;
            this.linReSelcet.Text = "ReSelect";
            this.linReSelcet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linReSelcet_LinkClicked);
            // 
            // linUpdate
            // 
            this.linUpdate.AutoSize = true;
            this.linUpdate.Location = new System.Drawing.Point(271, 376);
            this.linUpdate.Name = "linUpdate";
            this.linUpdate.Size = new System.Drawing.Size(41, 12);
            this.linUpdate.TabIndex = 14;
            this.linUpdate.TabStop = true;
            this.linUpdate.Text = "Update";
            this.linUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linUpdate_LinkClicked);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(44, 408);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(276, 408);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormOPCharact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 443);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.linUpdate);
            this.Controls.Add(this.linReSelcet);
            this.Controls.Add(this.txtTeaInform);
            this.Controls.Add(this.txtStuCharact);
            this.Controls.Add(this.txtStuSchool);
            this.Controls.Add(this.txtStuSex);
            this.Controls.Add(this.comStuID);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.labTeaInform);
            this.Controls.Add(this.labStuCharaact);
            this.Controls.Add(this.labStuSchool);
            this.Controls.Add(this.labStuSex);
            this.Controls.Add(this.labStuId);
            this.Controls.Add(this.labStuName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOPCharact";
            this.Text = "学生特点";
            this.Load += new System.EventHandler(this.FormOPCharact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStuName;
        private System.Windows.Forms.Label labStuId;
        private System.Windows.Forms.Label labStuSex;
        private System.Windows.Forms.Label labStuSchool;
        private System.Windows.Forms.Label labStuCharaact;
        private System.Windows.Forms.Label labTeaInform;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.ComboBox comStuID;
        private System.Windows.Forms.TextBox txtStuSex;
        private System.Windows.Forms.TextBox txtStuSchool;
        private System.Windows.Forms.TextBox txtStuCharact;
        private System.Windows.Forms.TextBox txtTeaInform;
        private System.Windows.Forms.LinkLabel linReSelcet;
        private System.Windows.Forms.LinkLabel linUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
    }
}