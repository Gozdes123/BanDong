using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Xls;

namespace BanDong_1._0v
{
    public partial class TodayOrder_Form2 : Form
    {
        public TodayOrder_Form2()
        {
            InitializeComponent();
        }

        private void TodayOrder_Form2_Load(object sender, EventArgs e)
        {

        }

        private void BTN_ToExcel_Click(object sender, EventArgs e)
        {
            SqlConnect.SqlToXls();
        }

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
