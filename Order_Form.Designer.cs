namespace BanDong_1._0v
{
    partial class Order_Form
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
            this.LB_Title_Order = new System.Windows.Forms.Label();
            this.cb_PayType = new System.Windows.Forms.ComboBox();
            this.LB_Title_StudentID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_BanDongType = new System.Windows.Forms.ComboBox();
            this.LB_Title_Welcome = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.BTN_Buy = new System.Windows.Forms.Button();
            this.BTN_Adapt = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_remark = new System.Windows.Forms.TextBox();
            this.LB_StudentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_Title_Order
            // 
            this.LB_Title_Order.AutoSize = true;
            this.LB_Title_Order.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Order.Location = new System.Drawing.Point(190, 38);
            this.LB_Title_Order.Name = "LB_Title_Order";
            this.LB_Title_Order.Size = new System.Drawing.Size(293, 37);
            this.LB_Title_Order.TabIndex = 8;
            this.LB_Title_Order.Text = "訂  購  系  統";
            // 
            // cb_PayType
            // 
            this.cb_PayType.FormattingEnabled = true;
            this.cb_PayType.Items.AddRange(new object[] {
            "便當票券",
            "現金"});
            this.cb_PayType.Location = new System.Drawing.Point(282, 186);
            this.cb_PayType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_PayType.Name = "cb_PayType";
            this.cb_PayType.Size = new System.Drawing.Size(205, 20);
            this.cb_PayType.TabIndex = 9;
            // 
            // LB_Title_StudentID
            // 
            this.LB_Title_StudentID.AutoSize = true;
            this.LB_Title_StudentID.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_StudentID.Location = new System.Drawing.Point(152, 174);
            this.LB_Title_StudentID.Name = "LB_Title_StudentID";
            this.LB_Title_StudentID.Size = new System.Drawing.Size(134, 31);
            this.LB_Title_StudentID.TabIndex = 10;
            this.LB_Title_StudentID.Text = "付款方式：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(152, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "便當類型：";
            // 
            // cb_BanDongType
            // 
            this.cb_BanDongType.FormattingEnabled = true;
            this.cb_BanDongType.Items.AddRange(new object[] {
            "圓形",
            "方形"});
            this.cb_BanDongType.Location = new System.Drawing.Point(282, 247);
            this.cb_BanDongType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_BanDongType.Name = "cb_BanDongType";
            this.cb_BanDongType.Size = new System.Drawing.Size(205, 20);
            this.cb_BanDongType.TabIndex = 11;
            // 
            // LB_Title_Welcome
            // 
            this.LB_Title_Welcome.AutoSize = true;
            this.LB_Title_Welcome.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Welcome.Location = new System.Drawing.Point(153, 115);
            this.LB_Title_Welcome.Name = "LB_Title_Welcome";
            this.LB_Title_Welcome.Size = new System.Drawing.Size(134, 31);
            this.LB_Title_Welcome.TabIndex = 13;
            this.LB_Title_Welcome.Text = "歡迎光臨!!";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelName.Location = new System.Drawing.Point(374, 115);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(121, 31);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "先生/小姐";
            // 
            // BTN_Buy
            // 
            this.BTN_Buy.BackColor = System.Drawing.Color.Silver;
            this.BTN_Buy.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Buy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Buy.Location = new System.Drawing.Point(128, 408);
            this.BTN_Buy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Buy.Name = "BTN_Buy";
            this.BTN_Buy.Size = new System.Drawing.Size(100, 50);
            this.BTN_Buy.TabIndex = 16;
            this.BTN_Buy.Text = "訂購";
            this.BTN_Buy.UseVisualStyleBackColor = false;
            this.BTN_Buy.Click += new System.EventHandler(this.BTN_Buy_Click_1);
            // 
            // BTN_Adapt
            // 
            this.BTN_Adapt.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_Adapt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Adapt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Adapt.Location = new System.Drawing.Point(314, 408);
            this.BTN_Adapt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Adapt.Name = "BTN_Adapt";
            this.BTN_Adapt.Size = new System.Drawing.Size(100, 50);
            this.BTN_Adapt.TabIndex = 17;
            this.BTN_Adapt.Text = "編輯";
            this.BTN_Adapt.UseVisualStyleBackColor = false;
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.BackColor = System.Drawing.Color.Yellow;
            this.BTN_Delete.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Delete.Location = new System.Drawing.Point(430, 408);
            this.BTN_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(100, 50);
            this.BTN_Delete.TabIndex = 18;
            this.BTN_Delete.Text = "刪除";
            this.BTN_Delete.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGreen;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(128, 475);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(402, 41);
            this.button3.TabIndex = 19;
            this.button3.Text = "歷史訂購紀錄";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(152, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "備註 :";
            // 
            // tbox_remark
            // 
            this.tbox_remark.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbox_remark.Location = new System.Drawing.Point(235, 302);
            this.tbox_remark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbox_remark.Multiline = true;
            this.tbox_remark.Name = "tbox_remark";
            this.tbox_remark.Size = new System.Drawing.Size(252, 86);
            this.tbox_remark.TabIndex = 21;
            // 
            // LB_StudentName
            // 
            this.LB_StudentName.AutoSize = true;
            this.LB_StudentName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_StudentName.Location = new System.Drawing.Point(293, 115);
            this.LB_StudentName.Name = "LB_StudentName";
            this.LB_StudentName.Size = new System.Drawing.Size(62, 31);
            this.LB_StudentName.TabIndex = 22;
            this.LB_StudentName.Text = "匿名";
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(681, 559);
            this.Controls.Add(this.LB_StudentName);
            this.Controls.Add(this.tbox_remark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Adapt);
            this.Controls.Add(this.BTN_Buy);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.LB_Title_Welcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_BanDongType);
            this.Controls.Add(this.LB_Title_StudentID);
            this.Controls.Add(this.cb_PayType);
            this.Controls.Add(this.LB_Title_Order);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Order_Form";
            this.Text = "Order_Form";
            this.Load += new System.EventHandler(this.Order_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Title_Order;
        private System.Windows.Forms.ComboBox cb_PayType;
        private System.Windows.Forms.Label LB_Title_StudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_BanDongType;
        private System.Windows.Forms.Label LB_Title_Welcome;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button BTN_Buy;
        private System.Windows.Forms.Button BTN_Adapt;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_remark;
        private System.Windows.Forms.Label LB_StudentName;
    }
}