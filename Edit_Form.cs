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
    public partial class Edit_Form : Form
    {
        private string StudentID = "";
        private string StudentName = "";
        private string PayType = "";
        private string BanDongType = "";
        private string Remark = "";
        DataSet ds = new DataSet();
        public Edit_Form(string StudentID, string StudentName, string payType, string banDongType, string remark)
        {
            InitializeComponent();
            this.StudentID = StudentID;
            this.StudentName = StudentName;
            LB_StudentName.Text = StudentName;
            PayType = payType;
            BanDongType = banDongType;
            Remark = remark;
        }

        private void Edit_Form_Load(object sender, EventArgs e)
        {
            cb_PayType.Text = PayType;
            cb_BanDongType.Text = BanDongType;
            tbox_remark.Text = Remark;
        }

        private void BTN_Confirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                string update = $"update Orders set Ticket_Money = '{cb_PayType.Text}', Type = '{cb_BanDongType.Text}', Remark='{tbox_remark.Text}',OrderDateTime='convert(varchar, getdate(), 120)' where StudentName = '{LB_StudentName.Text}'";
                SqlDataAdapter da_edit = new SqlDataAdapter(update, cn);
                da_edit.Fill(ds, "編輯");

                MessageBox.Show("編輯成功!!");
                Dispose();

            }
        }
    }
}
