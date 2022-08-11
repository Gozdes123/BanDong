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
            this.CB_PayType = new System.Windows.Forms.ComboBox();
            this.LB_Title_PayType = new System.Windows.Forms.Label();
            this.LB_Title_BanDongType = new System.Windows.Forms.Label();
            this.CB_BanDongType = new System.Windows.Forms.ComboBox();
            this.LB_Title_Welcome = new System.Windows.Forms.Label();
            this.LB_Title_sex = new System.Windows.Forms.Label();
            this.BTN_Buy = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_History = new System.Windows.Forms.Button();
            this.LB_Title_Remark = new System.Windows.Forms.Label();
            this.TB_Remark = new System.Windows.Forms.TextBox();
            this.LB_StudentName = new System.Windows.Forms.Label();
            this.BTN_Output = new System.Windows.Forms.Button();
            this.LB_TimeShow = new System.Windows.Forms.Label();
            this.Timer_Now = new System.Windows.Forms.Timer(this.components);
            this.LB_Title_Edit = new System.Windows.Forms.Label();
            this.LB_Title_PayType2 = new System.Windows.Forms.Label();
            this.CB_PayType2 = new System.Windows.Forms.ComboBox();
            this.TB_Remark2 = new System.Windows.Forms.TextBox();
            this.LB_Title_Remark2 = new System.Windows.Forms.Label();
            this.LB_Title_BanDongType2 = new System.Windows.Forms.Label();
            this.CB_BanDongType2 = new System.Windows.Forms.ComboBox();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Confirm = new System.Windows.Forms.Button();
            this.Timer_SQL_Truncate = new System.Windows.Forms.Timer(this.components);
            this.BTN_Logout = new System.Windows.Forms.Button();
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
            // CB_PayType
            // 
            this.CB_PayType.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CB_PayType.FormattingEnabled = true;
            this.CB_PayType.Items.AddRange(new object[] {
            "便當票券",
            "現金"});
            this.CB_PayType.Location = new System.Drawing.Point(283, 174);
            this.CB_PayType.Margin = new System.Windows.Forms.Padding(2);
            this.CB_PayType.Name = "CB_PayType";
            this.CB_PayType.Size = new System.Drawing.Size(205, 39);
            this.CB_PayType.TabIndex = 9;
            // 
            // LB_Title_PayType
            // 
            this.LB_Title_PayType.AutoSize = true;
            this.LB_Title_PayType.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_PayType.Location = new System.Drawing.Point(144, 182);
            this.LB_Title_PayType.Name = "LB_Title_PayType";
            this.LB_Title_PayType.Size = new System.Drawing.Size(134, 31);
            this.LB_Title_PayType.TabIndex = 10;
            this.LB_Title_PayType.Text = "付款方式：";
            // 
            // LB_Title_BanDongType
            // 
            this.LB_Title_BanDongType.AutoSize = true;
            this.LB_Title_BanDongType.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_BanDongType.Location = new System.Drawing.Point(144, 247);
            this.LB_Title_BanDongType.Name = "LB_Title_BanDongType";
            this.LB_Title_BanDongType.Size = new System.Drawing.Size(134, 31);
            this.LB_Title_BanDongType.TabIndex = 12;
            this.LB_Title_BanDongType.Text = "便當類型：";
            // 
            // CB_BanDongType
            // 
            this.CB_BanDongType.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CB_BanDongType.FormattingEnabled = true;
            this.CB_BanDongType.Items.AddRange(new object[] {
            "圓形",
            "方形"});
            this.CB_BanDongType.Location = new System.Drawing.Point(283, 239);
            this.CB_BanDongType.Margin = new System.Windows.Forms.Padding(2);
            this.CB_BanDongType.Name = "CB_BanDongType";
            this.CB_BanDongType.Size = new System.Drawing.Size(205, 39);
            this.CB_BanDongType.TabIndex = 11;
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
            // LB_Title_sex
            // 
            this.LB_Title_sex.AutoSize = true;
            this.LB_Title_sex.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_sex.Location = new System.Drawing.Point(374, 115);
            this.LB_Title_sex.Name = "LB_Title_sex";
            this.LB_Title_sex.Size = new System.Drawing.Size(121, 31);
            this.LB_Title_sex.TabIndex = 14;
            this.LB_Title_sex.Text = "先生/小姐";
            // 
            // BTN_Buy
            // 
            this.BTN_Buy.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_Buy.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Buy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Buy.Location = new System.Drawing.Point(128, 408);
            this.BTN_Buy.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Buy.Name = "BTN_Buy";
            this.BTN_Buy.Size = new System.Drawing.Size(115, 50);
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
            this.BTN_Edit.Location = new System.Drawing.Point(271, 408);
            this.BTN_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(115, 50);
            this.BTN_Edit.TabIndex = 17;
            this.BTN_Edit.Text = "編輯";
            this.BTN_Edit.UseVisualStyleBackColor = false;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.BackColor = System.Drawing.Color.Yellow;
            this.BTN_Delete.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Delete.Location = new System.Drawing.Point(414, 408);
            this.BTN_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(115, 50);
            this.BTN_Delete.TabIndex = 18;
            this.BTN_Delete.Text = "刪除";
            this.BTN_Delete.UseVisualStyleBackColor = false;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_History
            // 
            this.BTN_History.BackColor = System.Drawing.Color.PaleGreen;
            this.BTN_History.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_History.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_History.Location = new System.Drawing.Point(128, 475);
            this.BTN_History.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_History.Name = "BTN_History";
            this.BTN_History.Size = new System.Drawing.Size(402, 41);
            this.BTN_History.TabIndex = 19;
            this.BTN_History.Text = "歷史訂購紀錄";
            this.BTN_History.UseVisualStyleBackColor = false;
            this.BTN_History.Click += new System.EventHandler(this.BTN_History_Click);
            // 
            // LB_Title_Remark
            // 
            this.LB_Title_Remark.AutoSize = true;
            this.LB_Title_Remark.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Remark.Location = new System.Drawing.Point(144, 302);
            this.LB_Title_Remark.Name = "LB_Title_Remark";
            this.LB_Title_Remark.Size = new System.Drawing.Size(74, 31);
            this.LB_Title_Remark.TabIndex = 20;
            this.LB_Title_Remark.Text = "備註 :";
            // 
            // TB_Remark
            // 
            this.TB_Remark.BackColor = System.Drawing.Color.PapayaWhip;
            this.TB_Remark.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_Remark.Location = new System.Drawing.Point(223, 302);
            this.TB_Remark.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Remark.Multiline = true;
            this.TB_Remark.Name = "TB_Remark";
            this.TB_Remark.Size = new System.Drawing.Size(265, 86);
            this.TB_Remark.TabIndex = 21;
            // 
            // LB_StudentName
            // 
            this.LB_StudentName.AutoSize = true;
            this.LB_StudentName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_StudentName.Location = new System.Drawing.Point(283, 115);
            this.LB_StudentName.Name = "LB_StudentName";
            this.LB_StudentName.Size = new System.Drawing.Size(62, 31);
            this.LB_StudentName.TabIndex = 22;
            this.LB_StudentName.Text = "匿名";
            // 
            // BTN_Output
            // 
            this.BTN_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTN_Output.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Output.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Output.Location = new System.Drawing.Point(128, 534);
            this.BTN_Output.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Output.Name = "BTN_Output";
            this.BTN_Output.Size = new System.Drawing.Size(402, 41);
            this.BTN_Output.TabIndex = 23;
            this.BTN_Output.Text = "輸出訂購單";
            this.BTN_Output.UseVisualStyleBackColor = false;
            this.BTN_Output.Click += new System.EventHandler(this.BTN_Output_Click);
            // 
            // LB_TimeShow
            // 
            this.LB_TimeShow.AutoSize = true;
            this.LB_TimeShow.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_TimeShow.Location = new System.Drawing.Point(173, 689);
            this.LB_TimeShow.Name = "LB_TimeShow";
            this.LB_TimeShow.Size = new System.Drawing.Size(310, 31);
            this.LB_TimeShow.TabIndex = 24;
            this.LB_TimeShow.Text = "2022/08/07  上午 10:10:40";
            // 
            // Timer_Now
            // 
            this.Timer_Now.Tick += new System.EventHandler(this.Timer_Now_Tick);
            // 
            // LB_Title_Edit
            // 
            this.LB_Title_Edit.AutoSize = true;
            this.LB_Title_Edit.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Edit.Location = new System.Drawing.Point(653, 38);
            this.LB_Title_Edit.Name = "LB_Title_Edit";
            this.LB_Title_Edit.Size = new System.Drawing.Size(293, 37);
            this.LB_Title_Edit.TabIndex = 25;
            this.LB_Title_Edit.Text = "編  輯  訂  單";
            this.LB_Title_Edit.Visible = false;
            // 
            // LB_Title_PayType2
            // 
            this.LB_Title_PayType2.AutoSize = true;
            this.LB_Title_PayType2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_PayType2.Location = new System.Drawing.Point(612, 182);
            this.LB_Title_PayType2.Name = "LB_Title_PayType2";
            this.LB_Title_PayType2.Size = new System.Drawing.Size(134, 31);
            this.LB_Title_PayType2.TabIndex = 27;
            this.LB_Title_PayType2.Text = "付款方式：";
            this.LB_Title_PayType2.Visible = false;
            // 
            // CB_PayType2
            // 
            this.CB_PayType2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CB_PayType2.FormattingEnabled = true;
            this.CB_PayType2.Items.AddRange(new object[] {
            "便當票券",
            "現金"});
            this.CB_PayType2.Location = new System.Drawing.Point(751, 174);
            this.CB_PayType2.Margin = new System.Windows.Forms.Padding(2);
            this.CB_PayType2.Name = "CB_PayType2";
            this.CB_PayType2.Size = new System.Drawing.Size(205, 39);
            this.CB_PayType2.TabIndex = 26;
            this.CB_PayType2.Visible = false;
            // 
            // TB_Remark2
            // 
            this.TB_Remark2.BackColor = System.Drawing.Color.PapayaWhip;
            this.TB_Remark2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_Remark2.Location = new System.Drawing.Point(691, 302);
            this.TB_Remark2.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Remark2.Multiline = true;
            this.TB_Remark2.Name = "TB_Remark2";
            this.TB_Remark2.Size = new System.Drawing.Size(265, 86);
            this.TB_Remark2.TabIndex = 31;
            this.TB_Remark2.Visible = false;
            // 
            // LB_Title_Remark2
            // 
            this.LB_Title_Remark2.AutoSize = true;
            this.LB_Title_Remark2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Remark2.Location = new System.Drawing.Point(612, 302);
            this.LB_Title_Remark2.Name = "LB_Title_Remark2";
            this.LB_Title_Remark2.Size = new System.Drawing.Size(74, 31);
            this.LB_Title_Remark2.TabIndex = 30;
            this.LB_Title_Remark2.Text = "備註 :";
            this.LB_Title_Remark2.Visible = false;
            // 
            // LB_Title_BanDongType2
            // 
            this.LB_Title_BanDongType2.AutoSize = true;
            this.LB_Title_BanDongType2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_BanDongType2.Location = new System.Drawing.Point(612, 247);
            this.LB_Title_BanDongType2.Name = "LB_Title_BanDongType2";
            this.LB_Title_BanDongType2.Size = new System.Drawing.Size(134, 31);
            this.LB_Title_BanDongType2.TabIndex = 29;
            this.LB_Title_BanDongType2.Text = "便當類型：";
            this.LB_Title_BanDongType2.Visible = false;
            // 
            // CB_BanDongType2
            // 
            this.CB_BanDongType2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CB_BanDongType2.FormattingEnabled = true;
            this.CB_BanDongType2.Items.AddRange(new object[] {
            "圓形",
            "方形"});
            this.CB_BanDongType2.Location = new System.Drawing.Point(751, 239);
            this.CB_BanDongType2.Margin = new System.Windows.Forms.Padding(2);
            this.CB_BanDongType2.Name = "CB_BanDongType2";
            this.CB_BanDongType2.Size = new System.Drawing.Size(205, 39);
            this.CB_BanDongType2.TabIndex = 28;
            this.CB_BanDongType2.Visible = false;
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTN_Reset.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Reset.Location = new System.Drawing.Point(796, 408);
            this.BTN_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(73, 50);
            this.BTN_Reset.TabIndex = 37;
            this.BTN_Reset.Text = "重置";
            this.BTN_Reset.UseVisualStyleBackColor = false;
            this.BTN_Reset.Visible = false;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Cancel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Cancel.Location = new System.Drawing.Point(873, 408);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(73, 50);
            this.BTN_Cancel.TabIndex = 36;
            this.BTN_Cancel.Text = "取消";
            this.BTN_Cancel.UseVisualStyleBackColor = false;
            this.BTN_Cancel.Visible = false;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Confirm
            // 
            this.BTN_Confirm.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_Confirm.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Confirm.Location = new System.Drawing.Point(618, 408);
            this.BTN_Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Confirm.Name = "BTN_Confirm";
            this.BTN_Confirm.Size = new System.Drawing.Size(120, 50);
            this.BTN_Confirm.TabIndex = 35;
            this.BTN_Confirm.Text = "確認編輯";
            this.BTN_Confirm.UseVisualStyleBackColor = false;
            this.BTN_Confirm.Visible = false;
            this.BTN_Confirm.Click += new System.EventHandler(this.BTN_Confirm_Click);
            // 
            // Timer_SQL_Truncate
            // 
            this.Timer_SQL_Truncate.Interval = 60000;
            this.Timer_SQL_Truncate.Tick += new System.EventHandler(this.Timer_SQL_Truncate_Tick);
            // 
            // BTN_Logout
            // 
            this.BTN_Logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Logout.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Logout.Location = new System.Drawing.Point(11, 668);
            this.BTN_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Logout.Name = "BTN_Logout";
            this.BTN_Logout.Size = new System.Drawing.Size(115, 50);
            this.BTN_Logout.TabIndex = 38;
            this.BTN_Logout.Text = "登出";
            this.BTN_Logout.UseVisualStyleBackColor = false;
            this.BTN_Logout.Click += new System.EventHandler(this.BTN_Logout_Click);
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BTN_Logout);
            this.Controls.Add(this.BTN_Reset);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Confirm);
            this.Controls.Add(this.TB_Remark2);
            this.Controls.Add(this.LB_Title_Remark2);
            this.Controls.Add(this.LB_Title_BanDongType2);
            this.Controls.Add(this.CB_BanDongType2);
            this.Controls.Add(this.LB_Title_PayType2);
            this.Controls.Add(this.CB_PayType2);
            this.Controls.Add(this.LB_Title_Edit);
            this.Controls.Add(this.LB_TimeShow);
            this.Controls.Add(this.BTN_Output);
            this.Controls.Add(this.LB_StudentName);
            this.Controls.Add(this.TB_Remark);
            this.Controls.Add(this.LB_Title_Remark);
            this.Controls.Add(this.BTN_History);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.BTN_Buy);
            this.Controls.Add(this.LB_Title_sex);
            this.Controls.Add(this.LB_Title_Welcome);
            this.Controls.Add(this.LB_Title_BanDongType);
            this.Controls.Add(this.CB_BanDongType);
            this.Controls.Add(this.LB_Title_PayType);
            this.Controls.Add(this.CB_PayType);
            this.Controls.Add(this.LB_Title_Order);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Order_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order_Form";
            this.Load += new System.EventHandler(this.Order_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Title_Order;
        private System.Windows.Forms.ComboBox CB_PayType;
        private System.Windows.Forms.Label LB_Title_PayType;
        private System.Windows.Forms.Label LB_Title_BanDongType;
        private System.Windows.Forms.ComboBox CB_BanDongType;
        private System.Windows.Forms.Label LB_Title_Welcome;
        private System.Windows.Forms.Label LB_Title_sex;
        private System.Windows.Forms.Button BTN_Buy;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_History;
        private System.Windows.Forms.Label LB_Title_Remark;
        private System.Windows.Forms.TextBox TB_Remark;
        private System.Windows.Forms.Label LB_StudentName;
        private System.Windows.Forms.Button BTN_Output;
        private System.Windows.Forms.Label LB_TimeShow;
        private System.Windows.Forms.Timer Timer_Now;
        private System.Windows.Forms.Label LB_Title_Edit;
        private System.Windows.Forms.Label LB_Title_PayType2;
        private System.Windows.Forms.ComboBox CB_PayType2;
        private System.Windows.Forms.TextBox TB_Remark2;
        private System.Windows.Forms.Label LB_Title_Remark2;
        private System.Windows.Forms.Label LB_Title_BanDongType2;
        private System.Windows.Forms.ComboBox CB_BanDongType2;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Confirm;
        private System.Windows.Forms.Timer Timer_SQL_Truncate;
        private System.Windows.Forms.Button BTN_Logout;
    }
}