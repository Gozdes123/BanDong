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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LB_Title_Order = new System.Windows.Forms.Label();
            this.LB_Title_OrderDate = new System.Windows.Forms.Label();
            this.LB_OrderDate = new System.Windows.Forms.Label();
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
            this.LB_Title_Order.Location = new System.Drawing.Point(317, 9);
            this.LB_Title_Order.Name = "LB_Title_Order";
            this.LB_Title_Order.Size = new System.Drawing.Size(372, 37);
            this.LB_Title_Order.TabIndex = 9;
            this.LB_Title_Order.Text = "今  日  訂  餐  表";
            // 
            // LB_Title_OrderDate
            // 
            this.LB_Title_OrderDate.AutoSize = true;
            this.LB_Title_OrderDate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_OrderDate.Location = new System.Drawing.Point(12, 83);
            this.LB_Title_OrderDate.Name = "LB_Title_OrderDate";
            this.LB_Title_OrderDate.Size = new System.Drawing.Size(134, 31);
            this.LB_Title_OrderDate.TabIndex = 11;
            this.LB_Title_OrderDate.Text = "訂餐日期：";
            // 
            // LB_OrderDate
            // 
            this.LB_OrderDate.AutoSize = true;
            this.LB_OrderDate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_OrderDate.Location = new System.Drawing.Point(152, 83);
            this.LB_OrderDate.Name = "LB_OrderDate";
            this.LB_OrderDate.Size = new System.Drawing.Size(148, 31);
            this.LB_OrderDate.TabIndex = 25;
            this.LB_OrderDate.Text = "2022/08/07";
            // 
            // DGV_TodayOrder
            // 
            this.DGV_TodayOrder.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TodayOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_TodayOrder.ColumnHeadersHeight = 36;
            this.DGV_TodayOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_TodayOrder.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_TodayOrder.Location = new System.Drawing.Point(14, 121);
            this.DGV_TodayOrder.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_TodayOrder.Name = "DGV_TodayOrder";
            this.DGV_TodayOrder.RowHeadersWidth = 51;
            this.DGV_TodayOrder.RowTemplate.Height = 24;
            this.DGV_TodayOrder.Size = new System.Drawing.Size(978, 450);
            this.DGV_TodayOrder.TabIndex = 27;
            // 
            // LB_Title_Class
            // 
            this.LB_Title_Class.AutoSize = true;
            this.LB_Title_Class.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Class.Location = new System.Drawing.Point(40, 625);
            this.LB_Title_Class.Name = "LB_Title_Class";
            this.LB_Title_Class.Size = new System.Drawing.Size(86, 31);
            this.LB_Title_Class.TabIndex = 28;
            this.LB_Title_Class.Text = "班級：";
            // 
            // BTN_Class_Update
            // 
            this.BTN_Class_Update.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_Class_Update.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Class_Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Class_Update.Location = new System.Drawing.Point(470, 661);
            this.BTN_Class_Update.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Class_Update.Name = "BTN_Class_Update";
            this.BTN_Class_Update.Size = new System.Drawing.Size(86, 40);
            this.BTN_Class_Update.TabIndex = 31;
            this.BTN_Class_Update.Text = "變更";
            this.BTN_Class_Update.UseVisualStyleBackColor = false;
            this.BTN_Class_Update.Click += new System.EventHandler(this.BTN_Class_Update_Click);
            // 
            // BTN_ToExcel
            // 
            this.BTN_ToExcel.BackColor = System.Drawing.Color.Green;
            this.BTN_ToExcel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_ToExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_ToExcel.Location = new System.Drawing.Point(719, 615);
            this.BTN_ToExcel.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_ToExcel.Name = "BTN_ToExcel";
            this.BTN_ToExcel.Size = new System.Drawing.Size(236, 50);
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
            this.BTN_Print.Location = new System.Drawing.Point(719, 668);
            this.BTN_Print.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Print.Name = "BTN_Print";
            this.BTN_Print.Size = new System.Drawing.Size(236, 50);
            this.BTN_Print.TabIndex = 33;
            this.BTN_Print.Text = "列印";
            this.BTN_Print.UseVisualStyleBackColor = false;
            this.BTN_Print.Click += new System.EventHandler(this.BTN_Print_Click);
            // 
            // LB_ClassShow
            // 
            this.LB_ClassShow.AutoSize = true;
            this.LB_ClassShow.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_ClassShow.Location = new System.Drawing.Point(131, 625);
            this.LB_ClassShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ClassShow.Name = "LB_ClassShow";
            this.LB_ClassShow.Size = new System.Drawing.Size(206, 31);
            this.LB_ClassShow.TabIndex = 34;
            this.LB_ClassShow.Text = "尚未設定班級名稱";
            // 
            // TB_Class_Update
            // 
            this.TB_Class_Update.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_Class_Update.Location = new System.Drawing.Point(66, 666);
            this.TB_Class_Update.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Class_Update.Name = "TB_Class_Update";
            this.TB_Class_Update.Size = new System.Drawing.Size(384, 35);
            this.TB_Class_Update.TabIndex = 35;
            this.TB_Class_Update.Text = "請輸入變更班級名稱";
            // 
            // TodayOrder_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.TB_Class_Update);
            this.Controls.Add(this.LB_ClassShow);
            this.Controls.Add(this.BTN_Print);
            this.Controls.Add(this.BTN_ToExcel);
            this.Controls.Add(this.BTN_Class_Update);
            this.Controls.Add(this.LB_Title_Class);
            this.Controls.Add(this.DGV_TodayOrder);
            this.Controls.Add(this.LB_OrderDate);
            this.Controls.Add(this.LB_Title_OrderDate);
            this.Controls.Add(this.LB_Title_Order);
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
        private System.Windows.Forms.Label LB_OrderDate;
        private System.Windows.Forms.DataGridView DGV_TodayOrder;
        private System.Windows.Forms.Label LB_Title_Class;
        private System.Windows.Forms.Button BTN_Class_Update;
        private System.Windows.Forms.Button BTN_ToExcel;
        private System.Windows.Forms.Button BTN_Print;
        private System.Windows.Forms.Label LB_ClassShow;
        private System.Windows.Forms.TextBox TB_Class_Update;
    }
}