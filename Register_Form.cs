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
            if ( TB_cantNULL() && CheckPassWord() )//檢查(是否有空白 && 密碼確認比對)
            {
                using(SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
                {
                    cn.Open();
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
    }
}
