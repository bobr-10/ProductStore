using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Excel = Microsoft.Office.Interop.Excel;


namespace WPFexample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Excel.Application ExcelApp;
        public static Excel.Workbook Book;
        public static Excel.Worksheet worksheet;
        public static Excel.Range Range;

        public static string MainPath = $@"{Environment.CurrentDirectory}\Excel\items.xlsx";
    }
}
