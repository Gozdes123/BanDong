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
    public partial class Login_Form : Form
    {
        public static string StudentID = "";//學生ID
        public static string StudentName = "";//學生Name
        public static string MIS = "False";
        public static string sqlcn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BanDongDB.mdf;Integrated Security=True";
        
        
        public Login_Form()
        {
            InitializeComponent();
        }

        private void BTN_Register_Click(object sender, EventArgs e)
        {
            Register_Form register_Form = new Register_Form();
            register_Form.Show();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            string SQL_cmd_Select = $"SELECT * FROM Students WHERE StudentID like '{TB_StudentID.Text}'";
            using (SqlConnection cn = new SqlConnection(sqlcn))
            {
                cn.Open();
                try
                {
                    if (CheckTBcantNULL())
                    {
                        SqlCommand cmd_Select = new SqlCommand(SQL_cmd_Select,cn);
                        SqlDataReader dataReader_Select = cmd_Select.ExecuteReader();
                        if (dataReader_Select.HasRows != false)
                        {
                            dataReader_Select.Read();
                            if (dataReader_Select["StudentPassWord"].ToString() == TB_StudentPassWord.Text)
                            {
                                StudentID = dataReader_Select["StudentID"].ToString();//存取SQL學生ID
                                StudentName = dataReader_Select["StudentName"].ToString();//存取SQL學生Name
                                MIS = dataReader_Select["MIS"].ToString();
                                Order_Form order = new Order_Form(StudentID,StudentName,MIS);
                                order.Show();

                            }
                            else
                            {
                                MessageBox.Show("密碼錯誤");
                            }
                            cmd_Select.Dispose();
                            dataReader_Select.Close();
                        }
                        else
                        {
                            MessageBox.Show("該座號不存在");
                            cmd_Select.Dispose();
                            dataReader_Select.Close();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("系統有誤，請Debug");
                }

                cn.Close();
            }
        }

        /// <summary>
        /// 檢查座號&密碼是否空白
        /// </summary>
        /// <returns></returns>
        private bool CheckTBcantNULL()
        {
            if (TB_StudentID.Text != "" && TB_StudentPassWord.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("座號或密碼請勿空白");
                return false;
            }
        }
    }
}
