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
        private string StudentID = "";//存取學生ID
        private string StudentName = "";//存取學生Name
        private string MIS = "";//存取是否為MIS
        DataSet ds = new DataSet();
        public Order_Form(string StudentID, string StudentName,string MIS)
        {
            InitializeComponent();
            this.StudentID = StudentID;
            this.StudentName = StudentName;
            this.MIS = MIS;
            LB_StudentName.Text = StudentName;
            //判斷是否為管理員決定顯是否顯示輸出
            this.Size = new System.Drawing.Size(720, 720);
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
                        string insertlogs = $"insert into Logs(StudentID,StudentName,Ticket_money,Type,Remark,OrderDateTime) Values ('{StudentID}','{StudentName}','{cb_PayType.Text}','{cb_BanDongType.Text}','{tbox_remark.Text}',convert(varchar, getdate(), 120))";
                        string insert = $"insert into Orders(Ticket_Money, StudentName, Type, Remark, OrderDateTime) Values('{cb_PayType.Text}', '{LB_StudentName.Text}', '{cb_BanDongType.Text}', '{tbox_remark.Text}', convert(varchar, getdate(), 120));";
                        SqlDataAdapter da_buy = new SqlDataAdapter(insert, cn);
                        SqlDataAdapter da_logs = new SqlDataAdapter(insertlogs, cn);
                        da_buy.Fill(ds, "BuyBanDong");
                        da_logs.Fill(ds, "新增Logs");
                        BTN_Buy.Enabled = false;
                        BTN_Delete.Enabled = true;
                        BTN_Edit.Enabled = true;
                        MessageBox.Show("訂購成功!!");
                        this.Refresh();
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
            tbox_remark.Enabled = false;
        }
        private void ClearText2()
        {
            cb_BanDongType2.Text = "";
            cb_PayType2.Text = "";
            tbox_remark2.Text = "";
        }
        private void ClearText()
        {
            cb_BanDongType.Text = "";
            cb_PayType.Text = "";
            tbox_remark.Text = "";
        }
        private void OpenText()
        {
            cb_BanDongType.Enabled = true;
            cb_PayType.Enabled = true;
            tbox_remark.Enabled = true;
        }
        private void EditVisable()
        {
            LB_EDIT.Visible = true;
            LB_PayType2.Visible = true;
            LB_BanDongType2.Visible = true;
            LB_Remark2.Visible = true;
            cb_BanDongType2.Visible = true;
            cb_PayType2.Visible = true;
            tbox_remark2.Visible = true;
            BTN_Confirm.Visible = true;
            BTN_Reset.Visible = true;
            BTN_Cancel.Visible = true;
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



        private void Timer_Tick(object sender, EventArgs e)
        {
            LB_Time.Text = DateTime.Now.ToString();
        }

        private void BTN_Adapt_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Size = new Size(1181, 905);
            EditVisable();
            cb_PayType2.Text = cb_PayType.Text;
            cb_BanDongType2.Text = cb_BanDongType.Text;
            tbox_remark2.Text = tbox_remark.Text;
            //Edit_Form edit = new Edit_Form(StudentID,StudentName,cb_PayType.Text,cb_BanDongType.Text,tbox_remark.Text);
            //edit.Show();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                DialogResult dr = MessageBox.Show("確認是否刪除", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    SqlDataAdapter da_delete = new SqlDataAdapter($"delete from Orders where StudentName='{LB_StudentName.Text}'", cn);
                    SqlDataAdapter de_deletelogs = new SqlDataAdapter($"delete from Logs where StudentName='{LB_StudentName.Text}'", cn);
                    da_delete.Fill(ds, "刪除訂單");
                    de_deletelogs.Fill(ds, "刪除LOG");
                    BTN_Buy.Enabled = true;
                    BTN_Delete.Enabled = false;
                    BTN_Edit.Enabled = false;

                }
                MessageBox.Show("刪除成功", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                OpenText();
                ClearText();

            }
        }

        private void BTN_Confirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                string updatelogs = $"update Logs set Ticket_Money = '{cb_PayType2.Text}', Type = '{cb_BanDongType2.Text}', Remark='{tbox_remark2.Text}',OrderDateTime = convert(varchar, getdate(), 120) where StudentName = '{LB_StudentName.Text}'";
                string update = $"update Orders set Ticket_Money = '{cb_PayType2.Text}', Type = '{cb_BanDongType2.Text}', Remark='{tbox_remark2.Text}',OrderDateTime = convert(varchar, getdate(), 120) where StudentName = '{LB_StudentName.Text}'";
                SqlDataAdapter da_edit = new SqlDataAdapter(update, cn);
                SqlDataAdapter da_editlogss = new SqlDataAdapter(updatelogs, cn);
                da_edit.Fill(ds, "編輯");
                da_editlogss.Fill(ds, "編輯Logs");
                MessageBox.Show("編輯成功!!", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cb_BanDongType.Text = cb_BanDongType2.Text;
                cb_PayType.Text = cb_PayType2.Text;
                tbox_remark.Text = tbox_remark2.Text;
                this.Size = new System.Drawing.Size(700, 720);
                this.Refresh();

            }
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            ClearText2();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(700, 720);
        }

        private void button_history_Click(object sender, EventArgs e)
        {
            History_Form history = new History_Form(StudentID,StudentName);
            history.Show();
        }
    }
}
