using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BanDong_1._0v
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }

        private void BTN_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            string SQL_cmd_Insert = $"INSERT INTO Students VALUES('{TB_StudentID.Text}','{TB_StudentName.Text}','{TB_StudentPassWord.Text}','{CKB_MIS.Checked}')";
            string SQL_cmd_Select = $"SELECT * FROM Students WHERE StudentID like '{TB_StudentID.Text}'";
            if ( TB_cantNULL() && CheckPassWord() )//檢查(是否有空白 && 密碼確認比對)
            {
                using(SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
                {
                    cn.Open();
                    try
                    {
                        SqlCommand cmd_Select = new SqlCommand(SQL_cmd_Select, cn);
                        SqlDataReader dataReader_Select = cmd_Select.ExecuteReader();
                        if (dataReader_Select.HasRows == false)
                        {
                            cmd_Select.Dispose();
                            dataReader_Select.Close();

                            SqlCommand cmd_Insert = new SqlCommand(SQL_cmd_Insert,cn);
                            SqlDataReader dataReader_Insert = cmd_Insert.ExecuteReader();
                            dataReader_Insert.Read();
                            cmd_Insert.Dispose();
                            dataReader_Insert.Close();

                            MessageBox.Show("註冊成功!");
                            BTN_Submit.Enabled = false;
                            BTN_Clear.Enabled = false;
                            CKB_MIS.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("該座號已被註冊");
                            cmd_Select.Dispose();
                            dataReader_Select.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("系統有誤，請Debug");
                    }
                    cn.Close();
                }
            }
        }


        /// <summary>
        /// 檢查是否有空白(True/False則回報資料不完整)
        /// </summary>
        /// <returns></returns>
        private bool TB_cantNULL()
        {
            if (TB_StudentID.Text != "" && TB_StudentName.Text != "" && TB_StudentPassWord.Text != "" && TB_CheckPassWord.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("資料不完整，請再次確認");
                return false;
            }
        }
        /// <summary>
        /// 檢查密碼確認比對是否相同
        /// </summary>
        /// <returns></returns>
        private bool CheckPassWord()
        {
            if (TB_StudentPassWord.Text == TB_CheckPassWord.Text)
            {
                return true;
            }
            else
            {
                MessageBox.Show("密碼確認比對不符");
                return false;
            }
        }

        /// <summary>
        /// 清除按鍵
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TB_StudentID.Text = "";
            TB_StudentName.Text = "";
            TB_StudentPassWord.Text = "";
            TB_CheckPassWord.Text = "";
            CKB_MIS.Checked = false;
        }
    }
}
