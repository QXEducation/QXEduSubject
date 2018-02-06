namespace UI
{
    partial class FormSubjectInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubjectInfo));
            this.libSubID = new System.Windows.Forms.Label();
            this.libSubName = new System.Windows.Forms.Label();
            this.libSubGread = new System.Windows.Forms.Label();
            this.libSubTime = new System.Windows.Forms.Label();
            this.libSubPrice = new System.Windows.Forms.Label();
            this.libIfPacked = new System.Windows.Forms.Label();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.comGread1 = new System.Windows.Forms.ComboBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.IfPackedYes = new System.Windows.Forms.RadioButton();
            this.IfPackedNo = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.comGread2 = new System.Windows.Forms.ComboBox();
            this.txtSubID = new System.Windows.Forms.TextBox();
            this.labSubText = new System.Windows.Forms.Label();
            this.txtSubText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // libSubID
            // 
            this.libSubID.AutoSize = true;
            this.libSubID.Location = new System.Drawing.Point(90, 56);
            this.libSubID.Name = "libSubID";
            this.libSubID.Size = new System.Drawing.Size(53, 12);
            this.libSubID.TabIndex = 0;
            this.libSubID.Text = "LibSubID";
            // 
            // libSubName
            // 
            this.libSubName.AutoSize = true;
            this.libSubName.Location = new System.Drawing.Point(96, 84);
            this.libSubName.Name = "libSubName";
            this.libSubName.Size = new System.Drawing.Size(47, 12);
            this.libSubName.TabIndex = 0;
            this.libSubName.Text = "SubName";
            // 
            // libSubGread
            // 
            this.libSubGread.AutoSize = true;
            this.libSubGread.Location = new System.Drawing.Point(90, 117);
            this.libSubGread.Name = "libSubGread";
            this.libSubGread.Size = new System.Drawing.Size(53, 12);
            this.libSubGread.TabIndex = 0;
            this.libSubGread.Text = "SubGread";
            // 
            // libSubTime
            // 
            this.libSubTime.AutoSize = true;
            this.libSubTime.Location = new System.Drawing.Point(78, 149);
            this.libSubTime.Name = "libSubTime";
            this.libSubTime.Size = new System.Drawing.Size(65, 12);
            this.libSubTime.TabIndex = 0;
            this.libSubTime.Text = "libSubTime";
            // 
            // libSubPrice
            // 
            this.libSubPrice.AutoSize = true;
            this.libSubPrice.Location = new System.Drawing.Point(90, 182);
            this.libSubPrice.Name = "libSubPrice";
            this.libSubPrice.Size = new System.Drawing.Size(53, 12);
            this.libSubPrice.TabIndex = 0;
            this.libSubPrice.Text = "SubPrice";
            // 
            // libIfPacked
            // 
            this.libIfPacked.AutoSize = true;
            this.libIfPacked.Location = new System.Drawing.Point(61, 213);
            this.libIfPacked.Name = "libIfPacked";
            this.libIfPacked.Size = new System.Drawing.Size(53, 12);
            this.libIfPacked.TabIndex = 0;
            this.libIfPacked.Text = "ifPacked";
            // 
            // txtSubName
            // 
            this.txtSubName.Location = new System.Drawing.Point(158, 80);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(145, 21);
            this.txtSubName.TabIndex = 2;
            // 
            // comGread1
            // 
            this.comGread1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comGread1.FormattingEnabled = true;
            this.comGread1.Location = new System.Drawing.Point(158, 114);
            this.comGread1.Name = "comGread1";
            this.comGread1.Size = new System.Drawing.Size(69, 20);
            this.comGread1.TabIndex = 3;
            this.comGread1.SelectedIndexChanged += new System.EventHandler(this.comGread1_SelectedIndexChanged);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(158, 146);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(145, 21);
            this.txtTime.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(158, 179);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(145, 21);
            this.txtPrice.TabIndex = 6;
            // 
            // IfPackedYes
            // 
            this.IfPackedYes.AutoSize = true;
            this.IfPackedYes.Location = new System.Drawing.Point(168, 211);
            this.IfPackedYes.Name = "IfPackedYes";
            this.IfPackedYes.Size = new System.Drawing.Size(41, 16);
            this.IfPackedYes.TabIndex = 7;
            this.IfPackedYes.TabStop = true;
            this.IfPackedYes.Tag = "Packed";
            this.IfPackedYes.Text = "Yes";
            this.IfPackedYes.UseVisualStyleBackColor = true;
            // 
            // IfPackedNo
            // 
            this.IfPackedNo.AutoSize = true;
            this.IfPackedNo.Location = new System.Drawing.Point(233, 211);
            this.IfPackedNo.Name = "IfPackedNo";
            this.IfPackedNo.Size = new System.Drawing.Size(35, 16);
            this.IfPackedNo.TabIndex = 8;
            this.IfPackedNo.TabStop = true;
            this.IfPackedNo.Tag = "Packed";
            this.IfPackedNo.Text = "No";
            this.IfPackedNo.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(80, 294);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            this.btnInsert.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnInsert_MouseMove);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(215, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comGread2
            // 
            this.comGread2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comGread2.FormattingEnabled = true;
            this.comGread2.Location = new System.Drawing.Point(233, 114);
            this.comGread2.Name = "comGread2";
            this.comGread2.Size = new System.Drawing.Size(70, 20);
            this.comGread2.TabIndex = 4;
            // 
            // txtSubID
            // 
            this.txtSubID.Location = new System.Drawing.Point(158, 53);
            this.txtSubID.Name = "txtSubID";
            this.txtSubID.Size = new System.Drawing.Size(145, 21);
            this.txtSubID.TabIndex = 1;
            // 
            // labSubText
            // 
            this.labSubText.AutoSize = true;
            this.labSubText.Location = new System.Drawing.Point(102, 248);
            this.labSubText.Name = "labSubText";
            this.labSubText.Size = new System.Drawing.Size(47, 12);
            this.labSubText.TabIndex = 12;
            this.labSubText.Text = "SubText";
            // 
            // txtSubText
            // 
            this.txtSubText.Location = new System.Drawing.Point(158, 245);
            this.txtSubText.Multiline = true;
            this.txtSubText.Name = "txtSubText";
            this.txtSubText.Size = new System.Drawing.Size(145, 43);
            this.txtSubText.TabIndex = 13;
            // 
            // FormSubjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 390);
            this.Controls.Add(this.txtSubText);
            this.Controls.Add(this.labSubText);
            this.Controls.Add(this.txtSubID);
            this.Controls.Add(this.comGread2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.IfPackedNo);
            this.Controls.Add(this.IfPackedYes);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.comGread1);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.libIfPacked);
            this.Controls.Add(this.libSubPrice);
            this.Controls.Add(this.libSubTime);
            this.Controls.Add(this.libSubGread);
            this.Controls.Add(this.libSubName);
            this.Controls.Add(this.libSubID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSubjectInfo";
            this.Text = "课程录入";
            this.Load += new System.EventHandler(this.FormSubjectInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label libSubID;
        private System.Windows.Forms.Label libSubName;
        private System.Windows.Forms.Label libSubGread;
        private System.Windows.Forms.Label libSubTime;
        private System.Windows.Forms.Label libSubPrice;
        private System.Windows.Forms.Label libIfPacked;
        private System.Windows.Forms.TextBox txtSubName;
        private System.Windows.Forms.ComboBox comGread1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.RadioButton IfPackedYes;
        private System.Windows.Forms.RadioButton IfPackedNo;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox comGread2;
        private System.Windows.Forms.TextBox txtSubID;
        private System.Windows.Forms.Label labSubText;
        private System.Windows.Forms.TextBox txtSubText;
    }
}