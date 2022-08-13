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
        private delegate void Dgvset(DataGridView dgv);
        public History_Form(string studentid,string studentname)
        {
            InitializeComponent();
            StudentID = studentid;
            StudentName = studentname;

        }
        private void History_Form_Load(object sender, EventArgs e)
        {
            LB_StudentID.Text += StudentID;
            LB_StudentName.Text += StudentName;
            using (SqlConnection cn=new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter($"select OrderDateTime 訂購日期 ,StudentID 學號,StudentName 姓名,Ticket_Money 付款方式,Type 便當類型,Remark 備註 from Logs where StudentName='{StudentName}'",cn);
                da.Fill(ds,"查詢Logs");
                Dgvset dgs = Style.DgvSet;
                dgs(dataGridView2);
                dataGridView2.DataSource = ds.Tables[0];
                dataGridView2.AutoResizeColumns();
            }
        }
        //private void History_Form_SizeChanged(object sender, EventArgs e)
        //{
        //    dataGridView2.Width = this.Width - (996 - 954);
        //}
    }
}
