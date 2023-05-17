using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFexample.Views;
using Excel = Microsoft.Office.Interop.Excel;

namespace WPFexample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.ExcelApp = new Excel.Application();
            App.Book = App.ExcelApp.Workbooks.Open(App.MainPath);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new();
            List<string> categories = new List<string>();

            foreach (Excel.Worksheet sheet in App.Book.Worksheets)
            {
                categories.Add(sheet.Name);
            }
            int money = random.Next(0, 500);
            PriceList priceList = new(categories, money);
            this.Hide();
            priceList.Owner= this;
            priceList.ShowDialog();
        }

        private void account(object sender, RoutedEventArgs e)
        {
            Account account = new();
            this.Hide();
            account.Owner = this;
            account.ShowDialog();
        }

        private void Close(object sender, EventArgs e)
        {
            App.Book.Close();
            App.ExcelApp.Quit();
        }

        private void EditPrices(object sender, RoutedEventArgs e)
        {
            List<string> categories = new List<string>();

            foreach (Excel.Worksheet sheet in App.Book.Worksheets)
            {
                categories.Add(sheet.Name);
            }

            EditPrices edit = new(categories);
            this.Hide();
            edit.Owner = this;
            edit.ShowDialog();
        }
    }
}
