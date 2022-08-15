namespace BanDong_1._0v
{
    partial class TodayOrder_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LB_Title_Order = new System.Windows.Forms.Label();
            this.LB_Title_OrderDate = new System.Windows.Forms.Label();
            this.LB_Title_TakeDate = new System.Windows.Forms.Label();
            this.LB_OrderDate = new System.Windows.Forms.Label();
            this.LB_TakeDate = new System.Windows.Forms.Label();
            this.DGV_TodayOrder = new System.Windows.Forms.DataGridView();
            this.LB_Title_Class = new System.Windows.Forms.Label();
            this.BTN_Class_Update = new System.Windows.Forms.Button();
            this.BTN_ToExcel = new System.Windows.Forms.Button();
            this.BTN_Print = new System.Windows.Forms.Button();
            this.LB_ClassShow = new System.Windows.Forms.Label();
            this.TB_Class_Update = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TodayOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Title_Order
            // 
            this.LB_Title_Order.AutoSize = true;
            this.LB_Title_Order.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Order.Location = new System.Drawing.Point(423, 11);
            this.LB_Title_Order.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title_Order.Name = "LB_Title_Order";
            this.LB_Title_Order.Size = new System.Drawing.Size(465, 47);
            this.LB_Title_Order.TabIndex = 9;
            this.LB_Title_Order.Text = "今  日  訂  餐  表";
            // 
            // LB_Title_OrderDate
            // 
            this.LB_Title_OrderDate.AutoSize = true;
            this.LB_Title_OrderDate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_OrderDate.Location = new System.Drawing.Point(16, 104);
            this.LB_Title_OrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title_OrderDate.Name = "LB_Title_OrderDate";
            this.LB_Title_OrderDate.Size = new System.Drawing.Size(167, 38);
            this.LB_Title_OrderDate.TabIndex = 11;
            this.LB_Title_OrderDate.Text = "訂餐日期：";
            // 
            // LB_Title_TakeDate
            // 
            this.LB_Title_TakeDate.AutoSize = true;
            this.LB_Title_TakeDate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_TakeDate.Location = new System.Drawing.Point(728, 104);
            this.LB_Title_TakeDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title_TakeDate.Name = "LB_Title_TakeDate";
            this.LB_Title_TakeDate.Size = new System.Drawing.Size(167, 38);
            this.LB_Title_TakeDate.TabIndex = 12;
            this.LB_Title_TakeDate.Text = "取餐日期：";
            // 
            // LB_OrderDate
            // 
            this.LB_OrderDate.AutoSize = true;
            this.LB_OrderDate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_OrderDate.Location = new System.Drawing.Point(203, 104);
            this.LB_OrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_OrderDate.Name = "LB_OrderDate";
            this.LB_OrderDate.Size = new System.Drawing.Size(395, 38);
            this.LB_OrderDate.TabIndex = 25;
            this.LB_OrderDate.Text = "2022/08/07  上午 10:10:40";
            // 
            // LB_TakeDate
            // 
            this.LB_TakeDate.AutoSize = true;
            this.LB_TakeDate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_TakeDate.Location = new System.Drawing.Point(915, 104);
            this.LB_TakeDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_TakeDate.Name = "LB_TakeDate";
            this.LB_TakeDate.Size = new System.Drawing.Size(395, 38);
            this.LB_TakeDate.TabIndex = 26;
            this.LB_TakeDate.Text = "2022/08/07  上午 10:10:40";
            // 
            // DGV_TodayOrder
            // 
            this.DGV_TodayOrder.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TodayOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_TodayOrder.ColumnHeadersHeight = 36;
            this.DGV_TodayOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
<<<<<<< HEAD
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_TodayOrder.DefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_TodayOrder.Location = new System.Drawing.Point(18, 151);
=======
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_TodayOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_TodayOrder.Location = new System.Drawing.Point(24, 189);
            this.DGV_TodayOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> Git_BanDong/sid2
            this.DGV_TodayOrder.Name = "DGV_TodayOrder";
            this.DGV_TodayOrder.RowHeadersWidth = 51;
            this.DGV_TodayOrder.RowTemplate.Height = 24;
            this.DGV_TodayOrder.Size = new System.Drawing.Size(1304, 562);
            this.DGV_TodayOrder.TabIndex = 27;
            // 
            // LB_Title_Class
            // 
            this.LB_Title_Class.AutoSize = true;
            this.LB_Title_Class.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Class.Location = new System.Drawing.Point(53, 781);
            this.LB_Title_Class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title_Class.Name = "LB_Title_Class";
            this.LB_Title_Class.Size = new System.Drawing.Size(107, 38);
            this.LB_Title_Class.TabIndex = 28;
            this.LB_Title_Class.Text = "班級：";
            // 
            // BTN_Class_Update
            // 
<<<<<<< HEAD
            this.BTN_Class_Update.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_Class_Update.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Class_Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Class_Update.Location = new System.Drawing.Point(565, 666);
            this.BTN_Class_Update.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Class_Update.Name = "BTN_Class_Update";
            this.BTN_Class_Update.Size = new System.Drawing.Size(115, 50);
            this.BTN_Class_Update.TabIndex = 31;
            this.BTN_Class_Update.Text = "變更";
            this.BTN_Class_Update.UseVisualStyleBackColor = false;
            this.BTN_Class_Update.Click += new System.EventHandler(this.BTN_CreateClass_Click);
=======
            this.CBB_Class.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBB_Class.FormattingEnabled = true;
            this.CBB_Class.Location = new System.Drawing.Point(176, 778);
            this.CBB_Class.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBB_Class.Name = "CBB_Class";
            this.CBB_Class.Size = new System.Drawing.Size(744, 46);
            this.CBB_Class.TabIndex = 29;
            // 
            // TB_CreateClass
            // 
            this.TB_CreateClass.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_CreateClass.Location = new System.Drawing.Point(61, 841);
            this.TB_CreateClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_CreateClass.Name = "TB_CreateClass";
            this.TB_CreateClass.Size = new System.Drawing.Size(699, 47);
            this.TB_CreateClass.TabIndex = 30;
            // 
            // BTN_CreateClass
            // 
            this.BTN_CreateClass.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_CreateClass.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_CreateClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_CreateClass.Location = new System.Drawing.Point(768, 832);
            this.BTN_CreateClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_CreateClass.Name = "BTN_CreateClass";
            this.BTN_CreateClass.Size = new System.Drawing.Size(153, 62);
            this.BTN_CreateClass.TabIndex = 31;
            this.BTN_CreateClass.Text = "新增";
            this.BTN_CreateClass.UseVisualStyleBackColor = false;
>>>>>>> Git_BanDong/sid2
            // 
            // BTN_ToExcel
            // 
            this.BTN_ToExcel.BackColor = System.Drawing.Color.Green;
            this.BTN_ToExcel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_ToExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_ToExcel.Location = new System.Drawing.Point(959, 769);
            this.BTN_ToExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_ToExcel.Name = "BTN_ToExcel";
            this.BTN_ToExcel.Size = new System.Drawing.Size(315, 62);
            this.BTN_ToExcel.TabIndex = 32;
            this.BTN_ToExcel.Text = "匯出Excel";
            this.BTN_ToExcel.UseVisualStyleBackColor = false;
            this.BTN_ToExcel.Click += new System.EventHandler(this.BTN_ToExcel_Click);
            // 
            // BTN_Print
            // 
            this.BTN_Print.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTN_Print.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Print.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Print.Location = new System.Drawing.Point(959, 835);
            this.BTN_Print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Print.Name = "BTN_Print";
            this.BTN_Print.Size = new System.Drawing.Size(315, 62);
            this.BTN_Print.TabIndex = 33;
            this.BTN_Print.Text = "列印";
            this.BTN_Print.UseVisualStyleBackColor = false;
            // 
            // LB_ClassShow
            // 
            this.LB_ClassShow.AutoSize = true;
            this.LB_ClassShow.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_ClassShow.Location = new System.Drawing.Point(132, 625);
            this.LB_ClassShow.Name = "LB_ClassShow";
            this.LB_ClassShow.Size = new System.Drawing.Size(206, 31);
            this.LB_ClassShow.TabIndex = 34;
            this.LB_ClassShow.Text = "尚未設定班級名稱";
            // 
            // TB_Class_Update
            // 
            this.TB_Class_Update.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_Class_Update.Location = new System.Drawing.Point(46, 676);
            this.TB_Class_Update.Name = "TB_Class_Update";
            this.TB_Class_Update.Size = new System.Drawing.Size(511, 35);
            this.TB_Class_Update.TabIndex = 35;
            this.TB_Class_Update.Text = "請輸入變更班級名稱";
            // 
            // TodayOrder_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.TB_Class_Update);
            this.Controls.Add(this.LB_ClassShow);
=======
            this.ClientSize = new System.Drawing.Size(1344, 911);
>>>>>>> Git_BanDong/sid2
            this.Controls.Add(this.BTN_Print);
            this.Controls.Add(this.BTN_ToExcel);
            this.Controls.Add(this.BTN_Class_Update);
            this.Controls.Add(this.LB_Title_Class);
            this.Controls.Add(this.DGV_TodayOrder);
            this.Controls.Add(this.LB_TakeDate);
            this.Controls.Add(this.LB_OrderDate);
            this.Controls.Add(this.LB_Title_TakeDate);
            this.Controls.Add(this.LB_Title_OrderDate);
            this.Controls.Add(this.LB_Title_Order);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TodayOrder_Form";
            this.Text = "TodayOrder_Form";
            this.Load += new System.EventHandler(this.TodayOrder_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TodayOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Title_Order;
        private System.Windows.Forms.Label LB_Title_OrderDate;
        private System.Windows.Forms.Label LB_Title_TakeDate;
        private System.Windows.Forms.Label LB_OrderDate;
        private System.Windows.Forms.Label LB_TakeDate;
        private System.Windows.Forms.DataGridView DGV_TodayOrder;
        private System.Windows.Forms.Label LB_Title_Class;
        private System.Windows.Forms.Button BTN_Class_Update;
        private System.Windows.Forms.Button BTN_ToExcel;
        private System.Windows.Forms.Button BTN_Print;
        private System.Windows.Forms.Label LB_ClassShow;
        private System.Windows.Forms.TextBox TB_Class_Update;
    }
}