using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanDong_1._0v
{
    public partial class Order_Form : Form
    {
        private string StudentID = "";
        private string StudentName = "";

        DataSet ds = new DataSet();
        public Order_Form(string StudentID,string StudentName)
        {
            InitializeComponent();
            this.StudentID = StudentID;
            this.StudentName = StudentName;
            LB_StudentName.Text = StudentName;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Buy_Click_1(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                if (cb_PayType.Text != "" && cb_BanDongType.Text != "")
                {
                    string insert = $"insert into Orders(Ticket_Money, StudentName, Type, Remark, OrderDateTime) Values('{cb_PayType.Text}', '{labelName.Text}', '{cb_BanDongType.Text}', '{tbox_remark.Text}', '{DateTime.Now.ToString()}');";
                    SqlDataAdapter da_buy = new SqlDataAdapter(insert, cn);
                    da_buy.Fill(ds, "BuyBanDong");
                    BTN_Buy.Enabled = false;
                    MessageBox.Show("訂購成功!!");
                }
                else if (cb_PayType.Text == "" && cb_BanDongType.Text != "")
                {
                    MessageBox.Show("付款方式請勿空白");
                    BTN_Buy.Enabled = true;

                }
                else if (cb_PayType.Text != "" && cb_BanDongType.Text == "")
                {
                    MessageBox.Show("便當類型請勿空白");
                    BTN_Buy.Enabled = true;
                }
                else MessageBox.Show("欄位請勿空白!");
               

            }


        }

        private void Order_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
