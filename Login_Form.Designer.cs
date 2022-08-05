namespace BanDong_1._0v
{
    partial class Login_Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Title_StudentID = new System.Windows.Forms.Label();
            this.LB_Title_StudentPassWord = new System.Windows.Forms.Label();
            this.TB_StudentID = new System.Windows.Forms.TextBox();
            this.TB_StudentPassWord = new System.Windows.Forms.TextBox();
            this.BTN_Register = new System.Windows.Forms.Button();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.LB_Title_BanDong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_Title_StudentID
            // 
            this.LB_Title_StudentID.AutoSize = true;
            this.LB_Title_StudentID.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_StudentID.Location = new System.Drawing.Point(16, 194);
            this.LB_Title_StudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title_StudentID.Name = "LB_Title_StudentID";
            this.LB_Title_StudentID.Size = new System.Drawing.Size(107, 38);
            this.LB_Title_StudentID.TabIndex = 0;
            this.LB_Title_StudentID.Text = "座號：";
            // 
            // LB_Title_StudentPassWord
            // 
            this.LB_Title_StudentPassWord.AutoSize = true;
            this.LB_Title_StudentPassWord.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_StudentPassWord.Location = new System.Drawing.Point(16, 314);
            this.LB_Title_StudentPassWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title_StudentPassWord.Name = "LB_Title_StudentPassWord";
            this.LB_Title_StudentPassWord.Size = new System.Drawing.Size(107, 38);
            this.LB_Title_StudentPassWord.TabIndex = 1;
            this.LB_Title_StudentPassWord.Text = "密碼：";
            // 
            // TB_StudentID
            // 
            this.TB_StudentID.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_StudentID.Location = new System.Drawing.Point(139, 188);
            this.TB_StudentID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_StudentID.Name = "TB_StudentID";
            this.TB_StudentID.Size = new System.Drawing.Size(132, 43);
            this.TB_StudentID.TabIndex = 2;
            // 
            // TB_StudentPassWord
            // 
            this.TB_StudentPassWord.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB_StudentPassWord.Location = new System.Drawing.Point(139, 308);
            this.TB_StudentPassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_StudentPassWord.Name = "TB_StudentPassWord";
            this.TB_StudentPassWord.Size = new System.Drawing.Size(399, 43);
            this.TB_StudentPassWord.TabIndex = 3;
            // 
            // BTN_Register
            // 
            this.BTN_Register.BackColor = System.Drawing.Color.Blue;
            this.BTN_Register.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Register.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Register.Location = new System.Drawing.Point(103, 489);
            this.BTN_Register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Register.Name = "BTN_Register";
            this.BTN_Register.Size = new System.Drawing.Size(133, 62);
            this.BTN_Register.TabIndex = 4;
            this.BTN_Register.Text = "註冊";
            this.BTN_Register.UseVisualStyleBackColor = false;
            this.BTN_Register.Click += new System.EventHandler(this.BTN_Register_Click);
            // 
            // BTN_Login
            // 
            this.BTN_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTN_Login.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_Login.Location = new System.Drawing.Point(319, 489);
            this.BTN_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(133, 62);
            this.BTN_Login.TabIndex = 5;
            this.BTN_Login.Text = "登入";
            this.BTN_Login.UseVisualStyleBackColor = false;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // LB_Title_BanDong
            // 
            this.LB_Title_BanDong.AutoSize = true;
            this.LB_Title_BanDong.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title_BanDong.Location = new System.Drawing.Point(53, 38);
            this.LB_Title_BanDong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Title_BanDong.Name = "LB_Title_BanDong";
            this.LB_Title_BanDong.Size = new System.Drawing.Size(441, 47);
            this.LB_Title_BanDong.TabIndex = 6;
            this.LB_Title_BanDong.Text = "訂   餐   系   統";
            // 
            // Login_Form
            // 
            this.AcceptButton = this.BTN_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(579, 701);
            this.Controls.Add(this.LB_Title_BanDong);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.BTN_Register);
            this.Controls.Add(this.TB_StudentPassWord);
            this.Controls.Add(this.TB_StudentID);
            this.Controls.Add(this.LB_Title_StudentPassWord);
            this.Controls.Add(this.LB_Title_StudentID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            //this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Title_StudentID;
        private System.Windows.Forms.Label LB_Title_StudentPassWord;
        private System.Windows.Forms.TextBox TB_StudentID;
        private System.Windows.Forms.TextBox TB_StudentPassWord;
        private System.Windows.Forms.Button BTN_Register;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Label LB_Title_BanDong;
    }
}

