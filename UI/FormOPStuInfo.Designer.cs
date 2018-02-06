namespace UI
{
    partial class FormOPStuInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOPStuInfo));
            this.labStuName = new System.Windows.Forms.Label();
            this.labStuID = new System.Windows.Forms.Label();
            this.labStuSex = new System.Windows.Forms.Label();
            this.labStuSchool = new System.Windows.Forms.Label();
            this.labStuPhone = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.comStuID = new System.Windows.Forms.ComboBox();
            this.txtStuSex = new System.Windows.Forms.TextBox();
            this.txtStuSchool = new System.Windows.Forms.TextBox();
            this.linStuCharact = new System.Windows.Forms.LinkLabel();
            this.txtStuPhone = new System.Windows.Forms.TextBox();
            this.linUpdate = new System.Windows.Forms.LinkLabel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.linReSelcet = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labStuName
            // 
            this.labStuName.AutoSize = true;
            this.labStuName.Location = new System.Drawing.Point(77, 40);
            this.labStuName.Name = "labStuName";
            this.labStuName.Size = new System.Drawing.Size(47, 12);
            this.labStuName.TabIndex = 0;
            this.labStuName.Text = "StuName";
            // 
            // labStuID
            // 
            this.labStuID.AutoSize = true;
            this.labStuID.Location = new System.Drawing.Point(77, 82);
            this.labStuID.Name = "labStuID";
            this.labStuID.Size = new System.Drawing.Size(35, 12);
            this.labStuID.TabIndex = 1;
            this.labStuID.Text = "StuID";
            // 
            // labStuSex
            // 
            this.labStuSex.AutoSize = true;
            this.labStuSex.Location = new System.Drawing.Point(77, 124);
            this.labStuSex.Name = "labStuSex";
            this.labStuSex.Size = new System.Drawing.Size(41, 12);
            this.labStuSex.TabIndex = 2;
            this.labStuSex.Text = "StuSex";
            // 
            // labStuSchool
            // 
            this.labStuSchool.AutoSize = true;
            this.labStuSchool.Location = new System.Drawing.Point(77, 166);
            this.labStuSchool.Name = "labStuSchool";
            this.labStuSchool.Size = new System.Drawing.Size(59, 12);
            this.labStuSchool.TabIndex = 3;
            this.labStuSchool.Text = "StuSchool";
            // 
            // labStuPhone
            // 
            this.labStuPhone.AutoSize = true;
            this.labStuPhone.Location = new System.Drawing.Point(77, 208);
            this.labStuPhone.Name = "labStuPhone";
            this.labStuPhone.Size = new System.Drawing.Size(53, 12);
            this.labStuPhone.TabIndex = 4;
            this.labStuPhone.Text = "StuPhone";
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(152, 37);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(121, 21);
            this.txtStuName.TabIndex = 6;
            this.txtStuName.Leave += new System.EventHandler(this.txtStuName_Leave);
            // 
            // comStuID
            // 
            this.comStuID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comStuID.FormattingEnabled = true;
            this.comStuID.Location = new System.Drawing.Point(152, 79);
            this.comStuID.Name = "comStuID";
            this.comStuID.Size = new System.Drawing.Size(121, 20);
            this.comStuID.TabIndex = 7;
            this.comStuID.SelectedIndexChanged += new System.EventHandler(this.comStuID_SelectedIndexChanged);
            // 
            // txtStuSex
            // 
            this.txtStuSex.Location = new System.Drawing.Point(152, 121);
            this.txtStuSex.Name = "txtStuSex";
            this.txtStuSex.ReadOnly = true;
            this.txtStuSex.Size = new System.Drawing.Size(121, 21);
            this.txtStuSex.TabIndex = 8;
            // 
            // txtStuSchool
            // 
            this.txtStuSchool.Location = new System.Drawing.Point(152, 163);
            this.txtStuSchool.Name = "txtStuSchool";
            this.txtStuSchool.ReadOnly = true;
            this.txtStuSchool.Size = new System.Drawing.Size(121, 21);
            this.txtStuSchool.TabIndex = 9;
            // 
            // linStuCharact
            // 
            this.linStuCharact.AutoSize = true;
            this.linStuCharact.Location = new System.Drawing.Point(77, 254);
            this.linStuCharact.Name = "linStuCharact";
            this.linStuCharact.Size = new System.Drawing.Size(65, 12);
            this.linStuCharact.TabIndex = 10;
            this.linStuCharact.TabStop = true;
            this.linStuCharact.Text = "StuCharact";
            this.linStuCharact.Visible = false;
            this.linStuCharact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linStuCharact_LinkClicked);
            // 
            // txtStuPhone
            // 
            this.txtStuPhone.Location = new System.Drawing.Point(152, 205);
            this.txtStuPhone.Name = "txtStuPhone";
            this.txtStuPhone.ReadOnly = true;
            this.txtStuPhone.Size = new System.Drawing.Size(121, 21);
            this.txtStuPhone.TabIndex = 11;
            // 
            // linUpdate
            // 
            this.linUpdate.AutoSize = true;
            this.linUpdate.Location = new System.Drawing.Point(197, 254);
            this.linUpdate.Name = "linUpdate";
            this.linUpdate.Size = new System.Drawing.Size(41, 12);
            this.linUpdate.TabIndex = 12;
            this.linUpdate.TabStop = true;
            this.linUpdate.Text = "Update";
            this.linUpdate.Visible = false;
            this.linUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linUpdate_LinkClicked);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(79, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(198, 284);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // linReSelcet
            // 
            this.linReSelcet.AutoSize = true;
            this.linReSelcet.Location = new System.Drawing.Point(288, 40);
            this.linReSelcet.Name = "linReSelcet";
            this.linReSelcet.Size = new System.Drawing.Size(53, 12);
            this.linReSelcet.TabIndex = 15;
            this.linReSelcet.TabStop = true;
            this.linReSelcet.Text = "ReSelcet";
            this.linReSelcet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linReSelcet_LinkClicked);
            // 
            // FormOPStuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 351);
            this.Controls.Add(this.linReSelcet);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.linUpdate);
            this.Controls.Add(this.txtStuPhone);
            this.Controls.Add(this.linStuCharact);
            this.Controls.Add(this.txtStuSchool);
            this.Controls.Add(this.txtStuSex);
            this.Controls.Add(this.comStuID);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.labStuPhone);
            this.Controls.Add(this.labStuSchool);
            this.Controls.Add(this.labStuSex);
            this.Controls.Add(this.labStuID);
            this.Controls.Add(this.labStuName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOPStuInfo";
            this.Text = "学生信息";
            this.Load += new System.EventHandler(this.FormOPStuInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStuName;
        private System.Windows.Forms.Label labStuID;
        private System.Windows.Forms.Label labStuSex;
        private System.Windows.Forms.Label labStuSchool;
        private System.Windows.Forms.Label labStuPhone;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.ComboBox comStuID;
        private System.Windows.Forms.TextBox txtStuSex;
        private System.Windows.Forms.TextBox txtStuSchool;
        private System.Windows.Forms.LinkLabel linStuCharact;
        private System.Windows.Forms.TextBox txtStuPhone;
        private System.Windows.Forms.LinkLabel linUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel linReSelcet;
    }
}