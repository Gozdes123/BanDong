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
            this.LB_Title_Register = new System.Windows.Forms.Label();
            this.cb_PayType = new System.Windows.Forms.ComboBox();
            this.LB_Title_StudentID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LB_Title_Register
            // 
            this.LB_Title_Register.AutoSize = true;
            this.LB_Title_Register.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_Register.Location = new System.Drawing.Point(219, 62);
            this.LB_Title_Register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title_Register.Name = "LB_Title_Register";
            this.LB_Title_Register.Size = new System.Drawing.Size(366, 47);
            this.LB_Title_Register.TabIndex = 8;
            this.LB_Title_Register.Text = "訂  購  系  統";
            // 
            // cb_PayType
            // 
            this.cb_PayType.FormattingEnabled = true;
            this.cb_PayType.Items.AddRange(new object[] {
            "便當票券",
            "現金"});
            this.cb_PayType.Location = new System.Drawing.Point(313, 177);
            this.cb_PayType.Name = "cb_PayType";
            this.cb_PayType.Size = new System.Drawing.Size(272, 23);
            this.cb_PayType.TabIndex = 9;
            // 
            // LB_Title_StudentID
            // 
            this.LB_Title_StudentID.AutoSize = true;
            this.LB_Title_StudentID.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_StudentID.Location = new System.Drawing.Point(139, 162);
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
            this.label1.Location = new System.Drawing.Point(139, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "便當類型：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(313, 254);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 23);
            this.comboBox1.TabIndex = 11;
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LB_Title_StudentID);
            this.Controls.Add(this.cb_PayType);
            this.Controls.Add(this.LB_Title_Register);
            this.Name = "Order_Form";
            this.Text = "Order_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Title_Register;
        private System.Windows.Forms.ComboBox cb_PayType;
        private System.Windows.Forms.Label LB_Title_StudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}