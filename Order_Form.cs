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
        public static bool CheckLogin = false;//是否登入
        private string StudentID = "";//存取學生ID
        private string StudentName = "";//存取學生Name
        private bool MIS = false;//存取是否為MIS
        DataSet ds = new DataSet();

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="StudentID"></param>
        /// <param name="StudentName"></param>
        /// <param name="MIS"></param>
        public Order_Form()
        {
            InitializeComponent();
        }
        //--------------程式開始-------------//
        /// <summary>
        /// Order載入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Order_Form_Load(object sender, EventArgs e)
        {
            Login();//先登入function
            SaveStudent();//存取學生資料function
            Set();//前置設定function(含今日是否訂購過)

        }


        /// <summary>
        /// 登入function
        /// </summary>
        private void Login()
        {
            Login_Form login_Form = new Login_Form();
            login_Form.ShowDialog();

            if (CheckLogin == false)
            {
                Close();
            }
        }
        /// <summary>
        /// 存取學生資料function
        /// </summary>
        private void SaveStudent()
        {
            this.StudentID = Login_Form.StudentID;//存取學生ID
            this.StudentName = Login_Form.StudentName;//存取學生Name
            this.MIS = Convert.ToBoolean(Login_Form.MIS);//存取學生MIS
            LB_StudentName.Text = StudentName;//設定顯示Name
            BTN_Output.Visible = MIS;//設定是否顯示MIS獨有的匯出功能
        }
        /// <summary>
        /// 前置設定function
        /// </summary>
        private void Set()
        {
            Timer_Now.Start();//顯示時間開始
            Timer_SQL_Truncate.Start();//偵測是否到清除時間點
            this.Size = new System.Drawing.Size(720, 720);//設定大小
            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                SqlDataAdapter da_ordered = new SqlDataAdapter($"select * from Orders where StudentID='{StudentID}'", cn);
                da_ordered.Fill(ds, "是否已訂購");
                DataTable dt = ds.Tables["是否已訂購"];
                if (ds.Tables["是否已訂購"].Rows.Count > 0)
                {
                    CB_PayType.Text = dt.Rows[0]["Ticket_Money"].ToString();
                    CB_BanDongType.Text = dt.Rows[0]["Type"].ToString();
                    TB_Remark.Text = dt.Rows[0]["Remark"].ToString();
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
        /// <summary>
        /// 關閉訂餐功能function
        /// </summary>
        private void CloseText()
        {
            CB_BanDongType.Enabled = false;
            CB_PayType.Enabled = false;
            TB_Remark.Enabled = false;
        }


        //------------時間管理區--------------//
        /// <summary>
        /// Timer.每日12點一到清除當日Order表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_SQL_Truncate_Tick(object sender, EventArgs e)
        {
            if (LB_TimeShow.Text.Substring(12, 5) == "12:00")
            {
                string sql_Truncate = "Truncate TABLE Orders";
                using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
                {
                    cn.Open();
                    SqlCommand cmd_Truncate = new SqlCommand(sql_Truncate, cn);
                    SqlDataReader dataReader_Truncate = cmd_Truncate.ExecuteReader();
                    dataReader_Truncate.Read();
                    cmd_Truncate.Dispose();
                    dataReader_Truncate.Close();
                }
            }
        }

        /// <summary>
        /// Timer.時間
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Now_Tick(object sender, EventArgs e)
        {
            LB_TimeShow.Text = DateTime.Now.ToString();
        }

        //-----訂便當的 新增、刪除、修改區 事件------//

        /// <summary>
        /// 訂餐按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Buy_Click_1(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();

                if (CB_PayType.Text != "" && CB_BanDongType.Text != "")
                {
                    SqlDataAdapter da_search = new SqlDataAdapter($"select * from Students where StudentName ='{LB_StudentName.Text}'", cn);
                    da_search.Fill(ds, "使用者");
                    if (ds.Tables["使用者"].Rows.Count > 0)
                    {
                        string insertlogs = $"insert into Logs(OrderDateTime,StudentID,StudentName,Ticket_money,Type,Remark) Values (convert(varchar, getdate(), 120),'{StudentID}','{StudentName}','{CB_PayType.Text}','{CB_BanDongType.Text}','{TB_Remark.Text}')";
                        string insert = $"insert into Orders(Ticket_Money, StudentName, Type, Remark, OrderDateTime) Values('{CB_PayType.Text}', '{LB_StudentName.Text}', '{CB_BanDongType.Text}', '{TB_Remark.Text}', convert(varchar, getdate(), 120));";
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
                else if (CB_PayType.Text == "" && CB_BanDongType.Text != "")
                {
                    MessageBox.Show("付款方式請勿空白");
                    BTN_Buy.Enabled = true;

                }
                else if (CB_PayType.Text != "" && CB_BanDongType.Text == "")
                {
                    MessageBox.Show("便當類型請勿空白");
                    BTN_Buy.Enabled = true;
                }
                else MessageBox.Show("欄位請勿空白!");
            }
        }

        /// <summary>
        /// 編輯按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Size = new Size(1181, 905);
            EditVisableOpen();
            CB_PayType2.Text = CB_PayType.Text;
            CB_BanDongType2.Text = CB_BanDongType.Text;
            TB_Remark2.Text = TB_Remark.Text;
        }
        /// <summary>
        /// 顯示編輯模式function
        /// </summary>
        private void EditVisableOpen()
        {
            LB_Title_Edit.Visible = true;
            LB_Title_PayType2.Visible = true;
            LB_Title_BanDongType2.Visible = true;
            LB_Title_Remark2.Visible = true;
            CB_BanDongType2.Visible = true;
            CB_PayType2.Visible = true;
            TB_Remark2.Visible = true;
            BTN_Confirm.Visible = true;
            BTN_Reset.Visible = true;
            BTN_Cancel.Visible = true;
        }

        /// <summary>
        /// 刪除當日訂單
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                DialogResult dr = MessageBox.Show("確認是否刪除", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    SqlDataAdapter da_delete = new SqlDataAdapter($"delete from Orders where StudentID='{StudentID}'", cn);
                    SqlDataAdapter de_deletelogs = new SqlDataAdapter($"delete from Logs where StudentID='{StudentID}'", cn);
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
        /// <summary>
        /// 清除表內容function
        /// </summary>
        private void ClearText()
        {
            CB_BanDongType.Text = "";
            CB_PayType.Text = "";
            TB_Remark.Text = "";
        }
        /// <summary>
        /// 開啟訂餐功能function
        /// </summary>
        private void OpenText()
        {
            CB_BanDongType.Enabled = true;
            CB_PayType.Enabled = true;
            TB_Remark.Enabled = true;
        }

        //------------------------編輯模式區事件---------------------------//

        /// <summary>
        /// 編輯模式_確認編輯按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Confirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                string updatelogs = $"update Logs set Ticket_Money = '{CB_PayType2.Text}', Type = '{CB_BanDongType2.Text}', Remark='{TB_Remark2.Text}',OrderDateTime = convert(varchar, getdate(), 120) where StudentName = '{LB_StudentName.Text}'";
                string update = $"update Orders set Ticket_Money = '{CB_PayType2.Text}', Type = '{CB_BanDongType2.Text}', Remark='{TB_Remark2.Text}',OrderDateTime = convert(varchar, getdate(), 120) where StudentName = '{LB_StudentName.Text}'";
                SqlDataAdapter da_edit = new SqlDataAdapter(update, cn);
                SqlDataAdapter da_editlogss = new SqlDataAdapter(updatelogs, cn);
                da_edit.Fill(ds, "編輯");
                da_editlogss.Fill(ds, "編輯Logs");
                MessageBox.Show("編輯成功!!", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                CB_BanDongType.Text = CB_BanDongType2.Text;
                CB_PayType.Text = CB_PayType2.Text;
                TB_Remark.Text = TB_Remark2.Text;
                this.Size = new System.Drawing.Size(700, 720);
                this.Refresh();

            }
        }


        /// <summary>
        /// 編輯模式重製按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            ClearText2();
        }
        /// <summary>
        /// 重製function
        /// </summary>
        private void ClearText2()
        {
            CB_BanDongType2.Text = "";
            CB_PayType2.Text = "";
            TB_Remark2.Text = "";
        }


        /// <summary>
        /// 編輯模式取消按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(700, 720);
            EditVisableClose();
        }
        /// <summary>
        /// 隱藏編輯模式function
        /// </summary>
        private void EditVisableClose()
        {
            LB_Title_Edit.Visible = false;
            LB_Title_PayType2.Visible = false;
            LB_Title_BanDongType2.Visible = false;
            LB_Title_Remark2.Visible = false;
            CB_BanDongType2.Visible = false;
            CB_PayType2.Visible = false;
            TB_Remark2.Visible = false;
            BTN_Confirm.Visible = false;
            BTN_Reset.Visible = false;
            BTN_Cancel.Visible = false;
        }

        //-----------歷史紀錄&匯出------------//

        /// <summary>
        /// 歷史紀錄按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_History_Click(object sender, EventArgs e)
        {
            History_Form history = new History_Form(StudentID, StudentName);
            history.Show();
        }

        /// <summary>
        /// 今日Order匯出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Output_Click(object sender, EventArgs e)
        {
            TodayOrder_Form todayOrder_Form = new TodayOrder_Form();
            todayOrder_Form.Show();
        }
    }
}
