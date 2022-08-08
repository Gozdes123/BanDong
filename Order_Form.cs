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
        public Order_Form(string StudentID, string StudentName)
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
                    SqlDataAdapter da_search = new SqlDataAdapter($"select * from Students where StudentName ='{LB_StudentName.Text}'", cn);
                    da_search.Fill(ds, "使用者");
                    if (ds.Tables["使用者"].Rows.Count > 0)
                    {
                        string insertStr = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                        string insert = $"insert into Orders(Ticket_Money, StudentName, Type, Remark, OrderDateTime) Values('{cb_PayType.Text}', '{LB_StudentName.Text}', '{cb_BanDongType.Text}', '{tbox_remark.Text}', '{insertStr}');";
                        SqlDataAdapter da_buy = new SqlDataAdapter(insert, cn);
                        da_buy.Fill(ds, "BuyBanDong");
                        BTN_Buy.Enabled = false;
                        MessageBox.Show("訂購成功!!");
                    }
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
            
            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                SqlDataAdapter da_ordered = new SqlDataAdapter($"select * from Orders where StudentName='{LB_StudentName.Text}'", cn);
                da_ordered.Fill(ds, "是否已訂購");
                if (ds.Tables["是否已訂購"].Rows.Count > 0) BTN_Buy.Enabled = false; else BTN_Buy.Enabled = true;
            }
        }
    }
}
