namespace BanDong_1._0v
{
    partial class Edit_Form
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
            this.LB_StudentName = new System.Windows.Forms.Label();
            this.tbox_remark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_BanDongType = new System.Windows.Forms.ComboBox();
            this.LB_Title_StudentID = new System.Windows.Forms.Label();
            this.cb_PayType = new System.Windows.Forms.ComboBox();
            this.BTN_Confirm = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_StudentName
            // 
            this.LB_StudentName.AutoSize = true;
            this.LB_StudentName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_StudentName.Location = new System.Drawing.Point(177, 55);
            this.LB_StudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_StudentName.Name = "LB_StudentName";
            this.LB_StudentName.Size = new System.Drawing.Size(77, 38);
            this.LB_StudentName.TabIndex = 31;
            this.LB_StudentName.Text = "匿名";
            // 
            // tbox_remark
            // 
            this.tbox_remark.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbox_remark.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbox_remark.Location = new System.Drawing.Point(287, 289);
            this.tbox_remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_remark.Multiline = true;
            this.tbox_remark.Name = "tbox_remark";
            this.tbox_remark.Size = new System.Drawing.Size(335, 106);
            this.tbox_remark.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(177, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 38);
            this.label3.TabIndex = 29;
            this.label3.Text = "備註 :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelName.Location = new System.Drawing.Point(280, 55);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(150, 38);
            this.labelName.TabIndex = 28;
            this.labelName.Text = "先生/小姐";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(177, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 26;
            this.label1.Text = "便當類型：";
            // 
            // cb_BanDongType
            // 
            this.cb_BanDongType.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_BanDongType.FormattingEnabled = true;
            this.cb_BanDongType.Items.AddRange(new object[] {
            "圓形",
            "方形"});
            this.cb_BanDongType.Location = new System.Drawing.Point(350, 220);
            this.cb_BanDongType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_BanDongType.Name = "cb_BanDongType";
            this.cb_BanDongType.Size = new System.Drawing.Size(272, 46);
            this.cb_BanDongType.TabIndex = 25;
            // 
            // LB_Title_StudentID
            // 
            this.LB_Title_StudentID.AutoSize = true;
            this.LB_Title_StudentID.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_StudentID.Location = new System.Drawing.Point(177, 129);
            this.LB_Title_StudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title_StudentID.Name = "LB_Title_StudentID";
            this.LB_Title_StudentID.Size = new System.Drawing.Size(167, 38);
            this.LB_Title_StudentID.TabIndex = 24;
            this.LB_Title_StudentID.Text = "付款方式：";
            // 
            // cb_PayType
            // 
            this.cb_PayType.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_PayType.FormattingEnabled = true;
            this.cb_PayType.Items.AddRange(new object[] {
            "便當票券",
            "現金"});
            this.cb_PayType.Location = new System.Drawing.Point(351, 129);
            this.cb_PayType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_PayType.Name = "cb_PayType";
            this.cb_PayType.Size = new System.Drawing.Size(272, 46);
            this.cb_PayType.TabIndex = 23;
            // 
            // BTN_Confirm
            // 
            this.BTN_Confirm.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_Confirm.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Confirm.Location = new System.Drawing.Point(184, 407);
            this.BTN_Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Confirm.Name = "BTN_Confirm";
            this.BTN_Confirm.Size = new System.Drawing.Size(160, 62);
            this.BTN_Confirm.TabIndex = 32;
            this.BTN_Confirm.Text = "確認編輯";
            this.BTN_Confirm.UseVisualStyleBackColor = false;
            this.BTN_Confirm.Click += new System.EventHandler(this.BTN_Confirm_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Cancel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Cancel.Location = new System.Drawing.Point(525, 407);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(97, 62);
            this.BTN_Cancel.TabIndex = 33;
            this.BTN_Cancel.Text = "取消";
            this.BTN_Cancel.UseVisualStyleBackColor = false;
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTN_Reset.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Reset.Location = new System.Drawing.Point(422, 407);
            this.BTN_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(97, 62);
            this.BTN_Reset.TabIndex = 34;
            this.BTN_Reset.Text = "重置";
            this.BTN_Reset.UseVisualStyleBackColor = false;
            // 
            // Edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.BTN_Reset);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Confirm);
            this.Controls.Add(this.LB_StudentName);
            this.Controls.Add(this.tbox_remark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_BanDongType);
            this.Controls.Add(this.LB_Title_StudentID);
            this.Controls.Add(this.cb_PayType);
            this.Name = "Edit_Form";
            this.Text = "Edit_Form";
            this.Load += new System.EventHandler(this.Edit_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_StudentName;
        private System.Windows.Forms.TextBox tbox_remark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_BanDongType;
        private System.Windows.Forms.Label LB_Title_StudentID;
        private System.Windows.Forms.ComboBox cb_PayType;
        private System.Windows.Forms.Button BTN_Confirm;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Reset;
    }
}