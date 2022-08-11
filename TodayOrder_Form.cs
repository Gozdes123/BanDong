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
using Excel = Microsoft.Office.Interop.Excel;


namespace BanDong_1._0v
{
    public partial class TodayOrder_Form : Form
    {
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
            
            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                string sql_Select = $"SELECT OrderNO 編號, Ticket_Money [餐票/現金], StudentID 座號, StudentName 訂購姓名, Type 主菜選擇, Remark 備註 FROM Orders";
                SqlDataAdapter dataAdapter_Select = new SqlDataAdapter(sql_Select, cn);
                dataAdapter_Select.Fill(TodayOrderDataSet, "TodayOrders");
                cn.Close();
            }

            DGV_TodayOrder.DataSource = TodayOrderDataSet.Tables["TodayOrders"];
            DGV_TodayOrder.AutoResizeColumns();
        }


        /// <summary>
        /// 匯出Excel檔案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_ToExcel_Click(object sender, EventArgs e)
        {
            Excel.Application Excel_Orders = new Excel.Application();
            Excel_Orders.Application.Workbooks.Add(true);
            Excel_Orders.Visible = true;
            

            for (int i = 1; i <= DGV_TodayOrder.ColumnCount; i++)
            {
                Excel_Orders.Cells[1, 1] = "餐盒 (便當) 預定/領取登記表";
                Excel_Orders.Cells[2, 1] = $"訂購日:{LB_OrderDate.Text} 取餐日:{LB_TakeDate.Text}\n班級:{CBB_Class.Text}";
            }

            Excel.Range Excel_Title = (Excel.Range)Excel_Orders.Range[Excel_Orders.Cells[1, 1], Excel_Orders.Cells[1, 6]].Cells;
            Excel_Title.Merge(0);
            Excel_Title.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            Excel.Range Excel_Date = (Excel.Range)Excel_Orders.Range[Excel_Orders.Cells[2, 1], Excel_Orders.Cells[2, 6]].Cells;
            Excel_Date.Merge(0);
            Excel_Date.RowHeight = 52;

            string[] TableHeaders = { "編號", "餐券票號/現金","訂購姓名","領取姓名","主菜選擇","備註"};
            for(int i = 0; i < TableHeaders.Length; i++)
            {
                Excel_Orders.Cells[3,i+1] = TableHeaders[i];
            }

            using(SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                string sql_Select = $"SELECT * FROM Orders";
                SqlCommand cmd_Select = new SqlCommand(sql_Select, cn);
                SqlDataReader dr_Select = cmd_Select.ExecuteReader();
                dt_TodayOrders.Load(dr_Select);
                for (int i = 1; i <= 25; i++)
                {
                    Excel_Orders.Cells[3 + i, 1] = i;//編號
                    
                    if (i <= dt_TodayOrders.Rows.Count)
                    {
                        Excel_Orders.Cells[3 + i, 2] = dt_TodayOrders.Rows[i - 1][1].ToString();//餐票/現金
                        Excel_Orders.Cells[3 + i, 3] = dt_TodayOrders.Rows[i - 1][3].ToString();//訂購姓名
                        Excel_Orders.Cells[3 + i, 5] = dt_TodayOrders.Rows[i - 1][4].ToString();//主菜選擇
                        Excel_Orders.Cells[3 + i, 6] = dt_TodayOrders.Rows[i - 1][5].ToString();//備註
                    }                    
                }
            }
        }
    }
}
