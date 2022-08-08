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
            this.components = new System.ComponentModel.Container();
            this.LB_Title_Order = new System.Windows.Forms.Label();
            this.cb_PayType = new System.Windows.Forms.ComboBox();
            this.LB_Title_StudentID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_BanDongType = new System.Windows.Forms.ComboBox();
            this.LB_Title_Welcome = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.BTN_Buy = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.button_history = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_remark = new System.Windows.Forms.TextBox();
            this.LB_StudentName = new System.Windows.Forms.Label();
            this.button_layout = new System.Windows.Forms.Button();
            this.LB_Time = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LB_Title_Order
            // 
            this.LB_Title_Order.AutoSize = true;
            this.LB_Title_Order.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Order.Location = new System.Drawing.Point(253, 48);
            this.LB_Title_Order.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title_Order.Name = "LB_Title_Order";
            this.LB_Title_Order.Size = new System.Drawing.Size(366, 47);
            this.LB_Title_Order.TabIndex = 8;
            this.LB_Title_Order.Text = "訂  購  系  統";
            // 
            // cb_PayType
            // 
            this.cb_PayType.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_PayType.FormattingEnabled = true;
            this.cb_PayType.Items.AddRange(new object[] {
            "便當票券",
            "現金"});
            this.cb_PayType.Location = new System.Drawing.Point(377, 218);
            this.cb_PayType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_PayType.Name = "cb_PayType";
            this.cb_PayType.Size = new System.Drawing.Size(272, 46);
            this.cb_PayType.TabIndex = 9;
            // 
            // LB_Title_StudentID
            // 
            this.LB_Title_StudentID.AutoSize = true;
            this.LB_Title_StudentID.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_StudentID.Location = new System.Drawing.Point(203, 218);
            this.LB_Title_StudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title_StudentID.Name = "LB_Title_StudentID";
            this.LB_Title_StudentID.Size = new System.Drawing.Size(167, 38);
            this.LB_Title_StudentID.TabIndex = 10;
            this.LB_Title_StudentID.Text = "付款方式：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(203, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "便當類型：";
            // 
            // cb_BanDongType
            // 
            this.cb_BanDongType.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_BanDongType.FormattingEnabled = true;
            this.cb_BanDongType.Items.AddRange(new object[] {
            "圓形",
            "方形"});
            this.cb_BanDongType.Location = new System.Drawing.Point(376, 309);
            this.cb_BanDongType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_BanDongType.Name = "cb_BanDongType";
            this.cb_BanDongType.Size = new System.Drawing.Size(272, 46);
            this.cb_BanDongType.TabIndex = 11;
            // 
            // LB_Title_Welcome
            // 
            this.LB_Title_Welcome.AutoSize = true;
            this.LB_Title_Welcome.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Welcome.Location = new System.Drawing.Point(204, 144);
            this.LB_Title_Welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title_Welcome.Name = "LB_Title_Welcome";
            this.LB_Title_Welcome.Size = new System.Drawing.Size(165, 38);
            this.LB_Title_Welcome.TabIndex = 13;
            this.LB_Title_Welcome.Text = "歡迎光臨!!";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelName.Location = new System.Drawing.Point(499, 144);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(150, 38);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "先生/小姐";
            // 
            // BTN_Buy
            // 
            this.BTN_Buy.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_Buy.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Buy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Buy.Location = new System.Drawing.Point(171, 510);
            this.BTN_Buy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Buy.Name = "BTN_Buy";
            this.BTN_Buy.Size = new System.Drawing.Size(133, 62);
            this.BTN_Buy.TabIndex = 16;
            this.BTN_Buy.Text = "訂購";
            this.BTN_Buy.UseVisualStyleBackColor = false;
            this.BTN_Buy.Click += new System.EventHandler(this.BTN_Buy_Click_1);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_Edit.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Edit.Location = new System.Drawing.Point(419, 510);
            this.BTN_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(133, 62);
            this.BTN_Edit.TabIndex = 17;
            this.BTN_Edit.Text = "編輯";
            this.BTN_Edit.UseVisualStyleBackColor = false;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Adapt_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.BackColor = System.Drawing.Color.Yellow;
            this.BTN_Delete.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Delete.Location = new System.Drawing.Point(573, 510);
            this.BTN_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(133, 62);
            this.BTN_Delete.TabIndex = 18;
            this.BTN_Delete.Text = "刪除";
            this.BTN_Delete.UseVisualStyleBackColor = false;
            // 
            // button_history
            // 
            this.button_history.BackColor = System.Drawing.Color.PaleGreen;
            this.button_history.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_history.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_history.Location = new System.Drawing.Point(171, 594);
            this.button_history.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_history.Name = "button_history";
            this.button_history.Size = new System.Drawing.Size(536, 51);
            this.button_history.TabIndex = 19;
            this.button_history.Text = "歷史訂購紀錄";
            this.button_history.UseVisualStyleBackColor = false;
            this.button_history.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(203, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 38);
            this.label3.TabIndex = 20;
            this.label3.Text = "備註 :";
            // 
            // tbox_remark
            // 
            this.tbox_remark.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbox_remark.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbox_remark.Location = new System.Drawing.Point(313, 378);
            this.tbox_remark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_remark.Multiline = true;
            this.tbox_remark.Name = "tbox_remark";
            this.tbox_remark.Size = new System.Drawing.Size(335, 106);
            this.tbox_remark.TabIndex = 21;
            // 
            // LB_StudentName
            // 
            this.LB_StudentName.AutoSize = true;
            this.LB_StudentName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_StudentName.Location = new System.Drawing.Point(377, 144);
            this.LB_StudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_StudentName.Name = "LB_StudentName";
            this.LB_StudentName.Size = new System.Drawing.Size(77, 38);
            this.LB_StudentName.TabIndex = 22;
            this.LB_StudentName.Text = "匿名";
            // 
            // button_layout
            // 
            this.button_layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_layout.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_layout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_layout.Location = new System.Drawing.Point(171, 668);
            this.button_layout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_layout.Name = "button_layout";
            this.button_layout.Size = new System.Drawing.Size(536, 51);
            this.button_layout.TabIndex = 23;
            this.button_layout.Text = "輸出訂購單";
            this.button_layout.UseVisualStyleBackColor = false;
            // 
            // LB_Time
            // 
            this.LB_Time.AutoSize = true;
            this.LB_Time.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Time.Location = new System.Drawing.Point(524, 808);
            this.LB_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Time.Name = "LB_Time";
            this.LB_Time.Size = new System.Drawing.Size(215, 38);
            this.LB_Time.TabIndex = 24;
            this.LB_Time.Text = "00000000000";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(963, 858);
            this.Controls.Add(this.LB_Time);
            this.Controls.Add(this.button_layout);
            this.Controls.Add(this.LB_StudentName);
            this.Controls.Add(this.tbox_remark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_history);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.BTN_Buy);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.LB_Title_Welcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_BanDongType);
            this.Controls.Add(this.LB_Title_StudentID);
            this.Controls.Add(this.cb_PayType);
            this.Controls.Add(this.LB_Title_Order);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button button_history;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_remark;
        private System.Windows.Forms.Label LB_StudentName;
        private System.Windows.Forms.Button button_layout;
        private System.Windows.Forms.Label LB_Time;
        private System.Windows.Forms.Timer Timer;
    }
}