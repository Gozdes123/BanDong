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
using Spire.Xls;
using System.Drawing.Printing;
using System.IO;
//using Microsoft.Office.Interop.Excel;

namespace BanDong_1._0v
{
    public partial class TodayOrder_Form : Form
    {
        private string Today = DateTime.Now.ToString("yyyy/MM/dd");
        //int A4_height = 750;
        DataSet TodayOrderDataSet = new DataSet();
        DataTable dt_TodayOrders = new DataTable();
        public TodayOrder_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 載入顯示TodayOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TodayOrder_Form_Load(object sender, EventArgs e)
        {
            LB_OrderDate.Text = Today;
            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                string sql_Select = $"SELECT OrderNO 編號, Ticket_Money [餐票/現金], StudentID 座號, StudentName 訂購姓名, Type 主菜選擇, Remark 備註 FROM Orders";
                SqlDataAdapter dataAdapter_Select = new SqlDataAdapter(sql_Select, cn);
                dataAdapter_Select.Fill(TodayOrderDataSet, "TodayOrders");

                sql_Select = $"SELECT * FROM Class";
                SqlCommand cmd_Select = new SqlCommand(sql_Select, cn);
                SqlDataReader dr_Select = cmd_Select.ExecuteReader();
                if (dr_Select.HasRows)
                {
                    dr_Select.Read();
                    try
                    {
                        LB_ClassShow.Text = dr_Select["ClassName"].ToString();
                    }
                    catch { }
                }
                cmd_Select.Dispose();
                dr_Select.Close();

                cn.Close();
            }

            DGV_TodayOrder.DataSource = TodayOrderDataSet.Tables["TodayOrders"];
            DGV_TodayOrder.AutoResizeColumns();
            DGV_TodayOrder.Columns[5].Width = 200;
            InsertExcel();
        }

        
        /// <summary>
        /// 匯出Excel檔案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_ToExcel_Click(object sender, EventArgs e)
        {
            //InsertExcel();
            System.Diagnostics.Process.Start("sid.xls");
        }
        
        /// <summary>
        /// 建立Excel檔案
        /// </summary>
        public void InsertExcel()
        {
            FileStream file_stream = new FileStream("sid.xls", FileMode.Create);//建立目的地
            Workbook workbook = new Workbook();
            Worksheet Excel_Orders = workbook.Worksheets[0];

            Excel_Orders.Range[1, 1].Text = "餐盒 (便當) 預定/領取登記表";
            Excel_Orders.Range[1, 1].ColumnWidth = 82;
            Excel_Orders.Range[2, 1].Text = $"訂購日:{Today}        取餐日: \n班級:{LB_ClassShow.Text}";
            Excel_Orders.Range[2, 1].ColumnWidth = 82;
            //for (int i = 1; i <= DGV_TodayOrder.ColumnCount; i++)
            //{
            //    Excel_Orders.Cells[1, 1] = "餐盒 (便當) 預定/領取登記表";
            //    Excel_Orders.Cells[2, 1] = $"訂購日:{LB_OrderDate.Text}\n取餐日:{LB_TakeDate.Text}\n班級:{CBB_Class.Text}";
            //}
            CellRange Excel_Title = Excel_Orders["A1:F1"];
            Excel_Title.Merge();
            XlsStyle.SetXlsHeadStyle(Excel_Title);
            //SetHeaderRangeStyle(Excel_Title);
            //Excel_Title.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            CellRange Excel_Time = Excel_Orders["A2:F2"];
            Excel_Time.Merge();
            XlsStyle.SetXlsTimeStyle(Excel_Time);

            string[] TableHeaders = { "編號", "餐券/現金", "訂購姓名", "領取姓名", "主菜選擇", "備註" };
            for (int i = 0; i < TableHeaders.Length; i++)
            {
                Excel_Orders.Range[3, i + 1].Text = TableHeaders[i];
                Excel_Orders.Range[3, i + 1].ColumnWidth = 82 / TableHeaders.Length;
            }

            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                string sql_Select = $"SELECT * FROM Orders";
                SqlCommand cmd_Select = new SqlCommand(sql_Select, cn);
                SqlDataReader dr_Select = cmd_Select.ExecuteReader();
                dt_TodayOrders.Load(dr_Select);
                for (int i = 1; i <= 25; i++)
                {
                    Excel_Orders.Range[3 + i, 1].Text = i.ToString();//編號

                    if (i <= dt_TodayOrders.Rows.Count)
                    {
                        Excel_Orders.Range[3 + i, 2].Text = dt_TodayOrders.Rows[i - 1][1].ToString();//餐票/現金
                        Excel_Orders.Range[3 + i, 2].ColumnWidth = 15;
                        Excel_Orders.Range[3 + i, 3].Text = dt_TodayOrders.Rows[i - 1][3].ToString();//訂購姓名
                        Excel_Orders.Range[3 + i, 3].ColumnWidth = 12;
                        Excel_Orders.Range[3 + i, 5].Text = dt_TodayOrders.Rows[i - 1][4].ToString();//主菜選擇
                        Excel_Orders.Range[3 + i, 5].ColumnWidth = 15;
                        Excel_Orders.Range[3 + i, 6].Text = dt_TodayOrders.Rows[i - 1][5].ToString();//備註
                        Excel_Orders.Range[3 + i, 6].ColumnWidth = 12;
                    }
                }
                CellRange Excel_Content = Excel_Orders["A3:F28"];
                Excel_Content.RowHeight = 20;
                XlsStyle.SetXlsBodyStyle(Excel_Content);
            }

