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
    public partial class Login_Form : Form
    {
        public static string sqlcn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BanDongDB.mdf;Integrated Security=True";
        public Login_Form()
        {
            InitializeComponent();
        }

        private void BTN_Register_Click(object sender, EventArgs e)
        {
            Register_Form register_Form = new Register_Form();
            register_Form.Show();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            Order_Form order = new Order_Form();
            order.Show();
            using (SqlConnection cn = new SqlConnection(sqlcn))
            {
                cn.Open();

                cn.Close();
            }
        }

    }
}
