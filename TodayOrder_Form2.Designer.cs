﻿namespace BanDong_1._0v
{
    partial class TodayOrder_Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LB_Title_Class = new System.Windows.Forms.Label();
            this.LB_TakeDate = new System.Windows.Forms.Label();
            this.LB_OrderDate = new System.Windows.Forms.Label();
            this.LB_Title_TakeDate = new System.Windows.Forms.Label();
            this.LB_Title_OrderDate = new System.Windows.Forms.Label();
            this.LB_Title_Order = new System.Windows.Forms.Label();
            this.BTN_Print = new System.Windows.Forms.Button();
            this.BTN_ToExcel = new System.Windows.Forms.Button();
            this.BTN_CreateClass = new System.Windows.Forms.Button();
            this.TB_CreateClass = new System.Windows.Forms.TextBox();
            this.CBB_Class = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_TodayOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TodayOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Title_Class
            // 
            this.LB_Title_Class.AutoSize = true;
            this.LB_Title_Class.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Class.Location = new System.Drawing.Point(-167, 370);
            this.LB_Title_Class.Name = "LB_Title_Class";
            this.LB_Title_Class.Size = new System.Drawing.Size(86, 31);
            this.LB_Title_Class.TabIndex = 35;
            this.LB_Title_Class.Text = "班級：";
            // 
            // LB_TakeDate
            // 
            this.LB_TakeDate.AutoSize = true;
            this.LB_TakeDate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_TakeDate.Location = new System.Drawing.Point(692, 102);
            this.LB_TakeDate.Name = "LB_TakeDate";
            this.LB_TakeDate.Size = new System.Drawing.Size(310, 31);
            this.LB_TakeDate.TabIndex = 40;
            this.LB_TakeDate.Text = "2022/08/07  上午 10:10:40";
            // 
            // LB_OrderDate
            // 
            this.LB_OrderDate.AutoSize = true;
            this.LB_OrderDate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_OrderDate.Location = new System.Drawing.Point(158, 102);
            this.LB_OrderDate.Name = "LB_OrderDate";
            this.LB_OrderDate.Size = new System.Drawing.Size(310, 31);
            this.LB_OrderDate.TabIndex = 39;
            this.LB_OrderDate.Text = "2022/08/07  上午 10:10:40";
            // 
            // LB_Title_TakeDate
            // 
            this.LB_Title_TakeDate.AutoSize = true;
            this.LB_Title_TakeDate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_TakeDate.Location = new System.Drawing.Point(551, 102);
            this.LB_Title_TakeDate.Name = "LB_Title_TakeDate";
            this.LB_Title_TakeDate.Size = new System.Drawing.Size(134, 31);
            this.LB_Title_TakeDate.TabIndex = 38;
            this.LB_Title_TakeDate.Text = "取餐日期：";
            // 
            // LB_Title_OrderDate
            // 
            this.LB_Title_OrderDate.AutoSize = true;
            this.LB_Title_OrderDate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_OrderDate.Location = new System.Drawing.Point(17, 102);
            this.LB_Title_OrderDate.Name = "LB_Title_OrderDate";
            this.LB_Title_OrderDate.Size = new System.Drawing.Size(134, 31);
            this.LB_Title_OrderDate.TabIndex = 37;
            this.LB_Title_OrderDate.Text = "訂餐日期：";
            // 
            // LB_Title_Order
            // 
            this.LB_Title_Order.AutoSize = true;
            this.LB_Title_Order.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Order.Location = new System.Drawing.Point(322, 28);
            this.LB_Title_Order.Name = "LB_Title_Order";
            this.LB_Title_Order.Size = new System.Drawing.Size(372, 37);
            this.LB_Title_Order.TabIndex = 36;
            this.LB_Title_Order.Text = "今  日  訂  餐  表";
            // 
            // BTN_Print
            // 
            this.BTN_Print.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTN_Print.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Print.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Print.Location = new System.Drawing.Point(717, 667);
            this.BTN_Print.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Print.Name = "BTN_Print";
            this.BTN_Print.Size = new System.Drawing.Size(236, 50);
            this.BTN_Print.TabIndex = 47;
            this.BTN_Print.Text = "列印";
            this.BTN_Print.UseVisualStyleBackColor = false;
            this.BTN_Print.Click += new System.EventHandler(this.BTN_Print_Click);
            // 
            // BTN_ToExcel
            // 
            this.BTN_ToExcel.BackColor = System.Drawing.Color.Green;
            this.BTN_ToExcel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_ToExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_ToExcel.Location = new System.Drawing.Point(717, 614);
            this.BTN_ToExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ToExcel.Name = "BTN_ToExcel";
            this.BTN_ToExcel.Size = new System.Drawing.Size(236, 50);
            this.BTN_ToExcel.TabIndex = 46;
            this.BTN_ToExcel.Text = "匯出Excel";
            this.BTN_ToExcel.UseVisualStyleBackColor = false;
            this.BTN_ToExcel.Click += new System.EventHandler(this.BTN_ToExcel_Click);
            // 
            // BTN_CreateClass
            // 
            this.BTN_CreateClass.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_CreateClass.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_CreateClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_CreateClass.Location = new System.Drawing.Point(574, 665);
            this.BTN_CreateClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_CreateClass.Name = "BTN_CreateClass";
            this.BTN_CreateClass.Size = new System.Drawing.Size(115, 50);
            this.BTN_CreateClass.TabIndex = 45;
            this.BTN_CreateClass.Text = "新增";
            this.BTN_CreateClass.UseVisualStyleBackColor = false;
            // 
            // TB_CreateClass
            // 
            this.TB_CreateClass.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_CreateClass.Location = new System.Drawing.Point(44, 672);
            this.TB_CreateClass.Name = "TB_CreateClass";
            this.TB_CreateClass.Size = new System.Drawing.Size(525, 39);
            this.TB_CreateClass.TabIndex = 44;
            // 
            // CBB_Class
            // 
            this.CBB_Class.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBB_Class.FormattingEnabled = true;
            this.CBB_Class.Location = new System.Drawing.Point(130, 622);
            this.CBB_Class.Name = "CBB_Class";
            this.CBB_Class.Size = new System.Drawing.Size(559, 39);
            this.CBB_Class.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(38, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 42;
            this.label1.Text = "班級：";
            // 
            // DGV_TodayOrder
            // 
            this.DGV_TodayOrder.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TodayOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TodayOrder.ColumnHeadersHeight = 36;
            this.DGV_TodayOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_TodayOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_TodayOrder.Location = new System.Drawing.Point(16, 150);
            this.DGV_TodayOrder.Name = "DGV_TodayOrder";
            this.DGV_TodayOrder.RowHeadersWidth = 51;
            this.DGV_TodayOrder.RowTemplate.Height = 24;
            this.DGV_TodayOrder.Size = new System.Drawing.Size(978, 450);
            this.DGV_TodayOrder.TabIndex = 41;
            // 
            // TodayOrder_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1008, 725);
            this.Controls.Add(this.BTN_Print);
            this.Controls.Add(this.BTN_ToExcel);
            this.Controls.Add(this.BTN_CreateClass);
            this.Controls.Add(this.TB_CreateClass);
            this.Controls.Add(this.CBB_Class);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_TodayOrder);
            this.Controls.Add(this.LB_TakeDate);
            this.Controls.Add(this.LB_OrderDate);
            this.Controls.Add(this.LB_Title_TakeDate);
            this.Controls.Add(this.LB_Title_OrderDate);
            this.Controls.Add(this.LB_Title_Order);
            this.Controls.Add(this.LB_Title_Class);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TodayOrder_Form2";
            this.Text = "TodayOrder_Form2";
            this.Load += new System.EventHandler(this.TodayOrder_Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TodayOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LB_Title_Class;
        private System.Windows.Forms.Label LB_TakeDate;
        private System.Windows.Forms.Label LB_OrderDate;
        private System.Windows.Forms.Label LB_Title_TakeDate;
        private System.Windows.Forms.Label LB_Title_OrderDate;
        private System.Windows.Forms.Label LB_Title_Order;
        private System.Windows.Forms.Button BTN_Print;
        private System.Windows.Forms.Button BTN_ToExcel;
        private System.Windows.Forms.Button BTN_CreateClass;
        private System.Windows.Forms.TextBox TB_CreateClass;
        private System.Windows.Forms.ComboBox CBB_Class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_TodayOrder;
    }
}