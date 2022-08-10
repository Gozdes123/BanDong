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
            this.LB_Title_Order = new System.Windows.Forms.Label();
            this.LB_Title_OrderDate = new System.Windows.Forms.Label();
            this.LB_Title_TakeDate = new System.Windows.Forms.Label();
            this.LB_OrderDate = new System.Windows.Forms.Label();
            this.LB_TakeDate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LB_Title_Class = new System.Windows.Forms.Label();
            this.CBB_Class = new System.Windows.Forms.ComboBox();
            this.TB_CreateClass = new System.Windows.Forms.TextBox();
            this.BTN_CreateClass = new System.Windows.Forms.Button();
            this.BTN_ToExcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // LB_Title_TakeDate
            // 
            this.LB_Title_TakeDate.AutoSize = true;
            this.LB_Title_TakeDate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_TakeDate.Location = new System.Drawing.Point(546, 83);
            this.LB_Title_TakeDate.Name = "LB_Title_TakeDate";
            this.LB_Title_TakeDate.Size = new System.Drawing.Size(134, 31);
            this.LB_Title_TakeDate.TabIndex = 12;
            this.LB_Title_TakeDate.Text = "取餐日期：";
            // 
            // LB_OrderDate
            // 
            this.LB_OrderDate.AutoSize = true;
            this.LB_OrderDate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_OrderDate.Location = new System.Drawing.Point(152, 83);
            this.LB_OrderDate.Name = "LB_OrderDate";
            this.LB_OrderDate.Size = new System.Drawing.Size(310, 31);
            this.LB_OrderDate.TabIndex = 25;
            this.LB_OrderDate.Text = "2022/08/07  上午 10:10:40";
            // 
            // LB_TakeDate
            // 
            this.LB_TakeDate.AutoSize = true;
            this.LB_TakeDate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_TakeDate.Location = new System.Drawing.Point(686, 83);
            this.LB_TakeDate.Name = "LB_TakeDate";
            this.LB_TakeDate.Size = new System.Drawing.Size(310, 31);
            this.LB_TakeDate.TabIndex = 26;
            this.LB_TakeDate.Text = "2022/08/07  上午 10:10:40";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(978, 450);
            this.dataGridView1.TabIndex = 27;
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
            // CBB_Class
            // 
            this.CBB_Class.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBB_Class.FormattingEnabled = true;
            this.CBB_Class.Location = new System.Drawing.Point(132, 622);
            this.CBB_Class.Name = "CBB_Class";
            this.CBB_Class.Size = new System.Drawing.Size(559, 39);
            this.CBB_Class.TabIndex = 29;
            // 
            // TB_CreateClass
            // 
            this.TB_CreateClass.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_CreateClass.Location = new System.Drawing.Point(46, 673);
            this.TB_CreateClass.Name = "TB_CreateClass";
            this.TB_CreateClass.Size = new System.Drawing.Size(525, 39);
            this.TB_CreateClass.TabIndex = 30;
            // 
            // BTN_CreateClass
            // 
            this.BTN_CreateClass.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_CreateClass.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_CreateClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_CreateClass.Location = new System.Drawing.Point(576, 666);
            this.BTN_CreateClass.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_CreateClass.Name = "BTN_CreateClass";
            this.BTN_CreateClass.Size = new System.Drawing.Size(115, 50);
            this.BTN_CreateClass.TabIndex = 31;
            this.BTN_CreateClass.Text = "新增";
            this.BTN_CreateClass.UseVisualStyleBackColor = false;
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
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(719, 668);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 50);
            this.button1.TabIndex = 33;
            this.button1.Text = "列印";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TodayOrder_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_ToExcel);
            this.Controls.Add(this.BTN_CreateClass);
            this.Controls.Add(this.TB_CreateClass);
            this.Controls.Add(this.CBB_Class);
            this.Controls.Add(this.LB_Title_Class);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LB_TakeDate);
            this.Controls.Add(this.LB_OrderDate);
            this.Controls.Add(this.LB_Title_TakeDate);
            this.Controls.Add(this.LB_Title_OrderDate);
            this.Controls.Add(this.LB_Title_Order);
            this.Name = "TodayOrder_Form";
            this.Text = "TodayOrder_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Title_Order;
        private System.Windows.Forms.Label LB_Title_OrderDate;
        private System.Windows.Forms.Label LB_Title_TakeDate;
        private System.Windows.Forms.Label LB_OrderDate;
        private System.Windows.Forms.Label LB_TakeDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LB_Title_Class;
        private System.Windows.Forms.ComboBox CBB_Class;
        private System.Windows.Forms.TextBox TB_CreateClass;
        private System.Windows.Forms.Button BTN_CreateClass;
        private System.Windows.Forms.Button BTN_ToExcel;
        private System.Windows.Forms.Button button1;
    }
}