            //----------結尾備註----------//
            string str_footer = "(一)訂餐方式：以班級為單位，採預訂方式(提供訂單預定，請於單內填寫餐券票號及訂購數量)。\n   前一日中午持預定單與餐券(或現金)向餐廳阿姨訂餐。\n(二)取餐時間：11時30分至12時30分止，逾時不候。\n(三)取餐地點：幼獅會館門口。\n(四)取餐方式：請班級幹部於訂單簽名簽收，再向餐廳幫廚阿姨領取餐盒(便當)。\n※週一訂餐數，請於前週週五完成預定。\n※餐盒(便當)均由供餐廠商於當日送來，未提前訂餐者，恕餐廳當日無法提供餐盒(便當)。";
            Excel_Orders.Range[29, 1].Text = str_footer;
            CellRange Excel_Orders_Footer_Range = Excel_Orders["A29:F29"];
            Excel_Orders_Footer_Range.Merge();
            Excel_Orders_Footer_Range.RowHeight = 100;
            XlsStyle.SetXlsFooterStyle(Excel_Orders_Footer_Range);
            //----------結尾備註----------//

            
            workbook.SaveToStream(file_stream);
            file_stream.Close();

        }
       

        //----------------------Class區----------------------//

        //
        private void BTN_CreateClass_Click(object sender, EventArgs e)
        {
            string sql_Update = $"UPDATE Class SET ClassName = '{TB_Class_Update.Text}' ";
            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                if (TB_Class_Update.Text != "" && TB_Class_Update.Text != "尚未設定班級名稱")
                {
                    SqlCommand cmd_Update = new SqlCommand(sql_Update, cn);
                    SqlDataReader dr_Update = cmd_Update.ExecuteReader();
                    dr_Update.Read();
                    cmd_Update.Dispose();
                    dr_Update.Close();
                    LB_ClassShow.Text = TB_Class_Update.Text;
                    MessageBox.Show("變更完成");
                }
                else
                {
                    MessageBox.Show("請輸入變更的班級名稱");
                }
                Workbook workbook = new Workbook();
                workbook.LoadFromFile(".\\sid.xls");
                Worksheet Excel_Alter = workbook.Worksheets[0];
                Excel_Alter.Range[2, 1].Text = $"訂購日:{Today}        取餐日: \n班級:{LB_ClassShow.Text}";
                workbook.Save();
                //Excel_Orders.Range[2, 1].Text = $"訂購日:{Today}        取餐日: \n班級:{LB_ClassShow.Text}";
            }
        }


        /// <summary>
        /// 列印按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_Print_Click(object sender, EventArgs e)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(".\\sid.xls");
            PrintDialog dialog = new PrintDialog();
            dialog.AllowPrintToFile = true;
            dialog.AllowCurrentPage = true;
            dialog.AllowSomePages = true;
            dialog.AllowSelection = true;
            dialog.UseEXDialog = true;
            dialog.PrinterSettings.Duplex = Duplex.Simplex;
            dialog.PrinterSettings.FromPage = 0;
            dialog.PrinterSettings.ToPage = 8;
            dialog.PrinterSettings.PrintRange = PrintRange.SomePages;
            workbook.PrintDialog = dialog;
            PrintDocument pd = workbook.PrintDocument;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
    }
}
