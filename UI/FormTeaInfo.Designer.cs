namespace UI
{
    partial class FormTeaInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeaInfo));
            this.labTeaID = new System.Windows.Forms.Label();
            this.labTeaName = new System.Windows.Forms.Label();
            this.labTeaSex = new System.Windows.Forms.Label();
            this.labTeaPhone = new System.Windows.Forms.Label();
            this.labTmp = new System.Windows.Forms.Label();
            this.txtTeaID = new System.Windows.Forms.TextBox();
            this.txtTeaName = new System.Windows.Forms.TextBox();
            this.txtTeaSex = new System.Windows.Forms.TextBox();
            this.txtTeaPhone = new System.Windows.Forms.TextBox();
            this.txtTmp = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTeaID
            // 
            this.labTeaID.AutoSize = true;
            this.labTeaID.Location = new System.Drawing.Point(59, 40);
            this.labTeaID.Name = "labTeaID";
            this.labTeaID.Size = new System.Drawing.Size(35, 12);
            this.labTeaID.TabIndex = 0;
            this.labTeaID.Text = "TeaID";
            // 
            // labTeaName
            // 
            this.labTeaName.AutoSize = true;
            this.labTeaName.Location = new System.Drawing.Point(59, 72);
            this.labTeaName.Name = "labTeaName";
            this.labTeaName.Size = new System.Drawing.Size(47, 12);
            this.labTeaName.TabIndex = 1;
            this.labTeaName.Text = "TeaName";
            // 
            // labTeaSex
            // 
            this.labTeaSex.AutoSize = true;
            this.labTeaSex.Location = new System.Drawing.Point(59, 104);
            this.labTeaSex.Name = "labTeaSex";
            this.labTeaSex.Size = new System.Drawing.Size(41, 12);
            this.labTeaSex.TabIndex = 2;
            this.labTeaSex.Text = "TeaSex";
            // 
            // labTeaPhone
            // 
            this.labTeaPhone.AutoSize = true;
            this.labTeaPhone.Location = new System.Drawing.Point(59, 136);
            this.labTeaPhone.Name = "labTeaPhone";
            this.labTeaPhone.Size = new System.Drawing.Size(53, 12);
            this.labTeaPhone.TabIndex = 3;
            this.labTeaPhone.Text = "TeaPhone";
            // 
            // labTmp
            // 
            this.labTmp.AutoSize = true;
            this.labTmp.Location = new System.Drawing.Point(59, 168);
            this.labTmp.Name = "labTmp";
            this.labTmp.Size = new System.Drawing.Size(23, 12);
            this.labTmp.TabIndex = 4;
            this.labTmp.Text = "Tmp";
            this.labTmp.Visible = false;
            // 
            // txtTeaID
            // 
            this.txtTeaID.Location = new System.Drawing.Point(137, 37);
            this.txtTeaID.Name = "txtTeaID";
            this.txtTeaID.Size = new System.Drawing.Size(100, 21);
            this.txtTeaID.TabIndex = 5;
            // 
            // txtTeaName
            // 
            this.txtTeaName.Location = new System.Drawing.Point(137, 69);
            this.txtTeaName.Name = "txtTeaName";
            this.txtTeaName.Size = new System.Drawing.Size(100, 21);
            this.txtTeaName.TabIndex = 6;
            // 
            // txtTeaSex
            // 
            this.txtTeaSex.Location = new System.Drawing.Point(137, 104);
            this.txtTeaSex.Name = "txtTeaSex";
            this.txtTeaSex.Size = new System.Drawing.Size(100, 21);
            this.txtTeaSex.TabIndex = 7;
            // 
            // txtTeaPhone
            // 
            this.txtTeaPhone.Location = new System.Drawing.Point(137, 133);
            this.txtTeaPhone.Name = "txtTeaPhone";
            this.txtTeaPhone.Size = new System.Drawing.Size(100, 21);
            this.txtTeaPhone.TabIndex = 8;
            // 
            // txtTmp
            // 
            this.txtTmp.Location = new System.Drawing.Point(137, 165);
            this.txtTmp.Name = "txtTmp";
            this.txtTmp.Size = new System.Drawing.Size(100, 21);
            this.txtTmp.TabIndex = 9;
            this.txtTmp.Visible = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(61, 199);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(162, 199);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // FormTeaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtTmp);
            this.Controls.Add(this.txtTeaPhone);
            this.Controls.Add(this.txtTeaSex);
            this.Controls.Add(this.txtTeaName);
            this.Controls.Add(this.txtTeaID);
            this.Controls.Add(this.labTmp);
            this.Controls.Add(this.labTeaPhone);
            this.Controls.Add(this.labTeaSex);
            this.Controls.Add(this.labTeaName);
            this.Controls.Add(this.labTeaID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTeaInfo";
            this.Text = "教师信息录入";
            this.Load += new System.EventHandler(this.FormTeaInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTeaID;
        private System.Windows.Forms.Label labTeaName;
        private System.Windows.Forms.Label labTeaSex;
        private System.Windows.Forms.Label labTeaPhone;
        private System.Windows.Forms.Label labTmp;
        private System.Windows.Forms.TextBox txtTeaID;
        private System.Windows.Forms.TextBox txtTeaName;
        private System.Windows.Forms.TextBox txtTeaSex;
        private System.Windows.Forms.TextBox txtTeaPhone;
        private System.Windows.Forms.TextBox txtTmp;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
    }
}