using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


internal class Style
{
    /// <summary>
    /// 設定Excel的title樣式
    /// </summary>
    /// <param name="rg">Excel.Range</param>
    public static void SetHeaderStyle(Excel.Range rg)
    {
        rg.Font.Color = System.Drawing.Color.Black;
        rg.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
        rg.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
        rg.Borders.Color = Color.FromArgb(77, 31, 0);
        rg.Font.FontStyle = System.Drawing.FontStyle.Bold;
        rg.Font.Name = "標楷體";
        rg.Font.Size = 14;
        rg.Interior.Color = System.Drawing.Color.White;
        
    }

    /// <summary>
    /// 設定Excel表身的樣式
    /// </summary>
    /// <param name="rg">Excel.Range</param>
    public static void SetDateStyle(Excel.Range rg)
    {
        rg.Font.Color = System.Drawing.Color.Black;
        rg.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;  //Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
        rg.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
        rg.Borders.Color = Color.FromArgb(77, 31, 0);
        rg.Font.FontStyle = System.Drawing.FontStyle.Bold;
        rg.Font.Name = "標楷體";
        rg.Font.Size = 14;
        rg.Interior.Color = System.Drawing.Color.White;
    }

    public static void SetContextStyle(Excel.Range rg)
    {
        rg.Font.Color = System.Drawing.Color.Black;
        rg.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;  //Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
        rg.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
        rg.Borders.Color = Color.FromArgb(77, 31, 0);
        rg.Font.FontStyle = System.Drawing.FontStyle.Regular;
        rg.Font.Name = "標楷體";
        rg.Font.Size = 12;
        rg.Interior.Color = System.Drawing.Color.White;
    }

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

