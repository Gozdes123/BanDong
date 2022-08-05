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
        DataSet ds=new DataSet();
        public Order_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_Buy_Click_1(object sender, EventArgs e)
        {
            
            using (SqlConnection cn = new SqlConnection(Login_Form.sqlcn))
            {
                cn.Open();
                string insert = $"insert into Orders(Ticket_Money, StudentName, Type, Remark, OrderDateTime) Values('{cb_PayType.Text}', '{labelName.Text}', '{cb_BanDongType.Text}', '{tbox_remark.Text}', '{DateTime.Now.ToString()}');";
                SqlDataAdapter da_buy=new SqlDataAdapter(insert, cn);
                da_buy.Fill(ds,"BuyBanDong");
                DataTable dt = ds.Tables[0];
            }
            //"insert into Orders(Ticket_Money, StudentName, Type, Remark, OrderDateTime) Values('票券', '小白', '圓形', '素食', '2022-08-05 15:59');"

        }
    }
}
