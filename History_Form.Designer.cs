namespace BanDong_1._0v
{
    partial class History_Form
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LB_StudentID = new System.Windows.Forms.Label();
            this.LB_Title_Order = new System.Windows.Forms.Label();
            this.LB_StudentName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 210);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(555, 479);
            this.dataGridView2.TabIndex = 1;
            // 
            // LB_StudentID
            // 
            this.LB_StudentID.AutoSize = true;
            this.LB_StudentID.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_StudentID.Location = new System.Drawing.Point(13, 158);
            this.LB_StudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_StudentID.Name = "LB_StudentID";
            this.LB_StudentID.Size = new System.Drawing.Size(109, 38);
            this.LB_StudentID.TabIndex = 14;
            this.LB_StudentID.Text = "學 號 : ";
            // 
            // LB_Title_Order
            // 
            this.LB_Title_Order.AutoSize = true;
            this.LB_Title_Order.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Order.Location = new System.Drawing.Point(75, 40);
            this.LB_Title_Order.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title_Order.Name = "LB_Title_Order";
            this.LB_Title_Order.Size = new System.Drawing.Size(439, 47);
            this.LB_Title_Order.TabIndex = 15;
            this.LB_Title_Order.Text = "歷 史 訂 購 紀 錄";
            // 
            // LB_StudentName
            // 
            this.LB_StudentName.AutoSize = true;
            this.LB_StudentName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_StudentName.Location = new System.Drawing.Point(254, 158);
            this.LB_StudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_StudentName.Name = "LB_StudentName";
            this.LB_StudentName.Size = new System.Drawing.Size(109, 38);
            this.LB_StudentName.TabIndex = 16;
            this.LB_StudentName.Text = "姓 名 : ";
            // 
            // History_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(579, 701);
            this.Controls.Add(this.LB_StudentName);
            this.Controls.Add(this.LB_Title_Order);
            this.Controls.Add(this.LB_StudentID);
            this.Controls.Add(this.dataGridView2);
            this.Name = "History_Form";
            this.Text = "History_Form";
            this.Load += new System.EventHandler(this.History_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label LB_StudentID;
        private System.Windows.Forms.Label LB_Title_Order;
        private System.Windows.Forms.Label LB_StudentName;
    }
}