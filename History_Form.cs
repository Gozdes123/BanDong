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
    public partial class History_Form : Form
    {
        private string StudentID { get; set; }
        private string StudentName { get; set; }
        DataSet ds = new DataSet();
        public History_Form(string studentid, string studentname)
        {
            InitializeComponent();
            StudentID = studentid;
            StudentName = studentname;

        }
        private void History_Form_Load(object sender, EventArgs e)
        {
            LB_StudentID.Text += StudentID;
            LB_StudentName.Text += StudentName;
            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter($"select OrderDateTime 訂購日期 ,StudentID 學號,StudentName 姓名,Ticket_Money 付款方式,Type 便當類型,Remark 備註 from Logs where StudentName='{StudentName}'", cn);
                da.Fill(ds, "查詢Logs");
                DgvSet(dataGridView2);
                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.AutoResizeColumns();
            }
        }
        /// <summary>
        /// datagridview的樣式設定
        /// </summary>
        /// <param name="dgv">123</param>
        public static void DgvSet(DataGridView dgv)
        {
            DataGridViewCellStyle DgvHeaderStyle = new DataGridViewCellStyle();
            dgv.EnableHeadersVisualStyles = false;
            DgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvHeaderStyle.BackColor = Color.FromArgb(191, 239, 255);
            DgvHeaderStyle.ForeColor = Color.FromArgb(0, 0, 139);
            DgvHeaderStyle.Font = new Font("arial", 14, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle = DgvHeaderStyle;

            dgv.BackgroundColor = Color.FromArgb(255, 228, 225);
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(154, 255, 154);
            dgv.DefaultCellStyle.Font = new Font("arial", 14, FontStyle.Bold);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 255, 255);
            dgv.AlternatingRowsDefaultCellStyle.Font = new Font("arial", 14, FontStyle.Bold);
            //dgv.AutoResizeRows();
            //DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        }
    }
}
