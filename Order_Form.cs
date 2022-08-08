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

                        string insert = $"insert into Orders(Ticket_Money, StudentName, Type, Remark, OrderDateTime) Values('{cb_PayType.Text}', '{LB_StudentName.Text}', '{cb_BanDongType.Text}', '{tbox_remark.Text}', 'convert(varchar, getdate(), 120)');";
                        SqlDataAdapter da_buy = new SqlDataAdapter(insert, cn);
                        da_buy.Fill(ds, "BuyBanDong");
                        BTN_Buy.Enabled = false;
                        BTN_Delete.Enabled = true;
                        BTN_Edit.Enabled = true;
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
        private void CloseText()
        {
            cb_BanDongType.Enabled = false;
            cb_PayType.Enabled = false;
            tbox_remark.Enabled=false;
        }
        private void OpenText()
        {
            cb_BanDongType.Enabled = true;
            cb_PayType.Enabled = true;
            tbox_remark.Enabled = true;
        }
        private void Order_Form_Load(object sender, EventArgs e)
        {
            Timer.Start();
            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                SqlDataAdapter da_ordered = new SqlDataAdapter($"select * from Orders where StudentName='{LB_StudentName.Text}'", cn);
                da_ordered.Fill(ds, "是否已訂購");
                DataTable dt = ds.Tables["是否已訂購"];
                if (ds.Tables["是否已訂購"].Rows.Count > 0)
                {
                    cb_PayType.Text = dt.Rows[0]["Ticket_Money"].ToString();
                    cb_BanDongType.Text = dt.Rows[0]["Type"].ToString();
                    tbox_remark.Text = dt.Rows[0]["Remark"].ToString();
                    BTN_Buy.Enabled = false;
                    BTN_Edit.Enabled = true;
                    BTN_Delete.Enabled = true;
                    CloseText();
                }
                else
                {
                    BTN_Buy.Enabled = true;
                    BTN_Edit.Enabled = false;
                    BTN_Delete.Enabled = false;
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LB_Time.Text = DateTime.Now.ToString();
        }

        private void BTN_Adapt_Click(object sender, EventArgs e)
        {
            Edit_Form edit = new Edit_Form(StudentID,StudentName,cb_PayType.Text,cb_BanDongType.Text,tbox_remark.Text);
            edit.Show();
        }
    }
}
