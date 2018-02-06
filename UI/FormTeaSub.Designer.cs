namespace UI
{
    partial class FormTeaSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeaSub));
            this.labTeaName = new System.Windows.Forms.Label();
            this.labTeaID = new System.Windows.Forms.Label();
            this.labTeaSex = new System.Windows.Forms.Label();
            this.labTeaPhone = new System.Windows.Forms.Label();
            this.labSubGread = new System.Windows.Forms.Label();
            this.labSubID = new System.Windows.Forms.Label();
            this.labSubName = new System.Windows.Forms.Label();
            this.comTeaID = new System.Windows.Forms.ComboBox();
            this.txtTeaName = new System.Windows.Forms.TextBox();
            this.txtTeaSex = new System.Windows.Forms.TextBox();
            this.txtTeaPhone = new System.Windows.Forms.TextBox();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.comGread1 = new System.Windows.Forms.ComboBox();
            this.comGread2 = new System.Windows.Forms.ComboBox();
            this.labSubPriForTea = new System.Windows.Forms.Label();
            this.txtSPFT = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.linTeaADD = new System.Windows.Forms.LinkLabel();
            this.comSubID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labTeaName
            // 
            this.labTeaName.AutoSize = true;
            this.labTeaName.Location = new System.Drawing.Point(50, 42);
            this.labTeaName.Name = "labTeaName";
            this.labTeaName.Size = new System.Drawing.Size(47, 12);
            this.labTeaName.TabIndex = 0;
            this.labTeaName.Text = "TeaName";
            // 
            // labTeaID
            // 
            this.labTeaID.AutoSize = true;
            this.labTeaID.Location = new System.Drawing.Point(50, 75);
            this.labTeaID.Name = "labTeaID";
            this.labTeaID.Size = new System.Drawing.Size(35, 12);
            this.labTeaID.TabIndex = 1;
            this.labTeaID.Text = "TeaId";
            // 
            // labTeaSex
            // 
            this.labTeaSex.AutoSize = true;
            this.labTeaSex.Location = new System.Drawing.Point(50, 108);
            this.labTeaSex.Name = "labTeaSex";
            this.labTeaSex.Size = new System.Drawing.Size(41, 12);
            this.labTeaSex.TabIndex = 2;
            this.labTeaSex.Text = "TeaSex";
            // 
            // labTeaPhone
            // 
            this.labTeaPhone.AutoSize = true;
            this.labTeaPhone.Location = new System.Drawing.Point(50, 141);
            this.labTeaPhone.Name = "labTeaPhone";
            this.labTeaPhone.Size = new System.Drawing.Size(53, 12);
            this.labTeaPhone.TabIndex = 3;
            this.labTeaPhone.Text = "TeaPhone";
            // 
            // labSubGread
            // 
            this.labSubGread.AutoSize = true;
            this.labSubGread.Location = new System.Drawing.Point(50, 174);
            this.labSubGread.Name = "labSubGread";
            this.labSubGread.Size = new System.Drawing.Size(53, 12);
            this.labSubGread.TabIndex = 4;
            this.labSubGread.Text = "SubGread";
            // 
            // labSubID
            // 
            this.labSubID.AutoSize = true;
            this.labSubID.Location = new System.Drawing.Point(50, 207);
            this.labSubID.Name = "labSubID";
            this.labSubID.Size = new System.Drawing.Size(35, 12);
            this.labSubID.TabIndex = 5;
            this.labSubID.Text = "SubID";
            // 
            // labSubName
            // 
            this.labSubName.AutoSize = true;
            this.labSubName.Location = new System.Drawing.Point(50, 240);
            this.labSubName.Name = "labSubName";
            this.labSubName.Size = new System.Drawing.Size(47, 12);
            this.labSubName.TabIndex = 6;
            this.labSubName.Text = "SubName";
            // 
            // comTeaID
            // 
            this.comTeaID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTeaID.FormattingEnabled = true;
            this.comTeaID.Location = new System.Drawing.Point(133, 72);
            this.comTeaID.Name = "comTeaID";
            this.comTeaID.Size = new System.Drawing.Size(139, 20);
            this.comTeaID.TabIndex = 7;
            this.comTeaID.SelectedIndexChanged += new System.EventHandler(this.comTeaID_SelectedIndexChanged);
            // 
            // txtTeaName
            // 
            this.txtTeaName.Location = new System.Drawing.Point(133, 39);
            this.txtTeaName.Name = "txtTeaName";
            this.txtTeaName.Size = new System.Drawing.Size(139, 21);
            this.txtTeaName.TabIndex = 8;
            this.txtTeaName.Leave += new System.EventHandler(this.txtTeaName_Leave);
            // 
            // txtTeaSex
            // 
            this.txtTeaSex.Location = new System.Drawing.Point(133, 105);
            this.txtTeaSex.Name = "txtTeaSex";
            this.txtTeaSex.ReadOnly = true;
            this.txtTeaSex.Size = new System.Drawing.Size(139, 21);
            this.txtTeaSex.TabIndex = 9;
            // 
            // txtTeaPhone
            // 
            this.txtTeaPhone.Location = new System.Drawing.Point(133, 138);
            this.txtTeaPhone.Name = "txtTeaPhone";
            this.txtTeaPhone.ReadOnly = true;
            this.txtTeaPhone.Size = new System.Drawing.Size(139, 21);
            this.txtTeaPhone.TabIndex = 10;
            // 
            // txtSubName
            // 
            this.txtSubName.Location = new System.Drawing.Point(133, 237);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.ReadOnly = true;
            this.txtSubName.Size = new System.Drawing.Size(139, 21);
            this.txtSubName.TabIndex = 11;
            // 
            // comGread1
            // 
            this.comGread1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comGread1.FormattingEnabled = true;
            this.comGread1.Location = new System.Drawing.Point(133, 171);
            this.comGread1.Name = "comGread1";
            this.comGread1.Size = new System.Drawing.Size(65, 20);
            this.comGread1.TabIndex = 12;
            this.comGread1.SelectedIndexChanged += new System.EventHandler(this.comGread1_SelectedIndexChanged);
            // 
            // comGread2
            // 
            this.comGread2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comGread2.FormattingEnabled = true;
            this.comGread2.Location = new System.Drawing.Point(204, 171);
            this.comGread2.Name = "comGread2";
            this.comGread2.Size = new System.Drawing.Size(68, 20);
            this.comGread2.TabIndex = 13;
            this.comGread2.SelectedIndexChanged += new System.EventHandler(this.comGread2_SelectedIndexChanged);
            // 
            // labSubPriForTea
            // 
            this.labSubPriForTea.AutoSize = true;
            this.labSubPriForTea.Location = new System.Drawing.Point(50, 273);
            this.labSubPriForTea.Name = "labSubPriForTea";
            this.labSubPriForTea.Size = new System.Drawing.Size(77, 12);
            this.labSubPriForTea.TabIndex = 14;
            this.labSubPriForTea.Text = "SubPriForTea";
            // 
            // txtSPFT
            // 
            this.txtSPFT.Location = new System.Drawing.Point(133, 270);
            this.txtSPFT.Name = "txtSPFT";
            this.txtSPFT.Size = new System.Drawing.Size(139, 21);
            this.txtSPFT.TabIndex = 16;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(52, 315);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(197, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // linTeaADD
            // 
            this.linTeaADD.AutoSize = true;
            this.linTeaADD.Location = new System.Drawing.Point(287, 75);
            this.linTeaADD.Name = "linTeaADD";
            this.linTeaADD.Size = new System.Drawing.Size(41, 12);
            this.linTeaADD.TabIndex = 19;
            this.linTeaADD.TabStop = true;
            this.linTeaADD.Text = "TeaADD";
            this.linTeaADD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linTeaADD_LinkClicked);
            // 
            // comSubID
            // 
            this.comSubID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comSubID.FormattingEnabled = true;
            this.comSubID.Location = new System.Drawing.Point(133, 204);
            this.comSubID.Name = "comSubID";
            this.comSubID.Size = new System.Drawing.Size(139, 20);
            this.comSubID.TabIndex = 20;
            this.comSubID.SelectedIndexChanged += new System.EventHandler(this.comSubID_SelectedIndexChanged);
            // 
            // FormTeaSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 393);
            this.Controls.Add(this.comSubID);
            this.Controls.Add(this.linTeaADD);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtSPFT);
            this.Controls.Add(this.labSubPriForTea);
            this.Controls.Add(this.comGread2);
            this.Controls.Add(this.comGread1);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.txtTeaPhone);
            this.Controls.Add(this.txtTeaSex);
            this.Controls.Add(this.txtTeaName);
            this.Controls.Add(this.comTeaID);
            this.Controls.Add(this.labSubName);
            this.Controls.Add(this.labSubID);
            this.Controls.Add(this.labSubGread);
            this.Controls.Add(this.labTeaPhone);
            this.Controls.Add(this.labTeaSex);
            this.Controls.Add(this.labTeaID);
            this.Controls.Add(this.labTeaName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTeaSub";
            this.Text = "教师课时费";
            this.Load += new System.EventHandler(this.FormTeaSub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTeaName;
        private System.Windows.Forms.Label labTeaID;
        private System.Windows.Forms.Label labTeaSex;
        private System.Windows.Forms.Label labTeaPhone;
        private System.Windows.Forms.Label labSubGread;
        private System.Windows.Forms.Label labSubID;
        private System.Windows.Forms.Label labSubName;
        private System.Windows.Forms.ComboBox comTeaID;
        private System.Windows.Forms.TextBox txtTeaName;
        private System.Windows.Forms.TextBox txtTeaSex;
        private System.Windows.Forms.TextBox txtTeaPhone;
        private System.Windows.Forms.TextBox txtSubName;
        private System.Windows.Forms.ComboBox comGread1;
        private System.Windows.Forms.ComboBox comGread2;
        private System.Windows.Forms.Label labSubPriForTea;
        private System.Windows.Forms.TextBox txtSPFT;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel linTeaADD;
        private System.Windows.Forms.ComboBox comSubID;
    }
}