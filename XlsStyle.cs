using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Spire.Xls;
using System.Data;


class XlsStyle
{
    public static void SetXlsHeadStyle(CellRange cr)
    {
        cr.Style.Font.FontName = "標楷體";
        cr.Style.Font.Size = 14;
        cr.Style.Font.IsBold = true;
        cr.Style.HorizontalAlignment = HorizontalAlignType.Center;
        cr.Borders.LineStyle = LineStyleType.Thin;
        cr.Borders[BordersLineType.DiagonalDown].LineStyle = LineStyleType.None;
        cr.Borders[BordersLineType.DiagonalUp].LineStyle = LineStyleType.None;
        cr.Borders.Color = Color.Black;
        cr.ColumnWidth = 83 / 6;
        cr.AutoFitRows();
    }

    public static void SetXlsTimeStyle(CellRange cr)
    {
        cr.Style.Font.FontName = "標楷體";
        cr.Style.Font.Size = 14;
        cr.Style.Font.IsBold = true;
        cr.Style.HorizontalAlignment = HorizontalAlignType.Left;
        cr.Borders.LineStyle = LineStyleType.Thin;
        cr.Borders[BordersLineType.DiagonalDown].LineStyle = LineStyleType.None;
        cr.Borders[BordersLineType.DiagonalUp].LineStyle = LineStyleType.None;
        cr.Borders.Color = Color.Black;
        cr.ColumnWidth = 83 / 6;
        cr.RowHeight = 48;
    }

    public static void SetXlsBodyStyle(CellRange cr)
    {
        cr.Style.Font.FontName = "標楷體";
        cr.Style.Font.Size = 12;
        cr.Style.HorizontalAlignment = HorizontalAlignType.Left;
        cr.Borders.LineStyle = LineStyleType.Thin;
        cr.Borders[BordersLineType.DiagonalDown].LineStyle = LineStyleType.None;
        cr.Borders[BordersLineType.DiagonalUp].LineStyle = LineStyleType.None;
        cr.Borders.Color = Color.Black;
        //cr.ColumnWidth = 83 / 6;
        //cr.AutoFitColumns();
    }

    public static void SetXlsFooterStyle(CellRange cr)
    {
        cr.Style.Font.FontName = "標楷體";
        cr.Style.Font.Size = 10;
        cr.Style.HorizontalAlignment = HorizontalAlignType.Left;
        cr.Borders.LineStyle = LineStyleType.Thin;
        cr.Borders[BordersLineType.DiagonalDown].LineStyle = LineStyleType.None;
        cr.Borders[BordersLineType.DiagonalUp].LineStyle = LineStyleType.None;
        cr.Borders.Color = Color.Black;
    }
}

